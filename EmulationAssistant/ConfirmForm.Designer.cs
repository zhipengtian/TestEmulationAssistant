namespace AFSBrowser {
    partial class ConfirmForm {
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxISOpath = new System.Windows.Forms.TextBox();
            this.lblProvider = new System.Windows.Forms.Label();
            this.txtBoxProvider = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Location = new System.Drawing.Point(406, 208);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "You have chosen to mount the file:";
            // 
            // txtBoxISOpath
            // 
            this.txtBoxISOpath.Location = new System.Drawing.Point(198, 64);
            this.txtBoxISOpath.Name = "txtBoxISOpath";
            this.txtBoxISOpath.ReadOnly = true;
            this.txtBoxISOpath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxISOpath.Size = new System.Drawing.Size(249, 20);
            this.txtBoxISOpath.TabIndex = 4;
            this.txtBoxISOpath.Text = "\\\\afs\\iu.edu\\public\\sudoc\\volumes\\04\\30000038669341\\30000038669341.iso";
            this.txtBoxISOpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(20, 29);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(133, 13);
            this.lblProvider.TabIndex = 5;
            this.lblProvider.Text = "VMware Service Provider: ";
            // 
            // txtBoxProvider
            // 
            this.txtBoxProvider.Location = new System.Drawing.Point(157, 26);
            this.txtBoxProvider.Name = "txtBoxProvider";
            this.txtBoxProvider.ReadOnly = true;
            this.txtBoxProvider.Size = new System.Drawing.Size(290, 20);
            this.txtBoxProvider.TabIndex = 6;
            this.txtBoxProvider.Text = "Workstation";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 62);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verification";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProvider);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBoxISOpath);
            this.groupBox2.Controls.Add(this.txtBoxProvider);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 102);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter user password to confirm above selection";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(272, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(187, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // ConfirmForm
            // 
            this.AcceptButton = this.btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(495, 243);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnContinue);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 281);
            this.MinimumSize = new System.Drawing.Size(511, 281);
            this.Name = "ConfirmForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmation";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxISOpath;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.TextBox txtBoxProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
    }
}