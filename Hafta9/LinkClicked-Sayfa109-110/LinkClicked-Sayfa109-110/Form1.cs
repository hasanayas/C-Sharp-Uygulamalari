using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkClicked_Sayfa109_110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //belirtilen intertnet adresini açmak için
            linkLabel1.Text = "Yahoo ana sayfasına gitmek için burayı tıklayınız";
            linkLabel1.Links.Add(32, 6, "http://yahoo.com");
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.VisitedLinkColor = Color.Red;
            linkLabel1.ActiveLinkColor = Color.Brown;
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;


            linkLabel2.Text = "Mail göndermek için burayı tıklayınız";
            linkLabel2.Links.Add(20, 6, "mailto:sbirogul@yahoo.com");


            //belirtilen programı çalıştırmak için
            linkLabel3.Text = "Exe dosyasını çalıştırmak için burayı tıklayınız";
            linkLabel3.Links.Add(33, 10, "C:\\Riot Games\\Riot Client\\RiotClientServices.exe");

            //belirtilen klasörü açmak için
            linkLabel4.Text = "Windos klasörünü açmak için burayı tıklayınız";
            linkLabel4.Links.Add(29, 6, "C:\\Program Files");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
