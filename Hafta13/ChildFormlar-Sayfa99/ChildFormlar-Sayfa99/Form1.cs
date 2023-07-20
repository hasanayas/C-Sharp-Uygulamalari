using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildFormlar_Sayfa99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yeniFormSayisi = 0;
        private void toolStrip1_Click(object sender, EventArgs e)
        {
            yeniFormSayisi++;
            Form2 cocukForm = new Form2();
            cocukForm.MdiParent = this;
            cocukForm.Text = "Yeni Form" + yeniFormSayisi.ToString();
            cocukForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            yeniFormSayisi++;
            Form2 cocukForm = new Form2();
            cocukForm.MdiParent = this;
            cocukForm.Text = "Yeni Form" + yeniFormSayisi.ToString();
            cocukForm.Show();
        }
    }
}
