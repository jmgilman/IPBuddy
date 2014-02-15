namespace IPBuddy
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeMainList = new System.Windows.Forms.TreeView();
            this.contextMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboNetworkList = new System.Windows.Forms.ComboBox();
            this.labelSelectNetwork = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetDHCP = new System.Windows.Forms.Button();
            this.btnSetIP = new System.Windows.Forms.Button();
            this.contextMenuSite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuTree.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSiteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSiteToolStripMenuItem
            // 
            this.newSiteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSiteToolStripMenuItem.Name = "newSiteToolStripMenuItem";
            this.newSiteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newSiteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newSiteToolStripMenuItem.Text = "New Site";
            this.newSiteToolStripMenuItem.Click += new System.EventHandler(this.newSiteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // treeMainList
            // 
            this.treeMainList.ContextMenuStrip = this.contextMenuTree;
            this.treeMainList.Location = new System.Drawing.Point(12, 198);
            this.treeMainList.Name = "treeMainList";
            this.treeMainList.Size = new System.Drawing.Size(347, 181);
            this.treeMainList.TabIndex = 1;
            this.treeMainList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeMainList_NodeMouseClick);
            // 
            // contextMenuTree
            // 
            this.contextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSiteToolStripMenuItem1});
            this.contextMenuTree.Name = "contextMenuTree";
            this.contextMenuTree.Size = new System.Drawing.Size(121, 26);
            this.contextMenuTree.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuTree_Opening);
            // 
            // newSiteToolStripMenuItem1
            // 
            this.newSiteToolStripMenuItem1.Name = "newSiteToolStripMenuItem1";
            this.newSiteToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.newSiteToolStripMenuItem1.Text = "New Site";
            this.newSiteToolStripMenuItem1.Click += new System.EventHandler(this.newSiteToolStripMenuItem1_Click);
            // 
            // comboNetworkList
            // 
            this.comboNetworkList.FormattingEnabled = true;
            this.comboNetworkList.Location = new System.Drawing.Point(111, 19);
            this.comboNetworkList.Name = "comboNetworkList";
            this.comboNetworkList.Size = new System.Drawing.Size(218, 21);
            this.comboNetworkList.TabIndex = 2;
            this.comboNetworkList.SelectedIndexChanged += new System.EventHandler(this.comboNetworkList_SelectedIndexChanged);
            // 
            // labelSelectNetwork
            // 
            this.labelSelectNetwork.AutoSize = true;
            this.labelSelectNetwork.Location = new System.Drawing.Point(18, 23);
            this.labelSelectNetwork.Name = "labelSelectNetwork";
            this.labelSelectNetwork.Size = new System.Drawing.Size(83, 13);
            this.labelSelectNetwork.TabIndex = 3;
            this.labelSelectNetwork.Text = "Select Network:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtGateway);
            this.groupBox1.Controls.Add(this.txtSubnet);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.lblGateway);
            this.groupBox1.Controls.Add(this.lblSubnet);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.btnResetDHCP);
            this.groupBox1.Controls.Add(this.btnSetIP);
            this.groupBox1.Controls.Add(this.labelSelectNetwork);
            this.groupBox1.Controls.Add(this.comboNetworkList);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnResetDHCP
            // 
            this.btnResetDHCP.Location = new System.Drawing.Point(227, 136);
            this.btnResetDHCP.Name = "btnResetDHCP";
            this.btnResetDHCP.Size = new System.Drawing.Size(95, 23);
            this.btnResetDHCP.TabIndex = 5;
            this.btnResetDHCP.Text = "Reset to DHCP";
            this.btnResetDHCP.UseVisualStyleBackColor = true;
            // 
            // btnSetIP
            // 
            this.btnSetIP.Location = new System.Drawing.Point(37, 136);
            this.btnSetIP.Name = "btnSetIP";
            this.btnSetIP.Size = new System.Drawing.Size(95, 23);
            this.btnSetIP.TabIndex = 4;
            this.btnSetIP.Text = "Set IP";
            this.btnSetIP.UseVisualStyleBackColor = true;
            // 
            // contextMenuSite
            // 
            this.contextMenuSite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewIPToolStripMenuItem});
            this.contextMenuSite.Name = "contextMenuSite";
            this.contextMenuSite.Size = new System.Drawing.Size(137, 26);
            // 
            // addNewIPToolStripMenuItem
            // 
            this.addNewIPToolStripMenuItem.Name = "addNewIPToolStripMenuItem";
            this.addNewIPToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addNewIPToolStripMenuItem.Text = "Add New IP";
            this.addNewIPToolStripMenuItem.Click += new System.EventHandler(this.addNewIPToolStripMenuItem_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(18, 61);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(61, 13);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "IP Address:";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Location = new System.Drawing.Point(18, 80);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(73, 13);
            this.lblSubnet.TabIndex = 7;
            this.lblSubnet.Text = "Subnet Mask:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(18, 104);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(89, 13);
            this.lblGateway.TabIndex = 8;
            this.lblGateway.Text = "Default Gateway:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(111, 57);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(218, 20);
            this.txtIP.TabIndex = 9;
            // 
            // txtSubnet
            // 
            this.txtSubnet.Location = new System.Drawing.Point(111, 78);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(218, 20);
            this.txtSubnet.TabIndex = 10;
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(111, 99);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(218, 20);
            this.txtGateway.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save IP";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeMainList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "IPBuddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuTree.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuSite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView treeMainList;
        private System.Windows.Forms.ComboBox comboNetworkList;
        private System.Windows.Forms.Label labelSelectNetwork;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetDHCP;
        private System.Windows.Forms.Button btnSetIP;
        private System.Windows.Forms.ContextMenuStrip contextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem newSiteToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuSite;
        private System.Windows.Forms.ToolStripMenuItem addNewIPToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblIP;
    }
}

