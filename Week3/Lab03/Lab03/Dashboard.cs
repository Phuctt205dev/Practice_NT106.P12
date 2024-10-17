using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 button1 = new Bai01();
            button1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 button4 = new Bai04();
            button4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 button3 = new Bai03();
            button3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 button2 = new Bai02();
            button2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai05 button5 = new Bai05();
            button5.ShowDialog();
        }
    }
}
