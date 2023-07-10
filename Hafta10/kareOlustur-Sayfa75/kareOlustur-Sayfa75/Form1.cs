using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kareOlustur_Sayfa75
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics kare;
            kare = this.CreateGraphics();

            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 255, 0, 0)), 10, 10, 100, 100);

            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 255, 0)), 90, 50, 100, 100);

            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 0, 255)), 150, 10, 100, 100);

            kare.Dispose();


        }
    }
}
