namespace IPBuddy
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.treeSites = new System.Windows.Forms.TreeView();
            this.contextTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupAdapters = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdapterDefaultGateway = new System.Windows.Forms.Label();
            this.lblAdapterSubnetMask = new System.Windows.Forms.Label();
            this.lblAdapterIPAddress = new System.Windows.Forms.Label();
            this.txtAdapterDefaultGateway = new System.Windows.Forms.TextBox();
            this.txtAdapterSubnetMask = new System.Windows.Forms.TextBox();
            this.txtAdapterIPAddress = new System.Windows.Forms.TextBox();
            this.comboAdapterList = new System.Windows.Forms.ComboBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnSetStatic = new System.Windows.Forms.Button();
            this.btnSetDHCP = new System.Windows.Forms.Button();
            this.groupNAE = new System.Windows.Forms.GroupBox();
            this.dataNAE = new System.Windows.Forms.DataGridView();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nAEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nAETrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newNAEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importNAEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextNAE = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.launchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipNotify = new System.Windows.Forms.ToolTip(this.components);
            this.contextTree.SuspendLayout();
            this.groupAdapters.SuspendLayout();
            this.groupNAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNAE)).BeginInit();
            this.menuMain.SuspendLayout();
            this.contextSite.SuspendLayout();
            this.contextNAE.SuspendLayout();
            this.contextNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeSites
            // 
            this.treeSites.ContextMenuStrip = this.contextTree;
            this.treeSites.Location = new System.Drawing.Point(12, 30);
            this.treeSites.Name = "treeSites";
            this.treeSites.Size = new System.Drawing.Size(121, 382);
            this.treeSites.TabIndex = 0;
            this.treeSites.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeSites_AfterLabelEdit);
            this.treeSites.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSites_AfterSelect);
            this.treeSites.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSites_NodeMouseClick);
            this.treeSites.DoubleClick += new System.EventHandler(this.treeSites_DoubleClick);
            // 
            // contextTree
            // 
            this.contextTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSiteToolStripMenuItem,
            this.importSiteToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.contextTree.Name = "contextTree";
            this.contextTree.Size = new System.Drawing.Size(133, 70);
            // 
            // newSiteToolStripMenuItem
            // 
            this.newSiteToolStripMenuItem.Name = "newSiteToolStripMenuItem";
            this.newSiteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newSiteToolStripMenuItem.Text = "New Site";
            this.newSiteToolStripMenuItem.Click += new System.EventHandler(this.newSiteToolStripMenuItem_Click);
            // 
            // importSiteToolStripMenuItem1
            // 
            this.importSiteToolStripMenuItem1.Name = "importSiteToolStripMenuItem1";
            this.importSiteToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.importSiteToolStripMenuItem1.Text = "Import Site";
            this.importSiteToolStripMenuItem1.Click += new System.EventHandler(this.importSiteToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // groupAdapters
            // 
            this.groupAdapters.Controls.Add(this.label4);
            this.groupAdapters.Controls.Add(this.lblAdapterDefaultGateway);
            this.groupAdapters.Controls.Add(this.lblAdapterSubnetMask);
            this.groupAdapters.Controls.Add(this.lblAdapterIPAddress);
            this.groupAdapters.Controls.Add(this.txtAdapterDefaultGateway);
            this.groupAdapters.Controls.Add(this.txtAdapterSubnetMask);
            this.groupAdapters.Controls.Add(this.txtAdapterIPAddress);
            this.groupAdapters.Controls.Add(this.comboAdapterList);
            this.groupAdapters.Location = new System.Drawing.Point(142, 59);
            this.groupAdapters.Name = "groupAdapters";
            this.groupAdapters.Size = new System.Drawing.Size(303, 145);
            this.groupAdapters.TabIndex = 1;
            this.groupAdapters.TabStop = false;
            this.groupAdapters.Text = "Network Adapters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adapter: ";
            // 
            // lblAdapterDefaultGateway
            // 
            this.lblAdapterDefaultGateway.AutoSize = true;
            this.lblAdapterDefaultGateway.Location = new System.Drawing.Point(9, 113);
            this.lblAdapterDefaultGateway.Name = "lblAdapterDefaultGateway";
            this.lblAdapterDefaultGateway.Size = new System.Drawing.Size(89, 13);
            this.lblAdapterDefaultGateway.TabIndex = 6;
            this.lblAdapterDefaultGateway.Text = "Default Gateway:";
            // 
            // lblAdapterSubnetMask
            // 
            this.lblAdapterSubnetMask.AutoSize = true;
            this.lblAdapterSubnetMask.Location = new System.Drawing.Point(9, 87);
            this.lblAdapterSubnetMask.Name = "lblAdapterSubnetMask";
            this.lblAdapterSubnetMask.Size = new System.Drawing.Size(73, 13);
            this.lblAdapterSubnetMask.TabIndex = 5;
            this.lblAdapterSubnetMask.Text = "Subnet Mask:";
            // 
            // lblAdapterIPAddress
            // 
            this.lblAdapterIPAddress.AutoSize = true;
            this.lblAdapterIPAddress.Location = new System.Drawing.Point(9, 61);
            this.lblAdapterIPAddress.Name = "lblAdapterIPAddress";
            this.lblAdapterIPAddress.Size = new System.Drawing.Size(61, 13);
            this.lblAdapterIPAddress.TabIndex = 4;
            this.lblAdapterIPAddress.Text = "IP Address:";
            // 
            // txtAdapterDefaultGateway
            // 
            this.txtAdapterDefaultGateway.Enabled = false;
            this.txtAdapterDefaultGateway.Location = new System.Drawing.Point(103, 113);
            this.txtAdapterDefaultGateway.Name = "txtAdapterDefaultGateway";
            this.txtAdapterDefaultGateway.Size = new System.Drawing.Size(194, 20);
            this.txtAdapterDefaultGateway.TabIndex = 3;
            // 
            // txtAdapterSubnetMask
            // 
            this.txtAdapterSubnetMask.Enabled = false;
            this.txtAdapterSubnetMask.Location = new System.Drawing.Point(103, 87);
            this.txtAdapterSubnetMask.Name = "txtAdapterSubnetMask";
            this.txtAdapterSubnetMask.Size = new System.Drawing.Size(194, 20);
            this.txtAdapterSubnetMask.TabIndex = 2;
            // 
            // txtAdapterIPAddress
            // 
            this.txtAdapterIPAddress.Enabled = false;
            this.txtAdapterIPAddress.Location = new System.Drawing.Point(103, 61);
            this.txtAdapterIPAddress.Name = "txtAdapterIPAddress";
            this.txtAdapterIPAddress.Size = new System.Drawing.Size(194, 20);
            this.txtAdapterIPAddress.TabIndex = 1;
            // 
            // comboAdapterList
            // 
            this.comboAdapterList.FormattingEnabled = true;
            this.comboAdapterList.Location = new System.Drawing.Point(65, 24);
            this.comboAdapterList.Name = "comboAdapterList";
            this.comboAdapterList.Size = new System.Drawing.Size(232, 21);
            this.comboAdapterList.TabIndex = 0;
            this.comboAdapterList.SelectedIndexChanged += new System.EventHandler(this.comboAdapterList_SelectedIndexChanged);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(160, 30);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(85, 23);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnSetStatic
            // 
            this.btnSetStatic.Location = new System.Drawing.Point(252, 30);
            this.btnSetStatic.Name = "btnSetStatic";
            this.btnSetStatic.Size = new System.Drawing.Size(85, 23);
            this.btnSetStatic.TabIndex = 3;
            this.btnSetStatic.Text = "Set Static";
            this.btnSetStatic.UseVisualStyleBackColor = true;
            this.btnSetStatic.Click += new System.EventHandler(this.btnSetStatic_Click);
            // 
            // btnSetDHCP
            // 
            this.btnSetDHCP.Location = new System.Drawing.Point(344, 30);
            this.btnSetDHCP.Name = "btnSetDHCP";
            this.btnSetDHCP.Size = new System.Drawing.Size(85, 23);
            this.btnSetDHCP.TabIndex = 4;
            this.btnSetDHCP.Text = "Set DHCP";
            this.btnSetDHCP.UseVisualStyleBackColor = true;
            this.btnSetDHCP.Click += new System.EventHandler(this.btnSetDHCP_Click);
            // 
            // groupNAE
            // 
            this.groupNAE.Controls.Add(this.dataNAE);
            this.groupNAE.Location = new System.Drawing.Point(142, 210);
            this.groupNAE.Name = "groupNAE";
            this.groupNAE.Size = new System.Drawing.Size(303, 202);
            this.groupNAE.TabIndex = 5;
            this.groupNAE.TabStop = false;
            this.groupNAE.Text = "NAE";
            // 
            // dataNAE
            // 
            this.dataNAE.AllowUserToAddRows = false;
            this.dataNAE.AllowUserToDeleteRows = false;
            this.dataNAE.AllowUserToResizeRows = false;
            this.dataNAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNAE.Location = new System.Drawing.Point(11, 19);
            this.dataNAE.Name = "dataNAE";
            this.dataNAE.RowHeadersVisible = false;
            this.dataNAE.Size = new System.Drawing.Size(286, 177);
            this.dataNAE.TabIndex = 7;
            this.dataNAE.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNAE_CellEndEdit);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(457, 24);
            this.menuMain.TabIndex = 6;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteToolStripMenuItem,
            this.nAEToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // siteToolStripMenuItem
            // 
            this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
            this.siteToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.siteToolStripMenuItem.Text = "Site";
            this.siteToolStripMenuItem.Click += new System.EventHandler(this.siteToolStripMenuItem_Click);
            // 
            // nAEToolStripMenuItem
            // 
            this.nAEToolStripMenuItem.Name = "nAEToolStripMenuItem";
            this.nAEToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.nAEToolStripMenuItem.Text = "NAE";
            this.nAEToolStripMenuItem.Click += new System.EventHandler(this.nAEToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAETrackerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // nAETrackerToolStripMenuItem
            // 
            this.nAETrackerToolStripMenuItem.Name = "nAETrackerToolStripMenuItem";
            this.nAETrackerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.nAETrackerToolStripMenuItem.Text = "NAE Listener";
            this.nAETrackerToolStripMenuItem.Click += new System.EventHandler(this.nAETrackerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpTopicsToolStripMenuItem
            // 
            this.helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
            this.helpTopicsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpTopicsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.helpTopicsToolStripMenuItem.Text = "Help Topics";
            this.helpTopicsToolStripMenuItem.Click += new System.EventHandler(this.helpTopicsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextSite
            // 
            this.contextSite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNAEToolStripMenuItem,
            this.importNAEToolStripMenuItem1,
            this.exportToolStripMenuItem1,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextSite.Name = "contextSite";
            this.contextSite.Size = new System.Drawing.Size(137, 136);
            // 
            // newNAEToolStripMenuItem
            // 
            this.newNAEToolStripMenuItem.Name = "newNAEToolStripMenuItem";
            this.newNAEToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newNAEToolStripMenuItem.Text = "New NAE";
            this.newNAEToolStripMenuItem.Click += new System.EventHandler(this.newNAEToolStripMenuItem_Click);
            // 
            // importNAEToolStripMenuItem1
            // 
            this.importNAEToolStripMenuItem1.Name = "importNAEToolStripMenuItem1";
            this.importNAEToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.importNAEToolStripMenuItem1.Text = "Import NAE";
            this.importNAEToolStripMenuItem1.Click += new System.EventHandler(this.importNAEToolStripMenuItem1_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextNAE
            // 
            this.contextNAE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchToolStripMenuItem,
            this.exportToolStripMenuItem2,
            this.copyToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.contextNAE.Name = "contextNAE";
            this.contextNAE.Size = new System.Drawing.Size(114, 92);
            // 
            // launchToolStripMenuItem
            // 
            this.launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            this.launchToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.launchToolStripMenuItem.Text = "Launch";
            this.launchToolStripMenuItem.Click += new System.EventHandler(this.launchToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem2
            // 
            this.exportToolStripMenuItem2.Name = "exportToolStripMenuItem2";
            this.exportToolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.exportToolStripMenuItem2.Text = "Export";
            this.exportToolStripMenuItem2.Click += new System.EventHandler(this.exportToolStripMenuItem2_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "IPBuddy has been placed in the system tray.";
            this.notifyIcon.BalloonTipTitle = "IPBuddy";
            this.notifyIcon.ContextMenuStrip = this.contextNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "IPBuddy V2.0";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextNotify
            // 
            this.contextNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.contextNotify.Name = "contextNotify";
            this.contextNotify.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolTipNotify
            // 
            this.toolTipNotify.IsBalloon = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 424);
            this.Controls.Add(this.groupNAE);
            this.Controls.Add(this.btnSetDHCP);
            this.Controls.Add(this.btnSetStatic);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.groupAdapters);
            this.Controls.Add(this.treeSites);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "IPBuddy - V2.0.3";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.contextTree.ResumeLayout(false);
            this.groupAdapters.ResumeLayout(false);
            this.groupAdapters.PerformLayout();
            this.groupNAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNAE)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.contextSite.ResumeLayout(false);
            this.contextNAE.ResumeLayout(false);
            this.contextNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAdapters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdapterDefaultGateway;
        private System.Windows.Forms.Label lblAdapterSubnetMask;
        private System.Windows.Forms.Label lblAdapterIPAddress;
        private System.Windows.Forms.TextBox txtAdapterDefaultGateway;
        private System.Windows.Forms.TextBox txtAdapterSubnetMask;
        private System.Windows.Forms.TextBox txtAdapterIPAddress;
        private System.Windows.Forms.ComboBox comboAdapterList;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnSetStatic;
        private System.Windows.Forms.Button btnSetDHCP;
        private System.Windows.Forms.GroupBox groupNAE;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nAEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nAETrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextSite;
        private System.Windows.Forms.ToolStripMenuItem newNAEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextNAE;
        private System.Windows.Forms.ToolStripMenuItem launchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;

        public static System.Windows.Forms.ContextMenuStrip StaticContextSite;
        public static System.Windows.Forms.ContextMenuStrip StaticContextNAE;
        private System.Windows.Forms.ContextMenuStrip contextTree;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newSiteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataNAE;
        public System.Windows.Forms.TreeView treeSites;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importNAEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importSiteToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextNotify;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolTip toolTipNotify;

    }
}