namespace Thow
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.track_angle = new System.Windows.Forms.TrackBar();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.text_angle = new System.Windows.Forms.Label();
            this.check_cell = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_Start.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(12, 12);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(152, 47);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(172, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_Stop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Stop.Location = new System.Drawing.Point(12, 402);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(152, 47);
            this.button_Stop.TabIndex = 4;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // track_angle
            // 
            this.track_angle.Location = new System.Drawing.Point(57, 91);
            this.track_angle.Maximum = 90;
            this.track_angle.Name = "track_angle";
            this.track_angle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_angle.Size = new System.Drawing.Size(45, 305);
            this.track_angle.TabIndex = 11;
            this.track_angle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track_angle.Scroll += new System.EventHandler(this.track_angle_Scroll);
            // 
            // text_angle
            // 
            this.text_angle.AutoSize = true;
            this.text_angle.Location = new System.Drawing.Point(187, 11);
            this.text_angle.Name = "text_angle";
            this.text_angle.Size = new System.Drawing.Size(32, 13);
            this.text_angle.TabIndex = 12;
            this.text_angle.Text = "Угол";
            // 
            // check_cell
            // 
            this.check_cell.AutoSize = true;
            this.check_cell.Location = new System.Drawing.Point(318, 7);
            this.check_cell.Name = "check_cell";
            this.check_cell.Size = new System.Drawing.Size(80, 17);
            this.check_cell.TabIndex = 14;
            this.check_cell.Text = "checkBox1";
            this.check_cell.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.check_cell);
            this.Controls.Add(this.text_angle);
            this.Controls.Add(this.track_angle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar track_angle;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label text_angle;
        private System.Windows.Forms.CheckBox check_cell;
    }
}

