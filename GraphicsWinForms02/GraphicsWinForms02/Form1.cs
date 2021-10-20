using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsWinForms02
{
    public partial class Form1 : Form
    {
        private readonly int x0 = 0;
        private readonly int y0 = 0;

        public Bitmap bmp = new Bitmap(300, 300);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") textBox3.Text = Convert.ToString(0);
            Graphics graf = Graphics.FromImage(bmp);
            graf.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            graf.ScaleTransform(1, -1);
            Pen pen = new Pen(Color.Blue, 3);
            CircleDrawer circleDrawer = new CircleDrawer();
            graf.DrawLines(pen, circleDrawer.BresenhamCircle(x0, y0, int.Parse(textBox3.Text)));
            Point[] revPoint = circleDrawer.BresenhamCircle(x0, y0, int.Parse(textBox3.Text));
            for (int i = 0; i < CircleDrawer.count; i++)
            {
                int tenp = revPoint[i].X;
                revPoint[i].X = revPoint[i].Y;
                revPoint[i].Y = tenp;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.count; i++)
            {
                int tenp = revPoint[i].X;
                revPoint[i].X = -revPoint[i].Y;
                revPoint[i].Y = tenp;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.count; i++)
            {
                int tenp = revPoint[i].X;
                revPoint[i].X = revPoint[i].Y;
                revPoint[i].Y = tenp;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.count; i++)
            {
                revPoint[i].X *= -1;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.count; i++)
            {
                revPoint[i].Y *= -1;
            }
            graf.DrawLines(pen, revPoint);
            revPoint = circleDrawer.BresenhamCircle(x0, y0, int.Parse(textBox3.Text));
            for (int i = 0; i < CircleDrawer.count; i++)
            {
                revPoint[i].Y *= -1;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.count; i++)
            {
                revPoint[i].X *= -1;
            }
            graf.DrawLines(pen, revPoint);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") textBox3.Text = Convert.ToString(0);
            Graphics graf = Graphics.FromImage(bmp);
            graf.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            graf.ScaleTransform(1, -1);
            Pen pen = new Pen(Color.Red, 3);
            CircleDrawer CircleDrawer = new CircleDrawer();
            graf.DrawLines(pen, CircleDrawer.MichnerCircle(x0, y0, int.Parse(textBox3.Text)));
            pictureBox1.Image = bmp;
            Point[] revPoint = new Point[CircleDrawer.c];
            revPoint = CircleDrawer.MichnerCircle(x0, y0, int.Parse(textBox3.Text));
            for (int i = 0; i < CircleDrawer.c; i++)
            {
                int tenp = revPoint[i].X;
                revPoint[i].X = revPoint[i].Y;
                revPoint[i].Y = tenp;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.c; i++)
            {
                int tenp = revPoint[i].X;
                revPoint[i].X = -revPoint[i].Y;
                revPoint[i].Y = tenp;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.c; i++)
            {
                int tenp = revPoint[i].X;
                revPoint[i].X = revPoint[i].Y;
                revPoint[i].Y = tenp;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.c; i++)
            {
                revPoint[i].X *= -1;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.c; i++)
            {
                revPoint[i].Y *= -1;
            }
            graf.DrawLines(pen, revPoint);
            revPoint = CircleDrawer.MichnerCircle(x0,
            y0, int.Parse(textBox3.Text));
            for (int i = 0; i < CircleDrawer.c; i++)
            {
                revPoint[i].Y *= -1;
            }
            graf.DrawLines(pen, revPoint);
            for (int i = 0; i < CircleDrawer.c; i++)
            {
                revPoint[i].X *= -1;
            }
            graf.DrawLines(pen, revPoint);
            pictureBox1.Image = bmp;
        }
    }
}