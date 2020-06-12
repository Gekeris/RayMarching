using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace RayMarching
{
	public partial class Form1 : Form
	{
		List<Coordinate> objectList = new List<Coordinate>(); // Список объектов, до которых считаем расстояние

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			objectList.Add(new Coordinate(2, 1, 2)); // Добавить объект в список
			if (!Directory.Exists(".\\Pictures")) // Если нету директории кудо сохранять, создаём её
				Directory.CreateDirectory(".\\Pictures");
			ResetSettings(sender, e); // Загрузить настройки с файла
			RMSettings.SettingsEdit = false; // Изменялись ли настройки
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
			Camera.Initialize(this); // Создать базис
			Camera1.Image = CreateBitmap(); // Отрисовка изображения камеры
		}

		private Bitmap CreateBitmap() // Отрисовка изображения камеры
		{
			Bitmap bitmap = new Bitmap(Camera.Width, Camera.Height); // Создать битмап камеры

			for (int y = 0; y < Camera.Height; y++) // обход и закраска всех пикселей
				for (int x = 0; x < Camera.Width; x++) 
					bitmap.SetPixel(x, y, RayRM(x, y));

			if (SaveCheckBox.Checked) // Если пользователь решил сохранить результа, создать bmp файл с биткартой
			{
				DateTime thisDay = DateTime.Now;
				string path = ".\\Pictures\\" + thisDay.Year + "_" + ZeroCheck(thisDay.Month) + ZeroCheck(thisDay.Day) + ZeroCheck(thisDay.Hour) + ZeroCheck(thisDay.Minute) + ZeroCheck(thisDay.Second); // Название по дате
				for (int i = 0; true; i++) // Если за 1 сек было создано больше 1го файла, не перезаписывать их
				{
					if (!File.Exists(path + i + ".bmp"))
					{
						path += i + ".bmp";
						break;
					}
				}
				File.WriteAllText(path, ""); // Создать пустой bmp файл
				bitmap.Save(path); // Записать в него bitmap

				string ZeroCheck(int num) // Если число меньше 10, добавление нуля, для красоты
				{
					if (num < 10)
						return "0" + num + "_";
					else
						return num + "_";
				}
			}
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
			rayVector = Vector.Normalize(rayVector); // Нормализация базиса

			Coordinate rayCoord = new Coordinate(Camera.Position.x, Camera.Position.y, Camera.Position.z); // Стартовая позиция луча
			decimal i = 1; // Количество итераций
			while (true)
			{
				object obj = GetMinDist(rayCoord); // Узнать расстояние до ближайшего объекта
				if (obj.GetType().Name == "Color") // Если GetMinDist вернула цвет, значит произошло касание с объектом
					return (Color) obj;
				else // Если GetMinDist вернул число, умножаем вектор на него
					rayCoord += rayVector * (double) obj;
				if (i == MaxIterationNumericUpDown.Value) // Если количество итераций равно максимуму
					return Color.FromArgb(20, 20, 20);
				i++;
			}
		}

		private object GetMinDist(Coordinate coord) // Расстояние до ближайшего объекта
		{
			bool bocool = false; // Временная переменая
			double minDist = coord.y; // Минимум, растояние до пола
			foreach (Coordinate coordinate in objectList)
			{
				double temp = Vector.length(Vector.GetVect(coordinate, coord)) - 1;
				if (temp < minDist)
				{
					minDist = temp;
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

		private void ResetSettings(object sender, EventArgs e) // Загрузить настройки с файла
		{
			RMSettings.FromFile(this); // Загрузить настройки с файла
		}

		private void SaveSettings(object sender, EventArgs e)  // Сохранить настройки в файл
		{
			RMSettings.ToFile(this);
			RMSettings.SettingsEdit = false;
		}
	}
}
