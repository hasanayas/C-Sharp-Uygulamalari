using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koordinat_Sayfa65_66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;

            numericUpDownSol.Maximum = 500;
            numericUpDownUst.Maximum = 500;
            numericUpDownGenislik.Maximum = 500;
            numericUpDownYukseklik.Maximum = 500;

            numericUpDownSol.Value = textBox1.Left;
            numericUpDownUst.Value = textBox1.Top;
            numericUpDownGenislik.Value = textBox1.Width;
            numericUpDownYukseklik.Value = textBox1.Height;

        }

        private void numericUpDownSol_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Left = (int)numericUpDownSol.Value;
        }

        private void numericUpDownUst_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Top = (int)numericUpDownUst.Value;
        }

        private void numericUpDownGenislik_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Width = (int)numericUpDownGenislik.Value;
        }

        private void numericUpDownYukseklik_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Height = (int)numericUpDownYukseklik.Value;
        }
    }
}
