using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PathSinifi_Sayfa224
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string yol = openFileDialog1.FileName;
                listBox1.Items.Add("Bulunduğu klasör: " + Path.GetDirectoryName(yol));
                listBox1.Items.Add("Dosya adi: " + Path.GetFileName(yol));
                listBox1.Items.Add("Uzantisi: " + Path.GetExtension(yol));
                listBox1.Items.Add("Tam yolu: " + Path.GetFullPath(yol));
             





            }
        }
    }
}
