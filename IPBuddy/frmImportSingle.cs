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
    public partial class frmImportSingle : Form
    {
        public delegate void PopuateNAEMethod(NAE nae);
        public PopuateNAEMethod PopulateNAEDelegate;

        public delegate void StopProgressMethod();
        public StopProgressMethod StopProgressDelegate;

        public static TreeNode SiteNode;
        public frmMain mainFrm;

        private NAE loadedNAE;
        private int timeout = 20000;

        public frmImportSingle()
        {
            InitializeComponent();
            this.PopulateNAEDelegate = new PopuateNAEMethod(this.PopulateNAE);
            this.StopProgressDelegate = new StopProgressMethod(this.StopProgress);
        }

        public void PopulateNAE(NAE nae)
        {
            this.loadedNAE = nae;

            this.lblName.Text = nae.Name;
            this.lblIP.Text = nae.IPAddress;
            this.lblMAC.Text = nae.MAC;
            this.lblOS.Text = nae.OSVersion;
            this.lblMSEA.Text = nae.MSEAVersion;
            this.lblNeuron.Text = nae.NeuronID;

            NAEHandler.ListeningForNAE = false;
            NAEHandler.ListeningForNAEIP = "";

            this.progressBar.Style = ProgressBarStyle.Blocks;
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Value = 0;
        }

        public void StopProgress()
        {
            this.progressBar.Style = ProgressBarStyle.Blocks;
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Value = 0;

            NAEHandler.ListeningForNAE = false;
            NAEHandler.ListeningForNAEIP = "";

            MessageBox.Show("The request timed out. Is the NAE online?");
        }

        private void waitForNAE()
        {
            System.Threading.Thread.Sleep(this.timeout);
            if (NAEHandler.ListeningForNAE)
            {
                this.Invoke(this.StopProgressDelegate);
            }
        }

        private void frmImportSingle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void cmdPing_Click(object sender, EventArgs e)
        {
            if (StaticIP.IsIPv4(this.txtIP.Text))
            {
                NAEHandler.BroadcastToNAE(this.txtIP.Text);
                this.progressBar.Style = ProgressBarStyle.Marquee;
                this.progressBar.MarqueeAnimationSpeed = 20;
                Task.Run((Action)this.waitForNAE);
            }
            else
            {
                MessageBox.Show("Please enter a valid IP address.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.loadedNAE == null)
            {
                MessageBox.Show("Please ping a NAE before trying to import it.");
                return;
            }
            else if (Sites.FromTreeView(this.mainFrm.treeSites).Count <= 0)
            {
                MessageBox.Show("You have no sites to import to. Please create at least one site first.");
                return;
            }
            else if (frmImportSingle.SiteNode == null)
            {
                MessageBox.Show("There was an error adding the NAE to the site. Please try again.");
                this.Visible = false;
                return;
            }

            Site site = (Site)frmImportSingle.SiteNode.Tag;
            this.loadedNAE.StaticIPAddress = StaticIP.GenerateStatic(this.loadedNAE.IPAddress);
            site.NAEs.Add(this.loadedNAE);
            FormHandler.AddNAEToTree(frmImportSingle.SiteNode.Nodes, this.loadedNAE);

            frmImportSingle.SiteNode = null;
            this.Visible = false;
        }
    }
}
