using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IPBuddy
{
    class FormHandler
    {
        public static void AddNewSiteToTree(TreeView tree)
        {
            Site site = new Site{Name = "Site Name"};
            TreeNode siteNode = new TreeNode(site.Name);

            siteNode.Tag = site;
            siteNode.ContextMenuStrip = frmMain.StaticContextSite;
            tree.LabelEdit = true;
            tree.Nodes.Add(siteNode);

            if (!siteNode.IsEditing)
            {
                siteNode.BeginEdit();
            }
        }

        public static void AddNewNAEToTree(TreeView tree, TreeNode siteNode)
        {
            NAE nae = new NAE { Name = "New NAE" };
            TreeNode naeNode = new TreeNode(nae.Name);

            naeNode.Tag = nae;
            naeNode.ContextMenuStrip = frmMain.StaticContextNAE;

            if (!(siteNode.Tag is Site))
            {
                // Throw error
            }

            Site site = (Site)siteNode.Tag;
            site.NAEs.Add(nae);
            siteNode.Nodes.Add(naeNode);
            tree.LabelEdit = true;

            if (!naeNode.IsEditing)
            {
                naeNode.BeginEdit();
            }
        }

        public static void AddSiteToTree(TreeNodeCollection nodes, Site site)
        {
            TreeNode siteNode = new TreeNode(site.Name);
            siteNode.Tag = site;
            siteNode.ContextMenuStrip = frmMain.StaticContextSite;

            foreach(NAE nae in site.NAEs)
            {
                TreeNode naeNode = new TreeNode(nae.Name);
                naeNode.Tag = nae;
                naeNode.ContextMenuStrip = frmMain.StaticContextNAE;

                siteNode.Nodes.Add(naeNode);
            }

            nodes.Add(siteNode);
        }

        public static void AddNAEToTree(TreeNodeCollection nodes, NAE nae)
        {
            TreeNode naeNode = new TreeNode(nae.Name);
            naeNode.Tag = nae;
            naeNode.ContextMenuStrip = frmMain.StaticContextNAE;

            nodes.Add(naeNode);
        }

        public static XDocument TreeToXML(TreeView tree)
        {
            XDocument document = new XDocument( Sites.ToXML( Sites.FromTreeView(tree) ) );
            return document;
        }

        public static void XMLToTree(XDocument document, TreeView tree)
        {
            Sites.ToTreeView(Sites.FromXML(document.Root), tree);
        }

        public static void UpdateNICText(NIC nic, TextBox txtIP, TextBox txtSubnet, TextBox txtGateway)
        {
            txtIP.Text = nic.IP.Address;
            txtSubnet.Text = nic.IP.SubnetMask;
            txtGateway.Text = nic.IP.DefaultGateway;
        }
    }
}
