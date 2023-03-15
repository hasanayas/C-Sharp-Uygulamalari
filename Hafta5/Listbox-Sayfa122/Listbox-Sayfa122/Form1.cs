﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_Sayfa122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazertesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            listBox1.Items.AddRange(gunler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            MessageBox.Show("Seçili olan eleman listeden silinmiştir.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazertesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            listBox2.Items.AddRange(gunler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove("Salı");
        }
    }
}
