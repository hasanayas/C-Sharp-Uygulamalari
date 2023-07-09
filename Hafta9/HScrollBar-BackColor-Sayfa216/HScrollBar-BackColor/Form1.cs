using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HScrollBar_BackColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar_kirmizi.Maximum = 264;
            hScrollBar_mavi.Maximum = 264;
            hScrollBar_yesil.Maximum = 264;
        }

       

        private void hScrollBar_kirmizi_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(hScrollBar_kirmizi.Value,
                hScrollBar_mavi.Value, hScrollBar_yesil.Value);

            label4.Text = hScrollBar_kirmizi.Value.ToString();
            label5.Text = hScrollBar_yesil.Value.ToString();
            label6.Text = hScrollBar_mavi.Value.ToString();
        }

        private void hScrollBar_yesil_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(hScrollBar_kirmizi.Value,
              hScrollBar_mavi.Value, hScrollBar_yesil.Value);

            label4.Text = hScrollBar_kirmizi.Value.ToString();
            label5.Text = hScrollBar_yesil.Value.ToString();
            label6.Text = hScrollBar_mavi.Value.ToString();
        }

        private void hScrollBar_mavi_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(hScrollBar_kirmizi.Value,
              hScrollBar_mavi.Value, hScrollBar_yesil.Value);

            label4.Text = hScrollBar_kirmizi.Value.ToString();
            label5.Text = hScrollBar_yesil.Value.ToString();
            label6.Text = hScrollBar_mavi.Value.ToString();
        }
    }
}
