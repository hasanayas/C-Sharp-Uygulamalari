using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadOnly_Sayfa104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text == "1234")
            {
                txtAd.ReadOnly = false;
                txtSoyad.ReadOnly = false;
            }
            else
            {
                txtAd.ReadOnly = true;
                txtSoyad.ReadOnly = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtAd.ReadOnly = true;
            txtSoyad.ReadOnly = true;
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            {
                textBox1.Undo();
            }
            else
            {
                MessageBox.Show("Geri alma işleminiz gerçekleştirilemez");
            }
        }
    }
}
