using Microsoft.Web.WebView2.Core;
using HtmlAgilityPack;
using System.Net;

namespace BAI3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private async void loadbtn_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();

            try
            {
                await webView21.EnsureCoreWebView2Async();
                webView21.CoreWebView2.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private async void Bai3_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
        }

        private async void downbtn_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML File|*.html";
            sfd.FileName = "downloaded_page.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string html = await client.GetStringAsync(url);

                        File.WriteAllText(sfd.FileName, html);
                    }

                    MessageBox.Show("Tải HTML thành công!\nLưu tại: " + sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải HTML: " + ex.Message);
                }
            }
        }


        private async void downresbtn_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL trước!");
                return;
            }

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() != DialogResult.OK)
                return;

            string saveFolder = fbd.SelectedPath;
            Uri baseUri = new Uri(url);

            string html = "";
            using (WebClient wc = new WebClient())
            {
                try
                {
                    html = wc.DownloadString(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tải được HTML: " + ex.Message);
                    return;
                }
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var imgNodes = doc.DocumentNode.SelectNodes("//img[@src]");
            if (imgNodes == null || imgNodes.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hình ảnh nào!");
                return;
            }

            WebClient webClient = new WebClient();
            int index = 0;

            foreach (var img in imgNodes)
            {
                string imgUrl = img.GetAttributeValue("src", "");

                if (string.IsNullOrEmpty(imgUrl))
                    continue;

                Uri imgUri = new Uri(baseUri, imgUrl);

                string extension = Path.GetExtension(imgUri.LocalPath);
                if (string.IsNullOrEmpty(extension))
                    extension = ".jpg";

                string filename = $"image_{index++}{extension}";
                string savePath = Path.Combine(saveFolder, filename);

                try
                {
                    webClient.DownloadFile(imgUri, savePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải ảnh: " + ex.Message);
                }
            }

            MessageBox.Show("Tải xong tất cả ảnh!");
        }
    }
}
