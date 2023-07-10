using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelRenkKontrolu_Sayfa74_75
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownRed.Maximum = 255;
            numericUpDownGreen.Maximum = 255;
            numericUpDownBlue.Maximum = 255;
        }


        int red_deger, green_deger, blue_deger;
        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt16(numericUpDownRed.Value);
            green_deger = Convert.ToInt16(numericUpDownGreen.Value);
            blue_deger = Convert.ToInt16(numericUpDownBlue.Value);
            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt16(numericUpDownRed.Value);
            green_deger = Convert.ToInt16(numericUpDownGreen.Value);
            blue_deger = Convert.ToInt16(numericUpDownBlue.Value);
            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt16(numericUpDownRed.Value);
            green_deger = Convert.ToInt16(numericUpDownGreen.Value);
            blue_deger = Convert.ToInt16(numericUpDownBlue.Value);
            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
        }
    }
}
