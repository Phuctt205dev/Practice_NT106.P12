using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03_Clients
{

    public partial class Bai04 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string receivedData;
        public Bai04()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một kết nối tới server
                client = new TcpClient(tbIP.Text, int.Parse(tbPort.Text));
                stream = client.GetStream();

                // Khởi tạo thread nhận dữ liệu từ server
                Thread receiveThread = new Thread(new ThreadStart(ReceiveData));
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    MessageBox.Show("Chưa thiết lập kết nối tới server.");
                    return;
                }
                // Lấy dữ liệu từ RichTextBox và gửi đi
                string message = tbUsr.Text + ": " + rtbMess.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // Lưu dữ liệu đã gửi đi vào biến receivedData
                receivedData = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Phương thức để thêm người tham gia vào ListBox
        private void AddParticipant(string participantName)
        {
            if (!string.IsNullOrEmpty(participantName))
            {
                // Kiểm tra nếu đang ở luồng chính hoặc luồng khác
                if (lbParticipants.InvokeRequired)
                {
                    lbParticipants.Invoke((MethodInvoker)delegate {
                        lbParticipants.Items.Add(participantName);
                    });
                }
                else
                {
                    lbParticipants.Items.Add(participantName);
                }
            }
        }

        // Ví dụ: Gọi phương thức AddParticipant khi có người mới tham gia
        private void OnNewParticipantJoined(string participantName)
        {
            AddParticipant(participantName);
        }

        // Sự kiện giả định gọi hàm trên khi có người tham gia chat
        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            string newParticipant = "Tên Người Tham Gia"; // Thay bằng tên thực tế
            OnNewParticipantJoined(newParticipant);
        }

        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) continue;

                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                    Invoke((MethodInvoker)delegate
                    {
                        if (response.StartsWith("ClientList:"))
                        {
                            // Cập nhật danh sách người tham gia
                            lbParticipants.Items.Clear();
                            string[] clients = response.Substring(11).Split(',');
                            foreach (string clientName in clients)
                            {
                                // Kiểm tra tên client có hợp lệ không
                                if (!string.IsNullOrWhiteSpace(clientName))
                                {
                                    lbParticipants.Items.Add(clientName.Trim());
                                }
                            }
                        }
                        else
                        {
                            // Hiển thị tin nhắn nhận được
                            rtbSendMess.AppendText(response + "\n");
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu: " + ex.Message);
            }
        }

       

        private void lbParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {

            
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
                    // Nếu không chọn file, có thể gửi một tin nhắn văn bản khác nếu cần
                    MessageBox.Show("Không có file nào được chọn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void lbParticipants_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
    }

        

    }
}
