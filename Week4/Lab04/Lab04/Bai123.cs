using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Linq; // Thêm namespace để sử dụng Any()
using HtmlAgilityPack; // Đảm bảo HtmlAgilityPack được khai báo đúng

namespace Lab04
{
    using HtmlAgilityPack; // Đảm bảo HtmlAgilityPack được khai báo đúng

    public partial class Bai123 : Form
    {
        public Bai123()
        {
            InitializeComponent();
        }

        WebBrowser wb;

        private string GetHTML(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching HTML: " + ex.Message);
                return string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urlText = url.Text.ToString();
            richTextBox1.Text = GetHTML(urlText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urlText = url.Text.ToString();
            string filePath = fileurl.Text.ToString();
            richTextBox1.Text = GetHTML(urlText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wb = new WebBrowser();
            wb.Width = 1920;
            wb.Height = 1080;
            wb.ScriptErrorsSuppressed = true;
            panel1.Controls.Add(wb);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string html = wb.DocumentText;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Html files (*.html)|*.html|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(html);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string link = url.Text;
            wb.Navigate(link);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string urlText = url.Text.ToString();
            if (string.IsNullOrEmpty(urlText))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFolder = folderDialog.SelectedPath;
                    try
                    {
                        DownloadImages(urlText, saveFolder);
                        MessageBox.Show("Images downloaded successfully to " + saveFolder);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error downloading images: " + ex.Message);
                    }
                }
            }
        }

        private void DownloadImages(string url, string saveFolder)
        {
            string htmlContent = GetHTML(url);
            if (string.IsNullOrEmpty(htmlContent))
            {
                MessageBox.Show("Failed to fetch HTML content.");
                return;
            }

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlContent);

            // Lấy tất cả các thẻ <img> và thuộc tính src của chúng
            var imageNodes = doc.DocumentNode.SelectNodes("//img[@src]");
            if (imageNodes == null || imageNodes.Count == 0) // Kiểm tra Count thay vì Any()
            {
                MessageBox.Show("No images found on this page.");
                return;
            }

            foreach (var imgNode in imageNodes)
            {
                string imgSrc = imgNode.GetAttributeValue("src", null);
                if (!string.IsNullOrEmpty(imgSrc))
                {
                    // Xử lý đường dẫn tuyệt đối và tương đối
                    Uri imgUri = new Uri(new Uri(url), imgSrc);
                    DownloadImage(imgUri.ToString(), saveFolder);
                }
            }
        }

        private void DownloadImage(string imageUrl, string saveFolder)
        {
            try
            {
                string fileName = Path.GetFileName(new Uri(imageUrl).LocalPath);
                string savePath = Path.Combine(saveFolder, fileName);

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(imageUrl, savePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading image " + imageUrl + ": " + ex.Message);
            }
        }
    }
}
