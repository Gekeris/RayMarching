using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace RayMarching
{
	public partial class Form1 : Form
	{
		public static List<RMObject> objectList;
		public RMObject objectListAdd
		{
			set
			{
				RMObjectListBox.Items.Add(value.ToListBox(objectList.Count)); // Добавление оъекта в лист бокс
				objectList.Add(value); // Добавить объект в лист проверки
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			progressBar1.Maximum = Camera.Height; // Установить 100% на кол. строк
			AddObjectComboBox.SelectedIndex = 0; // Выбор первого елемента в списке добавления объектов
			PresetComboBox.SelectedIndex = 0; // Выбор первого елемента в списке пресетов
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
			progressBar1.Value = 0; // Обнулить прогресс
			progressBar1.Visible = true; // Сделать прогресс отрисовки изображения видимым
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
				progressBar1.Value++; // Увеличение прогресса
			}
			progressBar1.Visible = false; // Отключить отображение прогресса отрисовки
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
					return ChangeColor((Color) obj, Convert.ToDouble(i / MaxIterationNumericUpDown.Value), rayCoord); // Изменить цвет пикселя(AO, освещение, тень)
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
			if (objectList.Count > 0) // Если в листе объектов нету экземпляров не ищем путь к ним
			{
				obj = objectList[0]; // Стартовый объект
				objectList[0].GetDist(coord); // Получить расстояние от текущей точки до него
				foreach (RMObject tempObj in objectList) // Обход всех объектов
				{
					// Объединение или пересечение объетов
					if ((OrRadioButton.Checked && (tempObj.GetDist(coord) < obj.distance)) || (AndRadioButton.Checked && (tempObj.GetDist(coord) > obj.distance)))
						obj = tempObj;
				}
				// Сравнение расстояние до пола с расстояним до ближайшего объекта
				if (floor.GetDist(coord) < obj.distance)
					obj = floor;
			}
			else
			{
				floor.GetDist(coord);
				obj = floor;
			}
			// Если расстояние до объекта меньше минимально-установленного и надо вернуть цвет, возвращаем цвет
			if ((obj.distance <= Convert.ToDouble(MinDistNumericUpDown.Value)) && ReturnColor)
				return obj.color;

			return obj.distance;
		}

		private Color ChangeColor(Color color, double per, Coordinate coord) // Ambient Occlusion, освещение, тень
		{
			if (AmbientOcclusionCheckBox.Checked)
			{
				// Изменение цвета в зависимости от того сколько процентов шагов от максимума прошел луч
				color = Color.FromArgb(Convert.ToInt32((color.R * (1 - per) + 40 * per) / (1 + per)), Convert.ToInt32((color.G * (1 - per) + 40 * per) / (1 + per)), Convert.ToInt32((color.B * (1 - per) + 40 * per) / (1 + per)));
			}
			if (LightingCheckBox.Checked)
			{
				// Узнать нормализированое направление перпендикулярного вектора к нормали
				double dist = (double) GetDist(coord, false);
				double minDist = Convert.ToDouble(MinDistNumericUpDown.Value);
				Vector n = Vector.Normalize(new Vector
				(
					dist - (double) GetDist(new Coordinate(coord.x - minDist, coord.y, coord.z), false),
					dist - (double) GetDist(new Coordinate(coord.x, coord.y - minDist, coord.z), false),
					dist - (double) GetDist(new Coordinate(coord.x, coord.y, coord.z - minDist), false)
				));
				// Нормализирование направление источника света
				Vector li = Vector.Normalize(Vector.GetVect(coord, RMSettings.LightingPosition));
				double scalar = (Vector.Scalar(n, li) + 3) / 4; // На сколько совпадают вектора
				scalar *= scalar;
				color = Color.FromArgb(LightCol(color.R), LightCol(color.G), LightCol(color.B)); // Изменить цвет пикселя
				int LightCol(int ColorNum)
				{
					try
					{
						int ret = Convert.ToInt32(ColorNum * scalar * RMSettings.LightBrightness); // Если цвет больше 255, установка 255
						if (ret > 255)
							ret = 255;
						return ret;
					}
					catch // Если по какой-то причине не получилось узнать вектор нормали, закраска цвета в церный
					{
						return 0;
					}
				}
			}
			if (ShadowsCheckBox.Checked)
			{
				Coordinate c = new Coordinate(coord.x, coord.y, coord.z); // рассположение луча, который коснулся с объектом
				while (true)
				{
					double distToLight = Vector.length(Vector.GetVect(c, RMSettings.LightingPosition)); // Растояние точки с освещением
					double DistToAnyObject = (double) GetDist(c, false); // Расстояние до любого объекта

					// Если расстояние до объекта меньше минимального шага, установка расстояния равного минимальному шагу
					if ((DistToAnyObject >= -9E-15) && (DistToAnyObject < RMSettings.ShadowMinStep)) 
						DistToAnyObject = RMSettings.ShadowMinStep;

					//Если до точки освещения меньше чем до любого объекта, установить расстояние до него минимум
					if (distToLight < DistToAnyObject)
						DistToAnyObject = distToLight;

					if (DistToAnyObject < -9E-15)
					{
						// Если лучь зашёл в объект, рисуем тень
						color = Color.FromArgb(Convert.ToInt32(color.R / (1 + 1 / RMSettings.LightBrightness)), Convert.ToInt32(color.G / (1 + 1 / RMSettings.LightBrightness)), Convert.ToInt32(color.B / (1 + 1 / RMSettings.LightBrightness)));
						break;
					}
					else if (distToLight < 1) // Если лучь дошёл до света, тени нету
						break;
					else
					{
						// Перемещение луча тени на расстояние до ближайшего объекта
						Vector v = Vector.Normalize(Vector.GetVect(c, RMSettings.LightingPosition));
						c += v * DistToAnyObject;
					}
				}
			}
			return color;
		}

		private void SettingsEdit(object sender, EventArgs e) // Предложить пользователю сохранить настройки в случае их изменения
		{
			RMSettings.SettingsEdit = true;
			LightingButton.Enabled = (LightingCheckBox.Checked || ShadowsCheckBox.Checked); // Активация/деактивация кнопки настройки позиции света
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

		private void SaveScreenPicture_Click(object sender, EventArgs e) // Если пользователь захотел сохранить изображение из камеры
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

		private void CameraSettingsButton_Click(object sender, EventArgs e) // Открытие формы настройки камеры
		{
			using (CameraSettingsForm myform = new CameraSettingsForm())
			{
				myform.ShowDialog();
			}
		}

		private void RMObjectListBox_MouseDoubleClick(object sender, MouseEventArgs e) // Если пользователь дважды кликнул на листбокс
		{
			int index = RMObjectListBox.IndexFromPoint(e.Location); // Узнать индекс объекта который находить на позиции курсора
			if (index != -1) // Если там был объект, открыть форму
			{
				using (objectListSettingsForm myform = new objectListSettingsForm())
				{
					myform.index = index; // Передача индекса форме
					myform.ShowDialog();
					RMObjectListBox.Items.Clear(); // Обновить листбокс 
					for (int i = 0; i < objectList.Count; i++)
						RMObjectListBox.Items.Add(objectList[i].ToListBox(i));
				}
			}
		}

		private void AddObjectButton_Click(object sender, EventArgs e) // Добавление объекта пользователем
		{
			RMSettings.SettingsEdit = true;
			// Проверка объекта который пользователь добавляет и добавление его в список
			if (AddObjectComboBox.SelectedItem.ToString() == "Sphere")
				objectListAdd = new Sphere(0, 0, 0, 0, 0, 0, 1);
			else if (AddObjectComboBox.SelectedItem.ToString() == "Cube")
				objectListAdd = new Cube(0, 0, 0, 0, 0, 0, 1);
			else
				throw new ArgumentNullException("Error Form1.AddObjectButton_Click()");

			using (objectListSettingsForm myform = new objectListSettingsForm())
			{
				// Поскольку объект был добавлен в конец, редактируем последний элемент
				myform.index = objectList.Count - 1;
				myform.ShowDialog();
				RMObjectListBox.Items.Clear();
				for (int i = 0; i < objectList.Count; i++)
					RMObjectListBox.Items.Add(objectList[i].ToListBox(i));
			}
		}

		private void LightingButton_Click(object sender, EventArgs e) // Открытие формы настроек позиции света
		{
			using (LightingSettingsForm myform = new LightingSettingsForm())
			{
				myform.Shadow = ShadowsCheckBox.Checked;
				myform.ShowDialog();
			}
		}

		private void PresetButton_Click(object sender, EventArgs e) // Загрузка пресета
		{
			RMSettings.SettingsEdit = true;
			RMSettings.Preset(PresetComboBox.SelectedIndex, this);
			UpdateCamera(sender, e);
		}
	}
}
