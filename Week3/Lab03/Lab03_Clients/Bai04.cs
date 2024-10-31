using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Lab03_Clients
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            btn_OK.Enabled = true;
            btn_Send.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_SendImage.Enabled = false;
            txt_Message.ReadOnly = true;
            txt_Name1.ReadOnly = true;
        }

        IPEndPoint IP;
        Socket client;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string ip = txt_IP.Text;
            if (!int.TryParse(txt_Port.Text, out int test1) || txt_Port.Text == "")
            {
                MessageBox.Show("mời nhập đúng cổng là một số nguyên!!!");
                return;
            }
            if (!IPAddress.TryParse(ip, out IPAddress test) || txt_IP.Text == "")
            {
                MessageBox.Show("mời nhập đúng địa chỉ IP!!!");
                return;
            }


            IP = new IPEndPoint(IPAddress.Parse(ip), Int32.Parse(txt_Port.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IP);
                client.Send(Encoding.UTF8.GetBytes(txt_Name.Text + " đã vào phòng "));
                MessageBox.Show("Ket noi thanh cong !", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Khong the ket noi toi server !", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            btn_OK.Enabled = false;
            btn_Send.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_SendImage.Enabled = true;
            txt_Message.ReadOnly = false;
            txt_Name1.ReadOnly = false;
            txt_Name.ReadOnly = true;
            txt_Port.ReadOnly = true;
            txt_IP.ReadOnly = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_IP.Text = "";
            txt_Port.Text = "";
            client?.Send(Encoding.UTF8.GetBytes(txt_Name.Text + " đã rời phòng "));
            client?.Close();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                Send();
                AddMess(txt_Name.Text + ": " + txt_Message.Text);
            }
            catch
            {

                MessageBox.Show("Chưa kết nối tới server nên không thể gửi tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        void Send()
        {
            if (txt_Message.Text != string.Empty)
            {
                if (txt_Name1.Text == string.Empty)
                {
                    byte[] data = Encoding.UTF8.GetBytes(txt_Name.Text + ": " + txt_Message.Text);
                    client?.Send(data);
                }
                else
                {
                    byte[] data = Encoding.UTF8.GetBytes(txt_Name.Text + ": " + txt_Message.Text + "@" + txt_Name1.Text + "@");
                    client?.Send(data);
                }


            }
        }

 private void Receive()
{
    try
    {
        while (true)
        {
            byte[] initialData = new byte[1024];
            int receivedBytes = client.Receive(initialData);
            string mess = Encoding.UTF8.GetString(initialData, 0, receivedBytes).Trim('\0');

            if (mess.Contains("(PR.IMAGE)")) 
            {
                byte[] imageSizeBytes = new byte[4];
                client.Receive(imageSizeBytes);
                int imageSize = BitConverter.ToInt32(imageSizeBytes, 0);

                // Nhận ảnh
                byte[] imageData = new byte[imageSize];
                int totalReceived = 0;
                while (totalReceived < imageSize)
                {
                    int bytesReceived = client.Receive(imageData, totalReceived, imageSize - totalReceived, SocketFlags.None);
                    if (bytesReceived == 0) break;
                    totalReceived += bytesReceived;
                }

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pb_Avatar.Image = null;
                    Image image = Image.FromStream(ms);
                    Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                    pb_Avatar.Image = thumb;
                }
                AddMess("Đã nhận ảnh từ server.");
            }
            else if (mess.Contains("(TXT)")) 
            {
                byte[] textSizeBytes = new byte[4];
                client.Receive(textSizeBytes);
                int textSize = BitConverter.ToInt32(textSizeBytes, 0);

                byte[] textData = new byte[textSize];
                int totalReceived = 0;
                while (totalReceived < textSize)
                {
                    int bytesReceived = client.Receive(textData, totalReceived, textSize - totalReceived, SocketFlags.None);
                    if (bytesReceived == 0) break;
                    totalReceived += bytesReceived;
                }

                string fileContent = Encoding.UTF8.GetString(textData);
                AddMess("Nội dung file .txt:\n" + fileContent);
            }
            else 
            {
                AddMess(mess);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi trong quá trình nhận dữ liệu: " + ex.Message);
        Close();
    }
}
        void AddMess(string s)
        {
            lv_ShowConversation.Items.Add(new ListViewItem() { Text = s });
            txt_Message.Clear();
        }

        private void btn_SendImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string k = ofd.FileName;
            //MessageBox.Show(k);
            byte[] imageData = File.ReadAllBytes(k);
            string s = "";
            if (txt_Name1.Text != string.Empty)
            {
                s = "$" + txt_Name1.Text + "$";
            }
            client?.Send(Encoding.UTF8.GetBytes(txt_Name.Text + " (IMG) " + s));

            int imageSize = imageData.Length;
            byte[] imageSizeBytes = BitConverter.GetBytes(imageSize);
            client?.Send(imageSizeBytes);
            // Gửi ảnh
            client?.Send(imageData);

            System.Drawing.Image image = System.Drawing.Image.FromFile(k); // đọc file ảnh từ đường dẫn
            System.Drawing.Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
            pb_Avatar.Image = thumb; // hiển thị ảnh lên PictureBox

        }

        private void client_t4_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thoát?");
            try
            {
                client?.Send(Encoding.UTF8.GetBytes(txt_Name.Text + " đã rời phòng "));
                client?.Close();
            }
            catch { }
        }
       



        private void txt_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SendTxt_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc nội dung của file .txt
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    byte[] textData = Encoding.UTF8.GetBytes(fileContent); // Chuyển đổi thành mảng byte

                    // Gửi thông báo rằng có file đang được gửi
                    string message = txt_Name.Text + " đã gửi file .txt (TXT)";
                    client.Send(Encoding.UTF8.GetBytes(message));

                    // Gửi kích thước file
                    client.Send(BitConverter.GetBytes(textData.Length));

                    // Gửi nội dung file
                    client.Send(textData);

                    AddMess("Đã gửi file .txt."); // Hiển thị thông báo trên giao diện
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gửi file .txt: " + ex.Message); // Thông báo lỗi
                }
            }
        }
        private void lv_ShowConversation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}