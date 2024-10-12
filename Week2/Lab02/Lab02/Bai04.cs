using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void rtb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai04_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbName1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool NullOrEmpty()
        {
            if (string.IsNullOrEmpty(txtbName1.Text) || string.IsNullOrEmpty(txtbID1.Text) || string.IsNullOrEmpty(txtbPNum1.Text) || string.IsNullOrEmpty(txtbR1_1.Text) || string.IsNullOrEmpty(txtbR2_1.Text) || string.IsNullOrEmpty(txtbR3_1.Text))
            {
                return true;
            }
            return false;
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
                    throw new Exception("ID must have enough 8 characters!");
                }
                double r1, r2, r3;
                bool check1 = double.TryParse(txtbR1_1.Text, out r1);
                bool check2 =double.TryParse(txtbR2_1.Text, out r2);
                bool check3=double.TryParse(txtbR3_1.Text, out r3);
                if (check1 == false || check2 == false || check3 == false) { throw new Exception("Number Only"); }
                else
                {
                    Present.AppendText(txtbName1.Text + Environment.NewLine);
                    Present.AppendText(txtbID1.Text + Environment.NewLine);
                    Present.AppendText(txtbPNum1.Text + Environment.NewLine);
                    Present.AppendText(txtbR1_1.Text + Environment.NewLine);
                    Present.AppendText(txtbR2_1.Text + Environment.NewLine);
                    Present.AppendText(txtbR3_1.Text + Environment.NewLine);
                    double aver = ((r1 + r2 + r3) / 3);
                    txtbAver1.Text = aver.ToString();
                    Present.AppendText(txtbAver1.Text + Environment.NewLine);
                    txtbName1.Clear();
                    txtbID1.Clear();
                    txtbPNum1.Clear();
                    txtbR1_1.Clear();
                    txtbR2_1.Clear();
                    txtbR3_1.Clear();
                    txtbAver1.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter= "Text files (*.txt)|*.txt|All files (*.*)|*.*";
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
            }
        }
    }
}
