﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPUTBOX_Sayfa57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sinav_notu;
            sinav_notu = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Sınav notunu girin", "Not Girişi","0",100,100 ));
            if(sinav_notu >= 50)
            {
                MessageBox.Show("Tebrikler. Dersten geçtiniz");
            }
            else
            {
                MessageBox.Show("Üzgünüm. Dersten kaldınız");
            }
        }
    }
}
