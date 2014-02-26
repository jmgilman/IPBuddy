namespace IPBuddy
{
    partial class frmImportSingle
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNeuron = new System.Windows.Forms.Label();
            this.lblMSEA = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.cmdPing = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAE IP Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNeuron);
            this.groupBox1.Controls.Add(this.lblMSEA);
            this.groupBox1.Controls.Add(this.lblOS);
            this.groupBox1.Controls.Add(this.lblMAC);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NAE";
            // 
            // lblNeuron
            // 
            this.lblNeuron.AutoSize = true;
            this.lblNeuron.Location = new System.Drawing.Point(108, 105);
            this.lblNeuron.Name = "lblNeuron";
            this.lblNeuron.Size = new System.Drawing.Size(0, 13);
            this.lblNeuron.TabIndex = 11;
            // 
            // lblMSEA
            // 
            this.lblMSEA.AutoSize = true;
            this.lblMSEA.Location = new System.Drawing.Point(108, 88);
            this.lblMSEA.Name = "lblMSEA";
            this.lblMSEA.Size = new System.Drawing.Size(0, 13);
            this.lblMSEA.TabIndex = 10;
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(108, 71);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(0, 13);
            this.lblOS.TabIndex = 9;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Location = new System.Drawing.Point(108, 54);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(0, 13);
            this.lblMAC.TabIndex = 8;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(108, 38);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 13);
            this.lblIP.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(108, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Neuron ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "MSEA Version: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "OS Version: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MAC Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP Address: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(112, 9);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(160, 20);
            this.txtIP.TabIndex = 2;
            // 
            // cmdPing
            // 
            this.cmdPing.Location = new System.Drawing.Point(30, 35);
            this.cmdPing.Name = "cmdPing";
            this.cmdPing.Size = new System.Drawing.Size(95, 23);
            this.cmdPing.TabIndex = 3;
            this.cmdPing.Text = "Ping";
            this.cmdPing.UseVisualStyleBackColor = true;
            this.cmdPing.Click += new System.EventHandler(this.cmdPing_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 216);
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(260, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 4;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(159, 35);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(95, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmImportSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cmdPing);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmImportSingle";
            this.Text = "Import a NAE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImportSingle_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button cmdPing;
        private System.Windows.Forms.Label lblNeuron;
        private System.Windows.Forms.Label lblMSEA;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnImport;
    }
}