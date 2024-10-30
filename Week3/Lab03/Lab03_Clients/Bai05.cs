using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03_Clients
{
    public partial class Bai05 : Form
    {
        private Socket clientSocket = null;
        private TcpClient client;

        public Bai05()
        {
            clientSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            InitializeComponent();
        }

    }
}
