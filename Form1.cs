using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace virtualreality
{
    public partial class Form1 : Form
    {
        private Image i; Bitmap b; int value = 0; int value2 = 0; int xx = 0; int yy = 0; Graphics ee;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == 0)
            {

                int v = value & 1;
                
                ee = Graphics.FromImage(b);
                Pen a = new Pen(Color.FromArgb(0, 0, 0));
                Pen c = new Pen(Color.FromArgb(255, 255, 255));
                ee.Clear(Color.FromArgb(255, 255, 255));
                ee.DrawLine(a, e.X, 0, e.X, pictureBox1.Height);
                ee.DrawLine(a, 0, e.Y, pictureBox1.Width, e.Y);
                a.Dispose();
                c.Dispose();
                ee.Dispose();
                pictureBox1.Refresh();

                

               
               
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            


        }
    }
}
