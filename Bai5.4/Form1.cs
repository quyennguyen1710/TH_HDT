namespace Bai5._4
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

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double km = double.Parse(txtquangduong.Text);
            double money = 0;

            if (btn7cho.Checked)
            {
                if (km <= 1) money = km * 17000;
                else if (km <= 5) money = 1 * 17000 + (km - 1) * 15000;
                else if (km <= 100) money = 1 * 17000 + 4 * 15000 + (km - 5) * 12000;
                else money = 1 * 17000 + 4 * 15000 + 95 * 12000 + (km - 100) * 11000;

            }
            if (btn4cho.Checked)
            {
                if (km <= 1) money = km * 15000;
                else if (km <= 5) money = 1 * 15000 + (km - 1) * 13500;
                else if (km <= 100) money = 1 * 15000 + 4 * 13500 + (km - 5) * 11000;
                else money = 1 * 15000 + 4 * 13500 + 95 * 11000 + (km - 100) * 10000;
            }

            double MoneyGiam = 0;

            if (cbgiamgia.Checked)
            {
                MoneyGiam = money * 0.95;
                txtthanhtoan.Text = MoneyGiam.ToString() + "";
            }
            else txtthanhtoan.Text = money.ToString() + "";
        }

        private void btn7cho_CheckedChanged(object sender, EventArgs e)
        {
            double km = double.Parse(txtquangduong.Text);
            double money = 0;

            if (btn7cho.Checked)
            {
                if (km <= 1) money = km * 17000;
                else if (km <= 5) money = 1 * 17000 + (km - 1) * 15000;
                else if (km <= 100) money = 1 * 17000 + 4 * 15000 + (km - 5) * 12000;
                else money = 1 * 17000 + 4 * 15000 + 95 * 12000 + (km - 100) * 11000;

            }

            double MoneyGiam = 0;

            if (cbgiamgia.Checked)
            {
                MoneyGiam = money * 0.95;
                txtthanhtoan.Text = MoneyGiam.ToString() + "";
            }
            else txtthanhtoan.Text = money.ToString() + "";
        }

        private void btn4cho_CheckedChanged(object sender, EventArgs e)
        {
            double km = double.Parse(txtquangduong.Text);
            double money = 0;

            if (btn4cho.Checked)
            {
                if (km <= 1) money = km * 15000;
                else if (km <= 5) money = 1 * 15000 + (km - 1) * 13500;
                else if (km <= 100) money = 1 * 15000 + 4 * 13500 + (km - 5) * 11000;
                else money = 1 * 15000 + 4 * 13500 + 95 * 11000 + (km - 100) * 10000;
            }

            double MoneyGiam = 0;

            if (cbgiamgia.Checked)
            {
                MoneyGiam = money * 0.95;
                txtthanhtoan.Text = MoneyGiam.ToString() + "";
            }
            else txtthanhtoan.Text = money.ToString() + "";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
