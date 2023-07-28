namespace Sayfa236
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string metin;
            Font fnt = new Font("Tahoma", 12, FontStyle.Regular);
            int x = 10, y = 0;

            for(int i = 0; i < 15; i++)
            {
                metin = i.ToString() + " .satýr";
                e.Graphics.DrawString(metin, fnt, new SolidBrush(Color.Red), x, y);

                y += (int)e.Graphics.MeasureString(metin, fnt).Height;

                e.Graphics.DrawLine(new Pen(Color.Black), 0, y, this.ClientSize.Width, y);
            }
        }
    }
}