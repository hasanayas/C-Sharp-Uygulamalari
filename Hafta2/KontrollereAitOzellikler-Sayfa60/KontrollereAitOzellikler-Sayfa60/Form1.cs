using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrollereAitOzellikler_Sayfa60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_kisiadi.Text = "Serdar";
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            MessageBox.Show("Programla Bağlanti Saglandi", "Bağlanti durumu", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            MessageBox.Show("Programla olan baglanti Sonlandi", "Bağlanti durumu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
