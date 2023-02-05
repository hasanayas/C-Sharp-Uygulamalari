using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataAyıklama_Sayfa49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi = -25;
            decimal sonuc = 0;
            try
            {
                sonuc = Convert.ToDecimal(Math.Sqrt((double)sayi));
            }
            catch
            {
                MessageBox.Show("Negatif bir sayinin karekök alma işlemi gerçekleşmiştirilemez");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal sayi1 = 5, sayi2 = 0;
            decimal sonuc = 0;
            try
            {
                sonuc = sayi1 / sayi2;
            }

            catch (System.DivideByZeroException hata)
            {
                MessageBox.Show("Sıfıra bölme hatası");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal sonuc = 0;
            try
            {
                sonuc = Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(textBox2.Text);

            }
            catch (System.DivideByZeroException hata)
            {
                MessageBox.Show("Sıfıra Bölme Hatası");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Sayı Girilmedi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal sayi3 = 5, sayi2 = 0;
            decimal sonuc = 0;
            try
            {
                sonuc = sayi3 / sayi2;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Program bir hatayla karşilaşti Hatanin nedeni" + "aşagıda belirtilmiştir. \r\n" + hata.Message);
                //\r\n tanımıyla alt satır başına geçiş yapılması sağlanmıştır
            }
        }
    }
}
