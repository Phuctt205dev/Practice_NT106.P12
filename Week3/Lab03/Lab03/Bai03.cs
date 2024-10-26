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
    public partial class Bai03 : Form
    {
        private TcpListener tcpListener;
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private byte[] receiveBuffer = new byte[1024];
        public Bai03()
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

                rtbMessage.AppendText("Đang lắng nghe kết nối từ Client...\n");
                while (true)
                {
                    tcpListener.BeginAcceptTcpClient(HandleTcpClient, tcpListener);
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
                tcpClient = tcpListener.EndAcceptTcpClient(ar);
                networkStream = tcpClient.GetStream();

                string ip = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();

                rtbMessage.Invoke(new Action(() => rtbMessage.AppendText("Đã kết nối đến: " + ip + "\n")));

                Receive();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Receive()
        {
            networkStream.BeginRead(receiveBuffer, 0, receiveBuffer.Length, HandleReceive, networkStream);
        }

        private void HandleReceive(IAsyncResult ar)
        {
            try
            {
                int bytesRead = networkStream.EndRead(ar);

                if (bytesRead > 0)
                {
                    string message = Encoding.UTF8.GetString(receiveBuffer, 0, bytesRead);

                    rtbMessage.Invoke(new Action(() => rtbMessage.AppendText(message + "\n")));


                    Array.Clear(receiveBuffer, 0, receiveBuffer.Length);

                    Receive();
                }
                else // Kết nối đã bị đóng
                {
                    string ip = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
                    rtbMessage.Invoke(new Action(() => rtbMessage.AppendText(ip + " đã ngắt kết nối.\n")));

                    tcpClient.Close();
                    tcpClient = null;
                    networkStream.Close();
                    networkStream = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
    }
}

