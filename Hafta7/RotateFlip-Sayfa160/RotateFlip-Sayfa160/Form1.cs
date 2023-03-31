using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotateFlip_Sayfa160
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image resim;
            resim = (Image)pictureBox1.Image.Clone();
            resim.RotateFlip((RotateFlipType)comboBox1.SelectedItem);
            pictureBox2.Image = resim;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0;  i < 7 ; i++)
            {
                comboBox1.Items.Add((RotateFlipType)i);
            }
        }
    }
}
