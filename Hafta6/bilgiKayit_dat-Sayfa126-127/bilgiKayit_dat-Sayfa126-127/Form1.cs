using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiKayit_dat_Sayfa126_127
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // her üç listeye 3 textbox kontrolündeki bilgiler ekleniyor
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //dosya oluşturma

            System.IO.TextWriter bilgiyaz = System.IO.File.CreateText("C:\\Users\\NORA JDK\\Desktop\\Yeni klasör\\bilgi_kayit.txt");
            for(int i =0; i<listBox1.Items.Count; i++)
            {
                bilgiyaz.WriteLine(listBox1.Items[i]);
                bilgiyaz.WriteLine(listBox2.Items[i]);
                bilgiyaz.WriteLine(listBox3.Items[i]);
            }

            MessageBox.Show("Bilgiler klosore kaydedildi");
            // dosya kapatiliyor
            bilgiyaz.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.TextReader bilgioku = System.IO.File.OpenText("C:\\bilgi_kayit.dat");
                string satir;
                while ( (satir = bilgioku.ReadLine()) != null)
                {
                    listBox1.Items.Add(satir);

                    satir = bilgioku.ReadLine(); //bir alttaki satiri oku
                    listBox2.Items.Add(satir);

                    satir = bilgioku.ReadLine(); //bir alttaki satiri oku
                    listBox3.Items.Add(satir);
                }
                //dosyayi kapat
                bilgioku.Close();
            }

            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indis;
            indis = listBox1.SelectedIndex;
            if (indis < 0)
            {
                MessageBox.Show("Silinecek elemani seçiniz");

            }

            else
            {
                listBox1.Items.RemoveAt(indis);
                listBox2.Items.RemoveAt(indis);
                listBox3.Items.RemoveAt(indis);
            }
        }
    }
}
