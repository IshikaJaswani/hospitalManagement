using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Hospital
{
    public partial class loginnurse : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        public static string s = "";
        public loginnurse()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        private void loginnurse_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            changepassnurse f1 = new changepassnurse();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            user1 u = new user1();
            u.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string employeeid = "";
            string ssn = "";

            if (textBox1.Text != null)
            {
                employeeid = textBox1.Text;
                ssn = textBox2.Text;
                sql = "select eid,ssn from Nurses t where t.eid=" + employeeid + " ";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (textBox1.Text == dr[0].ToString())
                        {
                            if (textBox2.Text == dr[1].ToString())
                            {
                                s = textBox1.Text;
                                viewnursedetails f1 = new viewnursedetails();
                                f1.Show();
                                this.Hide();
                            }
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                dr.Close();
                con.Close();
                cmd.Dispose();

            }
        }
    }
}
