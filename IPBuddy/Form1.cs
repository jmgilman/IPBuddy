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
            /** Instantiate a new instance of the dialog box **/
            FormNewSite frmDialog = new FormNewSite();

            /** Verify the user clicked OK on the dialog box **/
            if (frmDialog.ShowDialog(this) == DialogResult.OK)
            {
                Site site = new Site(frmDialog.txtSiteName.Text);
                TreeNode node = new TreeNode(site.Name);

                node.Tag = site;
                node.ContextMenuStrip = contextMenuSite;

                treeMainList.Nodes.Add(node);
            }

            frmDialog.Dispose();
        }

        private void addNewIPAddress(TreeNode node)
        {
            /** Instantiate a new instance of the dialog box **/
            FormNewIP frmDialog = new FormNewIP();

            /** Verify the user clicked OK on the dialog box **/
            if (frmDialog.ShowDialog(this) == DialogResult.OK)
            {
                IPAddress ip = new IPAddress(frmDialog.txtName.Text, frmDialog.txtAddress.Text, frmDialog.txtSubnet.Text, frmDialog.txtGateway.Text);
                TreeNode newNode = new TreeNode(ip.Name);

                newNode.Tag = ip;
                newNode.ContextMenuStrip = contextMenuIP;
                node.Nodes.Add(newNode);

                Site site = (Site)node.Tag;
                site.Addresses.Add(ip);
            }

            frmDialog.Dispose();
        }

        private void loadFromXML(String fileName)
        {
            List<Site> sites = IPBuddyHelper.ImportFromXML(fileName);

            foreach (Site site in sites)
            {
                treeMainList.Nodes.Add(SiteToNode(site));
            }
        }

        private void updateIPSettings()
        {
            if (this.lastSelectedIPNode == null)
            {
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

        private void newSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewSite();
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

        private void treeMainList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
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
            ComboBox box = (ComboBox)sender;
            NIC nic = (NIC)box.SelectedItem;

            this.txtIP.Text = nic.IP.Address;
            this.txtSubnet.Text = nic.IP.SubnetMask;
            this.txtGateway.Text = nic.IP.DefaultGateway;
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
            Console.WriteLine("Label: " + e.Label);
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
            FormAbout frm = new FormAbout();
            frm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPBuddyHelper.ExportToXML(treeMainList, "default.xml");
        }

        private void txtSetIP_Leave(object sender, EventArgs e)
        {
            updateIPSettings();
        }

        private void txtSetSubnet_Leave(object sender, EventArgs e)
        {
            updateIPSettings();
        }

        private void txtSetGateway_Leave(object sender, EventArgs e)
        {
            updateIPSettings();
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
    }
}
