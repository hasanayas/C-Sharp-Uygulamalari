using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilinenCizimler_Sayfa231
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            ciz(g);
        }
        private void ciz(Graphics gr)
        {
            float x, y;
            x = this.ClientSize.Width / 2;
            y = this.ClientSize.Height / 2;
            for (int i = 0; i < this.ClientSize.Width / 2; i += 20)
            {
                gr.DrawEllipse(new Pen(Color.Blue), x - i, y - i, i * 2, i * 2);
            }
        }
    }
}
