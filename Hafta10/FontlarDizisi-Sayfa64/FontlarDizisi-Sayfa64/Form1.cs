using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontlarDizisi_Sayfa64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] fontlar = FontFamily.Families;
            for(int i =0; i < fontlar.Length; i++)
            {
                listBoxFontlar.Items.Add(fontlar[i].Name);
            }
        }

        private void listBoxFontlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Font = new Font(listBoxFontlar.SelectedItem.ToString(), 16,
                    FontStyle.Regular);
            }

            catch
            {
                MessageBox.Show("Bu font görüntülenemiyor");
            }
        }
    }
}
