using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Lab05
{
    public partial class MailDetail_Bai04 : Form
    {
        public string sub { get; set; }
        public string from { get; set; }
        public string date { get; set; }
        public string content { get; set; }
        public MimeMessage Mailmess { get; set; }
        public MailDetail_Bai04()
        {
            InitializeComponent();
        }

        private void MailDetail_Bai04_Load(object sender, EventArgs e)
        {
            tbSub.Text= sub;
            tbFrom.Text= from;
            tbDate.Text=date;
            rtbMailContent.Text= content;

            LoadImageFromEmail();
        }

        private void LoadImageFromEmail()
        {
            if (Mailmess == null)
                return;

            // Duyệt qua các thành phần trong email để tìm tệp đính kèm
            foreach (var attachment in Mailmess.BodyParts)
            {
                if (attachment is MimePart mimePart && mimePart.ContentType.MimeType.StartsWith("image/"))
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        mimePart.Content.DecodeTo(memoryStream);
                        memoryStream.Position = 0;

                        // Hiển thị hình ảnh trong PictureBox
                        Image image = Image.FromStream(memoryStream);

                        // Điều chỉnh kích thước PictureBox để giữ tỉ lệ hình ảnh
                        pbImage.Image = image;
                        pbImage.SizeMode = PictureBoxSizeMode.Zoom;

                        int maxWidth = this.Width - 40; // Trừ khoảng cách biên
                        int maxHeight = this.Height - pbImage.Top - 60;

                        // Tính toán tỉ lệ phù hợp
                        float ratio = Math.Min((float)maxWidth / image.Width, (float)maxHeight / image.Height);
                        pbImage.Width = (int)(image.Width * ratio);
                        pbImage.Height = (int)(image.Height * ratio);

                        pbImage.Visible = true; // Hiện PictureBox
                    }
                }
            }
        }
    }
}
