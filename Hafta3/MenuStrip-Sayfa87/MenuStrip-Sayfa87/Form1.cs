using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_Sayfa87
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        //Kontroller menüsünün ekle seçeneği seçildiğinde yeni bir tane button kontrolu yaratılıyor
        int say, y = 30;

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button komut_dugmesi = new Button();
            komut_dugmesi.Top = y;
            komut_dugmesi.Left = 0;
            komut_dugmesi.Width = 150;
            say++;

            komut_dugmesi.Text = "Yeni komut dugmesi" + say.ToString();
            y += komut_dugmesi.Height + 5;

            komut_dugmesi.Click += new EventHandler(tıkla);

            //button kontrolu forma ekleniyor
            this.Controls.Add(komut_dugmesi);
        }


        //sil seçeneğine tıklandığında aktf olan kontrol siliniyor
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.ActiveControl);
        }

        private void tıkla(object sender, System.EventArgs e)
        {
            MessageBox.Show("Tıklandı");
        }
        

    }
}
