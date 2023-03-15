using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxItemsClear_ItemsIndexOf_Sayfa123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listede " + listBox1.Items.Count + " tane eleman vardır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranan;
            aranan = textBox1.Text;

            int yer;
            yer = listBox1.Items.IndexOf(aranan);

            if(yer < 0)
            {
                MessageBox.Show("aradığınız kelime bulunamamıştır");
            }

            else
            {
                MessageBox.Show("Aradığınız kelime " + (yer + 1)+ " sırasındadır.");
            }
        }
    }
}
