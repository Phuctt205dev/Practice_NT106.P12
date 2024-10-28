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
    public partial class Bai02 : Form
    {
        private Socket socket;
        private Socket client;

        public Bai02()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(new IPEndPoint(IPAddress.Any, 8080));
                socket.Listen(5);

                btnListen.Enabled = false;
                listView1.Items.Add("Đang lắng nghe...");

                socket.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                client = socket.EndAccept(ar);
                listView1.Invoke(new Action(() => {
                    listView1.Items.Add("ket noi thanh cong !");
                }));

                Thread thread = new Thread(HandleClient);
                thread.Start();

                // Continue listening for other connections
                socket.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void HandleClient()
        {
            while (true)
            {
                try
                {
                    StringBuilder dataBuilder = new StringBuilder();
                    while (true)
                    {
                        byte[] buffer = new byte[1024];
                        int bytesReceived = client.Receive(buffer);
                        string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                        dataBuilder.Append(receivedData);
                        if (receivedData.EndsWith(Environment.NewLine))
                        {
                            break;
                        }
                    }
                    string data = dataBuilder.ToString();
                    listView1.Invoke(new Action(() => {
                        ListViewItem item = new ListViewItem(data);
                        listView1.Items.Add(item);
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    break;
                }
            }
            client.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
