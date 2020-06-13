using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayMarching
{
	public partial class CameraSettingsForm : Form
	{
		public CameraSettingsForm()
		{
			InitializeComponent();
		}

		private void CameraSettingsForm_Load(object sender, EventArgs e)
		{
			PositionXNumericUpDown.Value = Convert.ToDecimal(Camera.Position.x);
			PositionYNumericUpDown.Value = Convert.ToDecimal(Camera.Position.y);
			PositionZNumericUpDown.Value = Convert.ToDecimal(Camera.Position.z);

			LookAtXNumericUpDown.Value = Convert.ToDecimal(Camera.LookAt.x);
			LookAtYNumericUpDown.Value = Convert.ToDecimal(Camera.LookAt.y);
			LookAtZNumericUpDown.Value = Convert.ToDecimal(Camera.LookAt.z);
		}

		private void ApplyButton_Click(object sender, EventArgs e)
		{
			Camera.Position.x = Convert.ToDouble(PositionXNumericUpDown.Value);
			Camera.Position.y = Convert.ToDouble(PositionYNumericUpDown.Value);
			Camera.Position.z = Convert.ToDouble(PositionZNumericUpDown.Value);

			Camera.LookAt.x = Convert.ToDouble(LookAtXNumericUpDown.Value);
			Camera.LookAt.y = Convert.ToDouble(LookAtYNumericUpDown.Value);
			Camera.LookAt.z = Convert.ToDouble(LookAtZNumericUpDown.Value);
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
