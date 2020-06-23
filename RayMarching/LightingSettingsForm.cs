using System;
using System.Windows.Forms;

namespace RayMarching
{
	public partial class LightingSettingsForm : Form
	{
		public LightingSettingsForm()
		{
			InitializeComponent();
		}
		public bool Shadow = false; // Разрешить редактировать минимальный шаг тени, если отрисовка тени включена
		private void LightingSettingsForm_Load(object sender, EventArgs e) // загрузка настроек позиции и параметров света
		{
			PositionXNumericUpDown.Value = Convert.ToDecimal(RMSettings.LightingPosition.x);
			PositionYNumericUpDown.Value = Convert.ToDecimal(RMSettings.LightingPosition.y);
			PositionZNumericUpDown.Value = Convert.ToDecimal(RMSettings.LightingPosition.z);
			BrightnessNumericUpDown.Value = Convert.ToDecimal(RMSettings.LightBrightness);
			ShadowMinStepNumericUpDown.Value = Convert.ToDecimal(RMSettings.ShadowMinStep);
			ShadowMinStepNumericUpDown.Enabled = Shadow;
		}

		private void ApplyButton_Click(object sender, EventArgs e) // сохранить настройки позиции и параметров света
		{
			RMSettings.LightingPosition.x = Convert.ToDouble(PositionXNumericUpDown.Value);
			RMSettings.LightingPosition.y = Convert.ToDouble(PositionYNumericUpDown.Value);
			RMSettings.LightingPosition.z = Convert.ToDouble(PositionZNumericUpDown.Value);
			RMSettings.LightBrightness = Convert.ToDouble(BrightnessNumericUpDown.Value);
			RMSettings.ShadowMinStep = Convert.ToDouble(ShadowMinStepNumericUpDown.Value);
			Close();
		}

		private void CancelButton1_Click(object sender, EventArgs e) // Закрыть форму без сохранения изменений 
		{
			Close();
		}

		private void SettingEdit(object sender, EventArgs e) // Если были изменения настроек, предложить во время закрытия программы сохранить их
		{
			RMSettings.SettingsEdit = true;
		}
	}
}
