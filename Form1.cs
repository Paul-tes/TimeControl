using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbMinute_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (int.Parse(lbMin.Text) > 0 || int.Parse(lbSec.Text) > 0)
                {
                    timer1.Start();
                } else
                {
                    timer1.Start();
                    lbMin.Text = "0";
                    lbSec.Text = "0";
                }
                
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbMin.Text = "0";
            lbSec.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(lbSec.Text);
            int min = int.Parse((lbMin.Text));

            if (sec < 60)
            {
                sec++;
                lbSec.Text = sec.ToString();
            }else
            {
                lbSec.Text = "0";
                if (min < 60)
                {
                    min++;
                    lbMin.Text = min.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_fName_Click(object sender, EventArgs e)
        {

        }

        private void lb_LastName_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
 
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }
    }
}
