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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }
    
        private void writerbutton_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;
                using (FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write))
                {
                    string content = richTextBox1.Text.ToUpper();
                    byte[] buffer = Encoding.UTF8.GetBytes(content.Trim());
                    stream.Write(buffer, 0, buffer.Length);
                    MessageBox.Show("Save completed");
                    richTextBox1.Clear();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void readfile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    byte[] content = new byte[stream.Length];
                    stream.Read(content, 0, content.Length);
                    richTextBox1.AppendText(Encoding.UTF8.GetString(content));
                    stream.Close();
                }
            }
        }
    }
}

