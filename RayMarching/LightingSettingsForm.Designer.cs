namespace RayMarching
{
	partial class LightingSettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CancelButton1 = new System.Windows.Forms.Button();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.PositionZNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.PositionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.PositionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.BrightnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ShadowMinStepNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PositionZNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionYNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionXNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BrightnessNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ShadowMinStepNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// CancelButton1
			// 
			this.CancelButton1.Location = new System.Drawing.Point(126, 196);
			this.CancelButton1.Name = "CancelButton1";
			this.CancelButton1.Size = new System.Drawing.Size(75, 23);
			this.CancelButton1.TabIndex = 7;
			this.CancelButton1.Text = "Cancel";
			this.CancelButton1.UseVisualStyleBackColor = true;
			this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
			// 
			// ApplyButton
			// 
			this.ApplyButton.Location = new System.Drawing.Point(38, 196);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(75, 23);
			this.ApplyButton.TabIndex = 6;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.PositionZNumericUpDown);
			this.groupBox1.Controls.Add(this.PositionYNumericUpDown);
			this.groupBox1.Controls.Add(this.PositionXNumericUpDown);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(38, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(163, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Position";
			// 
			// PositionZNumericUpDown
			// 
			this.PositionZNumericUpDown.DecimalPlaces = 3;
			this.PositionZNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.PositionZNumericUpDown.Location = new System.Drawing.Point(35, 71);
			this.PositionZNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.PositionZNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.PositionZNumericUpDown.Name = "PositionZNumericUpDown";
			this.PositionZNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.PositionZNumericUpDown.TabIndex = 5;
			this.PositionZNumericUpDown.ValueChanged += new System.EventHandler(this.SettingEdit);
			// 
			// PositionYNumericUpDown
			// 
			this.PositionYNumericUpDown.DecimalPlaces = 3;
			this.PositionYNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.PositionYNumericUpDown.Location = new System.Drawing.Point(35, 45);
			this.PositionYNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.PositionYNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.PositionYNumericUpDown.Name = "PositionYNumericUpDown";
			this.PositionYNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.PositionYNumericUpDown.TabIndex = 4;
			this.PositionYNumericUpDown.ValueChanged += new System.EventHandler(this.SettingEdit);
			// 
			// PositionXNumericUpDown
			// 
			this.PositionXNumericUpDown.DecimalPlaces = 3;
			this.PositionXNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.PositionXNumericUpDown.Location = new System.Drawing.Point(35, 19);
			this.PositionXNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.PositionXNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.PositionXNumericUpDown.Name = "PositionXNumericUpDown";
			this.PositionXNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.PositionXNumericUpDown.TabIndex = 3;
			this.PositionXNumericUpDown.ValueChanged += new System.EventHandler(this.SettingEdit);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(11, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Z:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(11, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Y:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(11, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "X:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(91, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Brightness %";
			// 
			// BrightnessNumericUpDown
			// 
			this.BrightnessNumericUpDown.DecimalPlaces = 3;
			this.BrightnessNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.BrightnessNumericUpDown.Location = new System.Drawing.Point(62, 131);
			this.BrightnessNumericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.BrightnessNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.BrightnessNumericUpDown.Name = "BrightnessNumericUpDown";
			this.BrightnessNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.BrightnessNumericUpDown.TabIndex = 6;
			this.BrightnessNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.BrightnessNumericUpDown.ValueChanged += new System.EventHandler(this.SettingEdit);
			// 
			// ShadowMinStepNumericUpDown
			// 
			this.ShadowMinStepNumericUpDown.DecimalPlaces = 2;
			this.ShadowMinStepNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ShadowMinStepNumericUpDown.Location = new System.Drawing.Point(62, 170);
			this.ShadowMinStepNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ShadowMinStepNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ShadowMinStepNumericUpDown.Name = "ShadowMinStepNumericUpDown";
			this.ShadowMinStepNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.ShadowMinStepNumericUpDown.TabIndex = 9;
			this.ShadowMinStepNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ShadowMinStepNumericUpDown.ValueChanged += new System.EventHandler(this.SettingEdit);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 154);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(210, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Min step when checking shadow rendering";
			// 
			// LightingSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 232);
			this.Controls.Add(this.ShadowMinStepNumericUpDown);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.BrightnessNumericUpDown);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.CancelButton1);
			this.Controls.Add(this.ApplyButton);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(251, 271);
			this.MinimumSize = new System.Drawing.Size(251, 271);
			this.Name = "LightingSettingsForm";
			this.Text = "LightingSettingsForm";
			this.Load += new System.EventHandler(this.LightingSettingsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PositionZNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionYNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionXNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BrightnessNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ShadowMinStepNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelButton1;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown PositionZNumericUpDown;
		private System.Windows.Forms.NumericUpDown PositionYNumericUpDown;
		private System.Windows.Forms.NumericUpDown PositionXNumericUpDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown BrightnessNumericUpDown;
		private System.Windows.Forms.NumericUpDown ShadowMinStepNumericUpDown;
		private System.Windows.Forms.Label label5;
	}
}