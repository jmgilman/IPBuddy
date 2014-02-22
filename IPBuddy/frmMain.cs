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

namespace IPBuddy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            /** Used for assigning the correct menu to new site and NAE nodes in external classes **/
            frmMain.StaticContextSite = this.contextSite;
            frmMain.StaticContextNAE = this.contextNAE;

            /** Load NICs into combo box **/
            NIC.LoadNICs(this.comboAdapterList);

            /** Check for existing configuration and load if applicable **/
            if (System.IO.File.Exists("default.xml"))
            {
                FormHandler.XMLToTree(XDocument.Load("default.xml"), this.treeSites);
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

            openFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.treeSites.Nodes.Clear();
                FormHandler.XMLToTree(XDocument.Load(openFileDialog.FileName), this.treeSites);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument document = FormHandler.TreeToXML(this.treeSites);
            document.Save("default.xml");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XDocument document = FormHandler.TreeToXML(this.treeSites);
                document.Save(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nAETrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importNAEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportNAEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "IPBuddy.chm");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.Show();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {

        }

        private void btnSetStatic_Click(object sender, EventArgs e)
        {
            NIC nic = (NIC)this.comboAdapterList.SelectedItem;

            nic.SetStaticIP(this.txtAdapterIPAddress.Text, this.txtAdapterSubnetMask.Text, this.txtAdapterDefaultGateway.Text);
            NIC.LoadNICs(this.comboAdapterList);
            nic.ReselectNIC(this.comboAdapterList);

            nic = (NIC)this.comboAdapterList.SelectedItem;
            FormHandler.UpdateNICText(nic, this.txtAdapterIPAddress, this.txtAdapterSubnetMask, this.txtAdapterDefaultGateway);
        }

        private void btnSetDHCP_Click(object sender, EventArgs e)
        {
            NIC nic = (NIC)this.comboAdapterList.SelectedItem;

            nic.SetDHCP();
            NIC.LoadNICs(this.comboAdapterList);
            nic.ReselectNIC(this.comboAdapterList);

            nic = (NIC)this.comboAdapterList.SelectedItem;
            FormHandler.UpdateNICText(nic, this.txtAdapterIPAddress, this.txtAdapterSubnetMask, this.txtAdapterDefaultGateway);
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

        private void comboAdapterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            NIC nic = (NIC)this.comboAdapterList.SelectedItem;
            FormHandler.UpdateNICText(nic, this.txtAdapterIPAddress, this.txtAdapterSubnetMask, this.txtAdapterDefaultGateway);
        }

        private void newNAEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
            TreeNode node = this.treeSites.GetNodeAt(this.treeSites.PointToClient(cms.Location));

            FormHandler.AddNewNAEToTree(this.treeSites, node);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
            TreeNode node = this.treeSites.GetNodeAt(this.treeSites.PointToClient(cms.Location));
            Site site = (Site)node.Tag;

            Clipboard.SetText(site.ToXML().ToString());
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeSites.SelectedNode != null)
            {
                if (!String.IsNullOrEmpty(Clipboard.GetText()))
                {
                    TreeNodeCollection nodes = this.treeSites.SelectedNode.Nodes;
                    XElement xnae = XElement.Parse(Clipboard.GetText());
                    FormHandler.AddNAEToTree(nodes, NAE.FromXML(xnae));
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeSites.Nodes.Remove(this.treeSites.SelectedNode);
        }

        private void launchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
            TreeNode node = this.treeSites.GetNodeAt(this.treeSites.PointToClient(cms.Location));
            NAE nae = (NAE)node.Tag;

            Clipboard.SetText(nae.ToXML().ToString());
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.treeSites.Nodes.Remove(this.treeSites.SelectedNode);
        }

        private void newSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHandler.AddNewSiteToTree(this.treeSites);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Clipboard.GetText()))
            {
                XElement xsite = XElement.Parse(Clipboard.GetText());
                FormHandler.AddSiteToTree(this.treeSites.Nodes, IPBuddy.Site.FromXML(xsite));
            }
        }
    }
}
