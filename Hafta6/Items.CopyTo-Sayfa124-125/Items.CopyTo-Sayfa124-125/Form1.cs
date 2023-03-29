using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Items.CopyTo_Sayfa124_125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi1 = { "pazartesi", "sali", "carsamba","persembe" ,"cuma ","cumartesi","pazar"};
            string[] dizi2 = { "ocak", "subat", "mart", "nisan", "mayis", "haziran", "temmuz", "agustos", "eylul", "ekim", "kasim", "aralik" };
            listBox1.Items.Add("haftanin gunleri");
            listBox1.Items.Add("");
            listBox1.Items.AddRange(dizi1);

            listBox2.Items.Add("aylar");
            listBox2.Items.Add("");
            listBox2.Items.AddRange(dizi2);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            object[] x = new object[listBox1.Items.Count + listBox2.Items.Count];
            listBox1.Items.CopyTo(x, 0);
            listBox2.Items.CopyTo(x, listBox1.Items.Count);

            listBox3.Items.Add("2 listenin birleştirilmiş hali");
            listBox3.Items.Add("");
            listBox3.Items.AddRange(x);
        }
    }
}
