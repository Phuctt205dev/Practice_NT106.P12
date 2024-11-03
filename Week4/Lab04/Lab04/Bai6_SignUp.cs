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

namespace Lab04
{
    public partial class Bai6_SignUp : Form
    {
        public Bai6_SignUp()
        {
            InitializeComponent();
        }

        private async void btnSub_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Username = txtUN.Text,
                Password = txtPW.Text,
                Email = txtMail.Text,
                Firstname = txtFN.Text,
                Lastname = txtLN.Text,
                Phone = txtPN.Text,
                Birthday = dtBD.Value.ToString("dd-MM-yyyy"),
                Language = cbLang.Text,
                Sex = ckBoy.Checked ? "Male" : "Female"
            };

            string json = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://nt106.uitiot.vn");
                HttpResponseMessage response = await client.PostAsync("/api/register", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registration successful!");
                }
                else
                {
                    MessageBox.Show("Registration failed.");
                }
            }
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUN.Clear();
            txtPW.Clear();
            txtMail.Clear();
            txtFN.Clear();
            txtLN.Clear();
            txtPN.Clear();
            cbLang.Text = "Languages";
            ckBoy.Checked = false;
            ckGirl.Checked = false;
            dtBD.Value = DateTime.Now;
        }

        private void ckBoy_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoy.Checked==true)
            {
                ckGirl.Checked=false;
            }
            else { ckGirl.Checked=true; }
        }

        private void ckGirl_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGirl.Checked == true)
            {
                ckBoy.Checked=false;
            }
            else { ckBoy.Checked=true;}
        }
    }
}
