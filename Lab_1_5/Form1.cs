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
            InitializeComboBoxColumn();  // Tạo cột ComboBox cho giới tính
            dataGridView1.DataError += dataGridView1_DataError;  // Gắn sự kiện xử lý lỗi
        }

        // Tạo cột ComboBox và thêm các giá trị hợp lệ (Nam, Nữ)
        private void InitializeComboBoxColumn()
        {
            // Tạo cột ComboBox
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Giới tính",  // Tiêu đề cột
                Name = "GenderColumn"  // Tên cột để dễ dàng truy cập
            };

            // Thêm giá trị cho cột ComboBox
            comboBoxColumn.Items.Add("Nam");
            comboBoxColumn.Items.Add("Nữ");

            // Thêm cột vào DataGridView
            dataGridView1.Columns.Add(comboBoxColumn);
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
            // Xóa các trường dữ liệu
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = string.Empty;
            txtname.Text = string.Empty;
            comboxGender.SelectedIndex = -1;  // Đặt lại ComboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r1, r2, r3;
            if (int.TryParse(txt1.Text, out r1) && int.TryParse(txt2.Text, out r2) && int.TryParse(txt3.Text, out r3))
            {
                string name = txtname.Text;

                // Kiểm tra giá trị giới tính
                string gender = comboxGender.SelectedItem != null ? comboxGender.SelectedItem.ToString() : null;

                if (gender != null)
                {
                    double aver = (r1 + r2 + r3) / 3.0;
                    string classify = "";

                    if (aver >= 9)
                        classify = "Expert";
                    else if (aver >= 7)
                        classify = "Good";
                    else
                        classify = "Limited";

                    // Thêm hàng vào DataGridView
                    dataGridView1.Rows.Add("TS001", name, gender, r1, r2, r3, aver, classify);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Giả sử cột nút xóa là cột cuối cùng
            int deleteButtonColumnIndex = dataGridView1.ColumnCount - 1;

            if (e.ColumnIndex == deleteButtonColumnIndex && e.RowIndex >= 0)  // Nếu cột là cột nút "Xoá"
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);  // Xoá hàng tại chỉ số đó
            }
        }

        // Xử lý sự kiện DataError để tránh lỗi mặc định
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            e.ThrowException = false;  // Ngăn chặn hiển thị hộp thoại lỗi mặc định
        }
    }
}
