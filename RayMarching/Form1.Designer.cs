﻿namespace RayMarching
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.Camera1 = new System.Windows.Forms.PictureBox();
			this.ResetToDefButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.MaxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.MinDistNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ResetButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.AndRadioButton = new System.Windows.Forms.RadioButton();
			this.OrRadioButton = new System.Windows.Forms.RadioButton();
			this.SavePictureButton = new System.Windows.Forms.Button();
			this.CameraSettingsButton = new System.Windows.Forms.Button();
			this.RMObjectListBox = new System.Windows.Forms.ListBox();
			this.AddObjectButton = new System.Windows.Forms.Button();
			this.AddObjectComboBox = new System.Windows.Forms.ComboBox();
			this.AmbientOcclusionCheckBox = new System.Windows.Forms.CheckBox();
			this.LightingCheckBox = new System.Windows.Forms.CheckBox();
			this.ShadowsCheckBox = new System.Windows.Forms.CheckBox();
			this.LightingButton = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.PresetComboBox = new System.Windows.Forms.ComboBox();
			this.PresetButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Camera1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinDistNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// Camera1
			// 
			this.Camera1.Location = new System.Drawing.Point(0, 0);
			this.Camera1.Name = "Camera1";
			this.Camera1.Size = new System.Drawing.Size(640, 480);
			this.Camera1.TabIndex = 0;
			this.Camera1.TabStop = false;
			// 
			// ResetToDefButton
			// 
			this.ResetToDefButton.Location = new System.Drawing.Point(780, 445);
			this.ResetToDefButton.Name = "ResetToDefButton";
			this.ResetToDefButton.Size = new System.Drawing.Size(92, 23);
			this.ResetToDefButton.TabIndex = 2;
			this.ResetToDefButton.Text = "Reset to default";
			this.ResetToDefButton.UseVisualStyleBackColor = true;
			this.ResetToDefButton.Click += new System.EventHandler(this.DefaultSettings);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(646, 8);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(92, 23);
			this.UpdateButton.TabIndex = 3;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateCamera);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(681, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "MaxIteration";
			// 
			// MaxIterationNumericUpDown
			// 
			this.MaxIterationNumericUpDown.Location = new System.Drawing.Point(752, 60);
			this.MaxIterationNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.MaxIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MaxIterationNumericUpDown.Name = "MaxIterationNumericUpDown";
			this.MaxIterationNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.MaxIterationNumericUpDown.TabIndex = 23;
			this.MaxIterationNumericUpDown.Tag = "";
			this.MaxIterationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MaxIterationNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(655, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 13);
			this.label8.TabIndex = 24;
			this.label8.Text = "Minimum distance";
			// 
			// MinDistNumericUpDown
			// 
			this.MinDistNumericUpDown.DecimalPlaces = 6;
			this.MinDistNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
			this.MinDistNumericUpDown.Location = new System.Drawing.Point(752, 86);
			this.MinDistNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MinDistNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
			this.MinDistNumericUpDown.Name = "MinDistNumericUpDown";
			this.MinDistNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.MinDistNumericUpDown.TabIndex = 25;
			this.MinDistNumericUpDown.Tag = "";
			this.MinDistNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
			this.MinDistNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(646, 445);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(92, 23);
			this.ResetButton.TabIndex = 26;
			this.ResetButton.Text = "Reset settings";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetSettings);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(646, 416);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(92, 23);
			this.SaveButton.TabIndex = 27;
			this.SaveButton.Text = "Save settings";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveSettings);
			// 
			// AndRadioButton
			// 
			this.AndRadioButton.AutoSize = true;
			this.AndRadioButton.Location = new System.Drawing.Point(721, 37);
			this.AndRadioButton.Name = "AndRadioButton";
			this.AndRadioButton.Size = new System.Drawing.Size(44, 17);
			this.AndRadioButton.TabIndex = 28;
			this.AndRadioButton.TabStop = true;
			this.AndRadioButton.Text = "And";
			this.AndRadioButton.UseVisualStyleBackColor = true;
			this.AndRadioButton.CheckedChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// OrRadioButton
			// 
			this.OrRadioButton.AutoSize = true;
			this.OrRadioButton.Location = new System.Drawing.Point(771, 37);
			this.OrRadioButton.Name = "OrRadioButton";
			this.OrRadioButton.Size = new System.Drawing.Size(36, 17);
			this.OrRadioButton.TabIndex = 29;
			this.OrRadioButton.TabStop = true;
			this.OrRadioButton.Text = "Or";
			this.OrRadioButton.UseVisualStyleBackColor = true;
			this.OrRadioButton.CheckedChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// SavePictureButton
			// 
			this.SavePictureButton.Location = new System.Drawing.Point(780, 8);
			this.SavePictureButton.Name = "SavePictureButton";
			this.SavePictureButton.Size = new System.Drawing.Size(92, 23);
			this.SavePictureButton.TabIndex = 30;
			this.SavePictureButton.Text = "Save Screen";
			this.SavePictureButton.UseVisualStyleBackColor = true;
			this.SavePictureButton.Click += new System.EventHandler(this.SaveScreenPicture_Click);
			// 
			// CameraSettingsButton
			// 
			this.CameraSettingsButton.Location = new System.Drawing.Point(780, 112);
			this.CameraSettingsButton.Name = "CameraSettingsButton";
			this.CameraSettingsButton.Size = new System.Drawing.Size(92, 23);
			this.CameraSettingsButton.TabIndex = 31;
			this.CameraSettingsButton.Text = "Camera Settings";
			this.CameraSettingsButton.UseVisualStyleBackColor = true;
			this.CameraSettingsButton.Click += new System.EventHandler(this.CameraSettingsButton_Click);
			// 
			// RMObjectListBox
			// 
			this.RMObjectListBox.FormattingEnabled = true;
			this.RMObjectListBox.Location = new System.Drawing.Point(646, 234);
			this.RMObjectListBox.Name = "RMObjectListBox";
			this.RMObjectListBox.Size = new System.Drawing.Size(226, 173);
			this.RMObjectListBox.TabIndex = 32;
			this.RMObjectListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RMObjectListBox_MouseDoubleClick);
			// 
			// AddObjectButton
			// 
			this.AddObjectButton.Location = new System.Drawing.Point(646, 205);
			this.AddObjectButton.Name = "AddObjectButton";
			this.AddObjectButton.Size = new System.Drawing.Size(75, 23);
			this.AddObjectButton.TabIndex = 33;
			this.AddObjectButton.Text = "Add Object";
			this.AddObjectButton.UseVisualStyleBackColor = true;
			this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
			// 
			// AddObjectComboBox
			// 
			this.AddObjectComboBox.FormattingEnabled = true;
			this.AddObjectComboBox.Items.AddRange(new object[] {
            "Sphere",
            "Cube"});
			this.AddObjectComboBox.Location = new System.Drawing.Point(727, 207);
			this.AddObjectComboBox.Name = "AddObjectComboBox";
			this.AddObjectComboBox.Size = new System.Drawing.Size(121, 21);
			this.AddObjectComboBox.TabIndex = 34;
			// 
			// AmbientOcclusionCheckBox
			// 
			this.AmbientOcclusionCheckBox.AutoSize = true;
			this.AmbientOcclusionCheckBox.Location = new System.Drawing.Point(646, 116);
			this.AmbientOcclusionCheckBox.Name = "AmbientOcclusionCheckBox";
			this.AmbientOcclusionCheckBox.Size = new System.Drawing.Size(112, 17);
			this.AmbientOcclusionCheckBox.TabIndex = 35;
			this.AmbientOcclusionCheckBox.Text = "Ambient occlusion";
			this.AmbientOcclusionCheckBox.UseVisualStyleBackColor = true;
			this.AmbientOcclusionCheckBox.CheckedChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// LightingCheckBox
			// 
			this.LightingCheckBox.AutoSize = true;
			this.LightingCheckBox.Location = new System.Drawing.Point(646, 145);
			this.LightingCheckBox.Name = "LightingCheckBox";
			this.LightingCheckBox.Size = new System.Drawing.Size(63, 17);
			this.LightingCheckBox.TabIndex = 36;
			this.LightingCheckBox.Text = "Lighting";
			this.LightingCheckBox.UseVisualStyleBackColor = true;
			this.LightingCheckBox.CheckedChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// ShadowsCheckBox
			// 
			this.ShadowsCheckBox.AutoSize = true;
			this.ShadowsCheckBox.Location = new System.Drawing.Point(646, 174);
			this.ShadowsCheckBox.Name = "ShadowsCheckBox";
			this.ShadowsCheckBox.Size = new System.Drawing.Size(70, 17);
			this.ShadowsCheckBox.TabIndex = 37;
			this.ShadowsCheckBox.Text = "Shadows";
			this.ShadowsCheckBox.UseVisualStyleBackColor = true;
			this.ShadowsCheckBox.CheckedChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// LightingButton
			// 
			this.LightingButton.Enabled = false;
			this.LightingButton.Location = new System.Drawing.Point(780, 141);
			this.LightingButton.Name = "LightingButton";
			this.LightingButton.Size = new System.Drawing.Size(92, 23);
			this.LightingButton.TabIndex = 38;
			this.LightingButton.Text = "lighting Settings";
			this.LightingButton.UseVisualStyleBackColor = true;
			this.LightingButton.Click += new System.EventHandler(this.LightingButton_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(0, 457);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(640, 23);
			this.progressBar1.TabIndex = 39;
			// 
			// PresetComboBox
			// 
			this.PresetComboBox.FormattingEnabled = true;
			this.PresetComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.PresetComboBox.Location = new System.Drawing.Point(752, 169);
			this.PresetComboBox.Name = "PresetComboBox";
			this.PresetComboBox.Size = new System.Drawing.Size(32, 21);
			this.PresetComboBox.TabIndex = 40;
			// 
			// PresetButton
			// 
			this.PresetButton.Location = new System.Drawing.Point(790, 168);
			this.PresetButton.Name = "PresetButton";
			this.PresetButton.Size = new System.Drawing.Size(82, 23);
			this.PresetButton.TabIndex = 41;
			this.PresetButton.Text = "Load Preset";
			this.PresetButton.UseVisualStyleBackColor = true;
			this.PresetButton.Click += new System.EventHandler(this.PresetButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 480);
			this.Controls.Add(this.PresetButton);
			this.Controls.Add(this.PresetComboBox);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.LightingButton);
			this.Controls.Add(this.ShadowsCheckBox);
			this.Controls.Add(this.LightingCheckBox);
			this.Controls.Add(this.AmbientOcclusionCheckBox);
			this.Controls.Add(this.AddObjectComboBox);
			this.Controls.Add(this.AddObjectButton);
			this.Controls.Add(this.RMObjectListBox);
			this.Controls.Add(this.CameraSettingsButton);
			this.Controls.Add(this.SavePictureButton);
			this.Controls.Add(this.OrRadioButton);
			this.Controls.Add(this.AndRadioButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.MinDistNumericUpDown);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.MaxIterationNumericUpDown);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.ResetToDefButton);
			this.Controls.Add(this.Camera1);
			this.MaximumSize = new System.Drawing.Size(900, 519);
			this.MinimumSize = new System.Drawing.Size(900, 519);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Camera1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinDistNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Camera1;
		private System.Windows.Forms.Button ResetToDefButton;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.NumericUpDown MaxIterationNumericUpDown;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.NumericUpDown MinDistNumericUpDown;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button SaveButton;
		public System.Windows.Forms.RadioButton AndRadioButton;
		public System.Windows.Forms.RadioButton OrRadioButton;
		private System.Windows.Forms.Button SavePictureButton;
		private System.Windows.Forms.Button CameraSettingsButton;
		public System.Windows.Forms.ListBox RMObjectListBox;
		private System.Windows.Forms.Button AddObjectButton;
		private System.Windows.Forms.ComboBox AddObjectComboBox;
		public System.Windows.Forms.CheckBox AmbientOcclusionCheckBox;
		public System.Windows.Forms.CheckBox LightingCheckBox;
		public System.Windows.Forms.CheckBox ShadowsCheckBox;
		private System.Windows.Forms.Button LightingButton;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ComboBox PresetComboBox;
		private System.Windows.Forms.Button PresetButton;
	}
}

