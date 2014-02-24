namespace IPBuddy
{
    partial class frmListener
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
            this.listDevices = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.os = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.neuron = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDevices
            // 
            this.listDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.ip,
            this.mac,
            this.os,
            this.msea,
            this.neuron});
            this.listDevices.FullRowSelect = true;
            this.listDevices.Location = new System.Drawing.Point(8, 13);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(614, 97);
            this.listDevices.TabIndex = 0;
            this.listDevices.UseCompatibleStateImageBehavior = false;
            this.listDevices.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 95;
            // 
            // ip
            // 
            this.ip.Text = "IP Address";
            this.ip.Width = 100;
            // 
            // mac
            // 
            this.mac.Text = "MAC Address";
            this.mac.Width = 115;
            // 
            // os
            // 
            this.os.Text = "OS Version";
            this.os.Width = 100;
            // 
            // msea
            // 
            this.msea.Text = "MSEA Version";
            this.msea.Width = 100;
            // 
            // neuron
            // 
            this.neuron.Text = "Neuron ID";
            this.neuron.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Broadcast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Import";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 143);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListener";
            this.Text = "NAE Listener";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListener_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listDevices;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader ip;
        private System.Windows.Forms.ColumnHeader mac;
        private System.Windows.Forms.ColumnHeader os;
        private System.Windows.Forms.ColumnHeader msea;
        private System.Windows.Forms.ColumnHeader neuron;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}