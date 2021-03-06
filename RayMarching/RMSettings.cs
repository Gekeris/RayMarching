﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RayMarching
{
	public static class RMSettings
	{
		public static bool SettingsEdit; // Изменялись ли настройки

		public static Coordinate LightingPosition = new Coordinate(0, 0, 0); // Позиция света
		public static double LightBrightness = 1; // Яркость
		public static double ShadowMinStep = 0.01; // Минимальный шаг луча проверки на тень

		public static void DefaultSettings(Form1 form) // Стандартные настройки
		{
			Camera.Position.x = 0;
			Camera.Position.y = 5;
			Camera.Position.z = 0;

			Camera.LookAt.x = 3;
			Camera.LookAt.y = 1;
			Camera.LookAt.z = 3;

			LightingPosition.x = 0;
			LightingPosition.y = 5;
			LightingPosition.z = 5;
			LightBrightness = 1;

			ShadowMinStep = 0.01;

			form.MaxIterationNumericUpDown.Value = 50;
			form.MinDistNumericUpDown.Value = 0.001m;

			form.OrRadioButton.Checked = true;
			form.AndRadioButton.Checked = false;

			form.AmbientOcclusionCheckBox.Checked = false;
			form.LightingCheckBox.Checked = true;
			form.ShadowsCheckBox.Checked = true;

			Form1.objectList.Clear();
			form.RMObjectListBox.Items.Clear();
			form.objectListAdd = new Sphere(3, 1, 3, 0, 111, 0, 1);
		}

		public static void FromFile(Form1 form) // Загрузка настроек с файла
		{
			try
			{
				Dictionary<string, string> Settings = new Dictionary<string, string>(); // Словарь с настройками
				using (StreamReader sr = new StreamReader("settings.ini", Encoding.UTF8))
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

				LightingPosition.x = double.Parse(Settings["LightingPositionX"]);
				LightingPosition.y = double.Parse(Settings["LightingPositionY"]);
				LightingPosition.z = double.Parse(Settings["LightingPositionZ"]);
				LightBrightness = double.Parse(Settings["LightBrightness"]);

				ShadowMinStep = double.Parse(Settings["ShadowMinStep"]);

				form.MaxIterationNumericUpDown.Value = decimal.Parse(Settings["MaxIterationNumericUpDown"]);
				form.MinDistNumericUpDown.Value = decimal.Parse(Settings["MinDistNumericUpDown"]);

				form.OrRadioButton.Checked = bool.Parse(Settings["OrRadioButton"]);
				form.AndRadioButton.Checked = bool.Parse(Settings["AndRadioButton"]);

				form.AmbientOcclusionCheckBox.Checked = bool.Parse(Settings["AmbientOcclusionCheckBox"]);
				form.LightingCheckBox.Checked = bool.Parse(Settings["LightingCheckBox"]);
				form.ShadowsCheckBox.Checked = bool.Parse(Settings["ShadowsCheckBox"]);

				Form1.objectList.Clear();
				form.RMObjectListBox.Items.Clear();

				for (int i = 0; true; i++) // Загрузка объектов из файла
				{
					string objString = "object" + i; // Ключь поиска в словаре
					if (!Settings.ContainsKey(objString))
						break;
					string[] obj = Settings[objString].Split('#');
					// Добавление объектов в 
					if (obj[0] == "Sphere")
						form.objectListAdd = new Sphere(double.Parse(obj[1]), double.Parse(obj[2]), double.Parse(obj[3]), int.Parse(obj[4]), int.Parse(obj[5]), int.Parse(obj[6]), double.Parse(obj[7]));
					else if (obj[0] == "Cube")
						form.objectListAdd = new Cube(double.Parse(obj[1]), double.Parse(obj[2]), double.Parse(obj[3]), int.Parse(obj[4]), int.Parse(obj[5]), int.Parse(obj[6]), double.Parse(obj[7]));
					else
						throw new ArgumentNullException("Error RMSettings.FromFile()");
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
			using (StreamWriter sw = new StreamWriter("settings.ini", false, Encoding.UTF8))
			{
				sw.WriteLine("CameraPositionX=" + Camera.Position.x);
				sw.WriteLine("CameraPositionY=" + Camera.Position.y);
				sw.WriteLine("CameraPositionZ=" + Camera.Position.z);

				sw.WriteLine("CameraLookAtX=" + Camera.LookAt.x);
				sw.WriteLine("CameraLookAtY=" + Camera.LookAt.y);
				sw.WriteLine("CameraLookAtZ=" + Camera.LookAt.z);

				sw.WriteLine("LightingPositionX=" + LightingPosition.x);
				sw.WriteLine("LightingPositionY=" + LightingPosition.y);
				sw.WriteLine("LightingPositionZ=" + LightingPosition.z);
				sw.WriteLine("LightBrightness=" + LightBrightness);
				
				sw.WriteLine("ShadowMinStep=" + ShadowMinStep);

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

		public static void Preset(int id, Form1 form) // Пресеты
		{
			if (id == 0)
			{
				Camera.Position.x = 2.75;
				Camera.Position.y = 4;
				Camera.Position.z = 1;

				Camera.LookAt.x = 2;
				Camera.LookAt.y = 1;
				Camera.LookAt.z = 2;

				LightingPosition.x = 0;
				LightingPosition.y = 5;
				LightingPosition.z = 5;
				LightBrightness = 1;

				ShadowMinStep = 0.01;

				form.MaxIterationNumericUpDown.Value = 50;
				form.MinDistNumericUpDown.Value = 0.001m;

				form.OrRadioButton.Checked = false;
				form.AndRadioButton.Checked = true;

				form.AmbientOcclusionCheckBox.Checked = false;
				form.LightingCheckBox.Checked = true;
				form.ShadowsCheckBox.Checked = true;

				Form1.objectList.Clear();
				form.RMObjectListBox.Items.Clear();
				form.objectListAdd = new Sphere(1, 1, 2, 0, 111, 0, 1.25);
				form.objectListAdd = new Sphere(2, 1, 3, 0, 0, 111, 1.25);
				form.objectListAdd = new Sphere(3, 1, 2, 111, 111, 111, 1.25);
				form.objectListAdd = new Sphere(2, 1, 1, 111, 0, 0, 1.25);
			}
			else if (id == 1)
			{
				Camera.Position.x = 6;
				Camera.Position.y = 5;
				Camera.Position.z = 3;

				Camera.LookAt.x = 5.5;
				Camera.LookAt.y = 1;
				Camera.LookAt.z = 5.5;

				LightingPosition.x = 0;
				LightingPosition.y = 5;
				LightingPosition.z = 5;
				LightBrightness = 1;

				ShadowMinStep = 0.01;

				form.MaxIterationNumericUpDown.Value = 50;
				form.MinDistNumericUpDown.Value = 0.001m;

				form.OrRadioButton.Checked = false;
				form.AndRadioButton.Checked = true;

				form.AmbientOcclusionCheckBox.Checked = false;
				form.LightingCheckBox.Checked = true;
				form.ShadowsCheckBox.Checked = true;

				Form1.objectList.Clear();
				form.RMObjectListBox.Items.Clear();
				form.objectListAdd = new Sphere(2, 1, 2, 0, 111, 0, -5);
				form.objectListAdd = new Sphere(5, 1.5, 5, 0, 0, 0, 1.5);
			}
			else if (id == 2)
			{
				Camera.Position.x = 2.5;
				Camera.Position.y = 1.5;
				Camera.Position.z = -0.5;

				Camera.LookAt.x = 3;
				Camera.LookAt.y = 1;
				Camera.LookAt.z = 3;

				LightingPosition.x = 3;
				LightingPosition.y = 3;
				LightingPosition.z = 3;
				LightBrightness = 1;

				ShadowMinStep = 1E-08;

				form.MaxIterationNumericUpDown.Value = 150;
				form.MinDistNumericUpDown.Value = 0.001m;

				form.OrRadioButton.Checked = false;
				form.AndRadioButton.Checked = true;

				form.AmbientOcclusionCheckBox.Checked = true;
				form.LightingCheckBox.Checked = false;
				form.ShadowsCheckBox.Checked = true;

				Form1.objectList.Clear();
				form.RMObjectListBox.Items.Clear();
				form.objectListAdd = new Cube(3, 1, 3, 255, 255, 255, 1);
				form.objectListAdd = new Sphere(3, 1, 3, 0, 111, 0, -1.35);
				form.objectListAdd = new Sphere(3, 1, 3, 0, 255, 255, 1.4);
			}
			else
				throw new ArgumentNullException($"Error RMSettings.Preset({id}, form)");
		}
	}
}
