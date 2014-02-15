using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPBuddy
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
                IPAddress ip = new IPAddress(frmDialog.txtIPAddress.Text, frmDialog.txtSubnetMask.Text, frmDialog.txtDefaultGateway.Text);
                TreeNode newNode = new TreeNode(ip.Address);

                newNode.Tag = ip;
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
                TreeNode sitenode = new TreeNode(site.Name);
                sitenode.Tag = site;
                sitenode.ContextMenuStrip = contextMenuSite;

                foreach (IPAddress ip in site.Addresses)
                {
                    TreeNode ipnode = new TreeNode(ip.Address);
                    ipnode.Tag = ip;

                    sitenode.Nodes.Add(ipnode);
                }

                treeMainList.Nodes.Add(sitenode);
            }
        }

        private void newSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewSite();
        }

        private void contextMenuTree_Opening(object sender, CancelEventArgs e)
        {

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

                this.txtIP.Text = ip.Address;
                this.txtSubnet.Text = ip.SubnetMask;
                this.txtGateway.Text = ip.DefaultGateway;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            IPBuddyHelper.LoadNICs(comboNetworkList);

            if (System.IO.File.Exists("test.xml"))
            {
                this.loadFromXML("test.xml");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            TreeNode selnode = treeMainList.SelectedNode;
            
            if (selnode.Tag is IPAddress)
            {
                IPAddress ip = (IPAddress)selnode.Tag;

                ip.Address = txtIP.Text;
                ip.SubnetMask = txtSubnet.Text;
                ip.DefaultGateway = txtGateway.Text;

                selnode.Text = txtIP.Text;;
            }
            else
            {
                MessageBox.Show("Please select a valid IP address to save");
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            IPBuddyHelper.ExportToXML(treeMainList, "test.xml");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
