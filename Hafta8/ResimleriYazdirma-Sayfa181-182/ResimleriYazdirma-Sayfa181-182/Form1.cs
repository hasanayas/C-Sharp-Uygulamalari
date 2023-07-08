using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimleriYazdirma_Sayfa181_182
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void resimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim dosyaları |*.bmp; *.jpg; .png";
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void onizle_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void sayfaYapisi_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if(pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //resmin çizdirilmesi gerçekleştiriliyor
            int x, y;
            int genislik, yukseklik;

            System.Drawing.Printing.PageSettings sayfa_ayari;
            sayfa_ayari = printDocument1.DefaultPageSettings;

            x = sayfa_ayari.Margins.Left;
            y = sayfa_ayari.Margins.Top;
            genislik = pictureBox1.Width;
            yukseklik = pictureBox1.Height;


            if (checkBox1.Checked)
            {
                //sığdır kutucuğu işaretliyse
                genislik = sayfa_ayari.PaperSize.Width - sayfa_ayari.Margins.Left - sayfa_ayari.Margins.Right;
                yukseklik = sayfa_ayari.PaperSize.Height - sayfa_ayari.Margins.Top - sayfa_ayari.Margins.Bottom;

                //ortala kutucuğu işaretliyse
                x = sayfa_ayari.Margins.Left +
                    ((sayfa_ayari.PaperSize.Width - sayfa_ayari.Margins.Left -
                    sayfa_ayari.Margins.Right) - pictureBox1.Image.Width) / 2;

                y = sayfa_ayari.Margins.Top +
                    ((sayfa_ayari.PaperSize.Height - sayfa_ayari.Margins.Top -
                    sayfa_ayari.Margins.Bottom) - pictureBox1.Image.Height) / 2 ;

            }

            //resim çizdirme yapılıyor
            e.Graphics.DrawImage(pictureBox1.Image, x, y, genislik, yukseklik);
        }
    }
}
