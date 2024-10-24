using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Clients
{
    public partial class DashboardClients : Form
    {
        public DashboardClients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 m=new Bai01();
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 m=new Bai02();
            m.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 m=new Bai03();
            m.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 m=new Bai04();
            m.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai05 m=new Bai05();
            m.ShowDialog();
        }
    }
}
