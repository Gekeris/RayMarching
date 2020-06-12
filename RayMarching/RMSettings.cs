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
			form.SaveCheckBox.Checked = false;

			form.CameraPositionXNumericUpDown.Value = 0;
			form.CameraPositionYNumericUpDown.Value = 5;
			form.CameraPositionZNumericUpDown.Value = 0;

			form.CameraLookAtXNumericUpDown.Value = 5;
			form.CameraLookAtYNumericUpDown.Value = 0;
			form.CameraLookAtZNumericUpDown.Value = 5;

			form.MaxIterationNumericUpDown.Value = 40;
			form.MinDistNumericUpDown.Value = 0.0001m;
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
			form.SaveCheckBox.Checked = bool.Parse(Settings["SaveCheckBox"]);

			form.CameraPositionXNumericUpDown.Value = decimal.Parse(Settings["CameraPositionXNumericUpDown"]);
			form.CameraPositionYNumericUpDown.Value = decimal.Parse(Settings["CameraPositionYNumericUpDown"]);
			form.CameraPositionZNumericUpDown.Value = decimal.Parse(Settings["CameraPositionZNumericUpDown"]);

			form.CameraLookAtXNumericUpDown.Value = decimal.Parse(Settings["CameraLookAtXNumericUpDown"]);
			form.CameraLookAtYNumericUpDown.Value = decimal.Parse(Settings["CameraLookAtYNumericUpDown"]);
			form.CameraLookAtZNumericUpDown.Value = decimal.Parse(Settings["CameraLookAtZNumericUpDown"]);

			form.MaxIterationNumericUpDown.Value = decimal.Parse(Settings["MaxIterationNumericUpDown"]);
			form.MinDistNumericUpDown.Value = decimal.Parse(Settings["MinDistNumericUpDown"]);
		}

		public static void ToFile(Form1 form) // Записать настройки в файл
		{
			using (StreamWriter sw = new StreamWriter("settings.txt", false, Encoding.UTF8))
			{
				sw.WriteLine("SaveCheckBox=" + form.SaveCheckBox.Checked);

				sw.WriteLine("CameraPositionXNumericUpDown=" + form.CameraPositionXNumericUpDown.Value);
				sw.WriteLine("CameraPositionYNumericUpDown=" + form.CameraPositionYNumericUpDown.Value);
				sw.WriteLine("CameraPositionZNumericUpDown=" + form.CameraPositionZNumericUpDown.Value);

				sw.WriteLine("CameraLookAtXNumericUpDown=" + form.CameraLookAtXNumericUpDown.Value);
				sw.WriteLine("CameraLookAtYNumericUpDown=" + form.CameraLookAtYNumericUpDown.Value);
				sw.WriteLine("CameraLookAtZNumericUpDown=" + form.CameraLookAtZNumericUpDown.Value);

				sw.WriteLine("MaxIterationNumericUpDown=" + form.MaxIterationNumericUpDown.Value);
				sw.WriteLine("MinDistNumericUpDown=" + form.MinDistNumericUpDown.Value);
			}
		}
	}
}
