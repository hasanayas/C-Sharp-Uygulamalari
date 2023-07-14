using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DosyaYazmaOkuma_Sayfa226_227
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            listBox_adisoyadi.Items.Add(Txt_adisoyadi.Text);
           listBox_bolumu.Items.Add(Txt_bolumu.Text);
            listBox_babaadi.Items.Add(Txt_babaadi.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter bilgiyaz = System.IO.File.CreateText("C:\\bilgi_kayit.dat");

            for ( int i =0; i<listBox_adisoyadi.Items.Count; i++)
            {
                bilgiyaz.WriteLine(listBox_adisoyadi.Items[i]);
                bilgiyaz.WriteLine(listBox_bolumu.Items[i]);
                bilgiyaz.WriteLine(listBox_babaadi.Items[i]);
            }

            bilgiyaz.Close();
        }
    }
}
