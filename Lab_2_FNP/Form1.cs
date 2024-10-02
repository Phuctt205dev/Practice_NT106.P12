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

        private int Fatorial(int n)
        {
            int fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }

        private int SumOfPower(int A, int B)
        {
            int sum = 0;
            for (int i = 1; i <= B; i++)
            {
                sum += (int)Math.Pow(A, i);
            }
            return sum;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(Num1.Text);
            int B = Convert.ToInt32(Num2.Text);
            int index = Choices.SelectedIndex;
            int minus = A - B;

            if (index == 0) // Outputs if A < B
            {
                string result = "";
                for (int i = B; i >= A; i--)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        result += $"{i} x {j} = {i * j}\n";
                    }
                    result += "\n";
                }
                ResultBox.Text = result;
            }
            else if (index == 1) //Outputs if A > B
            {
                if (minus < 0)
                {
                    ResultBox.Text = "Cannot calculate fatorial due to negative numbers";
                }
                else
                {
                    int fatorial = Fatorial(minus);
                    int sumLuyThua = SumOfPower(A, B);
                    ResultBox.Text = $"(A - B)! = {fatorial}\nSum = {sumLuyThua}";
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
