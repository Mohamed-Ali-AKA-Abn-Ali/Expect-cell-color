using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.BackColor = colorDialog1.Color;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r = 0, g=0,b=0;
            r= (pictureBox1.BackColor.R* 2 / 7 ) + (pictureBox2.BackColor.R * 2 / 7) + (pictureBox4.BackColor.R * 3 / 14 )+( pictureBox5.BackColor.R * 3 / 14);
            g = (pictureBox1.BackColor.G * 2 / 7) + (pictureBox2.BackColor.G * 2 / 7) + (pictureBox4.BackColor.G * 3 / 14) + (pictureBox5.BackColor.G * 3 / 14);
            b = (pictureBox1.BackColor.B * 2 / 7) + (pictureBox2.BackColor.B * 2 / 7) + (pictureBox4.BackColor.B * 3 / 14) + (pictureBox5.BackColor.B * 3 / 14);
            pictureBox3.BackColor = Color.FromArgb(r,g,b);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int r1 = pictureBox1.BackColor.R, r2 = pictureBox2.BackColor.R, r3 = pictureBox3.BackColor.R, r4 = pictureBox4.BackColor.R, r5 = pictureBox5.BackColor.R;
            int g1 = pictureBox1.BackColor.G, g2 = pictureBox2.BackColor.G, g3 = pictureBox3.BackColor.G, g4 = pictureBox4.BackColor.G, g5 = pictureBox5.BackColor.G;
            int b1 = pictureBox1.BackColor.B, b2 = pictureBox2.BackColor.B, b3 = pictureBox3.BackColor.B, b4 = pictureBox4.BackColor.B, b5 = pictureBox5.BackColor.B;
            label1.Text=  ("RGB= (" + r1 + "," + g1 + "," + b1+")");
            label2.Text = ("RGB= (" + r2 + "," + g2 + "," + b2+")");
            label3.Text = ("RGB= (" + r3 + "," + g3 + "," + b3+")");
            label4.Text = ("RGB= (" + r4 + "," + g4 + "," + b4+")");
            label5.Text = ("RGB= (" + r5 + "," + g5 + "," + b5+")");



        }
    }
}
