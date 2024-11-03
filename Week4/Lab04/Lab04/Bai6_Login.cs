using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab04
{
    public partial class Bai6_Login : Form
    {
        public Bai6_Login()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtPassW.Text;

            var loginData = new
            {
                username = username,
                password = password
            };

            string json = JsonConvert.SerializeObject(loginData);

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://nt106.uitiot.vn/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("api/login", content);

                if (response.IsSuccessStatusCode)
                {
                    // Authentication successful
                    var responseData = await response.Content.ReadAsStringAsync();
                    var token = JsonConvert.DeserializeObject<dynamic>(responseData).token;

                    Bai6 mainForm = new Bai6()
                    {
                        Username = username // Pass the username to MainForm
                    };
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            Bai6_SignUp signUp = new Bai6_SignUp();
            signUp.ShowDialog();
        }
    }
}
