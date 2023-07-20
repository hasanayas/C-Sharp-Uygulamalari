using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataYakalama2_Sayfa50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi1 = 5, sayi2 = 0;
            decimal sonuc = 0;
            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch (System.DivideByZeroException hata)
            {
                MessageBox.Show("Sıfıra bölme hatasi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal sonuc = 0;

            try
            {
                sonuc = Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(textBox2.Text);
            }

            catch (System.DivideByZeroException hata)
            {
                MessageBox.Show("sıfıra bölme hatasi");
            }

            catch (Exception hata)
            {
                MessageBox.Show("sayi girilmedi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal sayi1 = 5, sayi2 = 0;
            decimal sonuc = 0;

            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Program bir hatayla karşılaştı. Hata nedeni" +
                    "aşağıda belirtilmiştir. \r\n" + hata.Message);

            }
        }
    }
}
