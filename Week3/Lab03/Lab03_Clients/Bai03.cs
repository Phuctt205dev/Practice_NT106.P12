using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Clients
{
    public partial class Bai03 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public Bai03()
        {
            InitializeComponent();
        }

        private void tbnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một kết nối tới server
                client = new TcpClient(tbIP.Text, int.Parse(tbPort.Text));
                stream = client.GetStream();

                // Thông báo trạng thái kết nối đến người dùng
                rtbSentMess.AppendText("Đã kết nối tới server " + tbIP.Text + ":" + tbPort.Text + "\n");
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
                string message = textBox1.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);


                // Thông báo cho người dùng biết rằng dữ liệu đã được gửi
                rtbSentMess.AppendText("Đã gửi dữ liệu: " + message + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    // Đóng stream và client
                    stream.Close();
                    client.Close();

                    rtbSentMess.AppendText("Đã ngắt kết nối khỏi server.\n");
                }
                else
                {
                    MessageBox.Show("Chưa kết nối tới server.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
