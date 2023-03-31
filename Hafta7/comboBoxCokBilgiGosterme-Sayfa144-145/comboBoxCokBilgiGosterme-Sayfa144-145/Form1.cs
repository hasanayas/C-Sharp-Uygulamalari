using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBoxCokBilgiGosterme_Sayfa144_145
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class iller
        {
            //sınıf içinde veri tanımlamayı kolaylaştırmak 
            //için constructor tanımlanabilir
            //ancak bu şart degildir

            public string adi;
            public string plaka;
            //2 parametreli constructor
            public iller(string adi, string plaka)
            {
                this.adi = adi;
                this.plaka = plaka;
            }
            //parametresiz constructor
            public iller()
            {
                adi = "";
                plaka = "";

            }
            //bu türden nesnelerin liste içerisinde nasıl gösterildigini belirlemek için veri yapısına tostring metodu eklenmelidir
            public override string ToString()
            {
                return plaka + " " + adi;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iller[] il = {new iller("İzmit", "41"),
                         new iller("Ankara", "06"),
                         new iller("Edirne", "22"),
                         new iller("İstanbul", "34"),
                         new iller("Düzce", "81")   };
            comboBox1.Items.AddRange(il);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //oluşan class burda kullanılıyor
            if (comboBox1.SelectedIndex < 0)
            {
                return;
            }

            label4.Text = ((iller)comboBox1.SelectedItem).adi;
            label5.Text = ((iller)comboBox1.SelectedItem).plaka;
        }
    }
}
