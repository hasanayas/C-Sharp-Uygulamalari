using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vScrollBar_hScrollBar_Sayfa216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 200;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 200;
        }

   

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            textBox1.Top = e.NewValue;
        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            textBox1.Left = e.NewValue;
        }
    }
}
