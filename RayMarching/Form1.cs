using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace RayMarching
{
	public partial class Form1 : Form
	{
		List<Coordinate> objectList = new List<Coordinate>();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			objectList.Add(new Coordinate(5, 1, 5));
			if (!Directory.Exists(".\\Pictures"))
				Directory.CreateDirectory(".\\Pictures");
			RMSettings.FromFile(this);
			Camera.Initialize(this);
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
			RMSettings.SettingsEdit = true;
			RMSettings.DefaultSettings(this);
		}

		private void UpdateCamera(object sender, EventArgs e)
		{
			Camera.Initialize(this);
			Camera1.Image = CreateBitmap();
		}

		private Bitmap CreateBitmap()
		{
			Bitmap bitmap = new Bitmap(Camera.Width, Camera.Height);

			for (int y = 0; y < Camera.Height; y++)
				for (int x = 0; x < Camera.Width; x++)
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
			double dx = -1 * ((2 * (double) x / Camera.Width) - 1);
			double dz = -1 * ((2 * (double) y / Camera.Height) - 1);
			dx *= Camera.MaxSide;

			Vector rayVector = new Vector(0, 0, 0);
			rayVector.x = (Camera.Basis[0].x * 1) + (Camera.Basis[0].y * dx) + (Camera.Basis[0].z * dz);
			rayVector.y = (Camera.Basis[1].x * 1) + (Camera.Basis[1].y * dx) + (Camera.Basis[1].z * dz);
			rayVector.z = (Camera.Basis[2].x * 1) + (Camera.Basis[2].y * dx) + (Camera.Basis[2].z * dz);
			rayVector = Vector.Normalize(rayVector);

			Coordinate rayCoord = new Coordinate(Camera.Position.x, Camera.Position.y, Camera.Position.z);
			decimal i = 1;
			while (true)
			{
				object obj = GetMinDist(rayCoord);
				if (obj.GetType().Name == "Color")
					return (Color) obj;
				else
					rayCoord += rayVector * (double) obj;
				if (i >= MaxIterationNumericUpDown.Value)
					return Color.FromArgb(20, 20, 20);
				i++;
			}
		}

		private object GetMinDist(Coordinate coord)
		{
			bool bocool = false;
			double minDist = coord.y;
			foreach (Coordinate coordinate in objectList)
			{
				double temp = Vector.length(Vector.GetVect(coordinate, coord));
				if (temp - 1 < minDist)
				{
					minDist = temp - 1;
					bocool = true;
				}
			}

			if ((minDist <= Convert.ToDouble(MinDistNumericUpDown.Value)) && (bocool))
				return Color.FromArgb(0, 111, 0);

			if (coord.y < Convert.ToDouble(MinDistNumericUpDown.Value))
			{
				double tempX = coord.x % 1;
				double tempZ = coord.z % 1;

				if (((tempX >= -0.1) && (tempX <= 0.1)) || ((tempZ >= -0.1) && (tempZ <= 0.1)))
					return Color.FromArgb(140, 140, 140);
				return Color.FromArgb(200, 200, 200);
			}

			return minDist;
		}

		private void SettingsEdit(object sender, EventArgs e)
		{
			RMSettings.SettingsEdit = true;
		}
	}
}
