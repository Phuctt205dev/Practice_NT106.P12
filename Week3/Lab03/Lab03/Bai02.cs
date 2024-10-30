using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai02 : Form
    {
        private Socket listenerSocket;

        public Bai02()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            listView1.View = View.Details;
            listView1.Columns.Add("Data", -2, HorizontalAlignment.Left);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
         
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(10);

            listView1.Items.Add(new ListViewItem("Listening for connections..."));
            listenerSocket.BeginAccept(AcceptCallback, null);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = listenerSocket.EndAccept(ar);
                listView1.Items.Add(new ListViewItem("New client connected"));

                // Xử lý nhận dữ liệu từ client trong một thread mới
                Thread thread = new Thread(() => ReceiveData(clientSocket));
                thread.Start();

                // Tiếp tục chấp nhận kết nối tiếp theo
                listenerSocket.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                listView1.Items.Add(new ListViewItem($"Error: {ex.Message}"));
            }
        }

        private void ReceiveData(Socket clientSocket)
        {
            try
            {
                byte[] recv = new byte[1];
                int bytesReceived;
                string text = "";

                while (clientSocket.Connected)
                {
                    text = "";
                    do
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        text += Encoding.ASCII.GetString(recv);
                    } while (text[text.Length - 1] != '\n');

                    // Cập nhật UI khi nhận được dữ liệu
                    listView1.Items.Add(new ListViewItem(text.Trim()));
                }
            }
            catch (Exception ex)
            {
                listView1.Items.Add(new ListViewItem($"Error: {ex.Message}"));
            }
            finally
            {
                clientSocket?.Close();
                listView1.Items.Add(new ListViewItem("Connection closed."));
            }
        }

        private void Bai02_FormClosing(object sender, FormClosingEventArgs e)
        {
            listenerSocket?.Close();
        }
    }
}
