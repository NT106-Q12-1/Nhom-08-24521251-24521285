using System.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BAI2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text.Trim();
            string filePath = tbFile.Text.Trim();

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Vui lòng nhập URL và đường dẫn lưu file!", "Thông Báo");
                return;
            }

            try
            {
                WebClient myClient = new WebClient();
                Stream response = myClient.OpenRead(url);
                myClient.DownloadFile(url, filePath);

                using (StreamReader reader = new StreamReader(response, Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    rtbResult.Text = content;
                }
                MessageBox.Show("Tải file và đọc thành công!", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải file: " + ex.Message, "Thông Báo");
            }

        }
    }
}
