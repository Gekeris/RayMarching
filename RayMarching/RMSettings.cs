using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RayMarching
{
	static class RMSettings
	{
		public static bool SettingsEdit;

		public static void DefaultSettings(Form1 form)
		{
			form.SaveCheckBox.Checked = false;
			form.CameraPositionXNumericUpDown.Value = 0;
			form.CameraPositionZNumericUpDown.Value = 0;
		}

		public static void FromFile(Form1 form)
		{
			if (!File.Exists("settings.txt"))
			{
				DefaultSettings(form);
				ToFile(form);
			}
			using (StreamReader sr = new StreamReader("settings.txt", Encoding.UTF8))
			{
				Dictionary<string, string> Settings = new Dictionary<string, string>();
				string[] tempSettings = sr.ReadToEnd().Split(new char[] { '\r', '\n', '=' }, System.StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < tempSettings.Length; i += 2)
					Settings.Add(tempSettings[i], tempSettings[i + 1]);

				form.SaveCheckBox.Checked = bool.Parse(Settings["SaveCheckBox"]);
				form.CameraPositionXNumericUpDown.Value = decimal.Parse(Settings["CameraPositionXNumericUpDown"]);
				form.CameraPositionZNumericUpDown.Value = decimal.Parse(Settings["CameraPositionZNumericUpDown"]);
			}
		}

		public static void ToFile(Form1 form)
		{
			using (StreamWriter sw = new StreamWriter("settings.txt", false, Encoding.UTF8))
			{
				sw.WriteLine("SaveCheckBox=" + form.SaveCheckBox.Checked);
				sw.WriteLine("CameraPositionXNumericUpDown=" + form.CameraPositionXNumericUpDown.Value);
				sw.WriteLine("CameraPositionZNumericUpDown=" + form.CameraPositionZNumericUpDown.Value);
			}
		}
	}
}
