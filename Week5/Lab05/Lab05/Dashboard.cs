using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
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

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 button2 = new Bai02();
            button2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 button4 = new Bai04();
            button4.ShowDialog();
        }
    }
}
