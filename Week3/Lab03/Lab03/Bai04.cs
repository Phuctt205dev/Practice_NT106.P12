using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Linq;

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
            btn_Disconnect.Enabled = false;
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (!int.TryParse(txt_Port.Text, out int test1) || txt_Port.Text == "")
            {
                MessageBox.Show("Mời nhập đúng cổng là một số nguyên!!!");
                return;
            }
            Connect();
            btn_Listen.Enabled = false;
            btn_Disconnect.Enabled = true;
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
                    AddMessage("Server ngắt kết nối ");
                    foreach (Socket item in clientList)
                    {
                        item.Close();
                    }
                    clientList.Clear();
                    clientDictionary.Clear();
                }
                server?.Close();
            }
            catch { }

            btn_Listen.Enabled = true;
            btn_Disconnect.Enabled = false;
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
                    else if (message.Contains("(TXT)"))
                    {
                        byte[] textSizeBytes = new byte[4];
                        client.Receive(textSizeBytes);
                        int textSize = BitConverter.ToInt32(textSizeBytes, 0);

                        byte[] textData = new byte[textSize];
                        int totalReceived = 0;
                        while (totalReceived < textSize)
                        {
                            int bytesReceived = client.Receive(textData, totalReceived, textSize - totalReceived, SocketFlags.None);
                            if (bytesReceived == 0) break;
                            totalReceived += bytesReceived;
                        }

                        // Chuyển đổi nội dung văn bản sang UTF-8
                        string fileContent = Encoding.UTF8.GetString(textData);
                        AddMessage("Nội dung file .txt:\n" + fileContent);

                        // Gửi nội dung tệp đến tất cả client
                        byte[] contentBytes = Encoding.UTF8.GetBytes("(TXT) " + fileContent);
                        foreach (Socket item in clientList)
                        {
                            if (item != client) // Không gửi lại cho client đã gửi
                            {
                                item.Send(contentBytes);
                            }
                        }
                    }


                    else if (message.Contains("đã vào phòng") && client != null)
                    {
                        string[] words = message.Split(new[] { "đã vào phòng" }, StringSplitOptions.None);
                        string result = words[0].Trim();
                        if (!check(result))
                        {
                            AddMessage(message);
                            lv_ListAccount.Items.Add(new ListViewItem() { Text = result });
                            clientDictionary.Add(words[0].Trim(), client);

                        }
                        else clientList.Remove(client);

                    }
                    else if (message.Contains("(IMG)"))
                    {// Nhận kích thước ảnh

                        byte[] imageSizeBytes = new byte[4];
                        client.Receive(imageSizeBytes);
                        int imageSize = BitConverter.ToInt32(imageSizeBytes, 0);

                        byte[] imageData = new byte[imageSize];
                        client.Receive(imageData);
                        File.WriteAllBytes("image.jpg", imageData);

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
        void SI(string k)
        {
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
       
        void PrivateImageSend(string x)
        {
            byte[] imageData = File.ReadAllBytes("image.jpg");
            // Gửi kích thước ảnh
            byte[] imageSizeBytes = BitConverter.GetBytes(imageData.Length);

            Socket clientASocket = clientDictionary[x]; // tạo socket riêng 
            clientASocket.Send(Encoding.UTF8.GetBytes("(PR.IMAGE) Có người gửi riêng ảnh cho bạn")); // gửi tin nhắn từ server đến 1 client\

                        clientASocket.Send(imageSizeBytes);
                        clientASocket.Send(imageData);
        }
        // Giả sử 'message' là tin nhắn nhận được từ một client
       


        bool check(string clientName)
        {
            foreach (ListViewItem item in lv_ListAccount.Items)
            {
                if (item.Text.Equals(clientName))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
