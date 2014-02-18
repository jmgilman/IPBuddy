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
//using System.Management;
using System.Diagnostics;

namespace IPBuddy
{
    public partial class FormMain : Form
    {
        private TreeNode selectedNode;
        private TreeNode lastSelectedIPNode;

        public FormMain()
        {
            InitializeComponent();
            this.selectedNode = new TreeNode();
        }

        private void addNewSite()
        {
            Site site = new Site("Site Name");
            TreeNode siteNode = new TreeNode(site.Name);

            siteNode.Tag = site;
            siteNode.ContextMenuStrip = contextMenuSite;
            treeMainList.LabelEdit = true;
            treeMainList.Nodes.Add(siteNode);

            if (!siteNode.IsEditing)
            {
                siteNode.BeginEdit();
            }
        }

        private void addNewIPAddress(TreeNode node)
        {
            IPAddress ip = new IPAddress("New IP Address", "192.168.1.10", "255.255.255.0", "192.168.1.1");
            TreeNode IPNode = new TreeNode(ip.Name);

            IPNode.Tag = ip;
            IPNode.ContextMenuStrip = contextMenuIP;
            treeMainList.LabelEdit = true;
            node.Nodes.Add(IPNode);

            treeMainList.SelectedNode = IPNode;
            if (!IPNode.IsEditing)
            {
                IPNode.BeginEdit();
            }
        }

        private void loadFromXML(String fileName)
        {
            List<Site> sites = IPBuddyHelper.ImportFromXML(fileName);

            foreach (Site site in sites)
            {
                treeMainList.Nodes.Add(SiteToNode(site));
            }
        }

        private void updateIPSettings(TextBox txtip)
        {
            if (this.lastSelectedIPNode == null)
            {
                return;
            }

            if (!IPBuddyHelper.IsIPv4(txtip.Text) && !String.IsNullOrEmpty(txtip.Text))
            {
                MessageBox.Show("Please enter a valid IPv4 address before continuing.");
                txtip.Focus();
                return;
            }

            if (this.lastSelectedIPNode.Tag is IPAddress)
            {
                IPAddress ip = (IPAddress)this.lastSelectedIPNode.Tag;

                ip.Address = txtSetIP.Text;
                ip.SubnetMask = txtSetSubnet.Text;
                ip.DefaultGateway = txtSetGateway.Text;
            }
            else
            {
                MessageBox.Show("Please select a valid IP address to save");
            }
        }

        private void updateNICSettings()
        {
            NIC nic = (NIC)comboNetworkList.SelectedItem;

            this.txtIP.Text = nic.IP.Address;
            this.txtSubnet.Text = nic.IP.SubnetMask;
            this.txtGateway.Text = nic.IP.DefaultGateway;
            this.lblDHCP.Text = nic.DHCPEnabled.ToString();
        }

        private TreeNode IPToNode(IPAddress ip)
        {
            TreeNode node = new TreeNode(ip.Name);
            node.Tag = ip;
            node.ContextMenuStrip = this.contextMenuIP;

            return node;
        }

        private TreeNode SiteToNode(Site site)
        {
            TreeNode node = new TreeNode(site.Name);
            node.Tag = site;
            node.ContextMenuStrip = this.contextMenuSite;

            foreach (IPAddress ip in site.Addresses)
            {
                node.Nodes.Add(IPToNode(ip));
            }

            return node;
        }

        private void newSiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addNewSite();
        }

        private void addNewIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
            TreeView treeView = (TreeView)cms.SourceControl;
            TreeNode node = treeView.GetNodeAt(treeView.PointToClient(cms.Location));

            addNewIPAddress(node);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            IPBuddyHelper.LoadNICs(comboNetworkList);

            if (System.IO.File.Exists("default.xml"))
            {
                this.loadFromXML("default.xml");
            }
        }

        private void comboNetworkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateNICSettings();
        }

        private void treeMainList_DoubleClick(object sender, EventArgs e)
        {
            if (this.selectedNode != null)
            {
                treeMainList.SelectedNode = this.selectedNode;
                treeMainList.LabelEdit = true;
                if (!this.selectedNode.IsEditing)
                {
                    this.selectedNode.BeginEdit();
                }
            }
        }

        private void treeMainList_MouseDown(object sender, MouseEventArgs e)
        {
            this.selectedNode = treeMainList.GetNodeAt(e.X, e.Y);
        }

        private void treeMainList_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null)
            {
                e.CancelEdit = true;
                return;
            }
            else if (e.Label.Length <= 0)
            {
                e.CancelEdit = true;
                return;
            }
            else
            {
                e.Node.EndEdit(false);
            }
        }

        private void NewIPAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeMainList.SelectedNode == null)
            {
                MessageBox.Show("Please select a valid site to add an IP address to.");
            }

            if (treeMainList.SelectedNode.Tag is Site)
            {
                addNewIPAddress(treeMainList.SelectedNode);
            }
            else
            {
                MessageBox.Show("Please select a valid site to add an IP address to.");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPBuddyHelper.ExportToXML(treeMainList, "default.xml");
        }

        private void txtSetIP_Leave(object sender, EventArgs e)
        {
            updateIPSettings(txtSetIP);
        }

        private void txtSetSubnet_Leave(object sender, EventArgs e)
        {
            updateIPSettings(txtSetSubnet);
        }

        private void txtSetGateway_Leave(object sender, EventArgs e)
        {
            updateIPSettings(txtSetGateway);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
            TreeView treeView = (TreeView)cms.SourceControl;
            TreeNode node = treeView.GetNodeAt(treeView.PointToClient(cms.Location));

            XElement xsite = IPBuddyHelper.SiteToXML((Site)node.Tag);
            Clipboard.SetText(xsite.ToString());
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() == null)
            {
                return;
            }

            if (Clipboard.GetText().Length <= 0)
            {
                return;
            }

            try
            {
                XElement element = XElement.Parse(Clipboard.GetText());
                if (element.Name.LocalName == "Site")
                {
                    Site site = IPBuddyHelper.SiteFromXML(element);
                    treeMainList.Nodes.Add(SiteToNode(site));
                }
                else
                {
                    MessageBox.Show("Invalid data on the clipboard. Please try copying again.");
                }
            }
            catch
            {
                MessageBox.Show("Invalid data on the clipboard. Please try copying again.");
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
            TreeView treeView = (TreeView)cms.SourceControl;
            TreeNode node = treeView.GetNodeAt(treeView.PointToClient(cms.Location));

            XElement xip = IPBuddyHelper.IPToXML((IPAddress)node.Tag);
            Clipboard.SetText(xip.ToString());
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() == null)
            {
                return;
            }

            if (Clipboard.GetText().Length <= 0)
            {
                return;
            }

            if (treeMainList.SelectedNode == null)
            {
                MessageBox.Show("Please select a valid site to add an IP address to.");
            }

            if (treeMainList.SelectedNode.Tag is Site)
            {
                try
                {
                    XElement element = XElement.Parse(Clipboard.GetText());
                    if (element.Name.LocalName == "IPAddress")
                    {
                        IPAddress ip = IPBuddyHelper.IPFromXML(element);
                        treeMainList.SelectedNode.Nodes.Add(IPToNode(ip));
                    }
                    else
                    {
                        MessageBox.Show("Invalid data on the clipboard. Please try copying again.");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid data on the clipboard. Please try copying again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid site to add an IP address to.");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeMainList.Nodes.Remove(treeMainList.SelectedNode);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeMainList.Nodes.Remove(treeMainList.SelectedNode);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.treeMainList.Nodes.Clear();
                this.loadFromXML(openFileDialog.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                IPBuddyHelper.ExportToXML(treeMainList, saveFileDialog.FileName);
            }
        }

        private void newSiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addNewSite();
        }

        private void newIPAddressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (treeMainList.SelectedNode == null)
            {
                MessageBox.Show("Please select a valid site to add an IP address to.");
            }

            if (treeMainList.SelectedNode.Tag is Site)
            {
                addNewIPAddress(treeMainList.SelectedNode);
            }
            else
            {
                MessageBox.Show("Please select a valid site to add an IP address to.");
            }
        }

        private void btnSetIP_Click(object sender, EventArgs e)
        {
            NIC nic = (NIC)comboNetworkList.SelectedItem;
            string cmd = String.Format("interface ip set address \"{0}\" static {1} {2} {3}", nic.Name, txtSetIP.Text, txtSetSubnet.Text, txtSetGateway.Text);

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", cmd);
            psi.Verb = "runas";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo = psi;

            p.Start();
            p.WaitForExit();

            IPBuddyHelper.LoadNICs(comboNetworkList);

            foreach (Object objnic in comboNetworkList.Items)
            {
                NIC cnic = (NIC)objnic;
                if (cnic.Name.Equals(nic.Name))
                {
                    comboNetworkList.SelectedItem = objnic;
                }
            }

            updateNICSettings();
        }

        private void treeMainList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is IPAddress)
            {
                IPAddress ip = (IPAddress)e.Node.Tag;

                this.txtSetIP.Text = ip.Address;
                this.txtSetSubnet.Text = ip.SubnetMask;
                this.txtSetGateway.Text = ip.DefaultGateway;
                this.lastSelectedIPNode = e.Node;
            }
        }

        private void btnResetDHCP_Click(object sender, EventArgs e)
        {
            NIC nic = (NIC)comboNetworkList.SelectedItem;
            string cmd = String.Format("interface ip set address \"{0}\" dhcp", nic.Name);

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", cmd);
            psi.Verb = "runas";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo = psi;

            p.Start();
            p.WaitForExit();

            IPBuddyHelper.LoadNICs(comboNetworkList);

            foreach(Object objnic in comboNetworkList.Items)
            {
                NIC cnic = (NIC)objnic;
                if (cnic.Name.Equals(nic.Name))
                {
                    comboNetworkList.SelectedItem = objnic;
                }
            }

            updateNICSettings();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "IPBuddy.chm");
        }
    }
}
