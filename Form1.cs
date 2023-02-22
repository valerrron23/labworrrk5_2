using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labworrrk5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            int tmp2 = Int32.Parse(txtMinutes.Text);
            tmp += 1;
            txtSeconds.Text = tmp.ToString();

            if (tmp == 60)
            {
                tmp2 += 1;
                txtMinutes.Text = tmp2.ToString();
                txtSeconds.Text = 0.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Stop();
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
            textBox1.Text = " ";
        }
    }
}
