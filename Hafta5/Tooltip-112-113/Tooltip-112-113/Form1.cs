using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooltip_112_113
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Buraya ad girişi yapılacaktır");
            toolTip1.SetToolTip(textBox2, "Sınav notunu giriniz." + "(Not değeri 100'den büyük olamaz");
            toolTip1.SetToolTip(textBox3, "Mail adresini giriniz.");
            toolTip1.SetToolTip(textBox4, "Araç plakasını girerken boşluk vermeyi unutmayınız."+ "(41 AD 558 gibi)");
            toolTip1.SetToolTip(textBox5, "Telefon numaranızı giriniz. (252 311 3443 gibi)");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
