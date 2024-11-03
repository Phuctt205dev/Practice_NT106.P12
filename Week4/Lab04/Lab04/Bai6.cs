using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai6 : Form
    {
        public string Username { get; set; }
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            // Update the label based on authentication status
            if (!string.IsNullOrEmpty(Username))
            {
                lbAccSta.Text = $"Welcome {Username}";
                lbAccSta.ForeColor = Color.Green;
            }
            else
            {
                lbAccSta.Text = "Unauthenticated";
                lbAccSta.ForeColor = Color.Red;
            }
        }

        private void btnWEat_Click(object sender, EventArgs e)
        {

        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            Bai6_AddFood addFood = new Bai6_AddFood();
            addFood.ShowDialog();
        }
    }
}
