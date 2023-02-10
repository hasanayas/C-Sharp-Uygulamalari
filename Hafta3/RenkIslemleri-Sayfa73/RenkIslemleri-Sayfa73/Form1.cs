using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenkIslemleri_Sayfa73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            label1.ForeColor = Color.Chocolate;
            numericUpDown1_red.Maximum = 255;
            numericUpDown2_green.Maximum = 255;
            numericUpDown3_blue.Maximum = 255;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        int red_deger, green_deger, blue_deger;

        private void numericUpDown1_red_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt16(numericUpDown1_red.Value);
            green_deger = Convert.ToInt16(numericUpDown2_green.Value);
           blue_deger = Convert.ToInt16(numericUpDown3_blue.Value);
            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics kare;
            kare = this.CreateGraphics();

            //kırmızı kare
            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 255, 0, 0)), 10, 10, 100, 100);

            //yeşil kare
            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 255, 0)), 90, 80, 100, 100);

            //mavi kare
            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 0,255)), 150, 10, 100, 100);

            kare.Dispose();
        }

        private void numericUpDown2_green_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt16(numericUpDown1_red.Value);
            green_deger = Convert.ToInt16(numericUpDown2_green.Value);
            blue_deger = Convert.ToInt16(numericUpDown3_blue.Value);
            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
        }

        private void numericUpDown3_blue_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt16(numericUpDown1_red.Value);
            green_deger = Convert.ToInt16(numericUpDown2_green.Value);
            blue_deger = Convert.ToInt16(numericUpDown3_blue.Value);
            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
        }
    }
}
