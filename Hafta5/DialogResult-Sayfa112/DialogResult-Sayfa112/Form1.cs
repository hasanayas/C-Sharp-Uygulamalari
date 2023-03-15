using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResult_Sayfa112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
                Form2 kayit_formu = new Form2();
                DialogResult c;
                kayit_formu.Text = "Çıkış ekranı";
                c = kayit_formu.ShowDialog();

                if (c == DialogResult.Yes)
                {
                    //textBox1 kontrolündeki bilgiler kayit.dat dosyasına kaydediliyor.
                    System.IO.TextWriter dosya = System.IO.File.CreateText("C:\\kayit.dat");
                    dosya.Write(textBox1.Text);
                    dosya.Close();
                }

                if (c == DialogResult.No)
                {
                    //hayır seçildiyse kayıt işlemi yapılmayacak
                    //buraya herhangi bir kod bloğu yazılmaz
                }

                if (c == DialogResult.Cancel)
                {
                    //çıkış işlemi iptal edilip Form1'e geri dönülüyor.
                    e.Cancel = true;
                }
            
        }
    }
}
