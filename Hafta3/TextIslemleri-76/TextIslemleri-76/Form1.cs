using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextIslemleri_76
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        decimal sayi1 = 0, sayi2 = 0, sonuc =0;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDecimal(textBox5.Text);
            sayi2 = Convert.ToDecimal(textBox3.Text);
            sonuc = sayi1 * sayi2;
            textBox4.Text = sonuc.ToString();
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDecimal(textBox5.Text);
            sayi2 = Convert.ToDecimal(textBox3.Text);
            sonuc = sayi1 * sayi2;
            textBox4.Text = sonuc.ToString();
        }

        
    }
}
