using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thow
{
    public partial class Form1 : Form
    {
        double x = 0, y = 0;
        double angle = Math.PI /180;        
        double al = 0;                          //угол
        double t = 15;                          //Время
        double V = 0;                           //Скорость
        const int g = 10;                       //Ускорение свободного падения

        int wX;
        int hX;

        Pen PenFromGrafic = new Pen(Brushes.Black);     //Карандаш для построения сетки
        Pen PenFromLine = new Pen(Brushes.Black, 2f);   //Карандаш для построения траектории

        public Form1()
        {
            InitializeComponent();
            track_angle.Scroll += track_angle_Scroll;

            this.Paint += new PaintEventHandler(Draw);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            timer1.Interval = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            wX = pictureBox1.Width;
            hX = pictureBox1.Height;

            x = (V * Math.Cos(al)) * t;
            y = (V * Math.Cos(al)) * t - g * t * t / 2;

            Bitmap flag = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(flag);

            //Сетка
            if (check_grid.Checked == true)
            {
                for (int i = 0; i <= hX; i+=100)
                {
                    if (i == hX)
                        graph.DrawLine(PenFromGrafic, 0, (i - 1), wX, (i - 1));
                    else if (i == 0)
                        graph.DrawLine(PenFromGrafic, 0, (i + 0.1f), wX, (i + 0.1f));
                    else
                        graph.DrawLine(PenFromGrafic, 0, (hX - i), wX, (hX - i));

                    for (int w = 0; w <= wX; w+=100)
                    {
                        if (w == wX)
                            graph.DrawLine(PenFromGrafic, (w - 1), 0, (wX - 1), i);
                        else if(w == 0)
                            graph.DrawLine(PenFromGrafic, (w + 0.1f), 0, (w + 0.1f), i);
                        else
                            graph.DrawLine(PenFromGrafic, (wX - w), 0, (wX - w), i);
                    }
                }
            }
                
            
            Point start = new Point(1, 400);
            Point control1 = new Point((int)(x * 50), (int)(hX / y));
            Point control2 = new Point((int)(x* 50), (int)(hX - 30 * y));
            Point end = new Point((int)(x * 100 *t), (int)(hX - 30 * y));

            try
            {
                graph.DrawBezier(PenFromLine, start, control1, control2, end);
            }
            catch (System.OverflowException)
            {            }
            
            pictureBox1.Image = flag;
        }
            
        private void button_Clear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            x = 0;
            y = 0;
            angle = Math.PI / 180;        
            t = 10;                       
            V = 0;                                        
            text_angle.Text = "0";
            al = 0;
            track_angle.Value = 0;
            timer1.Start();
        }

        private void track_angle_Scroll(object sender, EventArgs e)
        {
                V =     track_angle.Value;
                al =    V * angle;
                t =     V / Math.Cos(al);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            text_angle.Text = (al).ToString();
            text_speed.Text = V.ToString();

            Invalidate();
        }   
    }

}
