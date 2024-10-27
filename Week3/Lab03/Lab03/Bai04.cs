using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai04 : Form
    {
        private static TcpListener tcpListener;

        private static readonly List<TcpClient> clients = new List<TcpClient>();
        public Bai04()
        {
            InitializeComponent();
        }

        
        void StartUnsafeThread()
        {
            int port;
            if (!int.TryParse(tbPort.Text, out port))
            {
                MessageBox.Show("Vui lòng nhập Port đúng.");
                return;
            }

            if (tcpListener == null)
            {
                tcpListener = new TcpListener(IPAddress.Any, port);
                tcpListener.Start();

                rtbMessage.AppendText("Đang lắng nghe kết nối từ Clients...\n");
                while (true)
                {
                    tcpListener.BeginAcceptTcpClient(new AsyncCallback(HandleTcpClient), tcpListener);
                }
            }

            else
            {
                MessageBox.Show("Đã có kết nối đang được lắng nghe.");
            }
        }
        private void HandleTcpClient(IAsyncResult ar)
        {
            try
            {
                TcpListener listener = (TcpListener)ar.AsyncState;
                TcpClient client = listener.EndAcceptTcpClient(ar);
                string ip = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

                rtbMessage.Invoke(new Action(() => rtbMessage.AppendText("Đã kết nối đến: " + ip + "\n")));

                clients.Add(client);

                // Tạo một thread mới để xử lý dữ liệu đến từ client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HandleClientComm(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            NetworkStream stream = client.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        rtbMessage.Invoke(new Action(() => rtbMessage.AppendText("Tin nhắn từ " + ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString() + ": " + message + "\n")));
                        BroadcastMessage(message);
                    }
                }
                catch
                {
                    // Kết nối đã bị đóng
                    clients.Remove(client);
                    rtbMessage.Invoke(new Action(() => rtbMessage.AppendText(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString() + " đã ngắt kết nối.\n")));
                    break;
                }
            }
        }

        private void BroadcastMessage(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            foreach (TcpClient client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
    }
}