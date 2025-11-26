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

                var responseObject = JObject.Parse(responseString);

                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    rtbResult.AppendText($"Detail: {detail}");
                    return;
                }

                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();

                rtbResult.AppendText($"{tokenType} {accessToken} \n\n");
                rtbResult.AppendText("Đăng nhập thành công!\n");

                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                var getUserResponse = await client.GetAsync(getUserUrl);
                var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
            }
        }
    }
}
