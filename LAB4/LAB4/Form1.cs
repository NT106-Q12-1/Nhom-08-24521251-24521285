using System.Net;
using System.Security.Policy;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void getbtn_Click(object sender, EventArgs e)
        {
            string szURL = textBox1.Text.Trim();
            try
            {
                string html = getHTML(szURL);
                richTextBox1.Text = html;
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }
            
        }

        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

    }
}
