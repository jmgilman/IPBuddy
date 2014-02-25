using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PcapDotNet.Core;

namespace IPBuddy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            Logger.WriteMessage("Form initializing.");
            InitializeComponent();

            /** Setup grid view **/
            this.dataNAE.Columns.Add("name", "Property");
            this.dataNAE.Columns.Add("value", "Value");
            this.dataNAE.Columns[0].ReadOnly = true;
            this.dataNAE.Columns[1].Width = (this.dataNAE.Width - this.dataNAE.Columns[0].Width) - 3;

            /** Used for assigning the correct menu to new site and NAE nodes in external classes **/
            frmMain.StaticContextSite = this.contextSite;
            frmMain.StaticContextNAE = this.contextNAE;

            /** Load NICs into combo box **/
            NIC.LoadNICs(this.comboAdapterList);

            /** Check for existing configuration and load if applicable **/
            if (System.IO.File.Exists("default.xml"))
            {
                try
                {
                    FormHandler.XMLToTree(XDocument.Load("default.xml"), this.treeSites);
                    this.treeSites.ExpandAll();
                }
                catch (Exception e)
                {
                    Logger.WriteMessage("Error in loading default save file.");
                    Logger.WriteException(e);
                    Logger.PromptLogReview("An error occurred trying to load your previously saved configuration.");
                }
            }

            /** Start listening for packets **/
            try
            {
                IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
                if (allDevices.Count > 0)
                {
                    foreach (LivePacketDevice device in allDevices)
                    {
                        NAEListener listener = new NAEListener(device);
                        Task.Run((Action)listener.listen);
                    }
                }
                else
                {
                    MessageBox.Show("No network adapters were detected for listening and the NAE Listener will not function properly. Please ensure you have WinPCap installed.");
                }
            }
            catch (Exception e)
            {
                Logger.WriteMessage("Error in starting packet listeners");
                Logger.WriteException(e);
                Logger.PromptLogReview("An error occurred in starting the listener devices.");
                MessageBox.Show("Please note that since the listener devices failed to start, the NAE Listener tool will not function.");
            }

            /** Setup the NAE Handler **/
            NAEHandler.mainFrm = this;
            NAEHandler.Initialize();

            Logger.WriteMessage("Form initialized.");
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            Console.WriteLine("Resized");
            if (FormWindowState.Minimized == this.WindowState)
            {
                Console.WriteLine("Minimized");
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipText = "IPBuddy has been placed in the system tray!";
                notifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHandler.AddNewSiteToTree(this.treeSites);
        }

        private void nAEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeSites.SelectedNode == null)
            {
                MessageBox.Show("Error: Please select a site to add the NAE to.");
                return;
            } else if (!(this.treeSites.SelectedNode.Tag is Site)) {
                MessageBox.Show("Error: Please select a site to add the NAE to.");
            }

            FormHandler.AddNewNAEToTree(this.treeSites, this.treeSites.SelectedNode);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.treeSites.Nodes.Clear();
                    FormHandler.XMLToTree(XDocument.Load(openFileDialog.FileName), this.treeSites);
                }
                catch (Exception ex)
                {
                    Logger.WriteMessage("Failed to load XML file: " + openFileDialog.FileName);
                    Logger.WriteException(ex);
                    Logger.PromptLogReview("An error occurred in loading the file, it may be corrupted.");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument document = FormHandler.TreeToXML(this.treeSites);
                document.Save("default.xml");
            }
            catch (Exception ex)
            {
                Logger.WriteMessage("Failed to save XML file to default path.");
                Logger.WriteException(ex);
                Logger.PromptLogReview("An error occurred in saving the file, you may not have appropriate permissions.");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument document = FormHandler.TreeToXML(this.treeSites);
                    document.Save(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    Logger.WriteMessage("Failed to save XML file: " + saveFileDialog.FileName);
                    Logger.WriteException(ex);
                    Logger.PromptLogReview("An error occurred in saving the file, you may not have appropriate permissions.");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nAETrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NAEHandler.listenFrm.Show();
        }

        private void helpTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Help.ShowHelp(this, "Resources/IPBuddy.chm");
            }
            catch (Exception ex)
            {
                Logger.WriteMessage("Error in loading the help file.");
                Logger.WriteException(ex);
                Logger.PromptLogReview("There was an error opening the help file.");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.Show();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (this.treeSites.SelectedNode == null)
            {
                MessageBox.Show("Please select an NAE to launch.");
                return;
            }

            if (this.treeSites.SelectedNode.Tag is NAE)
            {
                try
                {
                    NAE nae = (NAE)this.treeSites.SelectedNode.Tag;

                    if (!StaticIP.IsIPv4(nae.IPAddress))
                    {
                        MessageBox.Show("Please enter a valid IP address for the NAE.");
                        return;
                    }

                    nae.Launch();
                }
                catch (Exception ex)
                {
                    Logger.WriteMessage("Error in launching NAE.");
                    Logger.WriteException(ex);
                    Logger.PromptLogReview("There was an error launching the NAE.");
                }
            }
            else
            {
                MessageBox.Show("Please select an NAE to launch.");
                return;
            }
        }

        private void btnSetStatic_Click(object sender, EventArgs e)
        {
            if (this.treeSites.SelectedNode == null)
            {
                MessageBox.Show("Please select an NAE to set a static IP for.");
                return;
            }

            if (!(this.treeSites.SelectedNode.Tag is NAE))
            {
                MessageBox.Show("Please select an NAE to set a static IP for.");
                return;
            }

            try
            {
                NAE nae = (NAE)this.treeSites.SelectedNode.Tag;
                NIC nic = (NIC)this.comboAdapterList.SelectedItem;

                if (!StaticIP.IsIPv4(nae.StaticIPAddress.Address) || !StaticIP.IsIPv4(nae.StaticIPAddress.SubnetMask) || !StaticIP.IsIPv4(nae.StaticIPAddress.DefaultGateway))
                {
                    MessageBox.Show("Please enter valid IP addresses for the NAE's static IP address, subnet mask, and gateway.");
                    return;
                }

                nic.SetStaticIP(nae.StaticIPAddress.Address, nae.StaticIPAddress.SubnetMask, nae.StaticIPAddress.DefaultGateway);
                NIC.LoadNICs(this.comboAdapterList);
                nic.ReselectNIC(this.comboAdapterList);

                nic = (NIC)this.comboAdapterList.SelectedItem;
                FormHandler.UpdateNICText(nic, this.txtAdapterIPAddress, this.txtAdapterSubnetMask, this.txtAdapterDefaultGateway);
            }
            catch (Exception ex)
            {
                Logger.WriteMessage("Error in setting the static IP address.");
                Logger.WriteException(ex);
                Logger.PromptLogReview("There was an error in setting the static IP address.");
            }
        }

        private void btnSetDHCP_Click(object sender, EventArgs e)
        {
            try
            {
                NIC nic = (NIC)this.comboAdapterList.SelectedItem;

                nic.SetDHCP();
                NIC.LoadNICs(this.comboAdapterList);
                nic.ReselectNIC(this.comboAdapterList);

                nic = (NIC)this.comboAdapterList.SelectedItem;
                FormHandler.UpdateNICText(nic, this.txtAdapterIPAddress, this.txtAdapterSubnetMask, this.txtAdapterDefaultGateway);
            }
            catch (Exception ex)
            {
                Logger.WriteMessage("Error in setting DHCP.");
                Logger.WriteException(ex);
                Logger.PromptLogReview("There was an error in setting DHCP.");
            }
        }

        private void treeSites_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeSites.SelectedNode = e.Node;
        }

        private void treeSites_DoubleClick(object sender, EventArgs e)
        {
            this.treeSites.LabelEdit = true;

            if (!this.treeSites.SelectedNode.IsEditing)
            {
                this.treeSites.SelectedNode.BeginEdit();
            }
        }

        private void treeSites_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Tag is Site)
            {
                Site site = (Site)e.Node.Tag;
                site.Name = e.Label;
            }
            else if (e.Node.Tag is NAE)
            {
                NAE nae = (NAE)e.Node.Tag;
                nae.Name = e.Label;
            }
        }

        private void treeSites_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is NAE)
            {
                NAE nae = (NAE)e.Node.Tag;

                string[] ip = new string[] { "IP Address:", nae.IPAddress };
                string[] mac = new string[] { "MAC Address:", nae.MAC };
                string[] osversion = new string[] { "OS Version:", nae.OSVersion };
                string[] mseaversion = new string[] { "MSEA Version:", nae.MSEAVersion };
                string[] staticip = new string[] { "Static IP:", nae.StaticIPAddress.Address };
                string[] staticsubnet = new string[] { "Static Subnet:", nae.StaticIPAddress.SubnetMask };
                string[] staticgateway = new string[] { "Static Gateway:", nae.StaticIPAddress.DefaultGateway };
                string[][] fields = new string[][] { ip, mac, osversion, mseaversion, staticip, staticsubnet, staticgateway };

                this.dataNAE.Rows.Clear();
                foreach (string[] field in fields)
                {
                    int index = this.dataNAE.Rows.Add(field);
                    this.dataNAE.Rows[index].Tag = nae;
                }
            }
        }

        private void comboAdapterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            NIC nic = (NIC)this.comboAdapterList.SelectedItem;
            FormHandler.UpdateNICText(nic, this.txtAdapterIPAddress, this.txtAdapterSubnetMask, this.txtAdapterDefaultGateway);
        }

        private void newNAEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeSites.SelectedNode;
            FormHandler.AddNewNAEToTree(this.treeSites, node);
        }

        private void importNAEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XElement xnae = XDocument.Load(openFileDialog.FileName).Root;
                    FormHandler.AddNAEToTree(this.treeSites.SelectedNode.Nodes, NAE.FromXML(xnae));
                }
                catch (Exception ex)
                {
                    Logger.WriteMessage("Failed to load XML file: " + openFileDialog.FileName);
                    Logger.WriteException(ex);
                    Logger.PromptLogReview("An error occurred in loading the file, it may be corrupted.");
                }
            }
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Site site = (Site)this.treeSites.SelectedNode.Tag;

            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = site.Name + ".xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument document = new XDocument(site.ToXML());
                    document.Save(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    Logger.WriteMessage("Failed to save XML file: " + saveFileDialog.FileName);
                    Logger.WriteException(ex);
                    Logger.PromptLogReview("An error occurred in saving the file, you may not have appropriate permissions.");
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeSites.SelectedNode;
            Site site = (Site)node.Tag;

            Clipboard.SetText(site.ToXML().ToString());
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeSites.SelectedNode != null)
            {
                if (!String.IsNullOrEmpty(Clipboard.GetText()))
                {
                    try
                    {
                        TreeNodeCollection nodes = this.treeSites.SelectedNode.Nodes;
                        XElement xnae = XElement.Parse(Clipboard.GetText());
                        FormHandler.AddNAEToTree(nodes, NAE.FromXML(xnae));
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteMessage("Error in pasting NAE.");
                        Logger.WriteException(ex);
                        Logger.PromptLogReview("Failed to paste the NAE, the data in the clipboard may be corrupt.");
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeSites.Nodes.Remove(this.treeSites.SelectedNode);
        }

        private void launchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NAE nae = (NAE)this.treeSites.SelectedNode.Tag;
                nae.Launch();
            }
            catch (Exception ex)
            {
                Logger.WriteMessage("Failed to launch NAE.");
                Logger.WriteException(ex);
                Logger.PromptLogReview("Failed to launch NAE.");
            }
        }

        private void exportToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            NAE nae = (NAE)this.treeSites.SelectedNode.Tag;

            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = nae.Name + ".xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument document = new XDocument(nae.ToXML());
                    document.Save(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    Logger.WriteMessage("Failed to save XML file: " + saveFileDialog.FileName);
                    Logger.WriteException(ex);
                    Logger.PromptLogReview("An error occurred in saving the file, you may not have appropriate permissions.");
                }
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeSites.SelectedNode;
            NAE nae = (NAE)node.Tag;

            Clipboard.SetText(nae.ToXML().ToString());
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Site site = (Site)this.treeSites.SelectedNode.Parent.Tag;
            NAE nae = (NAE)this.treeSites.SelectedNode.Tag;

            site.NAEs.Remove(nae);
            this.treeSites.Nodes.Remove(this.treeSites.SelectedNode);
        }

        private void newSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHandler.AddNewSiteToTree(this.treeSites);
        }

        private void importSiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XElement xsite = XDocument.Load(openFileDialog.FileName).Root;
                    FormHandler.AddSiteToTree(this.treeSites.Nodes, IPBuddy.Site.FromXML(xsite));
                }
                catch (Exception ex)
                {
                    Logger.WriteMessage("Failed to load XML file: " + openFileDialog.FileName);
                    Logger.WriteException(ex);
                    Logger.PromptLogReview("An error occurred in loading the file, it may be corrupted.");
                }
            }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Clipboard.GetText()))
            {
                try
                {
                    XElement xsite = XElement.Parse(Clipboard.GetText());
                    FormHandler.AddSiteToTree(this.treeSites.Nodes, IPBuddy.Site.FromXML(xsite));
                }
                catch (Exception ex)
                {
                    Logger.WriteMessage("Error in pasting site.");
                    Logger.WriteException(ex);
                    Logger.PromptLogReview("Failed to paste the site, the data in the clipboard may be corrupt.");
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataNAE_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataNAE.Rows[e.RowIndex];
            NAE nae = (NAE)row.Tag;
            Console.WriteLine(nae.Name);

            switch (e.RowIndex)
            {
                case 0:
                    nae.IPAddress = (String)row.Cells[1].Value;
                    break;
                case 1:
                    nae.MAC = (String)row.Cells[1].Value;
                    break;
                case 2:
                    nae.OSVersion = (String)row.Cells[1].Value;
                    break;
                case 3:
                    nae.MSEAVersion = (String)row.Cells[1].Value;
                    break;
                case 4:
                    nae.StaticIPAddress.Address = (String)row.Cells[1].Value;
                    break;
                case 5:
                    nae.StaticIPAddress.SubnetMask = (String)row.Cells[1].Value;
                    break;
                case 6:
                    nae.StaticIPAddress.DefaultGateway = (String)row.Cells[1].Value;
                    break;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon.Visible = false;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
