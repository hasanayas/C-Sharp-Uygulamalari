using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlaraSekilVerme_Sayfa95_97
{
    public partial class Form_Paint : Form
    {
        public Form_Paint()
        {
            InitializeComponent();
        }

        private void Form_Paint_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath grafik_sekil;
            grafik_sekil = new System.Drawing.Drawing2D.GraphicsPath();

            //0,0 noktasından 90 piksel dikdörtgen çizliyor

            grafik_sekil.AddRectangle(new Rectangle(0, 0, this.ClientSize.Width, 90));

            //72 punto büyüklüğünde Tohoma fontuyla kalır olarak bizim formumuz yaz
            grafik_sekil.AddString("Bizim Formumuz", new FontFamily("Tahoma"), (int)FontStyle.Bold, (float)72, new PointF(0, 100),
                new StringFormat(StringFormat.GenericDefault));

            // formun altına formun genişliği kadar 90 pixel yksekliğinde bir dikdörtgen çiziliyor

            grafik_sekil.AddRectangle(new Rectangle(0, this.ClientSize.Height - 90, this.ClientSize.Width, 90));

            //bu şekli forma uygula

            this.Region = new Region(grafik_sekil);
        }


        Point tiklanan_nokta;

        private void Form_Paint_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);
        }

        private void Form_Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point koordinatlar;
                koordinatlar = Control.MousePosition;
                koordinatlar.Offset(-tiklanan_nokta.X, -tiklanan_nokta.Y);
                this.Location = koordinatlar;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
