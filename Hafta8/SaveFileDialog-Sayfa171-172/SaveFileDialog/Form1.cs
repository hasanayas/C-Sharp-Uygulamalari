using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ac_Click(object sender, EventArgs e)
        {
            //aç işlemi yapılıyor
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try // önce rtf dosyasını açmayı dene
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.RichText);
                }
                catch
                {
                    try //olmasa düz metin olarak açmayı dene
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName,
                            RichTextBoxStreamType.PlainText);
                    }
                    catch // o da olmazsa hata ver
                    {
                        MessageBox.Show(openFileDialog1.FileName + "bu dosya açılmadı");
                    }
                }
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            //kaydet işlemi yapılıyor 
            if(openFileDialog1.FileName == "") //bir dosya açılmışsa
            {
                //aynı isimle kaydet
                richTextBox1.SaveFile(openFileDialog1.FileName,
                    RichTextBoxStreamType.RichText);
            }
            else
            {
                //saveFileDialog ile dosya adını sor
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //verilen isimle kaydet
                    richTextBox1.SaveFile(saveFileDialog1.FileName,
                        RichTextBoxStreamType.RichText);
                }
            }
        }

        private void button_farklikaydet_Click(object sender, EventArgs e)
        {
            //farklı kaydet 
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,
                    RichTextBoxStreamType.RichText);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Bütün dosyalar | *.*| RTF dosyaları | *.rtf| Metin dosyaları | *.txt";

            openFileDialog1.Title = "Açılacak dosya";

            saveFileDialog1.Filter = openFileDialog1.Filter;
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Title = "Kaydedilecek dosya";

        }
    }
}
