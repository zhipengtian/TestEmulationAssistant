namespace AFSBrowser {
    partial class PathsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnContinue = new System.Windows.Forms.Button();
            this.openAfsFD = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBoxISOpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.txtBxConfig = new System.Windows.Forms.TextBox();
            this.openConfigFD = new System.Windows.Forms.OpenFileDialog();
            this.btnConfigBrowse = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbServiceProvider = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtStatusStrip = new System.Windows.Forms.StatusStrip();
            this.txtStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.txtStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Location = new System.Drawing.Point(379, 397);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // openAfsFD
            // 
            this.openAfsFD.FileName = "openFileDialog1";
            this.openAfsFD.Title = "\"\\\\afs\\iu.edu\\public\\sudoc\\volumes\\\"";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(14, 87);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Bro&wse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBoxISOpath
            // 
            this.txtBoxISOpath.Location = new System.Drawing.Point(18, 52);
            this.txtBoxISOpath.Name = "txtBoxISOpath";
            this.txtBoxISOpath.Size = new System.Drawing.Size(397, 20);
            this.txtBoxISOpath.TabIndex = 1;
            this.txtBoxISOpath.TextChanged += new System.EventHandler(this.txtBoxISOpath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the path to the file or image you wish to open:";
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(18, 62);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(337, 39);
            this.lblConfig.TabIndex = 2;
            this.lblConfig.Text = "Please enter the path to your Virtual Machine Configuration File (.vmx) \r\n( i.e. " +
                "Windows XP Professional.vmx )\r\n\r\n";
            // 
            // txtBxConfig
            // 
            this.txtBxConfig.Location = new System.Drawing.Point(21, 107);
            this.txtBxConfig.Name = "txtBxConfig";
            this.txtBxConfig.Size = new System.Drawing.Size(397, 20);
            this.txtBxConfig.TabIndex = 3;
            this.txtBxConfig.Text = "C:\\Virtual Machines\\Windows-XP-Pro-Bare-Image\\Windows XP Professional.vmx";
            // 
            // openConfigFD
            // 
            this.openConfigFD.FileName = "openFileDialog1";
            // 
            // btnConfigBrowse
            // 
            this.btnConfigBrowse.Location = new System.Drawing.Point(21, 143);
            this.btnConfigBrowse.Name = "btnConfigBrowse";
            this.btnConfigBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnConfigBrowse.TabIndex = 4;
            this.btnConfigBrowse.Text = "&Browse";
            this.btnConfigBrowse.UseVisualStyleBackColor = true;
            this.btnConfigBrowse.Click += new System.EventHandler(this.btnConfigBrowse_Click);
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(95, 87);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(320, 42);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "* Note: If you are wanting to use a file or image that is on the AFS, it may take" +
                " a few seconds after clicking Browse until you see the file dialog. Please be aw" +
                "are that this is normal.\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblService);
            this.groupBox1.Controls.Add(this.cmbServiceProvider);
            this.groupBox1.Controls.Add(this.lblConfig);
            this.groupBox1.Controls.Add(this.txtBxConfig);
            this.groupBox1.Controls.Add(this.btnConfigBrowse);
            this.groupBox1.Location = new System.Drawing.Point(15, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Virtual Machine";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(18, 29);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(230, 13);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Which VMware service provider are you using?";
            // 
            // cmbServiceProvider
            // 
            this.cmbServiceProvider.DisplayMember = "Server";
            this.cmbServiceProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceProvider.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbServiceProvider.FormattingEnabled = true;
            this.cmbServiceProvider.Items.AddRange(new object[] {
            "Server",
            "Workstation"});
            this.cmbServiceProvider.Location = new System.Drawing.Point(297, 26);
            this.cmbServiceProvider.Name = "cmbServiceProvider";
            this.cmbServiceProvider.Size = new System.Drawing.Size(121, 21);
            this.cmbServiceProvider.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNote);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtBoxISOpath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disk Image";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(214, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to the Emulation Assistant.";
            // 
            // txtStatusStrip
            // 
            this.txtStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatusBar});
            this.txtStatusStrip.Location = new System.Drawing.Point(0, 431);
            this.txtStatusStrip.Name = "txtStatusStrip";
            this.txtStatusStrip.Size = new System.Drawing.Size(472, 22);
            this.txtStatusStrip.TabIndex = 6;
            this.txtStatusStrip.Text = "statusStrip1";
            this.txtStatusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.txtStatusStrip_ItemClicked);
            // 
            // txtStatusBar
            // 
            this.txtStatusBar.Name = "txtStatusBar";
            this.txtStatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(15, 397);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(298, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Location = new System.Drawing.Point(96, 397);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "View &Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Visible = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // PathsForm
            // 
            this.AcceptButton = this.btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 453);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtStatusStrip);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnContinue);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 491);
            this.MinimumSize = new System.Drawing.Size(488, 491);
            this.Name = "PathsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emulation Assistant";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PathsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.txtStatusStrip.ResumeLayout(false);
            this.txtStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.OpenFileDialog openAfsFD;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBoxISOpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.TextBox txtBxConfig;
        private System.Windows.Forms.OpenFileDialog openConfigFD;
        private System.Windows.Forms.Button btnConfigBrowse;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbServiceProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.StatusStrip txtStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel txtStatusBar;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHelp;

    }
}