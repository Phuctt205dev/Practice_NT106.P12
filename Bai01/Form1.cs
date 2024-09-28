namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(TxtA.Text, out number))
            {
                Console.WriteLine("Số hợp lệ: " + number);
            }
            else
            {
                txtB.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int number;


            if (int.TryParse(txtB.Text, out number))
            {

                Console.WriteLine("Số thứ 2 hợp lệ: " + number);
            }
            else
            {
                txtB.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            if (!int.TryParse(TxtA.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ cho số thứ nhất.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtA.Focus();
                return;
            }
            if (!int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ cho số thứ hai.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
                return;
            }

            if (!int.TryParse(txtC.Text, out c))
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ cho số thứ ba.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtC.Focus();
                return;
            }
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            txtResult.Text = " " + max;
            txtResult1.Text = " " + min;
        }
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            int number;


            if (int.TryParse(txtC.Text, out number))
            {

                Console.WriteLine("Số thứ 2 hợp lệ: " + number);
            }
            else
            {
                txtC.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtResult.Clear();
            txtResult1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

