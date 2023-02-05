using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajPenceleri_Sayfa55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkmak istediğinizden emin misiniz", "Onay", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkmak istediğinizden emin misiniz", "Onay", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
           

        //private void button4_Click(object sender, EventArgs e)
        //{
           
        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Dosya silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Form Kapatılsın mı ?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
