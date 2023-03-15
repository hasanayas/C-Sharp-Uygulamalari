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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int x;

        public System.Windows.Forms.TextBox textBox1;

        private void Form2_Load(object sender, EventArgs e)
        {

            //form başladıgında x değişkeninin değerini gösteriyor
            this.Text = "x degiskenin degeri = " + x.ToString();
        }
    }
}
