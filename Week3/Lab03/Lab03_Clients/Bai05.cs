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
        private TcpClient client;
        private NetworkStream stream;

        public Bai05()
        {
           
            InitializeComponent();
        }

      
    }
}
