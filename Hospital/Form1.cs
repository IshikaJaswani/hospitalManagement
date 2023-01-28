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
    public partial class Form1 : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        
        public Form1()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            change_password cp = new change_password();
            cp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = "";
            string pass = "";
            
            if (comboBox1.Text != null)
            {
                uname = comboBox1.Text;
                pass = textBox1.Text;
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
                                if(comboBox1.Text=="Admin")
                                {
                                    this.Hide();
                                    admin f1 = new admin();
                                    f1.ShowDialog();
                                    
                                }
                                else
                                {
                                    this.Hide();
                                    user1 f2 = new user1();
                                    f2.ShowDialog();
                                   
                                }
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
