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

			Camera.LookAt.x = 3;
			Camera.LookAt.y = 1;
			Camera.LookAt.z = 3;

			form.MaxIterationNumericUpDown.Value = 50;
			form.MinDistNumericUpDown.Value = 0.001m;

			form.AmbientOcclusionCheckBox.Checked = true;
			form.LightingCheckBox.Checked = false;
			form.ShadowsCheckBox.Checked = false;

			form.OrRadioButton.Checked = true;
			form.AndRadioButton.Checked = false;

			Form1.objectList.Clear();
			form.RMObjectListBox.Items.Clear();
			form.objectListAdd = new Sphere(3, 1, 3, 0, 111, 0, 1);
		}

		public static void FromFile(Form1 form) // Загрузка настроек с файла
		{
			try
			{
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

				form.AmbientOcclusionCheckBox.Checked = bool.Parse(Settings["AmbientOcclusionCheckBox"]);
				form.LightingCheckBox.Checked = bool.Parse(Settings["LightingCheckBox"]);
				form.ShadowsCheckBox.Checked = bool.Parse(Settings["ShadowsCheckBox"]);

				Form1.objectList.Clear();
				form.RMObjectListBox.Items.Clear();

				for (int i = 0; true; i++)
				{
					string objString = "object" + i;
					if (!Settings.ContainsKey(objString))
						break;
					string[] obj = Settings[objString].Split('#');
					if (obj[0] == "Sphere")
						form.objectListAdd = new Sphere(double.Parse(obj[1]), double.Parse(obj[2]), double.Parse(obj[3]), int.Parse(obj[4]), int.Parse(obj[5]), int.Parse(obj[6]), double.Parse(obj[7]));
					else
						throw new System.ArgumentNullException("Error RMSettings.FromFile()");
				}
			}
			catch
			{
				DefaultSettings(form);
				ToFile(form);
			}
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

				sw.WriteLine("AmbientOcclusionCheckBox=" + form.AmbientOcclusionCheckBox.Checked);
				sw.WriteLine("LightingCheckBox=" + form.LightingCheckBox.Checked);
				sw.WriteLine("ShadowsCheckBox=" + form.ShadowsCheckBox.Checked);

				for (int i = 0; i < Form1.objectList.Count; i++)
					sw.WriteLine(Form1.objectList[i].ToFile(i));
			}
		}
	}
}
