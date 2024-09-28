namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number;


            if (int.TryParse(txtA.Text, out number))
            {

                Console.WriteLine("Số thứ 1 hợp lệ: " + number);
            }
            else
            {
                txtA.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

