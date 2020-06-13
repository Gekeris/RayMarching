using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RayMarching
{
	static class RMSettings
	{
		public static bool SettingsEdit; // Изменялись ли настройки

		public static void DefaultSettings(Form1 form) // Стандартные настройки
		{
			Camera.Position.x = 0;
			Camera.Position.y = 5;
			Camera.Position.z = 0;

			Camera.LookAt.x = 5;
			Camera.LookAt.y = 0;
			Camera.LookAt.z = 5;

			form.MaxIterationNumericUpDown.Value = 40;
			form.MinDistNumericUpDown.Value = 0.0001m;

			form.OrRadioButton.Checked = true;
			form.AndRadioButton.Checked = false;
		}

		public static void FromFile(Form1 form) // Загрузка настроек с файла
		{
			if (!File.Exists("settings.txt"))
			{
				DefaultSettings(form);
				ToFile(form);
			}
			Dictionary<string, string> Settings = new Dictionary<string, string>(); // Словарь с настройками
			using (StreamReader sr = new StreamReader("settings.txt", Encoding.UTF8))
			{
				string[] tempSettings = sr.ReadToEnd().Split(new char[] { '\r', '\n', '=' }, System.StringSplitOptions.RemoveEmptyEntries);  // Поделить файл по строкам и =
				for (int i = 0; i < tempSettings.Length; i += 2) // Заполнение словаря. Первая строка название переменной (ключ), вторая значение в string
					Settings.Add(tempSettings[i], tempSettings[i + 1]);
			}
			Camera.Position.x = double.Parse(Settings["CameraPositionX"]);
			Camera.Position.y = double.Parse(Settings["CameraPositionY"]);
			Camera.Position.z = double.Parse(Settings["CameraPositionZ"]);

			Camera.LookAt.x = double.Parse(Settings["CameraLookAtX"]);
			Camera.LookAt.y = double.Parse(Settings["CameraLookAtY"]);
			Camera.LookAt.z = double.Parse(Settings["CameraLookAtZ"]);

			form.MaxIterationNumericUpDown.Value = decimal.Parse(Settings["MaxIterationNumericUpDown"]);
			form.MinDistNumericUpDown.Value = decimal.Parse(Settings["MinDistNumericUpDown"]);

			form.OrRadioButton.Checked = bool.Parse(Settings["OrRadioButton"]);
			form.AndRadioButton.Checked = bool.Parse(Settings["AndRadioButton"]);
		}

		public static void ToFile(Form1 form) // Записать настройки в файл
		{
			using (StreamWriter sw = new StreamWriter("settings.txt", false, Encoding.UTF8))
			{
				sw.WriteLine("CameraPositionX=" + Camera.Position.x);
				sw.WriteLine("CameraPositionY=" + Camera.Position.y);
				sw.WriteLine("CameraPositionZ=" + Camera.Position.z);

				sw.WriteLine("CameraLookAtX=" + Camera.LookAt.x);
				sw.WriteLine("CameraLookAtY=" + Camera.LookAt.y);
				sw.WriteLine("CameraLookAtZ=" + Camera.LookAt.z);

				sw.WriteLine("MaxIterationNumericUpDown=" + form.MaxIterationNumericUpDown.Value);
				sw.WriteLine("MinDistNumericUpDown=" + form.MinDistNumericUpDown.Value);

				sw.WriteLine("OrRadioButton=" + form.OrRadioButton.Checked);
				sw.WriteLine("AndRadioButton=" + form.AndRadioButton.Checked);
			}
		}
	}
}
