using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa43_olaylaraOrtakKodYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void islem(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            if ((sender as Button).Name == "button1")
            {
                sonuc = sayi1 + sayi2;
            }

            if ((sender as Button).Name == "button2")
            {
                sonuc = sayi1 - sayi2;
            }

            if ((sender as Button).Name == "button3")
            {
                sonuc = sayi1 * sayi2;
            }

            if ((sender as Button).Name == "button4")
            {
                sonuc = sayi1 / sayi2;
            }

            MessageBox.Show("İşlem sonucu= " + sonuc.ToString());
        }
    }
}
