using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab03
{
    public partial class ServerForm : Form
    {
        private TcpListener server;
        private bool isRunning;


        public ServerForm()
        {
            InitializeComponent();
        }

        private void btnlisten_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                server = new TcpListener(IPAddress.Any, 8888);
                server.Start();
                isRunning = true;
                txtLog.AppendText("Server started...\n");
                Thread listenerThread = new Thread(ListenForClients);
                listenerThread.Start();
            }
        }
        private void ListenForClients()
        {
            while (isRunning)
            {
                TcpClient client = server.AcceptTcpClient();
                txtLog.Invoke(new Action(() => txtLog.AppendText("Client connected.\n")));
                Thread clientThread = new Thread(HandleClientComm);
                clientThread.Start(client);
            }
        }
        private void HandleClientComm(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    txtLog.Invoke(new Action(() => txtLog.AppendText($"Received: {message}\n")));
                }
            }
            catch (Exception ex)
            {
                txtLog.Invoke(new Action(() => txtLog.AppendText($"Error: {ex.Message}\n")));
            }
            finally
            {
                client.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            isRunning = false;
            server?.Stop();
            base.OnFormClosing(e);
        }
    }
}
    

