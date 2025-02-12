namespace Bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtnhapa.Text);
            double b = double.Parse(txtnhapb.Text);
            double c = double.Parse(txtnhapc.Text);
            double delta;
            double x1, x2;

            if (a != 0)
            {
                if (b != 0)
                {
                    delta = b * b - 4 * a * c;
                    if (delta == 0) txtxuat.Text = "Phương trình có nghiệm kép: x = " + ((-b) / 2 * a);
                    else if (delta > 0)
                    {
                        x1 = (float)(-b + Math.Sqrt(delta)) / 2 * a;
                        x2 = (float)(-b - Math.Sqrt(delta)) / 2 * a;
                        txtxuat.Text = " Phương trình có 2 nghiệm: X1 = " + x1 + "X2 = " + x2;
                    }
                    else txtxuat.Text = "Phuong trinh vo nghiem";
                }
                else
                if ((a * c) < 0)
                {
                    x1 = (Math.Sqrt(-c / a));
                    x2 = -(Math.Sqrt(-c / a));
                    txtxuat.Text = " Phương trình có 2 nghiệm: X1 = " + x1 + "X2 = " + x2;
                }
            }
            else if (b == 0)
            {
                if (c == 0) txtxuat.Text = "Phuong trinh co vo so nghiem.";
                else txtxuat.Text = "Phuong trinh vo nghiem";
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
