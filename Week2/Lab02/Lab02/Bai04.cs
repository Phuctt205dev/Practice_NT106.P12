using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai04 : Form
    {
        private RichTextBox[] rtba = new RichTextBox[3];
        private int numout;
        public Bai04()
        {
            InitializeComponent();
            rtba[0] = rtb1;
            rtba[1] = rtb2;
            rtba[2] = rtb3;
            for (int i = 0; i < 3; i++)
            {
                rtba[i].Visible = false;
            }
            for (int i = 0; i < 3; i++)
            {
                rtba[i].Text = (i+1).ToString();
            }
            numout = Convert.ToInt32(lbPage.Text);
            rtba[numout - 1].Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            numout=Convert.ToInt32(lbPage.Text);
            if (numout != 1)
            {
                numout =numout -1;
                lbPage.Text= numout.ToString();
                rtba[numout-1].Visible = true;
            }
            else
                numout = 3;
                lbPage.Text =numout.ToString();
                rtba[numout-1].Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numout = Convert.ToInt32(lbPage.Text);
            if (numout != 3)
            {
                numout = numout + 1;
                lbPage.Text = numout.ToString();
                rtba[numout-1].Visible = true;
            }
            else
            {
                numout = 1;
                lbPage.Text=numout.ToString();
                rtba[numout-1].Visible = true;
            }
        }

        private void rtb3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
