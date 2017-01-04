namespace LoopTimer
{
	partial class LauncherForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
			this.numHours = new System.Windows.Forms.NumericUpDown();
			this.numMinutes = new System.Windows.Forms.NumericUpDown();
			this.numSeconds = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.timerDisplay = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
			this.SuspendLayout();
			// 
			// numHours
			// 
			this.numHours.Location = new System.Drawing.Point(48, 104);
			this.numHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.numHours.Name = "numHours";
			this.numHours.Size = new System.Drawing.Size(56, 20);
			this.numHours.TabIndex = 0;
			// 
			// numMinutes
			// 
			this.numMinutes.Location = new System.Drawing.Point(120, 104);
			this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numMinutes.Name = "numMinutes";
			this.numMinutes.Size = new System.Drawing.Size(56, 20);
			this.numMinutes.TabIndex = 0;
			// 
			// numSeconds
			// 
			this.numSeconds.Location = new System.Drawing.Point(192, 104);
			this.numSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numSeconds.Name = "numSeconds";
			this.numSeconds.Size = new System.Drawing.Size(56, 20);
			this.numSeconds.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(56, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "HH";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Location = new System.Drawing.Point(128, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "MM";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(200, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "SEC";
			// 
			// buttonStart
			// 
			this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStart.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.buttonStart.Location = new System.Drawing.Point(48, 152);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(96, 23);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "Старт";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.EnabledChanged += new System.EventHandler(this.button_EnabledChanged);
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.BackColor = System.Drawing.Color.Gray;
			this.buttonStop.Enabled = false;
			this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStop.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.buttonStop.Location = new System.Drawing.Point(152, 152);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(96, 23);
			this.buttonStop.TabIndex = 2;
			this.buttonStop.Text = "Стоп";
			this.buttonStop.UseVisualStyleBackColor = false;
			this.buttonStop.EnabledChanged += new System.EventHandler(this.button_EnabledChanged);
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// timerDisplay
			// 
			this.timerDisplay.BackColor = System.Drawing.Color.Transparent;
			this.timerDisplay.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timerDisplay.ForeColor = System.Drawing.Color.Red;
			this.timerDisplay.Location = new System.Drawing.Point(32, 16);
			this.timerDisplay.Name = "timerDisplay";
			this.timerDisplay.Size = new System.Drawing.Size(256, 64);
			this.timerDisplay.TabIndex = 3;
			this.timerDisplay.Text = "00:00:00";
			this.timerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LauncherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(304, 199);
			this.Controls.Add(this.timerDisplay);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numSeconds);
			this.Controls.Add(this.numMinutes);
			this.Controls.Add(this.numHours);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LauncherForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Циклический таймер";
			((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numHours;
		private System.Windows.Forms.NumericUpDown numMinutes;
		private System.Windows.Forms.NumericUpDown numSeconds;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Label timerDisplay;
	}
}

