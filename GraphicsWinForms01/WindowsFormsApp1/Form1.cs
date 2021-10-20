using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsWinForms01
{
    public partial class Form1 : Form
    {
        public Bitmap bmp = new Bitmap(599, 362);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (X1textBox1.Text == "") X1textBox1.Text = Convert.ToString(0);
            if (Y1textBox2.Text == "") Y1textBox2.Text = Convert.ToString(0);
            if (X2textBox3.Text == "") X2textBox3.Text = Convert.ToString(0);
            if (Y2textBox4.Text == "") Y2textBox4.Text = Convert.ToString(0);
            Graphics graf = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red, 10);
            DDA dDA = new DDA();
            graf.DrawLines(pen, dDA.Dda_line(float.Parse(X1textBox1.Text), float.Parse(Y1textBox2.Text),
            float.Parse(X2textBox3.Text), float.Parse(Y2textBox4.Text)));
            Console.WriteLine("===>> Before imp");
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (X1textBox1.Text == "") X1textBox1.Text = Convert.ToString(0);
            if (Y1textBox2.Text == "") Y1textBox2.Text = Convert.ToString(0);
            if (X2textBox3.Text == "") X2textBox3.Text = Convert.ToString(0);
            if (Y2textBox4.Text == "") Y2textBox4.Text = Convert.ToString(0);
            Graphics graf = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue, 10);
            Brazenhem brazenhem = new Brazenhem();
            graf.DrawLines(pen, brazenhem.BresenhamLine(int.Parse(X1textBox1.Text), int.Parse(Y1textBox2.Text),
            int.Parse(X2textBox3.Text), int.Parse(Y2textBox4.Text)));
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
