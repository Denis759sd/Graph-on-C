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
        double angle = Math.PI /180;        //угол в радианах
        double al = 0;
        double t = 2;                       //Время
        double V = 0;                       //Скорость
        const int g = 10;                   //Ускорение свободного радения
        int h = 0;

        int wX;
        int hX;
        double xF, yF;
        double step;

        private Graphics graphics;

        bool isActive = false;

        Pen PenFromGrafic = new Pen(Brushes.Black); 
        Pen PenFromLine = new Pen(Brushes.Black, 2f); 

        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
            track_angle.Scroll += track_angle_Scroll;
            
            al = 60 * angle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, new Rectangle((int)(50 * x), (int)(400 - 50 * y), 5, 5));
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            h = (int)V * (int)V / 2 / g;

            wX = pictureBox1.Width;
            hX = pictureBox1.Height;

            x = (V * Math.Cos(al)) * t;
            y = (V * Math.Sin(al)) * t - g * t * t / 2;

            Bitmap flag = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(flag);
            if (check_cell.Checked == true)
            {
                graph.DrawLine(PenFromGrafic, 0, (int)((hX / 4) - 100), wX, (int)((hX / 4) - 100));
                graph.DrawLine(PenFromGrafic, 0, (int)(hX / 4), wX, (int)(hX / 4));
                graph.DrawLine(PenFromGrafic, 0, (int)(hX / 2), wX, (int)(hX / 2));
                graph.DrawLine(PenFromGrafic, 0, (int)(hX / 1.25) - 20, wX, (int)(hX / 1.25) - 20);
                graph.DrawLine(PenFromGrafic, 0, (int)(hX / 1) - 1, wX, (int)(hX / 1) - 1);

                graph.DrawLine(PenFromGrafic, (int)(wX / 2), 0, (int)(wX / 2), hX);
                graph.DrawLine(PenFromGrafic, (int)(wX / 1) - 1, 0, (int)(wX / 1) - 1, hX);
                graph.DrawLine(PenFromGrafic, (int)(wX / 6) - 100, 0, (int)(wX / 6) - 100, hX);
                graph.DrawLine(PenFromGrafic, (int)(wX / 3), 0, (int)(wX / 3), hX);
                graph.DrawLine(PenFromGrafic, (int)(wX / 4) - 50, 0, (int)(wX / 4) - 50, hX);
                graph.DrawLine(PenFromGrafic, (int)(wX / 1.5), 0, (int)(wX / 1.5), hX);
                graph.DrawLine(PenFromGrafic, (int)(wX / 1.2), 0, (int)(wX / 1.2), hX);
            }
                
            
            Point start = new Point(1, 400);
            Point control1 = new Point((int)x, (int)(h / y));
            Point control2 = new Point((int)x, (int)(h / y));
            Point end = new Point((int)(x +V), hX - 1);

            //graph.FillRectangle(Brushes.Black, new Rectangle((int)(50 * x), (int)(400 - 50 * y),5,5));
            //graph.DrawBezier(PenFromLine, 1, 400, wX/2, hX/2, (int)(50 * x), (int)(400 - 50 * y), 0, 0);
            graph.DrawBezier(PenFromLine, start, control1, control2, end);
            pictureBox1.Image = flag;
        }

        private void button_Start_Click(object sender, EventArgs e) => Start(true);

            
        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            x = 0;
            y = 0;
            t = 0;
            V = 0;
            angle = 0;
            track_angle.Value = 0;
        }

        private void Start(bool active)
        {
            if (active == true)
            {
                this.Paint += new PaintEventHandler(Draw);
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;
                timer1.Interval = 50;
            }
            else
                return;
        }

        private void track_angle_Scroll(object sender, EventArgs e)
        {
            angle = track_angle.Value;
            //sal = track_angle.Value * angle;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                V = Convert.ToDouble(textBox1.Text);
            }
            catch (System.FormatException) { }
                     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            text_angle.Text = Math.Round(angle /al).ToString();

           //t += 0.01;
           //x = (V * Math.Cos(al)) * t;
           //y = (V * Math.Sin(al)) * t - g * t * t/2;
           //this.Text = x.ToString() + " " + y.ToString() + " " + "Время: " + t + "Скорость: " + V;
           //Invalidate();
        }   
    }

}
