using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmulationAssistant
{
	public partial class ISODisplay : Form
	{
		public ISODisplay()
		{
			InitializeComponent();
		}

		private void downloadXmlButton_Click(object sender, EventArgs e)
		{

			while (CDDisplay.Rows.Count > 0)
			{
				CDDisplay.Rows.RemoveAt(0);
			}
			List<CDInfo> cds = CDInfo.GetCDInfo(XmlUrlBox.Text);

			foreach (CDInfo cd in cds)
			{
				CDDisplay.Rows.Add(new DataGridCDRow(cd));
			}
		}

		private void launchVM_Click(object sender, EventArgs e)
		{
			VixWrapper vmware = new VixWrapper();
			if (!vmware.Connect(null, null, null))
			{
				return;
			}
			
			if (!vmware.Open(IsoLocationBox.Text))
			{
				return;
			}
			//vmware.RevertToLastSnapshot();
			if (!vmware.PowerOn())
			{
			}
		}

		private void VMLocationBox_Click(object sender, EventArgs e)
		{
			if (vmloc.ShowDialog() == DialogResult.OK)
			{
				VMLocationBox.Text = vmloc.FileName;
			}
		}
	}

	public class DataGridCDRow : DataGridViewRow
	{
		private CDInfo cd;

		public DataGridCDRow() : base() {}

		public DataGridCDRow(CDInfo cd) : base()
		{
			this.Cells.Add(new DataGridCDCell(cd.Isbn));
			this.Cells.Add(new DataGridCDCell(cd.Name));
			this.Cells.Add(new DataGridCDCell(cd.Description));
			this.Cells.Add(new DataGridCDCell(cd.Author));
			this.Cells.Add(new DataGridCDCell(cd.Year));
			this.cd = cd;
		}
	}

	public class DataGridCDCell : DataGridViewTextBoxCell
	{
		public DataGridCDCell() : base() { }
		public DataGridCDCell(String Value) : this()
		{
			this.Value = Value;
		}
	}
}
