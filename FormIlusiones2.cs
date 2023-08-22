using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramacionOrientadaAObjetos
{
    public partial class FormIlusiones2 : Form
    {
        Pen[] colores = { new Pen(Color.Red), 
            new Pen(Color.Yellow), new Pen(Color.Green), 
            new Pen(Color.Blue), new Pen(Color.Fuchsia), 
            new Pen(Color.Aqua), new Pen(Color.Sienna), 
            new Pen(Color.Brown) };

        public FormIlusiones2()
        {
            InitializeComponent();
        }

        private void FormIlusiones2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            for (int i = 0; i < w / 2; i += 10)
            {
                e.Graphics.DrawLine(colores[0], 0, i, i, h / 2);
                e.Graphics.DrawLine(colores[0], i, 0, w / 2, i);

                e.Graphics.DrawLine(colores[0], w - i, 0, w / 2, i);
                e.Graphics.DrawLine(colores[0], w, i, w - i, h / 2);

                e.Graphics.DrawLine(colores[0], 0, h / 2 + i, w / 2 - i, h / 2);
                e.Graphics.DrawLine(colores[0], i, h, w / 2, h - i);

                e.Graphics.DrawLine(colores[0], w / 2, h / 2 + i, w / 2 + i, h);
                e.Graphics.DrawLine(colores[0], w, h / 2 + i, w / 2 + i, h / 2);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)

        {
            int w = pictureBox8.Width;
            int h = pictureBox8.Height;
            for (int i = 0; i < w-20 ; i += 10)
              e.Graphics.DrawEllipse(colores[0], ((w-i)/2), ((h-i)/2), i, i);
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            for (int i = 0; i < w / 2; i += 10) { 
                e.Graphics.DrawLine(colores[2], w / 2, i, i, h - i);
            e.Graphics.DrawLine(colores[2], w / 2, i, w-i, h - i);
            e.Graphics.DrawLine(colores[2], i, h - i, w - i, h - i);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox3.Width;
            int h = pictureBox3.Height;
            for (int i = 0; i <= w / 2; i += 10)
            {
                e.Graphics.DrawLine(colores[2], i, 0, w / 2, i);
                e.Graphics.DrawLine(colores[2], i, h, w / 2, h - i);
                e.Graphics.DrawLine(colores[2], w / 2 + i, 0, w / 2, h / 2 - i);
                e.Graphics.DrawLine(colores[2], w / 2, h - i, w - i, h);
                e.Graphics.DrawLine(colores[2], i, h - i, w / 2 - i, h / 2 - i);
                e.Graphics.DrawLine(colores[2], w - i, h - i, w / 2 + i, h / 2 - i);
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox2.Width;
            int h = pictureBox2.Height;
            for (int i = 0; i < w; i += 10)
            {
                e.Graphics.DrawLine(colores[3], w / 2, i, i, h - i);
                e.Graphics.DrawLine(colores[3], w / 2, i, w - i, h - i);
                e.Graphics.DrawLine(colores[3], i, h - i, w - i, h - i);
            }
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox6.Width;
            int h = pictureBox6.Height;

            for (int i = 0; i < h / 2; i += 5)
            {
                e.Graphics.DrawLine(colores[4], 0, i, i, h);
                e.Graphics.DrawLine(colores[4], i, 0, w / 2, i);

                e.Graphics.DrawLine(colores[4], w - i, 0, w / 2, i);
                e.Graphics.DrawLine(colores[4], w, i, w - i, h);

                e.Graphics.DrawLine(colores[4], 0, h / 2 + i, w / 2 - i, h);
                e.Graphics.DrawLine(colores[4], i, h, w / 2, h - i);

                e.Graphics.DrawLine(colores[4], w / 2, h / 2 + i, w / 2 + i, h);
                e.Graphics.DrawLine(colores[4], w, h / 2 + i, w / 2 + i, h);
            }
    }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            {
                int w = pictureBox4.Width;
                int h = pictureBox4.Height;
                for (int i = 0; i < w - 20; i += 10)
                    e.Graphics.DrawRectangle(colores[0], ((w - i) / 2), ((h - i) / 2), i, i);

            }
        }
    }
}

