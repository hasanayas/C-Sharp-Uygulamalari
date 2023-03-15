using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contains_Findstring_Sayfa124_125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            listBox1.Items.AddRange(gunler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ekle;
            ekle = textBox1.Text;

            if (listBox1.Items.Contains(ekle) == true)
            {
                MessageBox.Show("Bu kelime zaten listede var");
            }
               

            else if (listBox1.Items.Contains(ekle) == false)
            {
                MessageBox.Show(ekle + " kelimesi listeye eklenmiştir");
                listBox1.Items.Add(ekle);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            listBox2.Items.AddRange(gunler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ekle;
            ekle = textBox1.Text;


            //büyük küçük harf duyarlılığı ayrımı yapmadan kelime aranacaktır. Listede yoksa -1 döndürecektir


            if(listBox2.FindString(ekle) > -1)
            {
                MessageBox.Show("bu kelime zaten listede var");
            }

            else if (listBox2.FindString (ekle) == -1)
            {
                MessageBox.Show(ekle + " kelimesi listeye eklenmiştir.");
                listBox1.Items.Add(ekle);
            }
        }
    }
}
