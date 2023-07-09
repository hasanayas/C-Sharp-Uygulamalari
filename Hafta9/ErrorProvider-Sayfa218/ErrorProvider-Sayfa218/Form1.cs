using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider_Sayfa218
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt16(textBox2.Text) > 100)
            {
                errorProvider1.SetError(textBox2, "100'den büyük değer girilmez");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }
    }
}
