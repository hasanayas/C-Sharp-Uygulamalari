using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogPenceresi_Filter_Sayfa168_169
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Açılacak dosyayı seçiniz";
            openFileDialog1.Filter = "Text dosyaları | *.txt|" +
                                    "Kelime dosyaları | .rtf|" +
                                    "Resim dosyaları | .jpg; *.bmp; *.png|" +
                                    "Programlar | *.exe";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowHelp = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    textBox1.Text = "";
                    System.IO.TextReader dosya = System.IO.File.OpenText(openFileDialog1.FileName);
                    string satir;

                    while ((satir = dosya.ReadLine()) != null)
                    {
                        textBox1.Text += satir + (char)13 + (char)10;
                        dosya.Close();
                    }
                }
                if (openFileDialog1.FilterIndex == 2)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                if (openFileDialog1.FilterIndex == 3)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                if (openFileDialog1.FilterIndex == 4)
                {
                    System.Diagnostics.Process.Start(openFileDialog1.FileName);
                }
            }
        }
        private void openFileDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Bu pencerenin sağ alt köşesindeki dosya türlerine uygun dosyaları" +
                "seçmeniz gerekmektedir. Text dosyaları kategorisi için uzantısı txt formatında" +
                "olan dosyaları seçebilirsiniz");
        }
    }
    
}
