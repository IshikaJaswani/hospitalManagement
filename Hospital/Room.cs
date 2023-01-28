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
    public partial class Room : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public Room()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from room";
            da = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int roomnumber, blockfloor, blockcode;
            string roomtype, unavailable;
            roomnumber = Convert.ToInt32(textBox1.Text);
            roomtype = textBox2.Text;

            blockfloor = Convert.ToInt32(textBox3.Text);
            blockcode = Convert.ToInt32(textBox4.Text);

            unavailable = comboBox1.Text;
            sql = "Update room set roomtype='" + roomtype + "',blockfloor=" + blockfloor + ",blockcode=" + blockcode + ",unavailable='" + unavailable + "' where roomnumber=" + roomnumber + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int roomnumber, blockfloor, blockcode;
            //string roomtype, unavailable;
            roomnumber = Convert.ToInt32(textBox1.Text);
            //roomtype = textBox2.Text;

            //blockfloor = Convert.ToInt32(textBox3.Text);
            //blockcode = Convert.ToInt32(textBox4.Text);

            //unavailable = comboBox1.Text;
            sql = "delete from room where roomnumber=" + roomnumber + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hospitalDatabaseDataSet.room);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string roomnumber = "";

            if (textBox1.Text != null)
            {
                roomnumber = textBox1.Text;
                sql = "select * from room t where t.roomnumber=" + roomnumber + " ";
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
                            textBox4.Text = dr[3].ToString();
                            comboBox1.SelectedItem= dr[4].ToString();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Only digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Only digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.SelectedItem.ToString()=="")
                {
                    MessageBox.Show("Enter all values");
                }
                else
                {
                    int roomnumber, blockfloor, blockcode;
                    string roomtype, unavailable;
                    roomnumber = Convert.ToInt32(textBox1.Text);
                    roomtype = textBox2.Text;
                   /* if(roomtype=="ac")
                    {
                        cost = "1500";
                    }
                    else
                    {
                        cost = "700";
                    }*/
                    blockfloor = Convert.ToInt32(textBox3.Text);
                    blockcode = Convert.ToInt32(textBox4.Text);

                    unavailable = comboBox1.Text;
                    sql = "insert into room values(" + roomnumber + ",'" + roomtype + "'," + blockfloor + "," + blockcode + ",'" + unavailable + "')";
                    cmd = new OleDbCommand(sql, con);
                    con.Open();
                    int r = cmd.ExecuteNonQuery();
                    MessageBox.Show(r + "inserted successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong entry");
            }
        }
    }
}
