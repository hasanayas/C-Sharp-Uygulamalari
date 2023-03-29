using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectedIndexChanged_Sayfa128_129
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eleman_tiklanirsa(object sender, EventArgs e)
        {
            int indis;

            indis = (sender as ListBox).SelectedIndex;

            //diğer listelerde de aynı eleman seçimleri yapılıyor

            listBox1.SelectedIndex = indis;
            listBox2.SelectedIndex = indis;
            listBox3.SelectedIndex = indis;

            int top_indis;
            top_indis = (sender as ListBox).TopIndex;
            listBox1.TopIndex = top_indis;
            listBox2.TopIndex = top_indis;
            listBox3.TopIndex = top_indis;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
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
