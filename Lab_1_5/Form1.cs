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
                string name = txtname.Text;
                string gender = comboxGender.SelectedItem.ToString();
                int r1 = int.Parse(txt1.Text);
                int r2 = int.Parse(txt2.Text);
                int r3 = int.Parse(txt3.Text);
                double aver = (r1 + r2 + r3) / 3.0;
                string classify = "";
                if (aver >= 9)
                    classify = "Expert";
                else if (aver >= 7)
                    classify = "Good";
                else
                    classify = "Limited";
                dataGridView1.Rows.Add("TS001", name, gender, r1, r2, r3, aver, classify);
            }
            else
            {
                MessageBox.Show("Results cannot be filled with non-numeric characters");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.ColumnIndex == e.RowIndex) // Check if "Xoá" button is clicked
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
        }
    }
}
