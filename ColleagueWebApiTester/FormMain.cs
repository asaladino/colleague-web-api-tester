using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ColleagueWebApiTester
{
    public partial class FormMain : Form
    {
        public string sessionToken = string.Empty;
        private string serviceUrl = "https://your.university.edu:456/colleagueapi/";
        private string username = "";
        private string password = "";
        private string service = "academic-levels";

        private string postData = string.Empty;
        private bool shouldPost;

        public FormMain()
        {
            InitializeComponent();
            textBoxApiUrl.Text = serviceUrl;
            textBoxServiceEndpoint.Text = service;
            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
        }

        private void buttonSendRequest_Click(object sender, EventArgs e)
        {
            LoadUiVariables();
            if (shouldPost)
            {
                richTextBoxResponse.Text = PostService();
            }
            else
            {
                richTextBoxResponse.Text = GetService();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoadUiVariables();
            sessionToken = Login();
            textBoxSessionToken.Text = sessionToken;
        }

        public void LoadUiVariables()
        {
            serviceUrl = textBoxApiUrl.Text;
            service = textBoxServiceEndpoint.Text;
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            shouldPost = checkBoxPost.Checked;
            postData = textBoxPostData.Text;
        }

        public string Login()
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.Headers.Add("Accept: application/vnd.ellucian.v1+json");
                    client.Headers.Add("Content-Type: application/json");
                    var headers = "{ 'UserId': '" + username + "','Password': '" + password + "'}";
                    return client.UploadString(serviceUrl + "session/login", headers);
                }
                catch (WebException ex)
                {
                    var text = ex.Message;
                    using (var data = ex.Response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        text = reader.ReadToEnd();
                    }
                    return text;
                }
            }
        }

        public string Logout()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Accept: application/vnd.ellucian.v1+json");
                client.Headers.Add("Content-Type: application/json");
                client.Headers.Add("X-CustomCredentials: " + sessionToken);
                return client.UploadString(serviceUrl + "session/logout", string.Empty);
            }
        }

        public string GetService()
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.Headers.Add("Accept: application/vnd.ellucian.v1+json");
                    client.Headers.Add("Content-Type: application/json");
                    client.Headers.Add("X-CustomCredentials: " + sessionToken);
                    return client.DownloadString(serviceUrl + service);
                }
                catch (WebException ex)
                {
                    var text = ex.Message;
                    using (var data = ex.Response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        text = reader.ReadToEnd();
                    }
                    return text;
                }
            }
        }

        public string PostService()
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.Headers.Add("Accept: application/vnd.ellucian.v1+json");
                    client.Headers.Add("Content-Type: application/json");
                    client.Headers.Add("X-CustomCredentials: " + sessionToken);
                    
                    return client.UploadString(serviceUrl + service, postData);
                }
                catch (WebException ex)
                {
                    var text = ex.Message;
                    using (var data = ex.Response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        text = reader.ReadToEnd();
                    }
                    return text;
                }
            }
        }
    }
}
