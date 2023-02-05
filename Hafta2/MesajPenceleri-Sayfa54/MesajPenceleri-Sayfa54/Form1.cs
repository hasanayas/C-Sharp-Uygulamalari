using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajPenceleri_Sayfa54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //MessageBox.Show(Mesaj)
        {

            MessageBox.Show("Visual C#.Net 2008");
        }

        private void button2_Click(object sender, EventArgs e) //MessageBox.Show(Mesaj,Başlık)
        {
            MessageBox.Show("Visual C#.Net 2008", "Hoşgeldin");
        }

        private void button3_Click(object sender, EventArgs e) //MessageBox.Show(Mesaj,Başlık,Düğmeler)
        {
            MessageBox.Show("Çıkmak İstediğinizden emin misiniz", "Onay", MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkmak İstediğinizden emin misiniz", "Onay", MessageBoxButtons.AbortRetryIgnore); //MessageBox.Show(Mesaj,Başlık,Düğmeler)
        }

        //MessageBox.Show(Mesaj,Başlık,Düğmeler,Simge)

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkmak İstediğinizden emin misiniz", "Onay", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
        }

    }
}
