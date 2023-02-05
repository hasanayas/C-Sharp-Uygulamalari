using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visible_Sayfa61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yas; 

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Bay İfadesinin Oldugu Onay Kutusu checkBox1 seçili oldugunda ve
            //yaşın girildiği durumda texbox kontrolündeki sayi degeri 
            //30 yaşından büyükse if blogu devreye girecek 
            yas = Convert.ToInt16(textBox2.Text);
            if ((radioButton1.Checked) == true && (yas < 30))
            {
                label4.Visible = true;
                textBox3.Visible = true;
                label5.Visible = true;
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
 //bayan ifadesinin oldugu onay kutusu checkBox2 seçili oldugunda yas degerine bakılmadan if bloguna girilecek
            if ((radioButton2.Checked)==true)
            {
                label4.Visible = false;
                textBox3.Visible = false;
                label5.Visible = false;
                textBox4.Visible = false;
                label6.Visible = false;
                textBox5.Visible = false;
            }
        }
    }
}
