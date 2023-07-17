using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace statusStrip_Sayfa210_211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")]
        private static extern int
        GetDiskFreeSpaceExA(string lpRootPathName,
            ref long lpFreeBytesAvailableToCaller,
            ref long lpTotalNumberOfBytes,
            ref long lpTotalNumberOfFreeBytes);

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;

            toolStripStatusLabel1.Text = "Disk Kapasiteleri";
            toolStripStatusLabel2.Text = "Ekran Çözünürlüğü";
            toolStripStatusLabel3.Text = "Basılı Tuş";
            toolStripStatusLabel4.Text = "Saat";

            long x = 0, y = 0, z = 0;
            string s = "";
            string[] suruculer = System.IO.Directory.GetLogicalDrives();

            for (int i = 0; i <= suruculer.GetUpperBound(0); i++)
            {
                y = 0;
                GetDiskFreeSpaceExA(suruculer[i], ref x, ref y, ref z);
                if (y > 1024 * 1024 * 1024)
                {
                    s += suruculer[i] + " = " + (y / 1024 / 1024 / 1024).ToString() + " GB ";
                }
                else
                {
                    s += suruculer[i] + " = " + (y / 1024 / 1024).ToString() + " MB ";
                }
            }
            toolStripStatusLabel1.Text = s;

            Rectangle r = new Rectangle();
            r = Screen.GetBounds(r);
            toolStripStatusLabel2.Text = r.Width.ToString() + "X" + r.Height.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            toolStripStatusLabel3.Text = e.KeyData.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = DateTime.Now.ToString();
        }
    }
}
