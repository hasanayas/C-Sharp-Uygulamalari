using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoordinatSistemi_Sayfa232
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Red, 4), 0, 0, ClientSize.Width, ClientSize.Height);

            //    e.Graphics.DrawLine(new Pen(Color.Red, 4), ClientSize.Width, 0, 0, ClientSize.Height);
        }
    }
}
