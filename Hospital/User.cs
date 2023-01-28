using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewpatientdetails f1 = new viewpatientdetails();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            undergoes f2 = new undergoes();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewbill f3 = new viewbill();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stay f4 = new Stay();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewappointmentdetails f5 = new viewappointmentdetails();
            f5.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            procedure f6 = new procedure();
            f6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            medication f7 = new medication();
            f7.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prescribes f8 = new prescribes();
            f8.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f9 = new Form1();
            f9.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            user1 u = new user1();
            u.ShowDialog();
        }
    }
}
