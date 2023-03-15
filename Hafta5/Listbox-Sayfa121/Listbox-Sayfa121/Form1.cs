using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_Sayfa121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Edirne");
            listBox2.Items.Add("Konya");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] gunler = {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma", "Cumartesi","Pazar"};

            listBox3.Items.AddRange(gunler);
            listBox3.Items.Insert(3, "Haftanın Günleri");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            listBox4.Items.AddRange(gunler);
            listBox4.Items.Insert(3, "Haftanın Günleri");
            listBox4.Items.RemoveAt(2);

        }
    }
}
