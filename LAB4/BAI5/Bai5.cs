using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;


namespace BAI5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();

            var url = "https://nt106.uitiot.vn/auth/token";
            var username = "phatpt";
            var password = "123456";

            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                JObject responseObject;
                try
                {
                    responseObject = JObject.Parse(responseString);
                }
                catch
                {
                    rtbResult.AppendText($"Phản hồi không hợp lệ từ server:\n{responseString}");
                    return;
                }

                if (responseObject["detail"] != null)
                {
                    string detail = responseObject["detail"].ToString();
                    rtbResult.AppendText($"Đăng nhập thất bại: {detail}\n");
                    return;
                }

                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();

                if (string.IsNullOrEmpty(accessToken))
                {
                    rtbResult.AppendText("Đăng nhập thất bại: Không nhận được access_token\n");
                    return;
                }    

                rtbResult.AppendText($"{tokenType} {accessToken}\n\n");
                rtbResult.AppendText("Đăng nhập thành công!\n");

                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var getUserUrl = "https://nt106.uitiot.vn/api/vl/user/me";
                var getUserResponse = await client.GetAsync(getUserUrl);
                var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
            }
        }
    }
}
