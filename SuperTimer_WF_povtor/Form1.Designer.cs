namespace SuperTimer_WF_povtor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeBox_label = new System.Windows.Forms.Label();
            this.hours_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.minutes_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.seconds_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.on_button = new System.Windows.Forms.Button();
            this.off_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seconds_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timeBox_label
            // 
            this.timeBox_label.AutoSize = true;
            this.timeBox_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox_label.ForeColor = System.Drawing.Color.Red;
            this.timeBox_label.Location = new System.Drawing.Point(427, 9);
            this.timeBox_label.Name = "timeBox_label";
            this.timeBox_label.Size = new System.Drawing.Size(347, 91);
            this.timeBox_label.TabIndex = 1;
            this.timeBox_label.Text = "00:00:00";
            // 
            // hours_numericUpDown2
            // 
            this.hours_numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hours_numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.hours_numericUpDown2.Location = new System.Drawing.Point(457, 103);
            this.hours_numericUpDown2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_numericUpDown2.Name = "hours_numericUpDown2";
            this.hours_numericUpDown2.Size = new System.Drawing.Size(84, 53);
            this.hours_numericUpDown2.TabIndex = 3;
            // 
            // minutes_numericUpDown
            // 
            this.minutes_numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minutes_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_numericUpDown.Location = new System.Drawing.Point(571, 103);
            this.minutes_numericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes_numericUpDown.Name = "minutes_numericUpDown";
            this.minutes_numericUpDown.Size = new System.Drawing.Size(80, 53);
            this.minutes_numericUpDown.TabIndex = 4;
            // 
            // seconds_numericUpDown
            // 
            this.seconds_numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.seconds_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_numericUpDown.Location = new System.Drawing.Point(682, 103);
            this.seconds_numericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.seconds_numericUpDown.Name = "seconds_numericUpDown";
            this.seconds_numericUpDown.Size = new System.Drawing.Size(82, 53);
            this.seconds_numericUpDown.TabIndex = 5;
            // 
            // on_button
            // 
            this.on_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.on_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.on_button.Location = new System.Drawing.Point(457, 180);
            this.on_button.Name = "on_button";
            this.on_button.Size = new System.Drawing.Size(143, 64);
            this.on_button.TabIndex = 6;
            this.on_button.Text = "ON";
            this.on_button.UseVisualStyleBackColor = false;
            // 
            // off_button
            // 
            this.off_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.off_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.off_button.Location = new System.Drawing.Point(616, 180);
            this.off_button.Name = "off_button";
            this.off_button.Size = new System.Drawing.Size(148, 64);
            this.off_button.TabIndex = 7;
            this.off_button.Text = "OFF";
            this.off_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.off_button);
            this.Controls.Add(this.on_button);
            this.Controls.Add(this.seconds_numericUpDown);
            this.Controls.Add(this.minutes_numericUpDown);
            this.Controls.Add(this.hours_numericUpDown2);
            this.Controls.Add(this.timeBox_label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seconds_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeBox_label;
        private System.Windows.Forms.NumericUpDown hours_numericUpDown2;
        private System.Windows.Forms.NumericUpDown minutes_numericUpDown;
        private System.Windows.Forms.NumericUpDown seconds_numericUpDown;
        private System.Windows.Forms.Button on_button;
        private System.Windows.Forms.Button off_button;
    }
}

