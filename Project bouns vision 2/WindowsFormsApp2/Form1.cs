/*made by:
Kirolos Osama Ayad                    191900016
Abanoub Ibrahim thabet                191900276   */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int r = 0, g = 0, b = 0;
            r = (button1.BackColor.R * 2 / 7) + (button2.BackColor.R * 2 / 7) + (button3.BackColor.R * 3 / 14) + (button4.BackColor.R * 3 / 14);
            g = (button1.BackColor.G * 2 / 7) + (button2.BackColor.G * 2 / 7) + (button3.BackColor.G * 3 / 14) + (button4.BackColor.G * 3 / 14);
            b = (button1.BackColor.B * 2 / 7) + (button2.BackColor.B * 2 / 7) + (button3.BackColor.B * 3 / 14) + (button4.BackColor.B * 3 / 14);
            button5.BackColor = Color.FromArgb(r, g, b);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int r1, r2, r3, r4, r5, g1, g2, g3, g4, g5, b1, b2, b3, b4, b5;
            r1 = button1.BackColor.R; 
            r2 = button2.BackColor.R;
            r3 = button3.BackColor.R;
            r4 = button4.BackColor.R;
            r5 = button5.BackColor.R;
            g1 = button1.BackColor.G;
            g2 = button2.BackColor.G;
            g3 = button3.BackColor.G;
            g4 = button4.BackColor.G;
            g5 = button5.BackColor.G;
            b1 = button1.BackColor.B;
            b2 = button2.BackColor.B;
            b3 = button3.BackColor.B;
            b4 = button4.BackColor.B;
            b5 = button5.BackColor.B;
            label1.Text = ("(" + r1 + "," + g1 + "," + b1 + ")");
            label2.Text = ("(" + r2 + "," + g2 + "," + b2 + ")");
            label3.Text = ("(" + r3 + "," + g3 + "," + b3 + ")");
            label4.Text = ("(" + r4 + "," + g4 + "," + b4 + ")");
            label5.Text = ("(" + r5 + "," + g5 + "," + b5 + ")");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
