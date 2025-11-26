using Microsoft.Web.WebView2.Core;
using System.Net;
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
            sfd.FileName = System.IO.Path.GetFileName(url);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        byte[] data = await client.GetByteArrayAsync(url);
                        File.WriteAllBytes(sfd.FileName, data);
                    }

                    MessageBox.Show("Tải thành công!\nLưu tại: " + sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải file: " + ex.Message);
                }
            }
        }

        private async void downresbtn_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 == null)
            {
                MessageBox.Show("WebView2 chưa sẵn sàng!");
                return;
            }

            // Lấy HTML từ WebView2
            string html = await webView21.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");
            html = WebUtility.HtmlDecode(html.Trim('"'));

            // Dùng HtmlAgilityPack phân tích HTML
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var imgs = doc.DocumentNode.SelectNodes("//img[@src]");
            if (imgs == null)
            {
                MessageBox.Show("Không tìm thấy hình!");
                return;
            }

            // Chọn thư mục lưu hình
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Chọn nơi lưu hình";
                if (fbd.ShowDialog() != DialogResult.OK)
                    return;

                string folder = fbd.SelectedPath;
                Uri baseUri = new Uri(webView21.Source.ToString());

                using (HttpClient client = new HttpClient())
                {
                    foreach (var img in imgs)
                    {
                        try
                        {
                            string src = img.GetAttributeValue("src", "");

                            Uri imgUrl = new Uri(baseUri, src);
                            byte[] data = await client.GetByteArrayAsync(imgUrl);

                            string fileName = Path.GetFileName(imgUrl.LocalPath);
                            string savePath = Path.Combine(folder, fileName);

                            File.WriteAllBytes(savePath, data);
                        }
                        catch
                        {
                            // bỏ qua từng ảnh lỗi
                        }
                    }
                }

                MessageBox.Show("Tải ảnh xong!");
            }
        }
    }
}
