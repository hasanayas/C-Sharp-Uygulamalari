namespace Sayfa237
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image resim = Image.FromFile("C:\\Users\\Serkan\\Desktop\\channels4_profile.jpg");
            System.Drawing.Drawing2D.GraphicsPath p = new System.Drawing.Drawing2D.GraphicsPath();

            p.AddEllipse(0, 0, resim.Width, resim.Height);
            e.Graphics.SetClip(p);
            e.Graphics.DrawImage(resim, 0, 0);
        }
    }
}