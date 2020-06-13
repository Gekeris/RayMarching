namespace RayMarching
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CameraPositionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.CameraPositionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.CameraPositionZNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.CameraLookAtXNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.CameraLookAtYNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.CameraLookAtZNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.MaxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.MinDistNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ResetButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.AndRadioButton = new System.Windows.Forms.RadioButton();
			this.OrRadioButton = new System.Windows.Forms.RadioButton();
			this.SavePictureButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Camera1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionXNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionYNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionZNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtXNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtYNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtZNumericUpDown)).BeginInit();
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
			this.UpdateButton.Location = new System.Drawing.Point(699, 8);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(75, 23);
			this.UpdateButton.TabIndex = 3;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateCamera);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(659, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "CameraPositionX";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(659, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "CameraPositionY";
			// 
			// CameraPositionXNumericUpDown
			// 
			this.CameraPositionXNumericUpDown.DecimalPlaces = 3;
			this.CameraPositionXNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.CameraPositionXNumericUpDown.Location = new System.Drawing.Point(752, 37);
			this.CameraPositionXNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.CameraPositionXNumericUpDown.Name = "CameraPositionXNumericUpDown";
			this.CameraPositionXNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.CameraPositionXNumericUpDown.TabIndex = 10;
			this.CameraPositionXNumericUpDown.ThousandsSeparator = true;
			this.CameraPositionXNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// CameraPositionYNumericUpDown
			// 
			this.CameraPositionYNumericUpDown.DecimalPlaces = 3;
			this.CameraPositionYNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.CameraPositionYNumericUpDown.Location = new System.Drawing.Point(752, 63);
			this.CameraPositionYNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.CameraPositionYNumericUpDown.Name = "CameraPositionYNumericUpDown";
			this.CameraPositionYNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.CameraPositionYNumericUpDown.TabIndex = 11;
			this.CameraPositionYNumericUpDown.ThousandsSeparator = true;
			this.CameraPositionYNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// CameraPositionZNumericUpDown
			// 
			this.CameraPositionZNumericUpDown.DecimalPlaces = 3;
			this.CameraPositionZNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.CameraPositionZNumericUpDown.Location = new System.Drawing.Point(752, 89);
			this.CameraPositionZNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.CameraPositionZNumericUpDown.Name = "CameraPositionZNumericUpDown";
			this.CameraPositionZNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.CameraPositionZNumericUpDown.TabIndex = 13;
			this.CameraPositionZNumericUpDown.ThousandsSeparator = true;
			this.CameraPositionZNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(659, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "CameraPositionZ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(662, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "CameraLookAtX";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(662, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "CameraLookAtY";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(662, 169);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "CameraLookAtZ";
			// 
			// CameraLookAtXNumericUpDown
			// 
			this.CameraLookAtXNumericUpDown.DecimalPlaces = 3;
			this.CameraLookAtXNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.CameraLookAtXNumericUpDown.Location = new System.Drawing.Point(752, 115);
			this.CameraLookAtXNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.CameraLookAtXNumericUpDown.Name = "CameraLookAtXNumericUpDown";
			this.CameraLookAtXNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.CameraLookAtXNumericUpDown.TabIndex = 17;
			this.CameraLookAtXNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// CameraLookAtYNumericUpDown
			// 
			this.CameraLookAtYNumericUpDown.DecimalPlaces = 3;
			this.CameraLookAtYNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.CameraLookAtYNumericUpDown.Location = new System.Drawing.Point(752, 141);
			this.CameraLookAtYNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.CameraLookAtYNumericUpDown.Name = "CameraLookAtYNumericUpDown";
			this.CameraLookAtYNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.CameraLookAtYNumericUpDown.TabIndex = 18;
			this.CameraLookAtYNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// CameraLookAtZNumericUpDown
			// 
			this.CameraLookAtZNumericUpDown.DecimalPlaces = 3;
			this.CameraLookAtZNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.CameraLookAtZNumericUpDown.Location = new System.Drawing.Point(752, 167);
			this.CameraLookAtZNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.CameraLookAtZNumericUpDown.Name = "CameraLookAtZNumericUpDown";
			this.CameraLookAtZNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.CameraLookAtZNumericUpDown.TabIndex = 19;
			this.CameraLookAtZNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(681, 195);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "MaxIteration";
			// 
			// MaxIterationNumericUpDown
			// 
			this.MaxIterationNumericUpDown.Location = new System.Drawing.Point(752, 193);
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
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(655, 221);
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
			this.MinDistNumericUpDown.Location = new System.Drawing.Point(752, 219);
			this.MinDistNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
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
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(780, 416);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(92, 23);
			this.ResetButton.TabIndex = 26;
			this.ResetButton.Text = "Reset settings";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetSettings);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(780, 387);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 23);
			this.button2.TabIndex = 27;
			this.button2.Text = "Save settings";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.SaveSettings);
			// 
			// AndRadioButton
			// 
			this.AndRadioButton.AutoSize = true;
			this.AndRadioButton.Location = new System.Drawing.Point(752, 246);
			this.AndRadioButton.Name = "AndRadioButton";
			this.AndRadioButton.Size = new System.Drawing.Size(44, 17);
			this.AndRadioButton.TabIndex = 28;
			this.AndRadioButton.TabStop = true;
			this.AndRadioButton.Text = "And";
			this.AndRadioButton.UseVisualStyleBackColor = true;
			// 
			// OrRadioButton
			// 
			this.OrRadioButton.AutoSize = true;
			this.OrRadioButton.Location = new System.Drawing.Point(752, 269);
			this.OrRadioButton.Name = "OrRadioButton";
			this.OrRadioButton.Size = new System.Drawing.Size(36, 17);
			this.OrRadioButton.TabIndex = 29;
			this.OrRadioButton.TabStop = true;
			this.OrRadioButton.Text = "Or";
			this.OrRadioButton.UseVisualStyleBackColor = true;
			// 
			// SaveScreenButton
			// 
			this.SavePictureButton.Location = new System.Drawing.Point(780, 8);
			this.SavePictureButton.Name = "SaveScreenButton";
			this.SavePictureButton.Size = new System.Drawing.Size(92, 23);
			this.SavePictureButton.TabIndex = 30;
			this.SavePictureButton.Text = "Save Screen";
			this.SavePictureButton.UseVisualStyleBackColor = true;
			this.SavePictureButton.Click += new System.EventHandler(this.SaveScreenPicture_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 480);
			this.Controls.Add(this.SavePictureButton);
			this.Controls.Add(this.OrRadioButton);
			this.Controls.Add(this.AndRadioButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.MinDistNumericUpDown);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.MaxIterationNumericUpDown);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.CameraLookAtZNumericUpDown);
			this.Controls.Add(this.CameraLookAtYNumericUpDown);
			this.Controls.Add(this.CameraLookAtXNumericUpDown);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.CameraPositionZNumericUpDown);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CameraPositionYNumericUpDown);
			this.Controls.Add(this.CameraPositionXNumericUpDown);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
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
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionXNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionYNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionZNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtXNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtYNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtZNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinDistNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Camera1;
		private System.Windows.Forms.Button ResetToDefButton;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.NumericUpDown CameraPositionXNumericUpDown;
		public System.Windows.Forms.NumericUpDown CameraPositionYNumericUpDown;
		public System.Windows.Forms.NumericUpDown CameraPositionZNumericUpDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.NumericUpDown CameraLookAtXNumericUpDown;
		public System.Windows.Forms.NumericUpDown CameraLookAtYNumericUpDown;
		public System.Windows.Forms.NumericUpDown CameraLookAtZNumericUpDown;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.NumericUpDown MaxIterationNumericUpDown;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.NumericUpDown MinDistNumericUpDown;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.RadioButton AndRadioButton;
		public System.Windows.Forms.RadioButton OrRadioButton;
		private System.Windows.Forms.Button SavePictureButton;
	}
}

