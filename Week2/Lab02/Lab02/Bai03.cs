using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab02
{
    public partial class Bai03 : Form
    {
        bool flag = true;
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(ofd.FileName);
                richTextBox1.Text = text;
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text (*.txt)|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        // Lấy nội dung từ RichTextBox
                        string content = richTextBox2.Text;

                        // Ghi nội dung vào tệp tin
                        byte[] buffer = Encoding.UTF8.GetBytes(content.Trim());
                        stream.Write(buffer, 0, buffer.Length);

                        // Hiển thị thông báo khi hoàn thành việc lưu tệp tin
                        MessageBox.Show("Save completed.");

                        //Xóa dữ liệu ở RichTextBox
                        richTextBox1.Clear();
                        richTextBox2.Clear();
                        stream.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot save. Pleas try again later!");
            }

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Lines;
            string[] operators = { "+", "-", "*", "/" };
            double operand1, operand2, result;
            List<string> results = new List<string>();

            foreach (string line in lines)
            {
                string[] tokens = line.Split(' ');

                //  Kiểm tra dữ liệu vào có là phép tính hay không
                if (tokens.Length != 3 || !operators.Contains(tokens[1]))
                {
                    results.Add("Invalid input: " + line);
                    flag = !flag;
                    continue;
                }


                //  Kiểm tra 2 số có phải là kiểu số thực hay không
                if (!double.TryParse(tokens[0], out operand1) || !double.TryParse(tokens[2], out operand2))
                {
                    results.Add("Invalid input: " + line);
                    flag = !flag;
                    continue;
                }

                switch (tokens[1])
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        if (operand2 == 0)
                        {
                            results.Add("Cannot divide by zero: " + line);
                            flag = !flag;
                            continue;
                        }
                        result = operand1 / operand2;
                        break;
                    default:
                        results.Add("Invalid operator: " + line);
                        continue;
                }
                results.Add(line + " = " + result);
            }
            richTextBox2.Lines = results.ToArray();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
