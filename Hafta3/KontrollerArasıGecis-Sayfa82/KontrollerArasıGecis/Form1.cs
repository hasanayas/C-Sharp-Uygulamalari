using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrollerArasıGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if(Convert.ToInt16(textBox2.Text)<0 || Convert.ToInt16(textBox2.Text)> 100) {
                    MessageBox.Show("Sınav notu 0-100 arasında olmalıdır!");
                    e.Cancel = true;
                    textBox2.Text = "";
                }
            }
            catch
            {
                textBox2.Text = "Sınav notu geçersizdir.";
                e.Cancel = true;

            }
        }

        int yer_at_isareti, yer_nokta_isareti;
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //mail adesinde @  ve . işareti bulunmalıdır.
            //ikinci harften itibaren  @ işaretinini araması

            yer_at_isareti = textBox3.Text.IndexOf("@",1);

            //@işaretinden sonra aramıyor
            if(yer_at_isareti >0) {
                yer_nokta_isareti = textBox3.Text.IndexOf(".", yer_at_isareti + 1);
            }

            //@işareti veya . işareti yoksa veya .sondaysa
            if(yer_at_isareti <0 || yer_nokta_isareti <0 || yer_nokta_isareti == textBox3.Text.Length - 1){

                MessageBox.Show("Mail adresi yanlış giriilmiştir");
                e.Cancel = true;
            }
        }

        int yer_ilkboslukbul, yer_ikinciboslukbul;

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

            //ilk boşluğu bul
            yer_ilkboslukbul = textBox4.Text.IndexOf(" ");

            //ikinci boşluk bul
            if (yer_ikinciboslukbul >= 0)
                yer_ikinciboslukbul = textBox4.Text.IndexOf(" ", yer_ilkboslukbul + 1);

            //uzunluk 3 değilse veya 2 tane boşluk bırakmadıysa veya boşluklardan biri sondaysa

            if(textBox4.Text.Length !=9 || yer_ilkboslukbul <0 || yer_ikinciboslukbul<0 
                || yer_ikinciboslukbul == textBox4.Text.Length - 1)
            {
                MessageBox.Show("Plaka 81 HV 688 şeklinde olmalıdır");
                e.Cancel = true;

            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            //uzunluk 10 değilse
            if(textBox5.Text.Length != 10)
            {
                MessageBox.Show("Telefon 5326651122 şeklinde olmalıdır");
                e.Cancel = true;
            }
        }
    }
}
