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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.track_angle = new System.Windows.Forms.TrackBar();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.text_angle = new System.Windows.Forms.Label();
            this.check_grid = new System.Windows.Forms.CheckBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
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
            // track_angle
            // 
            this.track_angle.Location = new System.Drawing.Point(12, 11);
            this.track_angle.Maximum = 90;
            this.track_angle.Name = "track_angle";
            this.track_angle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_angle.Size = new System.Drawing.Size(45, 437);
            this.track_angle.TabIndex = 11;
            this.track_angle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track_angle.Scroll += new System.EventHandler(this.track_angle_Scroll);
            // 
            // text_angle
            // 
            this.text_angle.AutoSize = true;
            this.text_angle.Location = new System.Drawing.Point(225, 9);
            this.text_angle.Name = "text_angle";
            this.text_angle.Size = new System.Drawing.Size(13, 13);
            this.text_angle.TabIndex = 12;
            this.text_angle.Text = "0";
            // 
            // check_grid
            // 
            this.check_grid.AutoSize = true;
            this.check_grid.Location = new System.Drawing.Point(84, 59);
            this.check_grid.Name = "check_grid";
            this.check_grid.Size = new System.Drawing.Size(45, 17);
            this.check_grid.TabIndex = 14;
            this.check_grid.Text = "Grid";
            this.check_grid.UseVisualStyleBackColor = true;
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(72, 30);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 15;
            this.button_Stop.Text = "Clear";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Угол:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.check_grid);
            this.Controls.Add(this.text_angle);
            this.Controls.Add(this.track_angle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar track_angle;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label text_angle;
        private System.Windows.Forms.CheckBox check_grid;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label1;
    }
}

