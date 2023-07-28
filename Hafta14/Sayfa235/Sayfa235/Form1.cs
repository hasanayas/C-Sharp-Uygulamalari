namespace Sayfa235
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] partiler = new string[20];
        int[] oylar = new int[20];
        int sira_no, toplam_oy;
        private void button1_Click(object sender, EventArgs e)
        {
            if (sira_no == 20)
            {
                MessageBox.Show("En çok 20 parti olabilir");
                return;
            }
            try
            {
                oylar[sira_no] = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Oy sayýsýnda hata var");
                return;
            }
            partiler[sira_no] = textBox1.Text;
            toplam_oy += oylar[sira_no];
            sira_no++;

            Graphics gr;
            gr = this.CreateGraphics();

            int baslangic_acisi = 0, yay_acisi = 0;
            Color renk;
            System.Drawing.Drawing2D.HatchBrush firca;
            Random r = new Random();

            for(int i = 0; i < sira_no; i++)
            {
                yay_acisi = 360 * oylar[i] / toplam_oy;
                renk = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                firca = new System.Drawing.Drawing2D.HatchBrush(
                    (System.Drawing.Drawing2D.HatchStyle)r.Next(50), renk);

                gr.FillPie(firca, 0, 80, 200, 200, baslangic_acisi, yay_acisi);

                gr.FillRectangle(firca, 210, 80 + i * 20, 18, 18);

                gr.DrawString(partiler[i] + " = " + oylar[i].ToString(),
                    new Font("Tahoma", 8, FontStyle.Regular),
                    new SolidBrush(Color.Red), 230, 80 + i * 20);

                baslangic_acisi += yay_acisi;
            }
        }
    }
}