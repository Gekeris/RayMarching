namespace RayMarching
{
	partial class objectListSettingsForm
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
			this.PositionZNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.PositionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.PositionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ColorBlueNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ColorGreenNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ColorRedNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.SaveButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.CancelButton1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PositionZNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionYNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionXNumericUpDown)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ColorBlueNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorGreenNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorRedNumericUpDown)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
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
			this.PositionZNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
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
			this.PositionYNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
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
			this.PositionXNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.PositionZNumericUpDown);
			this.groupBox1.Controls.Add(this.PositionYNumericUpDown);
			this.groupBox1.Controls.Add(this.PositionXNumericUpDown);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(163, 100);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Position";
			// 
			// ColorBlueNumericUpDown
			// 
			this.ColorBlueNumericUpDown.Location = new System.Drawing.Point(59, 71);
			this.ColorBlueNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ColorBlueNumericUpDown.Name = "ColorBlueNumericUpDown";
			this.ColorBlueNumericUpDown.Size = new System.Drawing.Size(96, 20);
			this.ColorBlueNumericUpDown.TabIndex = 5;
			this.ColorBlueNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// ColorGreenNumericUpDown
			// 
			this.ColorGreenNumericUpDown.Location = new System.Drawing.Point(59, 45);
			this.ColorGreenNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ColorGreenNumericUpDown.Name = "ColorGreenNumericUpDown";
			this.ColorGreenNumericUpDown.Size = new System.Drawing.Size(96, 20);
			this.ColorGreenNumericUpDown.TabIndex = 4;
			this.ColorGreenNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// ColorRedNumericUpDown
			// 
			this.ColorRedNumericUpDown.Location = new System.Drawing.Point(59, 19);
			this.ColorRedNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ColorRedNumericUpDown.Name = "ColorRedNumericUpDown";
			this.ColorRedNumericUpDown.Size = new System.Drawing.Size(96, 20);
			this.ColorRedNumericUpDown.TabIndex = 3;
			this.ColorRedNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(11, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "Blue:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(11, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "Green:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(11, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "Red:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ColorBlueNumericUpDown);
			this.groupBox2.Controls.Add(this.ColorGreenNumericUpDown);
			this.groupBox2.Controls.Add(this.ColorRedNumericUpDown);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(181, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(163, 100);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Color";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(14, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "label7";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 3;
			this.numericUpDown1.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
			this.numericUpDown1.Location = new System.Drawing.Point(55, 118);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(58, 159);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 5;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(139, 159);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(75, 23);
			this.RemoveButton.TabIndex = 6;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// CancelButton1
			// 
			this.CancelButton1.Location = new System.Drawing.Point(220, 159);
			this.CancelButton1.Name = "CancelButton1";
			this.CancelButton1.Size = new System.Drawing.Size(75, 23);
			this.CancelButton1.TabIndex = 7;
			this.CancelButton1.Text = "Cancel";
			this.CancelButton1.UseVisualStyleBackColor = true;
			this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// objectListSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 191);
			this.Controls.Add(this.CancelButton1);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(372, 230);
			this.MinimumSize = new System.Drawing.Size(372, 230);
			this.Name = "objectListSettingsForm";
			this.Text = "objectListSettingsForm";
			this.Load += new System.EventHandler(this.objectListSettingsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PositionZNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionYNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionXNumericUpDown)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ColorBlueNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorGreenNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorRedNumericUpDown)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown PositionZNumericUpDown;
		private System.Windows.Forms.NumericUpDown PositionYNumericUpDown;
		private System.Windows.Forms.NumericUpDown PositionXNumericUpDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown ColorBlueNumericUpDown;
		private System.Windows.Forms.NumericUpDown ColorGreenNumericUpDown;
		private System.Windows.Forms.NumericUpDown ColorRedNumericUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button CancelButton1;
	}
}