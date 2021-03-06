﻿using System;
using System.Windows.Forms;

namespace RayMarching
{
	public partial class CameraSettingsForm : Form
	{
		public CameraSettingsForm()
		{
			InitializeComponent();
		}

		private void CameraSettingsForm_Load(object sender, EventArgs e) // Загрузка текущих настроек камеры
		{
			PositionXNumericUpDown.Value = Convert.ToDecimal(Camera.Position.x);
			PositionYNumericUpDown.Value = Convert.ToDecimal(Camera.Position.y);
			PositionZNumericUpDown.Value = Convert.ToDecimal(Camera.Position.z);

			LookAtXNumericUpDown.Value = Convert.ToDecimal(Camera.LookAt.x);
			LookAtYNumericUpDown.Value = Convert.ToDecimal(Camera.LookAt.y);
			LookAtZNumericUpDown.Value = Convert.ToDecimal(Camera.LookAt.z);
		}

		private void ApplyButton_Click(object sender, EventArgs e) // Если пользователь решил сохранить настройки
		{
			Camera.Position.x = Convert.ToDouble(PositionXNumericUpDown.Value);
			Camera.Position.y = Convert.ToDouble(PositionYNumericUpDown.Value);
			Camera.Position.z = Convert.ToDouble(PositionZNumericUpDown.Value);

			Camera.LookAt.x = Convert.ToDouble(LookAtXNumericUpDown.Value);
			Camera.LookAt.y = Convert.ToDouble(LookAtYNumericUpDown.Value);
			Camera.LookAt.z = Convert.ToDouble(LookAtZNumericUpDown.Value);
			Close();
		}

		private void CancelButton_Click(object sender, EventArgs e) // Закрыть форму без сохранения настроек
		{
			Close();
		}

		private void SettingsEdit(object sender, EventArgs e) // Если были изменения настроек, предложить во время закрытия программы сохранить их
		{
			RMSettings.SettingsEdit = true;
		}
	}
}
