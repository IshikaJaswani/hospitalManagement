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
    public partial class viewnursedetails : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        public viewnursedetails()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
           
            int employeeid = Convert.ToInt32(loginnurse.s);
            textBox1.Text = Convert.ToString(employeeid);
            //int employeeid = Convert.ToInt32(textBox1.Text);
            sql = "select * from Nurses where Nurses.eid=" + employeeid + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                    textBox4.Text = dr[3].ToString();
                    textBox5.Text = dr[4].ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            user1 u = new user1();
            u.ShowDialog();
        }

        private void viewnursedetails_Load(object sender, EventArgs e)
        {
            int employeeid = Convert.ToInt32(loginnurse.s);
            textBox1.Text = Convert.ToString(employeeid);
        }
    }
}
