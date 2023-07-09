using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChar_Sayfa103_104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hak++;
            if(textBox1.Text == "1234") //varsayılan şifre
            {
                MessageBox.Show("Ana girişmenüsüne yönlendiriliyorsunuz");

            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Yanlış şifre girdiniz");

                if(hak == 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Şifreyi 3 defadan fazla girdiniz program kapatılacaktır");
                    this.Close();
                   
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';

            this.CancelButton = button2;

            this.AcceptButton = button1;
        }
        int hak = 0;
    }
}
