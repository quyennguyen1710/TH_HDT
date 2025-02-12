using System.Drawing;

namespace Bai5._5
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int h; //height
        int w; //weight
        Pen p = new Pen(Color.Blue, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x; //Cao = X ban đầu - x hiện tại
            w = e.Y - y;
            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if (rbtnhcn.Checked)
            {
                p.Color = Color.Blue;
                g.DrawRectangle(p, shape);
            }
            else
            {
                p.Color = Color.Red;
                g.DrawEllipse(p, shape);
                //Dientich = h * w * Math.PI / 4;
            }
        }
    }
}
