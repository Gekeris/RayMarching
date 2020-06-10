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
			this.SaveCheckBox = new System.Windows.Forms.CheckBox();
			this.ResetButton = new System.Windows.Forms.Button();
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
			this.LineOfSightNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.MaxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.MinDistNumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Camera1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionXNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionYNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraPositionZNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtXNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtYNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraLookAtZNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LineOfSightNumericUpDown)).BeginInit();
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
			// SaveCheckBox
			// 
			this.SaveCheckBox.AutoSize = true;
			this.SaveCheckBox.Location = new System.Drawing.Point(752, 12);
			this.SaveCheckBox.Name = "SaveCheckBox";
			this.SaveCheckBox.Size = new System.Drawing.Size(88, 17);
			this.SaveCheckBox.TabIndex = 1;
			this.SaveCheckBox.Text = "Save Screen";
			this.SaveCheckBox.UseVisualStyleBackColor = true;
			this.SaveCheckBox.CheckedChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(780, 445);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(92, 23);
			this.ResetButton.TabIndex = 2;
			this.ResetButton.Text = "Reset to default";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.DefaultSettings);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(646, 445);
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
			// LineOfSightNumericUpDown
			// 
			this.LineOfSightNumericUpDown.Location = new System.Drawing.Point(752, 194);
			this.LineOfSightNumericUpDown.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
			this.LineOfSightNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.LineOfSightNumericUpDown.Name = "LineOfSightNumericUpDown";
			this.LineOfSightNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.LineOfSightNumericUpDown.TabIndex = 20;
			this.LineOfSightNumericUpDown.Tag = "";
			this.LineOfSightNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.LineOfSightNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(682, 196);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Line of sight";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(681, 222);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "MaxIteration";
			// 
			// MaxIterationNumericUpDown
			// 
			this.MaxIterationNumericUpDown.Location = new System.Drawing.Point(752, 220);
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
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(655, 248);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "Minimum distance";
			// 
			// MinDistNumericUpDown
			// 
			this.MinDistNumericUpDown.DecimalPlaces = 6;
			this.MinDistNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
			this.MinDistNumericUpDown.Location = new System.Drawing.Point(752, 246);
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
            1,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 480);
			this.Controls.Add(this.MinDistNumericUpDown);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.MaxIterationNumericUpDown);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.LineOfSightNumericUpDown);
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
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.SaveCheckBox);
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
			((System.ComponentModel.ISupportInitialize)(this.LineOfSightNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinDistNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Camera1;
		public System.Windows.Forms.CheckBox SaveCheckBox;
		private System.Windows.Forms.Button ResetButton;
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
		public System.Windows.Forms.NumericUpDown LineOfSightNumericUpDown;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.NumericUpDown MaxIterationNumericUpDown;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.NumericUpDown MinDistNumericUpDown;
	}
}

