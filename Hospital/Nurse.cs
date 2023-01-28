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
    public partial class Nurse : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public Nurse()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from Nurses";
            da = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Enter all values");
                }
                else
                {
                    if (textBox4.Text.Length == 8)
                    {
                        int eid, ssn;
                        string nname, position, registered;
                        eid = Convert.ToInt32(textBox1.Text);
                        nname = textBox2.Text;
                        position = textBox3.Text;
                        ssn = Convert.ToInt32(textBox4.Text);
                        registered = comboBox1.Text;
                        sql = "insert into Nurses values(" + eid + ",'" + nname + "','" + position + "','" + registered + "'," + ssn + ")";
                        cmd = new OleDbCommand(sql, con);
                        con.Open();
                        int r = cmd.ExecuteNonQuery();
                        con.Close();
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Enter a 8 digit ssn number");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong entry");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string eid;
            string nname, position, registered,ssn;
            eid = textBox1.Text;
            nname = textBox2.Text;
            position = textBox3.Text;
            ssn = textBox4.Text;
            registered = comboBox1.Text;
            sql = "UPDATE Nurses SET nname = '" + textBox2.Text + "',ssn = " + textBox4.Text + ",registered = '" + comboBox1.Text + "',posi = '" + textBox3.Text + "' WHERE eid = " + textBox1.Text + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int eid, ssn;
            //string nname, position, registered;
            eid = Convert.ToInt32(textBox1.Text);
            //nname = textBox2.Text;
            //position = textBox3.Text;
           // ssn = Convert.ToInt32(textBox4.Text);
            //registered = comboBox1.Text;
            sql = "delete from Nurses where employeeid=" + eid + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string eid = "";

            if (textBox1.Text != null)
            {
                eid = textBox1.Text;
                sql = "select * from Nurses t where t.eid=" + eid + " ";
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
                            comboBox1.SelectedItem = dr[3].ToString();
                            textBox4.Text = dr[4].ToString();
                            
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Enter Only Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button6_Click(object sender, EventArgs e)
        {
            int eid, ssn;
            string nname, position, registered;
            eid = Convert.ToInt32(textBox1.Text);
            nname = textBox2.Text;
            position = textBox3.Text;
            ssn = Convert.ToInt32(textBox4.Text);
            registered = comboBox1.Text;
            sql = "Update Nurses set nname = '" + nname + "',position = '" + position + "',registered = '" + registered + "',ssn = " + ssn + " where Nurses.employeeid = " + eid + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet11.Nurses' table. You can move, or remove it, as needed.
            this.nursesTableAdapter4.Fill(this.hospitalDatabaseDataSet11.Nurses);
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet10.Nurses' table. You can move, or remove it, as needed.
            
        }
    }
}
