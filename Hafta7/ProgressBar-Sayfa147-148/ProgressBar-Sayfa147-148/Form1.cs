using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar_Sayfa147_148
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //rasgele 1-100 arasında 1000 tane sayı üretilerek
            //listBox1 kontrolunde gosteriliyor
            Random random = new Random();
            for (int i = 0; i < 500; i++)
            {
                int rasgele_sayi = random.Next(100);
                listBox1.Items.Add(rasgele_sayi.ToString());
            }
            //progressBar değerleri ayarlanıyor
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslama_zamani, bitis_zamani;
            TimeSpan fark;
            this.Text = "Lütfen bekleyiniz";
            baslama_zamani = DateTime.Now;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    int sayi1, sayi2;
                    sayi1 = Convert.ToInt16(listBox1.Items[i]);
                    sayi2 = Convert.ToInt16(listBox1.Items[j]);
                    if (sayi2 > sayi1)
                    {
                        int c = sayi2;
                        sayi2 = sayi1;
                        sayi1 = c;
                        listBox1.Items[i] = sayi1.ToString();
                        listBox1.Items[j] = sayi2.ToString();
                    }
                }
                progressBar1.Value = i;
            }
            //zaman farkı alınıyor
            bitis_zamani = DateTime.Now;
            fark = bitis_zamani - baslama_zamani;
            this.Text = "İşlem Süresi" + fark.ToString().Substring(0, 8);
        }
    }
}
