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
    public partial class change_password : Form
    {
        OleDbCommand cmd,cmd1;
        OleDbConnection con,con1;
        OleDbDataReader dr;
        string str, sql,sql1;
        public change_password()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
            con1 = new OleDbConnection(str);
        }

        private void change_password_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string uname = "";
            string opass = "";
            string npass = "";
            if (comboBox1.Text != null)
            {
                uname = comboBox1.Text;
                opass = textBox1.Text;
                npass = textBox2.Text;
                sql = "select * from login t where t.uname='" + uname + "' ";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (comboBox1.Text == dr[0].ToString())
                        {
                            if (textBox1.Text == dr[1].ToString())
                            {
                                
                                    sql1 = "Update login set pass='" + npass + "' where uname='" + uname + "'";
                                    cmd1 = new OleDbCommand(sql1, con1);
                                    con1.Open();
                                    int r = cmd1.ExecuteNonQuery();
                                    MessageBox.Show(r + "Updated Successfully");
                                    con1.Close();
                                    cmd1.Dispose();
                                
                            }
                            else
                            {
                                MessageBox.Show("Wrong Password");
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
