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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSiteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newIPAddressToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeMainList = new System.Windows.Forms.TreeView();
            this.contextMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboNetworkList = new System.Windows.Forms.ComboBox();
            this.labelSelectNetwork = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSetGateway = new System.Windows.Forms.TextBox();
            this.txtSetSubnet = new System.Windows.Forms.TextBox();
            this.txtSetIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnResetDHCP = new System.Windows.Forms.Button();
            this.btnSetIP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuSite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDHCP = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuTree.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuSite.SuspendLayout();
            this.contextMenuIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSiteToolStripMenuItem2,
            this.newIPAddressToolStripMenuItem1});
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newSiteToolStripMenuItem2
            // 
            this.newSiteToolStripMenuItem2.Name = "newSiteToolStripMenuItem2";
            this.newSiteToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newSiteToolStripMenuItem2.Size = new System.Drawing.Size(163, 22);
            this.newSiteToolStripMenuItem2.Text = "New Site";
            this.newSiteToolStripMenuItem2.Click += new System.EventHandler(this.newSiteToolStripMenuItem2_Click);
            // 
            // newIPAddressToolStripMenuItem1
            // 
            this.newIPAddressToolStripMenuItem1.Name = "newIPAddressToolStripMenuItem1";
            this.newIPAddressToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.newIPAddressToolStripMenuItem1.Text = "New IP Address";
            this.newIPAddressToolStripMenuItem1.Click += new System.EventHandler(this.newIPAddressToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loadToolStripMenuItem.Text = "Open";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // treeMainList
            // 
            this.treeMainList.ContextMenuStrip = this.contextMenuTree;
            this.treeMainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMainList.Location = new System.Drawing.Point(13, 316);
            this.treeMainList.Name = "treeMainList";
            this.treeMainList.Size = new System.Drawing.Size(347, 189);
            this.treeMainList.TabIndex = 1;
            this.treeMainList.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeMainList_AfterLabelEdit);
            this.treeMainList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMainList_AfterSelect);
            this.treeMainList.DoubleClick += new System.EventHandler(this.treeMainList_DoubleClick);
            this.treeMainList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeMainList_MouseDown);
            // 
            // contextMenuTree
            // 
            this.contextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSiteToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.contextMenuTree.Name = "contextMenuTree";
            this.contextMenuTree.Size = new System.Drawing.Size(144, 48);
            // 
            // newSiteToolStripMenuItem1
            // 
            this.newSiteToolStripMenuItem1.Name = "newSiteToolStripMenuItem1";
            this.newSiteToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.newSiteToolStripMenuItem1.Text = "New Site";
            this.newSiteToolStripMenuItem1.Click += new System.EventHandler(this.newSiteToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // comboNetworkList
            // 
            this.comboNetworkList.FormattingEnabled = true;
            this.comboNetworkList.Location = new System.Drawing.Point(111, 32);
            this.comboNetworkList.Name = "comboNetworkList";
            this.comboNetworkList.Size = new System.Drawing.Size(218, 21);
            this.comboNetworkList.TabIndex = 2;
            this.comboNetworkList.SelectedIndexChanged += new System.EventHandler(this.comboNetworkList_SelectedIndexChanged);
            // 
            // labelSelectNetwork
            // 
            this.labelSelectNetwork.AutoSize = true;
            this.labelSelectNetwork.Location = new System.Drawing.Point(18, 36);
            this.labelSelectNetwork.Name = "labelSelectNetwork";
            this.labelSelectNetwork.Size = new System.Drawing.Size(83, 13);
            this.labelSelectNetwork.TabIndex = 3;
            this.labelSelectNetwork.Text = "Select Network:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSetGateway);
            this.groupBox3.Controls.Add(this.txtSetSubnet);
            this.groupBox3.Controls.Add(this.txtSetIP);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set IP Settings";
            // 
            // txtSetGateway
            // 
            this.txtSetGateway.Location = new System.Drawing.Point(105, 61);
            this.txtSetGateway.Name = "txtSetGateway";
            this.txtSetGateway.Size = new System.Drawing.Size(218, 20);
            this.txtSetGateway.TabIndex = 17;
            this.txtSetGateway.Leave += new System.EventHandler(this.txtSetGateway_Leave);
            // 
            // txtSetSubnet
            // 
            this.txtSetSubnet.Location = new System.Drawing.Point(105, 40);
            this.txtSetSubnet.Name = "txtSetSubnet";
            this.txtSetSubnet.Size = new System.Drawing.Size(218, 20);
            this.txtSetSubnet.TabIndex = 16;
            this.txtSetSubnet.Leave += new System.EventHandler(this.txtSetSubnet_Leave);
            // 
            // txtSetIP
            // 
            this.txtSetIP.Location = new System.Drawing.Point(105, 19);
            this.txtSetIP.Name = "txtSetIP";
            this.txtSetIP.Size = new System.Drawing.Size(218, 20);
            this.txtSetIP.TabIndex = 15;
            this.txtSetIP.Leave += new System.EventHandler(this.txtSetIP_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Default Gateway:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Subnet Mask:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP Address:";
            // 
            // txtGateway
            // 
            this.txtGateway.Enabled = false;
            this.txtGateway.Location = new System.Drawing.Point(111, 112);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(218, 20);
            this.txtGateway.TabIndex = 11;
            // 
            // txtSubnet
            // 
            this.txtSubnet.Enabled = false;
            this.txtSubnet.Location = new System.Drawing.Point(111, 91);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(218, 20);
            this.txtSubnet.TabIndex = 10;
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(111, 70);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(218, 20);
            this.txtIP.TabIndex = 9;
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(18, 117);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(89, 13);
            this.lblGateway.TabIndex = 8;
            this.lblGateway.Text = "Default Gateway:";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Location = new System.Drawing.Point(18, 93);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(73, 13);
            this.lblSubnet.TabIndex = 7;
            this.lblSubnet.Text = "Subnet Mask:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(18, 74);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(61, 13);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "IP Address:";
            // 
            // btnResetDHCP
            // 
            this.btnResetDHCP.Location = new System.Drawing.Point(176, 254);
            this.btnResetDHCP.Name = "btnResetDHCP";
            this.btnResetDHCP.Size = new System.Drawing.Size(135, 23);
            this.btnResetDHCP.TabIndex = 5;
            this.btnResetDHCP.Text = "Reset to DHCP";
            this.btnResetDHCP.UseVisualStyleBackColor = true;
            this.btnResetDHCP.Click += new System.EventHandler(this.btnResetDHCP_Click);
            // 
            // btnSetIP
            // 
            this.btnSetIP.Location = new System.Drawing.Point(35, 254);
            this.btnSetIP.Name = "btnSetIP";
            this.btnSetIP.Size = new System.Drawing.Size(135, 23);
            this.btnSetIP.TabIndex = 4;
            this.btnSetIP.Text = "Set IP";
            this.btnSetIP.UseVisualStyleBackColor = true;
            this.btnSetIP.Click += new System.EventHandler(this.btnSetIP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDHCP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network Settings";
            // 
            // contextMenuSite
            // 
            this.contextMenuSite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewIPToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuSite.Name = "contextMenuSite";
            this.contextMenuSite.Size = new System.Drawing.Size(145, 92);
            // 
            // addNewIPToolStripMenuItem
            // 
            this.addNewIPToolStripMenuItem.Name = "addNewIPToolStripMenuItem";
            this.addNewIPToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addNewIPToolStripMenuItem.Text = "Add New IP";
            this.addNewIPToolStripMenuItem.Click += new System.EventHandler(this.addNewIPToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuIP
            // 
            this.contextMenuIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.contextMenuIP.Name = "contextMenuIP";
            this.contextMenuIP.Size = new System.Drawing.Size(108, 48);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DHCP Enabled: ";
            // 
            // lblDHCP
            // 
            this.lblDHCP.AutoSize = true;
            this.lblDHCP.Location = new System.Drawing.Point(184, 39);
            this.lblDHCP.Name = "lblDHCP";
            this.lblDHCP.Size = new System.Drawing.Size(0, 13);
            this.lblDHCP.TabIndex = 1;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeMainList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "IPBuddy";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuTree.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuSite.ResumeLayout(false);
            this.contextMenuIP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView treeMainList;
        private System.Windows.Forms.ComboBox comboNetworkList;
        private System.Windows.Forms.Label labelSelectNetwork;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetDHCP;
        private System.Windows.Forms.Button btnSetIP;
        private System.Windows.Forms.ContextMenuStrip contextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem newSiteToolStripMenuItem1;
        public System.Windows.Forms.ContextMenuStrip contextMenuSite;
        private System.Windows.Forms.ToolStripMenuItem addNewIPToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSetGateway;
        private System.Windows.Forms.TextBox txtSetSubnet;
        private System.Windows.Forms.TextBox txtSetIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuIP;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSiteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newIPAddressToolStripMenuItem1;
        private System.Windows.Forms.Label lblDHCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

