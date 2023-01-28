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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logindr f1 = new logindr();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginnurse f2 = new loginnurse();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User f3 = new User();
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.ShowDialog();
        }
    }
}
