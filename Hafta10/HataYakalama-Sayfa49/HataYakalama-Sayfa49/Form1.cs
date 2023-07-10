using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataYakalama_Sayfa49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi = -25;
            decimal sonuc =0;

            try
            {
                sonuc = Convert.ToDecimal(Math.Sqrt((double)sayi));

            }

            catch
            {
                MessageBox.Show("Negatif bir sayının karekök alma işlemi gerçekleştirilemez");

            }
        }
    }
}
