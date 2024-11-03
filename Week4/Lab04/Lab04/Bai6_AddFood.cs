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
    public partial class Bai6_AddFood : Form
    {
        public Bai6_AddFood()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var foodItem = new
            {
                FoodName = txtFoodNa.Text,
                Price = txtPrice.Text,
                Address = txtAddr.Text,
                ImageURL = txtPic.Text,
                Description = rtbDesc.Text
            };

            // Serialize to JSON
            string json = JsonConvert.SerializeObject(foodItem);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            // Sending the data via POST request
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://nt106.uitiot.vn");
                HttpResponseMessage response = await client.PostAsync("/api/addFood", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Food item added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add food item.");
                }
            }
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            txtFoodNa.Clear();
            txtPrice.Clear();
            txtAddr.Clear();
            txtPic.Clear();
            rtbDesc.Clear();
        }
    }
}
