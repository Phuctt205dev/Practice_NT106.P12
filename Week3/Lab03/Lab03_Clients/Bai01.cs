using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Clients
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();
                IPAddress ipadd = IPAddress.Parse(txtIP.Text);
                int port = Convert.ToInt32(txtPort.Text);
                IPEndPoint ipend = new IPEndPoint(ipadd, port);
                Byte[] sendBytes = Encoding.UTF8.GetBytes(txtMessage.Text);
                udpClient.Send(sendBytes, sendBytes.Length, ipend);


                udpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
