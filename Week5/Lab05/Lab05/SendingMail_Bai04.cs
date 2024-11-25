using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
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
                message.From.Add(new MailboxAddress(tbName.Text, tbFrom.Text.Trim()));
                message.To.Add(new MailboxAddress(tbTo.Text, tbTo.Text.Trim()));
                message.Subject = tbSubject.Text.Trim();
                if (ckbHTML.Checked)
                {
                    string htmlContent = $@"
                        <h1 style='color:blue;'>Xin chào!</h1>
                        <p>{rtbMailContent.Text}</p>
                        <p style='font-style:italic;'>Email được gửi từ ứng dụng của tôi.</p>";
                    message.Body = new TextPart("html") { Text = htmlContent };
                }
                else { message.Body = new TextPart("plain") { Text = rtbMailContent.Text }; }

                var multipart = new Multipart("mixed") { message.Body }; // Gộp nội dung email
                if (!string.IsNullOrEmpty(tbFilePath.Text) && File.Exists(tbFilePath.Text))
                {
                    var attachment = new MimePart("image", Path.GetExtension(tbFilePath.Text).Replace(".", ""))
                    {
                        Content = new MimeContent(File.OpenRead(tbFilePath.Text)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(tbFilePath.Text)
                    };
                    multipart.Add(attachment); // Thêm tệp vào email
                }

                message.Body = multipart;


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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        tbFilePath.Text = ofd.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

        }
    }
}
