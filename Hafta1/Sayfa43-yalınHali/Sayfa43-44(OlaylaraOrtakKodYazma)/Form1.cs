using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa43_44_OlaylaraOrtakKodYazma_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuc = 0;

            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            if ((sender as Button).Name == "button1")
            {
                sonuc = sayı1 + sayı2;
            }
            if ((sender as Button).Name == "button2")
            {
                sonuc = sayı1 - sayı2;
            }
            if ((sender as Button).Name == "button3")
            {
                sonuc = sayı1 * sayı2;
            }
            if ((sender as Button).Name == "button4")
            {
                sonuc = sayı1 / sayı2;
            }
            MessageBox.Show("İşlem sonucu=" + sonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }
    }
}
