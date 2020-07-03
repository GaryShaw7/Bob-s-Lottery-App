using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryGenerator
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var num1 = rand.Next(1, 49);
            var num2 = rand.Next(1, 49);
            var num3 = rand.Next(1, 49);
            var num4 = rand.Next(1, 49);
            var num5 = rand.Next(1, 49);
            var num6 = rand.Next(1, 49);

            txtNumber1.Text = num1.ToString();
            txtNum2.Text = num2.ToString();
            txtNum3.Text = num3.ToString();
            txtNum4.Text = num4.ToString();
            txtNum5.Text = num5.ToString();
            txtNum6.Text = num6.ToString();


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum6_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
