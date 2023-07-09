using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modified_Sayfa105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            try
            {
                System.IO.TextReader dosya = System.IO.File.OpenText("C\\kayit.dat");
                string satir;

                while((satir = dosya.ReadLine()) != null)
                {
                    textBox1.Text += satir + (char)13 + (char)10;
                }
                dosya.Close();
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(textBox1.Modified == true)
            {
                DialogResult c;
                c = MessageBox.Show("Değişiklikler kaydedilsin mi?", "Çıkış",
                    MessageBoxButtons.YesNo);
                if (c == DialogResult.Yes)
                {
                    System.IO.TextWriter dosya = System.IO.File.CreateText("D:\\kayit.dat");
                    dosya.Write(textBox1.Text);
                    dosya.Close();
                }
            }
        }
    }
}
