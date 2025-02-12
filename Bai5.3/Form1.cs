namespace Bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog anh = new OpenFileDialog();
            if (anh.ShowDialog() == DialogResult.OK) pictureBox1.Image = new Bitmap(anh.FileName);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
