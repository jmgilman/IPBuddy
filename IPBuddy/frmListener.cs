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
    public partial class frmListener : Form
    {
        public delegate void AddNAEMethod(NAE nae);
        public AddNAEMethod AddNAEDelegate;
        public frmMain mainFrm;
        private List<NAE> naes;

        public frmListener()
        {
            InitializeComponent();
            this.naes = new List<NAE>();
            this.AddNAEDelegate = new AddNAEMethod(this.AddNAE);
        }

        public void AddNAE(NAE nae)
        {
            foreach(NAE listnae in this.naes)
            {
                if (listnae.IPAddress.Equals(nae.IPAddress))
                {
                    return;
                }
            }

            string[] row = new string[] { nae.Name, nae.IPAddress, nae.MAC, nae.OSVersion, nae.MSEAVersion, nae.NeuronID };
            ListViewItem item = new ListViewItem(row);
            item.Tag = nae;

            this.listDevices.Items.Add(item);
            this.naes.Add(nae);
        }

        private StaticIP generateStatic(String naeIP)
        {
            string[] parts = naeIP.Split(new char[] {'.'});
            string lastOctet = parts[parts.Length - 1];
            string baseIP = String.Join(".", parts, 0, parts.Length - 1);

            string ip = baseIP + "." + (Convert.ToInt32(lastOctet) + 1).ToString();
            string subnet = "255.255.255.0";
            string gateway = baseIP + ".1";

            return new StaticIP() { Address = ip, SubnetMask = subnet, DefaultGateway = gateway };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NAEHandler.Broadcast();
        }

        private void frmListener_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NAE nae = (NAE)this.listDevices.SelectedItems[0].Tag;
            nae.StaticIPAddress = this.generateStatic(nae.IPAddress);
            frmImport frm = new frmImport();
            
            foreach(Site site in Sites.FromTreeView(this.mainFrm.treeSites))
            {
                frm.comboSite.Items.Add(site.Name);
            }

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK && !String.IsNullOrEmpty((String)frm.comboSite.SelectedItem))
            {
                String selectedSite = (String)frm.comboSite.SelectedItem;
                foreach(TreeNode node in this.mainFrm.treeSites.Nodes)
                {
                    Site site = (Site)node.Tag;
                    if (selectedSite.Equals(site.Name))
                    {
                        site.NAEs.Add(nae);
                        FormHandler.AddNAEToTree(node.Nodes, nae);
                    }
                }
            }
        }
    }
}
