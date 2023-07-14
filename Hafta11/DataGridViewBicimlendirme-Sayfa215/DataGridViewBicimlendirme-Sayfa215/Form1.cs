using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewBicimlendirme_Sayfa215
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

            sutun = new DataColumn("Musterinin_Adi", System.Type.GetType("System.String"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Aldigi Mal", System.Type.GetType("System.String"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Adet", System.Type.GetType("System.Int32"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Birim_Fiyat", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Toplam", System.Type.GetType("System.Decimal"));
            sutun.Expression = "Adet * Birim_Fiyat";
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Odenen", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Kalan", System.Type.GetType("System.Decimal"));
            sutun.Expression = "Toplam - Odenen";
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Borcu Yok", System.Type.GetType("System.Boolean"));
           
            dt.Columns.Add(sutun);

            dataGridView1.DataSource = dt;
        }
    }
}
