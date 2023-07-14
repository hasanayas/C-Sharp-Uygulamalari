using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenFazlaYazdirma.Sayfa175.176
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void baskionizleme_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void sayfaayari_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }

        int sayi = 1;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int sayfa_yüksekigi;
            System.Drawing.Printing.PageSettings sayfa_ayari;
            sayfa_ayari = printDocument1.DefaultPageSettings;
            sayfa_yüksekigi = sayfa_ayari.PaperSize.Height - sayfa_ayari.Margins.Top - sayfa_ayari.Margins.Bottom;


            Font fnt = new Font("Tahoma", 14, FontStyle.Regular);
            int satır_yüksekligi;
            satır_yüksekligi = (int)e.Graphics.MeasureString("1", fnt).Height;

            int maksimum_satir;
            maksimum_satir = sayfa_yüksekigi / satır_yüksekligi;
            int i, satır_no = 0;

            for (i = sayi; i < sayi + maksimum_satir; i++)
            {
                if (i > 200)
                {
                    e.HasMorePages = false;
                    sayi = 1;
                    return;
                }

                e.Graphics.DrawString(i.ToString() + ".satır", fnt, new SolidBrush(Color.Black), printDocument1.DefaultPageSettings.Margins.Left, printDocument1.DefaultPageSettings.Margins.Top + satır_no * satır_yüksekligi);
                satır_no++;
            }
            sayi = i;
            if (i < 200)
            {
                e.HasMorePages = true;
            }
        }
    }
}
