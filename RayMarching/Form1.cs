using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace RayMarching
{
	public partial class Form1 : Form
	{
		public static List<RMObject> objectList;
		public RMObject objectListAdd
		{
			set
			{
				RMObjectListBox.Items.Add(value.ToListBox(objectList.Count));
				objectList.Add(value);
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			progressBar1.Maximum = Camera.Height;
			AddObjectComboBox.SelectedIndex = 0;
			objectList = new List<RMObject>();
			ResetSettings(sender, e); // Загрузить настройки с файла
			UpdateCamera(sender, e); // Отрисовка камеры 
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (RMSettings.SettingsEdit) // Если настройки изменялись, вывести уведомления о предложении их сохранить
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

		private void DefaultSettings(object sender, EventArgs e) // Установка стандартных настроек
		{
			RMSettings.SettingsEdit = true;
			RMSettings.DefaultSettings(this);
		}

		private void UpdateCamera(object sender, EventArgs e) // Отрисовка камеры
		{
			progressBar1.Value = 0;
			progressBar1.Visible = true;
			Camera.Initialize(); // Создать базис
			Camera1.Image = CreateBitmap(); // Отрисовка изображения камеры
		}

		private Bitmap CreateBitmap() // Отрисовка изображения камеры
		{
			Bitmap bitmap = new Bitmap(Camera.Width, Camera.Height); // Создать битмап камеры
			for (int y = 0; y < Camera.Height; y++) // обход и закраска всех пикселей
			{
				for (int x = 0; x < Camera.Width; x++)
					bitmap.SetPixel(x, y, RayRM(x, y));
				progressBar1.Value++;
			}
			progressBar1.Visible = false;
			return bitmap; // Возвращение карты
		}

		private Color RayRM(int x, int y) // Отрисовка пикселя и его окраска
		{
			double dx = 1 - (2 * (double) x / Camera.Width); // узнать координату x относительно базиса камеры
			double dz = 1 - (2 * (double) y / Camera.Height); // узнать координату z относительно базиса камеры

			Vector rayVector = new Vector(0, 0, 0); // Переход из базиса камеры в стандартный базис
			rayVector.x = (Camera.Basis[0].x * 1) + (Camera.Basis[0].y * dx) + (Camera.Basis[0].z * dz);
			rayVector.y = (Camera.Basis[1].x * 1) + (Camera.Basis[1].y * dx) + (Camera.Basis[1].z * dz);
			rayVector.z = (Camera.Basis[2].x * 1) + (Camera.Basis[2].y * dx) + (Camera.Basis[2].z * dz);
			rayVector = Vector.Normalize(rayVector);

			Coordinate rayCoord = new Coordinate(Camera.Position.x, Camera.Position.y, Camera.Position.z); // Стартовая позиция луча
			decimal i = 1; // Количество итераций
			while (true)
			{
				object obj = GetDist(rayCoord, true); // Узнать расстояние до ближайшего объекта
				if (obj.GetType().Name == "Color") // Если GetMinDist вернула цвет, значит произошло касание с объектом
					return ChangeColor((Color) obj, Convert.ToDouble(i / MaxIterationNumericUpDown.Value), rayCoord,x,y);
				else // Если GetMinDist вернул число, умножаем вектор на него
					rayCoord += rayVector * (double) obj;
				if (i == MaxIterationNumericUpDown.Value) // Если количество итераций равно максимуму
					return Color.FromArgb(20, 20, 20);
				i++;
			}
		}
		Floor floor = new Floor();
		private object GetDist(Coordinate coord, bool ReturnColor) // Расстояние до ближайшего объекта
		{
			RMObject obj;
			if (objectList.Count > 0)
			{
				obj = objectList[0];
				objectList[0].GetDist(coord);
				foreach (RMObject tempObj in objectList)
				{
					if ((OrRadioButton.Checked && (tempObj.GetDist(coord) < obj.distance)) || (AndRadioButton.Checked && (tempObj.GetDist(coord) > obj.distance)))
						obj = tempObj;
				}

				if (floor.GetDist(coord) < obj.distance)
					obj = floor;
			}
			else
			{
				floor.GetDist(coord);
				obj = floor;
			}

			if ((obj.distance <= Convert.ToDouble(MinDistNumericUpDown.Value)) && ReturnColor)
				return obj.color;

			return obj.distance;
		}

		private Color ChangeColor(Color color, double per, Coordinate coord,int x, int y)
		{
			if (AmbientOcclusionCheckBox.Checked)
			{
				color = Color.FromArgb(Convert.ToInt32((color.R * (1 - per) + 40 * per) / (1 + per)), Convert.ToInt32((color.G * (1 - per) + 40 * per) / (1 + per)), Convert.ToInt32((color.B * (1 - per) + 40 * per) / (1 + per)));
			}
			if (LightingCheckBox.Checked)
			{
				double dist = (double) GetDist(coord, false);
				double minDist = Convert.ToDouble(MinDistNumericUpDown.Value);
				Vector n = Vector.Normalize(new Vector
				(
					dist - (double) GetDist(new Coordinate(coord.x - minDist, coord.y, coord.z), false),
					dist - (double) GetDist(new Coordinate(coord.x, coord.y - minDist, coord.z), false),
					dist - (double) GetDist(new Coordinate(coord.x, coord.y, coord.z - minDist), false)
				));
				Vector li = Vector.Normalize(Vector.GetVect(coord, RMSettings.LightingPosition));
				double scalar = (Vector.Scalar(n, li) + 1) / 2;
				scalar *= scalar;
				color = Color.FromArgb(LightCol(color.R), LightCol(color.G), LightCol(color.B));
				int LightCol(int ColorNum)
				{
					int ret = Convert.ToInt32(ColorNum * scalar * RMSettings.LightBrightness);
					if (ret > 255)
						ret = 255;
					return ret;
				}
			}
			if (ShadowsCheckBox.Checked)
			{
				Coordinate c = new Coordinate(coord.x, coord.y, coord.z);
				while (true)
				{
					double distToCamera = Vector.length(Vector.GetVect(c, RMSettings.LightingPosition));
					double DistToAnyObject = (double) GetDist(c, false);

					if ((DistToAnyObject >= -9E-15) && (DistToAnyObject < RMSettings.ShadowMinStep))
						DistToAnyObject = RMSettings.ShadowMinStep;

					if (distToCamera < DistToAnyObject)
						DistToAnyObject = distToCamera;

					if (DistToAnyObject < -9E-15)
					{
						color = Color.FromArgb(Convert.ToInt32(color.R / (1 + 1 / RMSettings.LightBrightness)), Convert.ToInt32(color.G / (1 + 1 / RMSettings.LightBrightness)), Convert.ToInt32(color.B / (1 + 1 / RMSettings.LightBrightness)));
						break;
					}
					else if (distToCamera < 1)
						break;
					else
					{
						Vector v = Vector.Normalize(Vector.GetVect(c, RMSettings.LightingPosition));
						c +=  v * DistToAnyObject;
					}
				}
			}
			return color;
		}

		private void SettingsEdit(object sender, EventArgs e)
		{
			RMSettings.SettingsEdit = true;
			LightingButton.Enabled = (LightingCheckBox.Checked || ShadowsCheckBox.Checked);
		}

		private void ResetSettings(object sender, EventArgs e) // Загрузить настройки с файла
		{
			RMSettings.FromFile(this); // Загрузить настройки с файла
			RMSettings.SettingsEdit = false; // Изменялись ли настройки
		}

		private void SaveSettings(object sender, EventArgs e)  // Сохранить настройки в файл
		{
			RMSettings.ToFile(this);
			RMSettings.SettingsEdit = false;
		}

		private void SaveScreenPicture_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(".\\Pictures")) // Если нету директории куда сохранять, создаём её
				Directory.CreateDirectory(".\\Pictures");

			DateTime thisDay = DateTime.Now; // Текущее время
			string path = ".\\Pictures\\" + thisDay.Year + "_" + ZeroCheck(thisDay.Month) + ZeroCheck(thisDay.Day) + ZeroCheck(thisDay.Hour) + ZeroCheck(thisDay.Minute) + ZeroCheck(thisDay.Second); // Название по дате
			for (int i = 0; true; i++) // Если за 1 сек было создано больше 1го файла, не перезаписывать их
			{
				if (!File.Exists(path + i + ".bmp"))
				{
					path += i + ".bmp";
					break;
				}
			}
			Camera1.Image.Save(path); // Сохранить изображение камеры в виде bmp файла

			string ZeroCheck(int num) // Если число меньше 10, добавление нуля, для красоты
			{
				if (num < 10)
					return "0" + num + "_";
				else
					return num + "_";
			}
		}

		private void CameraSettingsButton_Click(object sender, EventArgs e)
		{
			using (CameraSettingsForm myform = new CameraSettingsForm())
			{
				myform.ShowDialog();
			}
		}

		private void RMObjectListBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int index = RMObjectListBox.IndexFromPoint(e.Location);
			if (index != -1)
			{
				using (objectListSettingsForm myform = new objectListSettingsForm())
				{
					myform.index = index;
					myform.ShowDialog();
					RMObjectListBox.Items.Clear();
					for(int i = 0; i < objectList.Count; i++)
						RMObjectListBox.Items.Add(objectList[i].ToListBox(i));
				}
			}
		}

		private void AddObjectButton_Click(object sender, EventArgs e)
		{
			RMSettings.SettingsEdit = true;
			if(AddObjectComboBox.SelectedItem.ToString() == "Sphere")
				objectListAdd = new Sphere(0, 0, 0, 0, 0, 0, 1);
			else
				throw new ArgumentNullException("Error Form1.AddObjectButton_Click()");

			using (objectListSettingsForm myform = new objectListSettingsForm())
			{
				myform.index = objectList.Count - 1;
				myform.ShowDialog();
				RMObjectListBox.Items.Clear();
				for (int i = 0; i < objectList.Count; i++)
					RMObjectListBox.Items.Add(objectList[i].ToListBox(i));
			}
		}

		private void LightingButton_Click(object sender, EventArgs e)
		{
			using (LightingSettingsForm myform = new LightingSettingsForm())
			{
				myform.Shadow = ShadowsCheckBox.Checked;
				myform.ShowDialog();
			}
		}
	}
}
