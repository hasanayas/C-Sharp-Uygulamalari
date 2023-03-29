using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox_Sayfa140_141
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(txtMalzemeAdi.Text);
            checkedListBox2.Items.Add(txt_MalzemeFiyati.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int indis;
            indis = checkedListBox1.SelectedIndex;
            if ( indis <0)
            {
                MessageBox.Show("Önce listeden bir seçim yapiniz");


            }

            else
            {
                checkedListBox1.Items.RemoveAt(indis);
                checkedListBox2.Items.RemoveAt(indis);
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indis, b, t;

            //seçili elemanın indisini alır
            indis = checkedListBox1.SelectedIndex;

            checkedListBox2.SelectedIndex = indis;

            if(indis < 0)
            {
                return;
            }



            //kutu içindeki işaretlerinde aynı olması sağlanıyor
            checkedListBox2.SetItemChecked(indis, checkedListBox1.GetItemChecked(indis));

            //satılan malzeme listesinden bul
            b = listBox1.Items.IndexOf(checkedListBox1.Items[indis]);

            //satılan malzeme yoksa 
            if (b < 0)
            {

                if(checkedListBox1.GetItemChecked(indis) == true)
                {

                    //satılan malzeme listesine ekle
                    listBox1.Items.Add(checkedListBox1.Items[indis]);

                    //fiyat tarafına ekle 
                    listBox2.Items.Add(checkedListBox2.Items[indis]);
                } 
            }

            //satılan melzeme listesinde varsa 
            if (b >= 0)
            {
                // ve işaretli değilse
                if(checkedListBox1.GetItemChecked(indis) == false)
                {
                    //işareti kaldırıldıysa satılan malzeme listesinden kaldır
                    listBox1.Items.RemoveAt(b);
                    listBox2.Items.RemoveAt(b);
                }
            }

            //toplam değeri bul 
            t = 0; 
            for ( int i = 0; i<listBox2.Items.Count; i++)
            {
                t = t + Convert.ToInt16(listBox2.Items[i].ToString());
            }
            label5.Text = t.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedIndex = checkedListBox2.SelectedIndex;
        }
    }
}
