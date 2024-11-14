using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit;
using System;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void SetupListView()
        {
            listViewMess.Clear();
            listViewMess.Columns.Add("Email", 300);
            listViewMess.Columns.Add("From", 200);
            listViewMess.Columns.Add("Date", 100);
        }

        private void buttonIMAP_Click(object sender, EventArgs e)
        {
            listViewMess.Clear();
            listViewMess.Columns.Add("Email", 300);
            listViewMess.Columns.Add("From", 200);
            listViewMess.Columns.Add("Date", 100);//Tạo cột và phạm vi cột
            var client = new ImapClient();
            try
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            labelTotal_2.Text = inbox.Count.ToString();
            labelRecent_2.Text = inbox.Recent.ToString();

            // Tạo kết nối



            for (int i = 0; i < 4; i++)
            {
                var message = inbox.GetMessage(i);
                var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });
                listViewMess.Items.Add(item);
            }// Add thông tin lên bảng
            client.Disconnect(true);
        }

        private void buttonPop3_Click(object sender, EventArgs e)
        {
            SetupListView();

            using (var client = new Pop3Client())
            {
                try
                {
                    client.Connect("pop.gmail.com", 995, true);
                    client.Authenticate(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());
                    labelTotal_2.Text = client.Count.ToString();

                    for (int i = 0; i < Math.Min(2, client.Count); i++)
                    {
                        var message = client.GetMessage(i);
                        var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });
                        listViewMess.Items.Add(item);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "POP3 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (client.IsConnected)
                        client.Disconnect(true);
                }
            }
        }
    }
}
