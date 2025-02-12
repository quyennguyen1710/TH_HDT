using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            double chuvi = Math.Round(double.Parse(txtnhap.Text) * Math.PI * 2,5);
            txtXuat.Text = "Chu vi hình tròn = " + chuvi.ToString();

        }

        private void btndientich_Click(object sender, EventArgs e)
        {
            double dientich = Math.Round(Math.Pow(double.Parse(txtnhap.Text), 2) * Math.PI,5);
            txtXuat.Text = "Diện tích hình tròn = " + dientich.ToString();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
