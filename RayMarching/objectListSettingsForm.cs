using System;
using System.Drawing;
using System.Windows.Forms;

namespace RayMarching
{
	public partial class objectListSettingsForm : Form
	{
		public int index = -1;
		public objectListSettingsForm()
		{
			InitializeComponent();
		}

		private void objectListSettingsForm_Load(object sender, EventArgs e)
		{
			PositionXNumericUpDown.Value = Convert.ToDecimal(Form1.objectList[index].Position.x);
			PositionYNumericUpDown.Value = Convert.ToDecimal(Form1.objectList[index].Position.y);
			PositionZNumericUpDown.Value = Convert.ToDecimal(Form1.objectList[index].Position.z);

			ColorRedNumericUpDown.Value = Convert.ToDecimal(Form1.objectList[index].color.R);
			ColorGreenNumericUpDown.Value = Convert.ToDecimal(Form1.objectList[index].color.G);
			ColorBlueNumericUpDown.Value = Convert.ToDecimal(Form1.objectList[index].color.B);

			if (Form1.objectList[index].GetType().Name == "Sphere")
			{
				label7.Text = "Radius: ";
				numericUpDown1.Value = Convert.ToDecimal(((Sphere) Form1.objectList[index]).radius);
			}
			else
				throw new ArgumentNullException("Error objectListSettingsForm.objectListSettingsForm_Load()");
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			Form1.objectList[index].Position.x = Convert.ToDouble(PositionXNumericUpDown.Value);
			Form1.objectList[index].Position.y = Convert.ToDouble(PositionYNumericUpDown.Value);
			Form1.objectList[index].Position.z = Convert.ToDouble(PositionZNumericUpDown.Value);

			Form1.objectList[index].color = Color.FromArgb(Convert.ToInt32(ColorRedNumericUpDown.Value), Convert.ToInt32(ColorGreenNumericUpDown.Value), Convert.ToInt32(ColorBlueNumericUpDown.Value));

			if (Form1.objectList[index].GetType().Name == "Sphere")
				((Sphere) Form1.objectList[index]).radius = Convert.ToDouble(numericUpDown1.Value);
			else
				throw new ArgumentNullException("Error objectListSettingsForm.SaveButton_Click()");
			Close();
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			Form1.objectList.RemoveAt(index);
			Close();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SettingsEdit(object sender, EventArgs e)
		{
			RMSettings.SettingsEdit = true;
		}
	}
}
