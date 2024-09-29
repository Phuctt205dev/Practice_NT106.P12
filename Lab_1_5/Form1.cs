using System;
using System.Windows.Forms;

namespace Lab_1_5
{
    public partial class Form1 : Form
    {
        private int studentCounter = 1;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();  
            dataGridView1.DataError += dataGridView1_DataError;  
        }

        private void InitializeDataGridView()
        {
            
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("Score1", "Result1");
            dataGridView1.Columns.Add("Score2", "Result2");
            dataGridView1.Columns.Add("Score3", "Result3");
            dataGridView1.Columns.Add("Average", "Average");
            dataGridView1.Columns.Add("Classification", "Ranking");

          
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Xóa",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteButtonColumn);
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = string.Empty;
            txtname.Text = string.Empty;
            comboxGender.SelectedIndex = -1;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m1, m2, m3;

            if (int.TryParse(txt1.Text, out m1) && int.TryParse(txt2.Text, out m2) && int.TryParse(txt3.Text, out m3) && m1 >= 0 && m1 <= 10 && m2 >= 0 && m2 <= 10 && m3 >= 0 && m3 <= 10)
            {
                string name = txtname.Text;
                if (name.Length > 30)
                {
                    MessageBox.Show("Họ và tên không được quá 30 ký tự.");
                    return;
                }

               
                string gender = comboxGender.SelectedItem != null ? comboxGender.SelectedItem.ToString() : null;
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Vui lòng chọn giới tính.");
                    return;
                }

                double average = Math.Round((m1 + m2 + m3) / 3.0, 1);
                string classification = "";

                if (average >= 8 && m1 >= 6.5 && m2 >= 6.5 && m3 >= 6.5)
                    classification = "Giỏi";
                else if (average >= 6.5 && m1 >= 5 && m2 >= 5 && m3 >= 5)
                    classification = "Khá";
                else if (average >= 5 && m1 >= 3.5 && m2 >= 3.5 && m3 >= 3.5)
                    classification = "Trung Bình";
                else if (average >= 3.5 && m1 >= 2 && m2 >= 2 && m3 >= 2)
                    classification = "Yếu";
                else
                    classification = "Kém";

                string studentID = $"TS{studentCounter:D3}";
                studentCounter++;  
                dataGridView1.Rows.Add(studentID, name, gender, m1, m2, m3, average, classification);
            }
            else
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int deleteButtonColumnIndex = dataGridView1.Columns["Delete"].Index;

            if (e.ColumnIndex == deleteButtonColumnIndex && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
