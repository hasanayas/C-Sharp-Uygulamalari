using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_Sayfa113_114
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double birim_fiyat;
        double adet;
        double ara_toplam;
        double tutar;

   

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

    
        private void islem_yap2(object sender, EventArgs e)
        {
            birim_fiyat = Convert.ToDouble(Txt_birimfiyati.Text);
            adet = Convert.ToDouble(Txt_adet.Text);
            ara_toplam = birim_fiyat * adet;


            if ((checkBox_KDV.Checked == true) && (checkBox_bayii.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;
                tutar = tutar - tutar * 0.25;
            }

            else if ((checkBox_KDV.Checked == true) && (checkBox_bayii.Checked == false))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;
            }


            else if ((checkBox_KDV.Checked == false) && (checkBox_bayii.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.25;
            }

            else
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam;
                Txt_tutar.Text = tutar.ToString();

            }

            Txt_tutar.Text = tutar.ToString();
        }

        private void ekle_indir2(object sender, EventArgs e)
        {
            birim_fiyat = Convert.ToDouble(Txt_birimfiyati.Text);
            adet = Convert.ToDouble(Txt_adet.Text);
            ara_toplam = birim_fiyat * adet;


            if ((checkBox_KDV.Checked == true) && (checkBox_bayii.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;
                tutar = tutar - tutar * 0.25;
            }

            else if ((checkBox_KDV.Checked == true) && (checkBox_bayii.Checked == false))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.18;
            }


            else if ((checkBox_KDV.Checked == false) && (checkBox_bayii.Checked == true))
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam + ara_toplam * 0.25;
            }

            else
            {
                ara_toplam = birim_fiyat * adet;
                tutar = ara_toplam;
                Txt_tutar.Text = tutar.ToString();

            }

            Txt_tutar.Text = tutar.ToString();
        }
    }
}
