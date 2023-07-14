using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyadanOku_Sayfa227
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.TextReader bilgioku = System.IO.File.OpenText("C:\\bilgi_kayit.dat");
                string satir;

                while((satir = bilgioku.ReadLine()) != null)
                {
                    listBox_adisoyadi.Items.Add(satir);

                    satir = bilgioku.ReadLine();
                    listBox_bolumu.Items.Add(satir);

                    satir = bilgioku.ReadLine();
                    listBox_babaadi.Items.Add(satir);

                }
                bilgioku.Close();
            }
            catch
            {

            }
        }
    }
}
