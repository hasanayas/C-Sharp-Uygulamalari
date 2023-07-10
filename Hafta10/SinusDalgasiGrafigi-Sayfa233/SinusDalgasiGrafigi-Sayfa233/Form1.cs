using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinusDalgasiGrafigi_Sayfa233
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int xorta, yorta, xmax, ymax;
            xorta = this.ClientSize.Width / 2;
            yorta = this.ClientSize.Height / 2;
            xmax = this.ClientSize.Width;
            ymax = this.ClientSize.Height;

            e.Graphics.Clear(this.BackColor);

            e.Graphics.DrawLine(new Pen(Color.Red, 3), xorta, 0, xorta, ymax);
            e.Graphics.DrawLine(new Pen(Color.Red, 3), 0, yorta, xmax, yorta);

            float x, y, x1, y1;
            for (x = -this.ClientSize.Width / 2; x < this.ClientSize.Width / 2; x += 0.1f) ;
            {
                y = (float)(x * Math.Sin(x * Math.PI / 180));

                x1 = x + xorta;
                y1 = -y + yorta;
                e.Graphics.DrawLine(new Pen(Color.Blue, 4), x1, y1, x1 + 1, y1);

            }
        }
    }
}
