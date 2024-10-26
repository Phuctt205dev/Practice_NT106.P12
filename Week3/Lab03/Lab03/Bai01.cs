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
    public partial class Bai01 : Form
    {
        private UdpClient udpServer;
        private Thread serverThread;
        private Thread listenThread;

        public Bai01()
        {
            InitializeComponent();
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

            while (true)
            {
                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receiveBytes = udpClient.Receive(ref remoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string message = remoteIpEndPoint.Address.ToString().Trim() + ": " + returnData.ToString().Trim();

                // Sử dụng phương thức Invoke để gọi hàm AddMessageToListView trên UI Thread
                txtReceivedMessages.Invoke(new Action(() => AddMessageToRichTextBox(message)));
            }
        }

        private void AddMessageToRichTextBox(string message)
        {
            txtReceivedMessages.AppendText(message.Trim() + "\t\n");
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