using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenFazlaFormlaCalisma_Sayfa88_90
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        Form2 ikinci_form = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
           if(ikinci_form == null)
            {
                ikinci_form = new Form2();

                ikinci_form.FormClosed += new FormClosedEventHandler(kapandi);
                ikinci_form.Show();

            }

            else
            {
                ikinci_form.Show();
                ikinci_form.Activate();
            }
           
        }

        private void kapandi(object sender, EventArgs e)
        {
            ikinci_form = null;
        }



      

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 ikincii_form = new Form2();

            if ((ikincii_form == null) || (ikincii_form.IsDisposed))
            {
                ikincii_form = new Form2();
                ikincii_form.Show();


            }

            else
            {
                ikinci_form.Show();
                ikincii_form.Activate();
            }
        }
    }
}
