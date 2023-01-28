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
    public partial class Patient : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public Patient()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from patient";
            da = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDatabaseDataSet.patient);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ssn, insuranceid, pcp;
            string pname, address,phone;
           
            ssn = Convert.ToInt32(textBox1.Text);
            pname = textBox2.Text;
            address = textBox3.Text;
            phone = textBox4.Text;
            insuranceid = Convert.ToInt32(textBox5.Text);
            pcp = Convert.ToInt32(textBox6.Text);
            sql = "Update patient set pname='" + pname + "',address='" + address + "',phone='" + phone + "',insuranceid=" + insuranceid + ",pcp=" + pcp + " where ssn=" + ssn + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ssn,  insuranceid, pcp;
            //string pname, address,phone;
            ssn = Convert.ToInt32(textBox1.Text);
           // pname = textBox2.Text;
            //address = textBox3.Text;
            //phone = textBox4.Text;
           // insuranceid = Convert.ToInt32(textBox5.Text);
           // pcp = Convert.ToInt32(textBox6.Text);
            sql = "delete from patient where ssn=" + ssn + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ssn = "";

            if (textBox1.Text != null)
            {
                ssn = textBox1.Text;
                sql = "select * from patient t where t.ssn=" + ssn + " ";
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
                            textBox5.Text = dr[4].ToString();
                            textBox6.Text = dr[5].ToString();
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
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Only digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Only digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Enter all values");
                }
                else
                {
                    if (textBox1.Text.Length == 8)
                    {
                        if (textBox4.Text.Length == 10)
                        {
                            int ssn, insuranceid, pcp;
                            string pname, address,phone;
                            ssn = Convert.ToInt32(textBox1.Text);

                            pname = textBox2.Text;
                            address = textBox3.Text;
                            phone = textBox4.Text;
                            insuranceid = Convert.ToInt32(textBox5.Text);
                            pcp = Convert.ToInt32(textBox6.Text);
                            sql = "insert into patient values(" + ssn + ",'" + pname + "','" + address + "','" + phone + "'," + insuranceid + "," + pcp + ")";
                            cmd = new OleDbCommand(sql, con);
                            con.Open();
                            int r = cmd.ExecuteNonQuery();
                            MessageBox.Show(r + "inserted successfully");
                            con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Enter a 10 digit phone number");
                        }
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
    }
}
