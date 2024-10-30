using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab03_Clients
{
    public partial class Bai04 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;

        public Bai04()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 12345);
                stream = client.GetStream();
                rtbSendMess.AppendText("Kết nối đến server thành công.\n");

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến server: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string username = tbUsr.Text;
            string messageContent = rtbMess.Text;

            if (!string.IsNullOrEmpty(messageContent))
            {
                // Định dạng tin nhắn với tên người dùng
                string message = $"{username}: {messageContent}";

                // Mã hóa tin nhắn và gửi đến server
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);

                // Hiển thị tin nhắn vừa gửi trong rtbSendMess và xóa nội dung trong rtbMess
                rtbSendMess.AppendText($"Me: {messageContent}\n");
                rtbMess.Clear();
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int byteCount;

            while (client.Connected)
            {
                try
                {
                    byteCount = stream.Read(buffer, 0, buffer.Length);
                    if (byteCount > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                        rtbSendMess.Invoke((MethodInvoker)(() => rtbSendMess.AppendText(message + "\n")));
                    }
                }
                catch (Exception ex)
                {
                    rtbSendMess.Invoke((MethodInvoker)(() => rtbSendMess.AppendText("Ngắt kết nối từ server.\n")));
                    break;
                }
            }
        }

        private void Bai04_FormClosing(object sender, FormClosingEventArgs e)
        {
            receiveThread?.Abort();
            client?.Close();
        }

        private void rtbSendMess_TextChanged(object sender, EventArgs e)
        {
            // Bạn có thể thêm mã ở đây nếu muốn xử lý các sự kiện liên quan đến thay đổi trong rtbSendMess
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    MessageBox.Show("Chưa thiết lập kết nối tới server.");
                    return;
                }

                // Tạo dialog để chọn file
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png|Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file được chọn
                    string filePath = openFileDialog.FileName;
                    byte[] fileData = File.ReadAllBytes(filePath); // Đọc nội dung file

                    // Gửi dữ liệu file
                    stream.Write(fileData, 0, fileData.Length);
                    MessageBox.Show("Đã gửi file: " + Path.GetFileName(filePath));
                }
                else
                {
                    MessageBox.Show("Không có file nào được chọn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
    
    

