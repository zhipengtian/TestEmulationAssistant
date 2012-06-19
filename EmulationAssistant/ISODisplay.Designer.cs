﻿namespace EmulationAssistant
{
	partial class ISODisplay
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
			this.CDDisplay = new System.Windows.Forms.DataGridView();
			this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.XmlUrlBox = new System.Windows.Forms.TextBox();
			this.downloadXmlButton = new System.Windows.Forms.Button();
			this.eventLog1 = new System.Diagnostics.EventLog();
			this.IsoLocationBox = new System.Windows.Forms.TextBox();
			this.ScriptLocationBox = new System.Windows.Forms.TextBox();
			this.CatalogLocation = new System.Windows.Forms.Label();
			this.IsoLocation = new System.Windows.Forms.Label();
			this.ScriptLocation = new System.Windows.Forms.Label();
			this.launchVM = new System.Windows.Forms.Button();
			this.VMLocation = new System.Windows.Forms.Label();
			this.VMLocationBox = new System.Windows.Forms.TextBox();
			this.vmloc = new System.Windows.Forms.OpenFileDialog();
			this.VMServerBox = new System.Windows.Forms.TextBox();
			this.VMServer = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.CDDisplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
			this.SuspendLayout();
			// 
			// CDDisplay
			// 
			this.CDDisplay.AllowUserToAddRows = false;
			this.CDDisplay.AllowUserToDeleteRows = false;
			this.CDDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CDDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CDDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.CDDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CDDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Desc,
            this.Publisher,
            this.Year});
			this.CDDisplay.Location = new System.Drawing.Point(12, 12);
			this.CDDisplay.MultiSelect = false;
			this.CDDisplay.Name = "CDDisplay";
			this.CDDisplay.ReadOnly = true;
			this.CDDisplay.RowHeadersVisible = false;
			this.CDDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CDDisplay.Size = new System.Drawing.Size(872, 601);
			this.CDDisplay.TabIndex = 0;
			// 
			// ISBN
			// 
			this.ISBN.HeaderText = "ISBN";
			this.ISBN.Name = "ISBN";
			this.ISBN.ReadOnly = true;
			// 
			// Title
			// 
			this.Title.HeaderText = "Title";
			this.Title.Name = "Title";
			this.Title.ReadOnly = true;
			// 
			// Desc
			// 
			this.Desc.HeaderText = "Description";
			this.Desc.Name = "Desc";
			this.Desc.ReadOnly = true;
			// 
			// Publisher
			// 
			this.Publisher.HeaderText = "Publisher";
			this.Publisher.Name = "Publisher";
			this.Publisher.ReadOnly = true;
			// 
			// Year
			// 
			this.Year.HeaderText = "Year";
			this.Year.Name = "Year";
			this.Year.ReadOnly = true;
			// 
			// XmlUrlBox
			// 
			this.XmlUrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.XmlUrlBox.Location = new System.Drawing.Point(893, 41);
			this.XmlUrlBox.Name = "XmlUrlBox";
			this.XmlUrlBox.Size = new System.Drawing.Size(197, 20);
			this.XmlUrlBox.TabIndex = 1;
			// 
			// downloadXmlButton
			// 
			this.downloadXmlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.downloadXmlButton.Location = new System.Drawing.Point(890, 67);
			this.downloadXmlButton.Name = "downloadXmlButton";
			this.downloadXmlButton.Size = new System.Drawing.Size(118, 23);
			this.downloadXmlButton.TabIndex = 2;
			this.downloadXmlButton.Text = "Download Catalog";
			this.downloadXmlButton.UseVisualStyleBackColor = true;
			this.downloadXmlButton.Click += new System.EventHandler(this.downloadXmlButton_Click);
			// 
			// eventLog1
			// 
			this.eventLog1.SynchronizingObject = this;
			// 
			// IsoLocationBox
			// 
			this.IsoLocationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.IsoLocationBox.Location = new System.Drawing.Point(890, 118);
			this.IsoLocationBox.Name = "IsoLocationBox";
			this.IsoLocationBox.Size = new System.Drawing.Size(197, 20);
			this.IsoLocationBox.TabIndex = 3;
			// 
			// ScriptLocationBox
			// 
			this.ScriptLocationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ScriptLocationBox.Location = new System.Drawing.Point(890, 166);
			this.ScriptLocationBox.Name = "ScriptLocationBox";
			this.ScriptLocationBox.Size = new System.Drawing.Size(197, 20);
			this.ScriptLocationBox.TabIndex = 4;
			// 
			// CatalogLocation
			// 
			this.CatalogLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CatalogLocation.AutoSize = true;
			this.CatalogLocation.Location = new System.Drawing.Point(887, 25);
			this.CatalogLocation.Name = "CatalogLocation";
			this.CatalogLocation.Size = new System.Drawing.Size(87, 13);
			this.CatalogLocation.TabIndex = 5;
			this.CatalogLocation.Text = "Catalog Location";
			// 
			// IsoLocation
			// 
			this.IsoLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.IsoLocation.AutoSize = true;
			this.IsoLocation.Location = new System.Drawing.Point(887, 102);
			this.IsoLocation.Name = "IsoLocation";
			this.IsoLocation.Size = new System.Drawing.Size(69, 13);
			this.IsoLocation.TabIndex = 6;
			this.IsoLocation.Text = "ISO Location";
			// 
			// ScriptLocation
			// 
			this.ScriptLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ScriptLocation.AutoSize = true;
			this.ScriptLocation.Location = new System.Drawing.Point(887, 150);
			this.ScriptLocation.Name = "ScriptLocation";
			this.ScriptLocation.Size = new System.Drawing.Size(109, 13);
			this.ScriptLocation.TabIndex = 7;
			this.ScriptLocation.Text = "AutoIt Script Location";
			// 
			// launchVM
			// 
			this.launchVM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.launchVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.launchVM.Location = new System.Drawing.Point(937, 314);
			this.launchVM.Name = "launchVM";
			this.launchVM.Size = new System.Drawing.Size(94, 72);
			this.launchVM.TabIndex = 8;
			this.launchVM.Text = "Launch";
			this.launchVM.UseVisualStyleBackColor = true;
			this.launchVM.Click += new System.EventHandler(this.launchVM_Click);
			// 
			// VMLocation
			// 
			this.VMLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.VMLocation.AutoSize = true;
			this.VMLocation.Location = new System.Drawing.Point(890, 245);
			this.VMLocation.Name = "VMLocation";
			this.VMLocation.Size = new System.Drawing.Size(124, 13);
			this.VMLocation.TabIndex = 9;
			this.VMLocation.Text = "Virtual Machine Location";
			// 
			// VMLocationBox
			// 
			this.VMLocationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.VMLocationBox.Location = new System.Drawing.Point(890, 262);
			this.VMLocationBox.Name = "VMLocationBox";
			this.VMLocationBox.Size = new System.Drawing.Size(197, 20);
			this.VMLocationBox.TabIndex = 10;
			this.VMLocationBox.Click += new System.EventHandler(this.VMLocationBox_Click);
			// 
			// vmloc
			// 
			this.vmloc.Filter = "Virtual Machine Configuration File (*.vmx) | *.vmx";
			// 
			// VMServerBox
			// 
			this.VMServerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.VMServerBox.Location = new System.Drawing.Point(887, 215);
			this.VMServerBox.Name = "VMServerBox";
			this.VMServerBox.Size = new System.Drawing.Size(197, 20);
			this.VMServerBox.TabIndex = 12;
			// 
			// VMServer
			// 
			this.VMServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.VMServer.AutoSize = true;
			this.VMServer.Location = new System.Drawing.Point(887, 198);
			this.VMServer.Name = "VMServer";
			this.VMServer.Size = new System.Drawing.Size(147, 13);
			this.VMServer.TabIndex = 11;
			this.VMServer.Text = "VM Server (blank if unknown)";
			// 
			// ISODisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1099, 625);
			this.Controls.Add(this.VMServerBox);
			this.Controls.Add(this.VMServer);
			this.Controls.Add(this.VMLocationBox);
			this.Controls.Add(this.VMLocation);
			this.Controls.Add(this.launchVM);
			this.Controls.Add(this.ScriptLocation);
			this.Controls.Add(this.IsoLocation);
			this.Controls.Add(this.CatalogLocation);
			this.Controls.Add(this.ScriptLocationBox);
			this.Controls.Add(this.IsoLocationBox);
			this.Controls.Add(this.downloadXmlButton);
			this.Controls.Add(this.XmlUrlBox);
			this.Controls.Add(this.CDDisplay);
			this.Name = "ISODisplay";
			this.Text = "Emulation Assistant";
			((System.ComponentModel.ISupportInitialize)(this.CDDisplay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView CDDisplay;
		private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
		private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
		private System.Windows.Forms.DataGridViewTextBoxColumn Year;
		private System.Windows.Forms.TextBox XmlUrlBox;
		private System.Windows.Forms.Button downloadXmlButton;
		private System.Diagnostics.EventLog eventLog1;
		private System.Windows.Forms.Button launchVM;
		private System.Windows.Forms.Label ScriptLocation;
		private System.Windows.Forms.Label IsoLocation;
		private System.Windows.Forms.Label CatalogLocation;
		private System.Windows.Forms.TextBox ScriptLocationBox;
		private System.Windows.Forms.TextBox IsoLocationBox;
		private System.Windows.Forms.TextBox VMLocationBox;
		private System.Windows.Forms.Label VMLocation;
		private System.Windows.Forms.OpenFileDialog vmloc;
		private System.Windows.Forms.TextBox VMServerBox;
		private System.Windows.Forms.Label VMServer;
	}
}