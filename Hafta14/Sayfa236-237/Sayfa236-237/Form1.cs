namespace Sayfa236_237
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sn_yatay, sn_dusey, yelkovan_x, yelkovan_y, akrep_x, akrep_y;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            this.BackColor = Color.Navy;
            this.TransparencyKey = Color.Navy;

            this.FormBorderStyle = FormBorderStyle.None;
        }

        int x = 0, m = 270, n = 270;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics grafik = this.CreateGraphics();

            Pen saat = new Pen(Color.Orange, 3);
            grafik.DrawEllipse(saat, 100, 100, 200, 200);
            grafik.DrawLine(saat, 200, 100, 200, 115);
            grafik.DrawLine(saat, 300, 200, 285, 200);
            grafik.DrawLine(saat, 200, 300, 200, 285);
            grafik.DrawLine(saat, 100, 200, 115, 200);
            double yaricap = 100;
            if (x == 360) { x = 0; }
            if (x == 270) { m += 6; }
            if (x == 270 && m % 12 == 0) { n += 1; }

            Pen sn_kalem = new Pen(Color.Black, 1);
            sn_yatay = yaricap * Math.Cos(Math.PI * x / 180) + 200;
            sn_dusey = yaricap * Math.Sin(Math.PI * x / 180) + 200;

            Point merkez = new Point(200, 200);
            Point noktasn = new Point(Convert.ToInt32(sn_yatay), Convert.ToInt32(sn_dusey));
            grafik.DrawLine(sn_kalem, merkez, noktasn);
            x += 6;

            Pen yel_kalem = new Pen(Color.Red, 2);
            yelkovan_x = 80 * Math.Cos(Math.PI * m / 180) + 200;
            yelkovan_y = 80 * Math.Sin(Math.PI * m / 180) + 200;
            Point noktayel = new Point(Convert.ToInt32(yelkovan_x) + 30, Convert.ToInt32(yelkovan_y));
            grafik.DrawLine(yel_kalem, merkez, noktayel);

            Pen akrep_kalem = new Pen(Color.Olive, 2);
            akrep_x = 80 * Math.Cos(Math.PI * m / 180) + 200;
            akrep_y = 80 * Math.Sin(Math.PI * m / 180) + 200;
            Point noktaakrp = new Point(Convert.ToInt32(akrep_x) + 30, Convert.ToInt32(akrep_y));
            grafik.DrawLine(yel_kalem, merkez, noktaakrp);

            grafik.Dispose();
        }
    }
}