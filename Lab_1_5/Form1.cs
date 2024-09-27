using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = string.Empty;
            txtname.Text = string.Empty;
            comboxGender.Text = "Gender";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txt1.Text, out num) && int.TryParse(txt2.Text, out num) && int.TryParse(txt3.Text, out num))
            {

            }
            else
            {
                MessageBox.Show("Điểm số không chứa ký tự khác số");
            }
        }
    }
}
