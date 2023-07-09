using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn sutun;
            DataRow satir;

            sutun = new DataColumn("Sıra No");
            sutun.AutoIncrement = true;
            sutun.AutoIncrementStep = 1;

            dt.Columns.Add(sutun);

            sutun = new DataColumn("Adı Soyadı");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Dogum Tarihi");
            dt.Columns.Add(sutun);

            dataGridView1.DataSource = dt;

            satir = dt.NewRow();
            satir["Adı Soyadı"] = "Serkan";
            satir["Dogum Tarihi"] = "04.01.2001";

            dt.Rows.Add(satir);

            satir = dt.NewRow();
            satir["Adı Soyadı"] = "Sümeyra Aykutluğ";
            satir["Dogum Tarihi"] = "14.11.2001";

            dt.Rows.Add(satir);
        }
    }
}
