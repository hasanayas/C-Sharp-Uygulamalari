using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cokSecimliListeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
                
        }

        private void btn_siil_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show(listBox1.SelectedIndices.Count.ToString() +
                " eleman silinsin mi", "Sil", MessageBoxButtons.YesNo);

            if( c == DialogResult.Yes)
            {
                for ( int i =listBox1.SelectedIndices.Count-1; i >=0; i--)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);

                }
            }
        }

        private void btn_sagaAktar_Click(object sender, EventArgs e)
        {
            for ( int i = listBox1.SelectedIndices.Count-1; i>=0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);

                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void btn_solaAktar_Click(object sender, EventArgs e)
        {

            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);

                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }
    }
}
