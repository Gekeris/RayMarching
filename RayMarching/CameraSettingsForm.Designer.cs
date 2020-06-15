namespace RayMarching
{
	partial class CameraSettingsForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.PositionZNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.PositionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.PositionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.LookAtZNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.LookAtYNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.LookAtXNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.CancelButton1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PositionZNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionYNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionXNumericUpDown)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LookAtZNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LookAtYNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LookAtXNumericUpDown)).BeginInit();
			this.SuspendLayout();
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
			this.groupBox1.TabIndex = 0;
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.LookAtZNumericUpDown);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.LookAtYNumericUpDown);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.LookAtXNumericUpDown);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(181, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(163, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "LookAt";
			// 
			// LookAtZNumericUpDown
			// 
			this.LookAtZNumericUpDown.DecimalPlaces = 3;
			this.LookAtZNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.LookAtZNumericUpDown.Location = new System.Drawing.Point(30, 71);
			this.LookAtZNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.LookAtZNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.LookAtZNumericUpDown.Name = "LookAtZNumericUpDown";
			this.LookAtZNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.LookAtZNumericUpDown.TabIndex = 8;
			this.LookAtZNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(6, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "Z:";
			// 
			// LookAtYNumericUpDown
			// 
			this.LookAtYNumericUpDown.DecimalPlaces = 3;
			this.LookAtYNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.LookAtYNumericUpDown.Location = new System.Drawing.Point(30, 45);
			this.LookAtYNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.LookAtYNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.LookAtYNumericUpDown.Name = "LookAtYNumericUpDown";
			this.LookAtYNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.LookAtYNumericUpDown.TabIndex = 7;
			this.LookAtYNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(6, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "Y:";
			// 
			// LookAtXNumericUpDown
			// 
			this.LookAtXNumericUpDown.DecimalPlaces = 3;
			this.LookAtXNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.LookAtXNumericUpDown.Location = new System.Drawing.Point(30, 19);
			this.LookAtXNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.LookAtXNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.LookAtXNumericUpDown.Name = "LookAtXNumericUpDown";
			this.LookAtXNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.LookAtXNumericUpDown.TabIndex = 6;
			this.LookAtXNumericUpDown.ValueChanged += new System.EventHandler(this.SettingsEdit);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(6, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "X:";
			// 
			// ApplyButton
			// 
			this.ApplyButton.Location = new System.Drawing.Point(100, 118);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(75, 23);
			this.ApplyButton.TabIndex = 2;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton1.Location = new System.Drawing.Point(181, 118);
			this.CancelButton1.Name = "CancelButton";
			this.CancelButton1.Size = new System.Drawing.Size(75, 23);
			this.CancelButton1.TabIndex = 3;
			this.CancelButton1.Text = "Cancel";
			this.CancelButton1.UseVisualStyleBackColor = true;
			this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// CameraSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 147);
			this.Controls.Add(this.CancelButton1);
			this.Controls.Add(this.ApplyButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(369, 186);
			this.MinimumSize = new System.Drawing.Size(369, 186);
			this.Name = "CameraSettingsForm";
			this.Text = "CameraSettingsForm";
			this.Load += new System.EventHandler(this.CameraSettingsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PositionZNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionYNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionXNumericUpDown)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LookAtZNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LookAtYNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LookAtXNumericUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.Button CancelButton1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown PositionXNumericUpDown;
		private System.Windows.Forms.NumericUpDown PositionZNumericUpDown;
		private System.Windows.Forms.NumericUpDown PositionYNumericUpDown;
		private System.Windows.Forms.NumericUpDown LookAtZNumericUpDown;
		private System.Windows.Forms.NumericUpDown LookAtYNumericUpDown;
		private System.Windows.Forms.NumericUpDown LookAtXNumericUpDown;
	}
}