using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenSinifi_Sayfa233_234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem1 = new Pen(Color.Red, 10);
            e.Graphics.DrawLine(kalem1, 20, 20, 200, 20);

            Pen kalem2 = new Pen(new System.Drawing.Drawing2D.HatchBrush(
                System.Drawing.Drawing2D.HatchStyle.Cross, Color.Aqua), 10);
            e.Graphics.DrawLine(kalem2, 20, 50, 200, 50);


            Pen kalem3 = new Pen(Color.Red, 10);
            kalem3.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;


            Pen kalem4 = new Pen(new System.Drawing.Drawing2D.HatchBrush(
           System.Drawing.Drawing2D.HatchStyle.LightHorizontal, Color.Aqua), 10);
            e.Graphics.DrawLine(kalem2, 20, 80, 200, 80);



            Pen kalem5 = new Pen(Color.Red, 10);
            kalem5.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            e.Graphics.DrawLine(kalem2, 20, 140, 200, 140);

        }
    }
}
