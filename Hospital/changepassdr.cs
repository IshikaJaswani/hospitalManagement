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
    public partial class changepassdr : Form
    {
        OleDbCommand cmd, cmd1;
        OleDbConnection con, con1;
        OleDbDataReader dr;
        string str, sql, sql1;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            user1 u = new user1();
            u.ShowDialog();
        }

        public changepassdr()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
            con1 = new OleDbConnection(str);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int uname, opass, npass;
            
            if (textBox3.Text != null)
            {
                uname = Convert.ToInt32(textBox3.Text);
                opass = Convert.ToInt32(textBox1.Text);
                npass = Convert.ToInt32(textBox2.Text);
                sql = "select employeeid,ssn from physician t where t.employeeid=" + uname + " ";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (textBox3.Text == dr[0].ToString())
                        {
                            if (textBox1.Text == dr[1].ToString())
                            {

                                sql1 = "Update physician set ssn='" + npass + "' where employeeid=" + uname + "";
                                cmd1 = new OleDbCommand(sql1, con1);
                                con1.Open();
                                int r = cmd1.ExecuteNonQuery();
                                MessageBox.Show(r + "Updated Successfully");
                                con1.Close();
                                cmd1.Dispose();

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
