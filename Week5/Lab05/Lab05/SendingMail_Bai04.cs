using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05
{
    public partial class SendingMail_Bai04 : Form
    {
        public string usernametagfrom_main { get; set; }
        public SendingMail_Bai04()
        {
            InitializeComponent();
        }

        private void SendingMail_Bai04_Load(object sender, EventArgs e)
        {
            tbFrom.Text = usernametagfrom_main;
        }

        public string smtp { get; set; }
        public string smtpPort { get; set; }
        public string passwordfromMain { get; set; }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Tên người gửi", tbFrom.Text.Trim()));
                message.To.Add(new MailboxAddress("Tên người nhận", tbTo.Text.Trim()));
                message.Subject = tbSubject.Text.Trim();
                message.Body = new TextPart("plain") { Text = rtbMailContent.Text };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", Convert.ToInt32(smtpPort), true); // SSL
                    client.Authenticate(tbFrom.Text.Trim(), passwordfromMain);
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
