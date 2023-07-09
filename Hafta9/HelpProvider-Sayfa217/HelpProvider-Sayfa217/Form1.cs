using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpProvider_Sayfa217
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            helpProvider1.SetHelpString(button1, "Bu bir komut düğmesidir");
            helpProvider1.SetShowHelp(button1, true);
        }
    }
}
