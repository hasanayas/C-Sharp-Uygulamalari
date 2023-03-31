using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerRenkKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "";
            timer1.Interval = 200;
            timer1.Enabled = true;
          
        }
        int sx = 5, sy = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Color c;
            c = textBox1.BackColor;
            textBox1.BackColor = textBox1.ForeColor;
            textBox1.ForeColor = c;

            //formun üstüne veya altına ulaştıysa artımı ters çevirme işlemi
            if(radioButton1.Top <= 0 || radioButton1.Bottom >= this.ClientSize.Height)
            {
                sy = -sy; //artış yönü ters çevrildi
            }

            //formun soluna veya sağına ulaştıysa artımı ters çevirme işlemi
            if(radioButton1.Left<= 0 || radioButton1.Right >= this.ClientSize.Width)
            {
                sx = -sx; //artış yönü ters çevrildi
            }

            radioButton1.Left += sx;
            radioButton1.Top += sy;

        }




    }
}
