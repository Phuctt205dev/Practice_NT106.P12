using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Runtime.CompilerServices;

namespace Lab03
{
    public partial class Bai04 : Form
    {
        private IPEndPoint TCP;
        private Socket server;
        private List<Socket> clientList;
        private Dictionary<string, Socket> clientDictionary;

        public Bai04()
        {
            InitializeComponent();
            lv_ListAccount.Items.Add(new ListViewItem() { Text = "DANH SÁCH" });
            btn_Send.Enabled = false;
            btn_SendImage.Enabled = false;
            btn_Disconnect.Enabled = false;
            btn_ListClientsConnecting.Enabled = false;
            txt_Message.ReadOnly = true;
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (!int.TryParse(txt_Port.Text, out int test1) || txt_Port.Text == "")
            {
                MessageBox.Show("mời nhập đúng cổng là một số nguyên!!!");
                return;
            }
            Connect();
            btn_Listen.Enabled = false;
            btn_Send.Enabled = true;
            btn_SendImage.Enabled = true;
            btn_Disconnect.Enabled = true;
            btn_ListClientsConnecting.Enabled = true;
            txt_Message.ReadOnly = false;
        }
        void Connect()
        {
            clientDictionary = new Dictionary<string, Socket>();
            clientList = new List<Socket>();
            TCP = new IPEndPoint(IPAddress.Any, Int32.Parse(txt_Port.Text));
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(TCP);
            AddMessage("Bắt đầu lắng nghe tại port " + txt_Port.Text);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        //clientList.Remove(client);
                        //listView1.Items.Add(new ListViewItem("New client connected"));
                        // Bắt đầu lắng nghe tin nhắn từ client
                        Thread ReceiveThread = new Thread(() => Receive(client));
                        ReceiveThread.IsBackground = true;
                        ReceiveThread.Start();
                    }
                }
                catch
                {
                    TCP = new IPEndPoint(IPAddress.Any, Int32.Parse(txt_Port.Text));
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }
        void AddMessage(string s)
        {
            lv_Message.Items.Add(new ListViewItem() { Text = s });
        }
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {

            try
            {

                if (clientList != null)
                {
                    txt_Message.Text = "Server ngắt kết nối ";
                    foreach (Socket item in clientList)
                    {
                        Send(item);
                    }
                    txt_Message.Text = "";
                    AddMessage("Server ngắt kết nối ");
                }
                server?.Close();
            }
            catch { }
            btn_Listen.Enabled = true;
            btn_Send.Enabled = false;
            btn_SendImage.Enabled = false;
            btn_Disconnect.Enabled = false;
            btn_ListClientsConnecting.Enabled = false;
            txt_Message.ReadOnly = true;
        }
        void Receive(Socket client)
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    client.Receive(data);
                    string message = Encoding.UTF8.GetString(data);
                    string clientAddress = client.RemoteEndPoint.AddressFamily.ToString();


                    if (message.Contains('@'))
                    {

                        int startIndex = message.IndexOf('@') + 1;
                        int endIndex = message.IndexOf('@', startIndex);
                        string string1 = message.Substring(startIndex, endIndex - startIndex);
                        string output = message.Replace("@" + string1 + "@", "");
                        try
                        {
                            if (clientDictionary != null && clientDictionary.ContainsKey(string1))
                            {
                                {
                                    byte[] messageBytes = Encoding.UTF8.GetBytes("private from " + output);
                                    Socket clientASocket = clientDictionary[string1]; // tạo socket riêng 
                                    clientASocket.Send(messageBytes); // gửi tin nhắn từ server đến 1 client
                                }
                            }
                        }
                        catch { }



                    }
                    else if (message.Contains("đã vào phòng") && client != null)
                    {
                        string[] words = message.Split(new[] { "đã vào phòng" }, StringSplitOptions.None);
                        string result = words[0].Trim();
                        if (!check(result))
                        {
                            AddMessage(message);
                            lv_ListAccount.Items.Add(new ListViewItem() { Text = result });
                            //dsclient.Add(result, client);
                            clientDictionary.Add(words[0].Trim(), client);

                        }
                        else clientList.Remove(client);

                    }
                    else if (message.Contains("(IMG)"))
                    {// Nhận kích thước ảnh

                        byte[] imageSizeBytes = new byte[4];
                        client.Receive(imageSizeBytes);
                        int imageSize = BitConverter.ToInt32(imageSizeBytes, 0);

                        // Nhận ảnh
                        byte[] imageData = new byte[imageSize];
                        client.Receive(imageData);
                        File.WriteAllBytes("image.jpg", imageData);

                        //using (MemoryStream ms = new MemoryStream(imageData))
                        //{
                        //    pictureBox1.Image = null;
                        //    Image image = Image.FromStream(ms);
                        //    Image thumb = image.GetThumbnailImage(200, 200, () => false, IntPtr.Zero);
                        //    pictureBox1.Image = thumb;
                        //}

                        if (message.Contains('$'))
                        {
                            int startIndex = message.IndexOf('$') + 1;
                            int endIndex = message.IndexOf('$', startIndex);
                            string string1 = message.Substring(startIndex, endIndex - startIndex);
                            string output = message.Replace("$" + string1 + "$", "");

                            try
                            {
                                if (clientDictionary != null && clientDictionary.ContainsKey(string1))
                                {
                                    PrivateImageSend(string1);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Không có client nào như vậy trong danh sách");
                            }
                        }
                        else SI("image.jpg");
                    }
                    else
                    {
                        AddMessage(message);
                        if (clientList != null)
                            foreach (Socket item in clientList)
                            {
                                if (item != client)
                                    item.Send(Encoding.UTF8.GetBytes(message));


                            }
                    }

                    if (message.Contains("đã rời phòng") && client != null)
                    {

                        string[] words = message.Split(new[] { "đã rời phòng" }, StringSplitOptions.None);
                        string result = words[0].Trim();
                        foreach (ListViewItem item in lv_ListAccount.Items)
                        {
                            if (item.Text == result)
                            {
                                lv_Message.Items.Remove(item);
                                break;
                            }
                        }

                        clientDictionary.Remove(words[0].Trim());
                        clientList.Remove(client);
                    }




                }
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
        }
        private void btn_ListClientsConnecting_Click(object sender, EventArgs e)
        {
            lb_Client.Items.Clear();
            if (clientDictionary != null)
            {
                try
                {
                    foreach (string key in clientDictionary.Keys)
                    {
                        lb_Client.Items.Add(key);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (clientList != null)
            {
                foreach (Socket item in clientList)
                {
                    Send(item);
                }
                AddMessage("Admin: " + txt_Message.Text);
                txt_Message.Clear();
            }
        }
        void Send(Socket client)
        {

            if ((client != null) && (txt_Message.Text != string.Empty))
            {
                client.Send(Encoding.UTF8.GetBytes("Admin : " + txt_Message.Text));
            }

        }
        bool check(string s)
        {
            string compareString = s;
            bool found = false;
            foreach (ListViewItem item in lv_ListAccount.Items)
            {
                if (item.Text.Equals(compareString))
                {
                    found = true;
                    break;
                }
            }
            return found;

       
    }
        private void btn_SendImage_Click(object sender, EventArgs e)
        {
            // Đọc đường dẫn file ảnh
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string k = ofd.FileName;
            //MessageBox.Show(k);
            SI(k);
        }
        void SI(string k)
        {
            //MessageBox.Show(k);
            byte[] imageData = File.ReadAllBytes(k);
            // Gửi kích thước ảnh
            byte[] imageSizeBytes = BitConverter.GetBytes(imageData.Length);


            pb_Avatar.Image = null;
            Image image = Image.FromFile(k);
            Image thumb = image.GetThumbnailImage(400, 450, () => false, IntPtr.Zero);
            pb_Avatar.Image = thumb;
            if (clientList != null)
            {
                foreach (Socket item in clientList)
                {

                    item.Send(Encoding.UTF8.GetBytes("(PR.IMAGE)"));

                    item.Send(imageSizeBytes);
                    // Gửi dữ liệu ảnh
                    item.Send(imageData);
                }
            }
        }
        private void lb_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Client.SelectedIndex != -1)
            {
                // Lấy nội dung của mục được chọn
                string selected = lb_Client.SelectedItem.ToString();

                string message = lb_Client.Text;
                byte[] messageBytes = Encoding.ASCII.GetBytes(message);
                if (selected != null)
                {
                    Socket clientASocket = clientDictionary[selected]; // tạo socket riêng
                    clientASocket.Send(messageBytes); // gửi tin nhắn từ server đến 1 client
                }

            }
        }
        void PrivateImageSend(string x)
        {
            //MessageBox.Show(k);
            byte[] imageData = File.ReadAllBytes("image.jpg");
            // Gửi kích thước ảnh
            byte[] imageSizeBytes = BitConverter.GetBytes(imageData.Length);

            Socket clientASocket = clientDictionary[x]; // tạo socket riêng 
            clientASocket.Send(Encoding.UTF8.GetBytes("(PR.IMAGE) Có người gửi riêng ảnh cho bạn")); // gửi tin nhắn từ server đến 1 client\


            clientASocket.Send(imageSizeBytes);
            // Gửi dữ liệu ảnh
            clientASocket.Send(imageData);
        }
    }
}
