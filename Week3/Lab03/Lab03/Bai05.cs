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
        private TcpListener listener;
        private Dictionary<TcpClient, Thread> clients = new Dictionary<TcpClient, Thread>();

        public ServerForm()
        {
            InitializeComponent();
        }

       

    }
}
