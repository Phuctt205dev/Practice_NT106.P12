using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai04 : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private Thread listenThread;

        public Bai04()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, 12345);
            server.Start();
            rtbMessage.AppendText("Server đang chạy...\n");

            listenThread = new Thread(ListenForClients);
            listenThread.Start();
        }
        private void ListenForClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                clients.Add(client);
                rtbMessage.Invoke((MethodInvoker)(() => rtbMessage.AppendText("Client mới kết nối.\n")));

                Thread clientThread = new Thread(HandleClient);
                clientThread.Start(client);
            }
        }
        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int byteCount;

            while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                rtbMessage.Invoke((MethodInvoker)(() => rtbMessage.AppendText(message + "\n")));
                Broadcast(message);
            }

            clients.Remove(client);
            client.Close();
        }
        private void Broadcast(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            foreach (var client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }
        }

    }
}