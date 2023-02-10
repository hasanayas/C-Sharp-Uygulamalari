using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaAitMetodlar_Sayfa88
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int orjinal_x = 800;
        int orjinal_y = 600;

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle cozunurluk = new Rectangle();
            cozunurluk = Screen.GetBounds(cozunurluk);
            float oranx, orany;
            oranx = (float)cozunurluk.Width / orjinal_x;
            orany = (float)cozunurluk.Height / orjinal_y;
            this.Left = 0;
            this.Top = 0;
            this.Scale(oranx, orany);
        }
    }
}
