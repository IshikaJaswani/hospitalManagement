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
    public partial class Stay : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public Stay()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from stay";
            da = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void Stay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.stay' table. You can move, or remove it, as needed.
            this.stayTableAdapter.Fill(this.hospitalDatabaseDataSet.stay);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int stayid, patient, room;

            stayid = Convert.ToInt32(textBox1.Text);

            patient = Convert.ToInt32(textBox2.Text);
            room = Convert.ToInt32(textBox3.Text);
            DateTime start_time = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime end_time = Convert.ToDateTime(dateTimePicker2.Value);
            sql = "Update stay set patient=" + patient + ",room=" + room + ",start_time='" + start_time + "',end_time='" + end_time + "' where stayid=" + stayid + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int stayid, patient, room;

            stayid = Convert.ToInt32(textBox1.Text);

            //patient = Convert.ToInt32(textBox2.Text);
            //room = Convert.ToInt32(textBox3.Text);
            //DateTime start_time = Convert.ToDateTime(dateTimePicker1.Value);
            //DateTime end_time = Convert.ToDateTime(dateTimePicker2.Value);
            sql = "delete from stay where stayid=" + stayid + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stayid = "";

            if (textBox1.Text != null)
            {
                stayid = textBox1.Text;
                sql = "select * from stay t where t.stayid=" + stayid + " ";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (textBox1.Text == dr[0].ToString())
                        {
                            textBox2.Text = dr[1].ToString();
                            textBox3.Text = dr[2].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(dr[3].ToString());
                            dateTimePicker2.Value = Convert.ToDateTime(dr[4].ToString());
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

        private void button5_Click(object sender, EventArgs e)
        {
            int room;
            
            if (textBox3.Text != null)
            {
                room = Convert.ToInt32(textBox3.Text);
                sql = "select room.roomnumber,room.unavailable,stay.room from room LEFT OUTER JOIN stay on room.roomnumber=stay.room";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (textBox3.Text == dr[0].ToString())
                        {
                            if(dr[0].ToString()=="no" || dr[0].ToString() == "No")
                            {
                                MessageBox.Show("Room is available");
                            }
                            else
                            {
                                MessageBox.Show("Unavailable");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unavailable");
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Only digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Only digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Only digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Enter all values");
                }
                else
                {
                    if (dateTimePicker1.Value < DateTime.Now || dateTimePicker2.Value < DateTime.Now)
                    {
                        MessageBox.Show("Enter valid date");
                    }
                    else
                    {
                        int stayid, patient, room;

                        stayid = Convert.ToInt32(textBox1.Text);

                        patient = Convert.ToInt32(textBox2.Text);
                        room = Convert.ToInt32(textBox3.Text);
                        DateTime start_time = Convert.ToDateTime(dateTimePicker1.Value);
                        DateTime end_time = Convert.ToDateTime(dateTimePicker2.Value);
                        sql = "insert into stay values(" + stayid + "," + patient + "," + room + ",'" + start_time + "','" + end_time + "')";
                        cmd = new OleDbCommand(sql, con);
                        con.Open();
                        int r = cmd.ExecuteNonQuery();
                        con.Close();
                        populate();
                    }
                }
            


        }
    }
}
