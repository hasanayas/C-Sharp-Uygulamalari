﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Sayfa148
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Timer kontrolu kullanarak form başlığı kayan yazı uygulaması yapılmıştır


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1, this.Text.Length - 1) +
                this.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Enabled = true;
            this.Text = "Visual C#.Net 2008";
        }
    }
}
