using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
            btnRefresh.Enabled = false;
            btnSendMail.Enabled = false;
        }

        private void SetupListView()
        {
            lstMailList.View = View.Details;
            lstMailList.Columns.Clear();
            lstMailList.FullRowSelect = true;
            lstMailList.Items.Clear();
            lstMailList.Columns.Add("#", 25);
            lstMailList.Columns.Add("Email", 300);
            lstMailList.Columns.Add("From", 200);
            lstMailList.Columns.Add("DateTime", 300);
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            lstMailList.ItemSelectionChanged += lstMailList_ItemSelectionChanged;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                SetupListView();
                string email=textBoxEmail.Text.Trim();
                string pass=textBoxPass.Text.Trim();
                string imapH=txtIMAP.Text.Trim();
                int imapPort= int.Parse(txtPortIMAP.Text.Trim());

                using (var client = new ImapClient())
                {
                    client.Connect(imapH, imapPort, true);
                    client.Authenticate(email, pass);

                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    lstMailList.Items.Clear();
                    int limit = Math.Min(10, inbox.Count);
                    for (int i = 0; i < limit; i++) 
                    {
                        var message=inbox.GetMessage(i);
                        var item = new ListViewItem(new[]
                        {
                            i.ToString(),
                            message.Subject,
                            message.From.ToString(),
                            message.Date.ToString(),
                        });
                        lstMailList.Items.Add(item);
                    }
                    client.Disconnect(true);
                }
                groupBox2.Enabled = false;
                btnSignIn.Enabled = false;
                btnSendMail.Enabled = true;
                btnRefresh.Enabled = true;
                MessageBox.Show("Connected!", "Notification");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SetupListView();
                string email = textBoxEmail.Text.Trim();
                string pass = textBoxPass.Text.Trim();
                string imapH = txtIMAP.Text.Trim();
                int imapPort = int.Parse(txtPortIMAP.Text.Trim());

                using (var client = new ImapClient())
                {
                    client.Connect(imapH, imapPort, true);
                    client.Authenticate(email, pass);

                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    lstMailList.Items.Clear();
                    int limit = Math.Min(10, inbox.Count);
                    for (int i = 0; i < limit; i++)
                    {
                        var message = inbox.GetMessage(i);
                        var item = new ListViewItem(new[]
                        {
                            i.ToString(),
                            message.Subject,
                            message.From.ToString(),
                            message.Date.ToString(),
                        });
                        lstMailList.Items.Add(item);
                    }
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            SendingMail_Bai04 SendForm = new SendingMail_Bai04();
            SendForm.usernametagfrom_main=textBoxEmail.Text.ToString();
            SendForm.smtp=txtSMTP.Text.ToString();
            SendForm.smtpPort=txtPortSMTP.Text.ToString();
            SendForm.passwordfromMain=textBoxPass.Text.ToString();
            SendForm.ShowDialog();
        }

        private void lstMailList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstMailList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) // Nếu dòng được chọn
            {
                try
                {
                    string email = textBoxEmail.Text.Trim();
                    string pass = textBoxPass.Text.Trim();
                    string imapH = txtIMAP.Text.Trim();
                    int imapPort = int.Parse(txtPortIMAP.Text.Trim());

                    using (var client = new ImapClient())
                    {
                        client.Connect(imapH, imapPort, true);
                        client.Authenticate(email, pass);

                        var inbox = client.Inbox;
                        inbox.Open(MailKit.FolderAccess.ReadOnly);

                        // Lấy email theo chỉ số từ dòng được chọn
                        int emailIndex = int.Parse(e.Item.Text); // Số thứ tự email
                        var message = inbox.GetMessage(emailIndex);

                        // Chuẩn bị nội dung email
                        string emailContent = message.TextBody.ToString();

                        client.Disconnect(true);

                        // Mở MailDetailsForm và truyền nội dung email
                        var mailDetailsForm = new MailDetail_Bai04
                        {
                            content = emailContent,
                            sub = message.Subject.ToString(),
                            from = message.From.ToString(),
                            date = message.Date.ToString(),
                            Mailmess = message
                        };
                        mailDetailsForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to read mail: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
