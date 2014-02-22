using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace IPBuddy
{
    class Sites
    {
        public static XElement ToXML(List<Site> sites)
        {
            XElement xsites = new XElement("Sites");

            foreach(Site site in sites)
            {
                xsites.Add(site.ToXML());
            }

            return xsites;
        }

        public static void ToTreeView(List<Site> sites, TreeView tree)
        {
            foreach(Site site in sites)
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

                tree.Nodes.Add(siteNode);
            }
        }

        public static List<Site> FromXML(XElement xsites)
        {
            List<Site> sites = new List<Site>();

            foreach(XElement xsite in xsites.Elements())
            {
                sites.Add(Site.FromXML(xsite));
            }

            return sites;
        }

        public static List<Site> FromTreeView(TreeView tree)
        {
            List<Site> sites = new List<Site>();

            if (tree.Nodes.Count > 0)
            {
                foreach(TreeNode siteNode in tree.Nodes)
                {
                    if (!(siteNode.Tag is Site))
                    {
                        // Throw error
                    }

                    sites.Add((Site)siteNode.Tag);
                }
            }

            return sites;
        }
    }
}
