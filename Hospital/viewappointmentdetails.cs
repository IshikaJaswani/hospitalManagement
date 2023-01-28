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

    public partial class viewappointmentdetails : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        public viewappointmentdetails()
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
            textBox6.Clear();
            textBox7.Clear();
            int ssn;
            if (textBox1.Text != null)
            {

                ssn = Convert.ToInt32(textBox1.Text);
                sql = "select * from appointment where appointment.appointmentid=" + ssn + "";
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
                        textBox6.Text = dr[4].ToString();
                        textBox7.Text = dr[5].ToString();
                        textBox5.Text = dr[6].ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User u = new User();
            u.ShowDialog();
        }

        private void viewappointmentdetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}
