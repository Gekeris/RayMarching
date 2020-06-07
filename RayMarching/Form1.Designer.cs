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
			((System.ComponentModel.ISupportInitialize)(this.Camera1)).BeginInit();
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
			this.SaveCheckBox.Location = new System.Drawing.Point(646, 12);
			this.SaveCheckBox.Name = "SaveCheckBox";
			this.SaveCheckBox.Size = new System.Drawing.Size(51, 17);
			this.SaveCheckBox.TabIndex = 1;
			this.SaveCheckBox.Text = "Save";
			this.SaveCheckBox.UseVisualStyleBackColor = true;
			this.SaveCheckBox.CheckedChanged += new System.EventHandler(this.SaveCheckBox_CheckedChanged);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 480);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Camera1;
		public System.Windows.Forms.CheckBox SaveCheckBox;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button UpdateButton;
	}
}

