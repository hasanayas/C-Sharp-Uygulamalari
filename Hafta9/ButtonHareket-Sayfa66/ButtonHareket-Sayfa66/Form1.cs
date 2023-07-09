using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonHareket_Sayfa66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Left = button1.Left;
            button2.Top = button1.Top;
            button1.Width = button2.Width;
            button1.Height = button2.Height;


            //Aynı işlem SetBounds methodu ilede yapılabiilir
            button4.SetBounds(button3.Left, button3.Top+ button3.Height + 20,
                button3.Width, button3.Height);


            //Aynı işlem locatiıon ve size ile de yapılabilir

            button6.Location = new Point(button5.Left, button5.Top + button5.Height + 20);
            button6.Size = new Size(button5.Width, button5.Height);


        }
    }
}
