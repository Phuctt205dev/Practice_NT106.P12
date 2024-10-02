using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_FNP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int TinhGiaiThua(int n)
        {
            int giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }

        // Hàm tính tổng S = A^1 + A^2 + ... + A^B
        private int TinhTongLuyThua(int A, int B)
        {
            int tong = 0;
            for (int i = 1; i <= B; i++)
            {
                tong += (int)Math.Pow(A, i); // Tính A^i
            }
            return tong;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(Num1.Text);
            int B = Convert.ToInt32(Num2.Text);
            int index = Choices.SelectedIndex;
            int minus = A - B;

            if (index == 0)
            {
                // Bảng cửu chương từ B đến A
                string ketQua = "";
                for (int i = B; i >= A; i--)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        ketQua += $"{i} x {j} = {i * j}\n";
                    }
                    ketQua += "\n"; // Thêm dòng trống sau mỗi bảng cửu chương
                }
                ResultBox.Text = ketQua;
            }
            else if (index == 1)
            {
                // Tính giai thừa (A - B) và tổng S
                if (minus < 0)
                {
                    ResultBox.Text = "Không thể tính giai thừa cho số âm.";
                }
                else
                {
                    int giaiThua = TinhGiaiThua(minus);
                    int tongLuyThua = TinhTongLuyThua(A, B);
                    ResultBox.Text = $"(A - B)! = {giaiThua}\nTổng S = {tongLuyThua}";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Num1.Text=Num2.Text=string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Choices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
