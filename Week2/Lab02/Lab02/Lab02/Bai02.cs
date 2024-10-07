using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear dữ liệu cũ
            richTextBox2.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            string[] separatingStrings = { " ", "\r", "\n" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;

                // Đọc file từ đường dẫn
                using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    byte[] content = new byte[stream.Length];
                    stream.Read(content, 0, (int)stream.Length);
                    string text = Encoding.UTF8.GetString(content);

                    // Hiển thị file trong RichTextBox
                    richTextBox2.AppendText(text);

                    // Đếm số dòng
                    textBox6.Text = richTextBox2.Lines.Count().ToString();

                    // Đếm số từ
                    string[] lines = text.Split('\n');
                    int totalWords = 0;
                    foreach (string line in lines)
                    {
                        string[] words = line.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
                        totalWords += words.Length;
                    }

                    // Hiển thị số từ
                    textBox5.Text = totalWords.ToString();

                    // Hiển thị số ký tự bao gồm khoảng trắng
                    textBox3.Text = content.Length.ToString();

                    // Hiển thị số ký tự không tính khoảng trắng
                    int charCountWithoutSpaces = text.Count(c => !char.IsWhiteSpace(c));
                    textBox2.Text = charCountWithoutSpaces.ToString();

                    // Hiển thị tên tập tin
                    textBox1.Text = ofd.SafeFileName;

                    // Hiển thị Url
                    textBox4.Text = ofd.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
