using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai01 : Form
    {
        private Thread listenThread;

        public Bai01()
        {
            InitializeComponent();
            listView1.View = View.Details;  // Hiển thị theo dạng chi tiết
            listView1.Columns.Add("IP", 100);
            listView1.Columns.Add("Message", 300);
        }

        private void Listen()
        {
            int port;
            if (!int.TryParse(txtPort.Text, out port))
            {
                MessageBox.Show("Vui lòng nhập Port đúng.");
                return;
            }

            UdpClient udpClient = new UdpClient(port);
            MessageBox.Show("Server bắt đầu lắng nghe trên cổng " + port);

            while (true)
            {
                try
                {
                    IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receiveBytes = udpClient.Receive(ref remoteIpEndPoint);
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    string message = remoteIpEndPoint.Address.ToString() + ": " + returnData.Trim();

                    // Thêm log để kiểm tra tin nhắn nhận được
                    Console.WriteLine("Nhận từ: " + message);

                    listView1.Invoke(new Action(() => AddMessageToListView(remoteIpEndPoint.Address.ToString(), returnData)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhận dữ liệu: " + ex.Message);
                }
            }
        }

        private void AddMessageToListView(string ip, string message)
        {
            var item = new ListViewItem(ip);
            item.SubItems.Add(message);
            listView1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listenThread == null || !listenThread.IsAlive)
            {
                listenThread = new Thread(new ThreadStart(Listen));
                listenThread.IsBackground = true;
                listenThread.Start();
            }
        }
    }
}
