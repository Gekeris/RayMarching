using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Text;

namespace RayMarching
{
	public partial class Form1 : Form
	{
		const int CameraW = 640;
		const int CameraH = 480;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (!Directory.Exists(".\\Pictures"))
				Directory.CreateDirectory(".\\Pictures");
			Camera.Initialize(Convert.ToDouble(CameraPositionXNumericUpDown.Value), Convert.ToDouble(CameraPositionZNumericUpDown.Value));
			RMSettings.FromFile(this);
			RMSettings.SettingsEdit = false;
			UpdateCamera(sender, e);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (RMSettings.SettingsEdit)
			{
				DialogResult dialogResult = MessageBox.Show("Save settings?", "Save settings?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				switch (dialogResult)
				{
					case DialogResult.Yes:
					RMSettings.ToFile(this);
					break;

					case DialogResult.Cancel:
					e.Cancel = true;
					break;
				}
			}
		}

		private void DefaultSettings(object sender, EventArgs e)
		{
			RMSettings.DefaultSettings(this);
		}

		private void UpdateCamera(object sender, EventArgs e)
		{
			Camera1.Image = CreateBitmap();
		}

		private Bitmap CreateBitmap()
		{
			Bitmap bitmap = new Bitmap(CameraW, CameraH);

			for (int y = 0; y < CameraH; y++)
				for (int x = 0; x < CameraW; x++)
					bitmap.SetPixel(x, y, RayRM(x, y));

			if (SaveCheckBox.Checked)
			{
				DateTime thisDay = DateTime.Now;
				string path = ".\\Pictures\\" + thisDay.Year + "_" + ZeroCheck(thisDay.Month) + ZeroCheck(thisDay.Day) + ZeroCheck(thisDay.Hour) + ZeroCheck(thisDay.Minute) + ZeroCheck(thisDay.Second);
				for (int i = 0; i >= 0; i++)
				{
					if (!File.Exists(path + i + ".bmp"))
					{
						path += i + ".bmp";
						break;
					}
				}
				File.WriteAllText(path, "");
				bitmap.Save(path);

				string ZeroCheck(int num)
				{
					if (num < 10)
						return "0" + num + "_";
					else
						return num + "_";
				}
			}
			return bitmap;
		}

		private Color RayRM(int x, int y)
		{
			return Color.FromArgb(0, 111, 0);
		}

		private void SettingsEdit(object sender, EventArgs e)
		{
			RMSettings.SettingsEdit = true;
		}
	}
}
