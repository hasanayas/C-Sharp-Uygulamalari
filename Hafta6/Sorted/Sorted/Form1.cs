using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //random sayı üretme 1-100 
            Random r = new Random();
            for ( int i=0; i<25; i++)
            {
                int rastgele_sayi = r.Next(100);
                listBox3.Items.Add(rastgele_sayi.ToString());
            }


            string[] liste = {"ali","masa","serdar","bilgisayar","kalem" +
                    "bora", "çay", "araba","saat"};

            listBox1.Items.AddRange(liste);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox2.Sorted = true;
            listBox2.Items.AddRange(listBox1.Items);


          

        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sırlama algoritması 
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                for (int a = i; a < listBox3.Items.Count; a++)
                {
                    int sayi1 = 0;
                    int sayi2 = 0;
                    sayi1 = Convert.ToInt16(listBox3.Items[i]);
                    sayi2 = Convert.ToInt16(listBox3.Items[a]);

                    //büyükten küçüğe sırlama
                    if (sayi2 > sayi1)
                    {
                        int c = sayi2;
                        sayi2 = sayi1;
                        sayi1 = c;

                        listBox3.Items[i] = sayi1.ToString();
                        listBox3.Items[a] = sayi2.ToString();

                    }
                }
                
            }
           
        }
    }
}
