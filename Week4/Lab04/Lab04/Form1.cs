using Lab4;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai123 button1 = new Bai123();
            button1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai5 button2 = new Bai5();
            button2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai6 button3 = new Bai6();
            button3.ShowDialog();
        }
    }
}
