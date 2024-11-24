using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Windows.Forms;

namespace Lab05
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
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Tên người gửi", textBoxFrom.Text.Trim()));
                message.To.Add(new MailboxAddress("Tên người nhận", textBoxTo.Text.Trim()));
                message.Subject = textBoxSubject.Text.Trim();
                message.Body = new TextPart("plain") { Text = richTextBoxBody.Text };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true); // SSL
                    client.Authenticate(textBoxFrom.Text.Trim(), "elcf yxpu aasi iptq");
                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Email đã gửi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
