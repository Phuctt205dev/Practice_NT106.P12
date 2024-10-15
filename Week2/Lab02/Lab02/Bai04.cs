using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai04 : Form
    {
        private int currentIndex = 1;
        private List<string[]> peopleData = new List<string[]>();

        public Bai04()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (peopleData.Count == 0)
                {
                    MessageBox.Show("No data available", "Error");
                    return;
                }

                currentIndex++; // Tăng chỉ số trang
                if (currentIndex >= peopleData.Count)
                {
                    currentIndex = 0; // Quay lại trang đầu nếu vượt quá chỉ số cuối
                }

                DisplayCurrentPersonData(); // Hiển thị dữ liệu của trang hiện tại
                UpdatePaginationDisplay();  // Cập nhật số trang hiển thị
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        



        private void UpdatePaginationDisplay()
        {
            if (peopleData.Count > 0)
            {
                lbPage.Text = $"{currentIndex + 1} / {peopleData.Count}"; // Hiển thị trang hiện tại và tổng số trang
            }
            else
            {
                lbPage.Text = "0 / 0"; // Nếu không có dữ liệu
            }
        }

        private void DisplayCurrentPersonData()
        {
            string[] personData = peopleData[currentIndex];
            txtbNameShow.Text = personData[0];
            txtbIDShow.Text = personData[1];
            txtbPNumShow.Text = personData[2];
            txtbR1_Show.Text = personData[3];
            txtbR2_Show.Text = personData[4];
            txtbR3_Show.Text = personData[5];
            txtbAverShow.Text = personData[6];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool NullOrEmpty()
        {
            return string.IsNullOrEmpty(txtbName1.Text) ||
                   string.IsNullOrEmpty(txtbID1.Text) ||
                   string.IsNullOrEmpty(txtbPNum1.Text) ||
                   string.IsNullOrEmpty(txtbR1_1.Text) ||
                   string.IsNullOrEmpty(txtbR2_1.Text) ||
                   string.IsNullOrEmpty(txtbR3_1.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (NullOrEmpty())
                {
                    throw new Exception("Type all!");
                }
                if (txtbID1.Text.Length != 8)
                {
                    throw new Exception("ID must have exactly 8 characters!");
                }

                double r1, r2, r3;
                bool check1 = double.TryParse(txtbR1_1.Text, out r1);
                bool check2 = double.TryParse(txtbR2_1.Text, out r2);
                bool check3 = double.TryParse(txtbR3_1.Text, out r3);

                if (!check1 || !check2 || !check3)
                {
                    throw new Exception("Please enter valid numbers only.");
                }
                else
                {
                    string[] personData = new string[]
                    {
                        txtbName1.Text.Trim(),
                        txtbID1.Text.Trim(),
                        txtbPNum1.Text.Trim(),
                        txtbR1_1.Text.Trim(),
                        txtbR2_1.Text.Trim(),
                        txtbR3_1.Text.Trim(),
                        ((r1 + r2 + r3) / 3).ToString("F2")
                    };
                    peopleData.Add(personData);

                    Present.AppendText(txtbName1.Text + Environment.NewLine);
                    Present.AppendText(txtbID1.Text + Environment.NewLine);
                    Present.AppendText(txtbPNum1.Text + Environment.NewLine);
                    Present.AppendText(txtbR1_1.Text + Environment.NewLine);
                    Present.AppendText(txtbR2_1.Text + Environment.NewLine);
                    Present.AppendText(txtbR3_1.Text + Environment.NewLine);
                    Present.AppendText(personData[6] + Environment.NewLine);

                    txtbName1.Clear();
                    txtbID1.Clear();
                    txtbPNum1.Clear();
                    txtbR1_1.Clear();
                    txtbR2_1.Clear();
                    txtbR3_1.Clear();
                    txtbAver1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = Present.Text;
                File.WriteAllText(saveFileDialog.FileName, content);
                MessageBox.Show("Data has been written! ", "Notification");
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFile.FileName);
                Present.Text = content;

                currentIndex = 0;
                peopleData.Clear();

                string[] lines = Present.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                for (int i = 0; i < lines.Length; i += 7)
                {
                    if (i + 6 < lines.Length)
                    {
                        string[] personData = new string[7]
                        {
                            lines[i].Trim(),
                            lines[i + 1].Trim(),
                            lines[i + 2].Trim(),
                            lines[i + 3].Trim(),
                            lines[i + 4].Trim(),
                            lines[i + 5].Trim(),
                            lines[i + 6].Trim()
                        };
                        peopleData.Add(personData);
                    }
                }
                if (peopleData.Count > 0)
                {
                    DisplayCurrentPersonData();
                    UpdatePaginationDisplay(); // Cập nhật hiển thị sau khi đọc dữ liệu từ file
                }
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (peopleData.Count == 0)
                {
                    MessageBox.Show("No data available", "Error");
                    return;
                }

                currentIndex--; // Giảm chỉ số trang
                if (currentIndex < 0)
                {
                    currentIndex = peopleData.Count - 1; // Quay về trang cuối cùng nếu giảm về âm
                }

                DisplayCurrentPersonData(); // Hiển thị dữ liệu của trang hiện tại
                UpdatePaginationDisplay();  // Cập nhật số trang hiển thị
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
