using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxFontVeRenkler_Sayfa142
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bilgisayardaki fontları diziye alma

            FontFamily[] fontlar_listesi = FontFamily.Families;

            //fontları listeye aktarır
            for (int i=0; i<= fontlar_listesi.GetUpperBound(0); i++)
            {
                comboBox1.Items.Add(fontlar_listesi[i].Name);
            }

            //ilk eleman seçili olsun
            comboBox1.SelectedIndex = 0;

            //font büyüklüğünü combobax 2 ye aktar 8-100 arası
            
            for(int i =8; i<=100; i++)
            {
                comboBox2.Items.Add(i);
            }

            //ilk eleman seçili olsun 
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Font = new Font(comboBox1.Text.ToString(),
                    float.Parse(comboBox2.Text),
                    FontStyle.Regular);
            }

            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
