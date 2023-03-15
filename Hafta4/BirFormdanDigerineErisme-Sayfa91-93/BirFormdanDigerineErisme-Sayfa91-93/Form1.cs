using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirFormdanDigerineErisme_Sayfa91_93
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

        private System.Windows.Forms.Button button1;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ikinci_form = new Form2();
            ikinci_form.x = 100;
            ikinci_form.textBox2.Text = "Formlar arası aktarım başarılı";
            ikinci_form.Show();
        }
    }
}
