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
    public partial class Department : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public Department()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from department";
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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
                {
                    MessageBox.Show("Enter all values");
                }
                else
                {
                    int departmentid, head;
                    string dname;
                    departmentid = Convert.ToInt32(textBox1.Text);
                    dname = textBox2.Text;

                    head = Convert.ToInt32(textBox3.Text);
                    sql = "insert into department values(" + departmentid + ",'" + dname + "'," + head + ")";
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

        private void button2_Click(object sender, EventArgs e)
        {
            int departmentid, head;
            string dname;
            departmentid = Convert.ToInt32(textBox1.Text);
            dname = textBox2.Text;

            head = Convert.ToInt32(textBox3.Text);
            sql = "Update department set dname='" + dname + "',head=" + head + " where departmentid=" + departmentid + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int departmentid, head;
            //string dname;
            departmentid = Convert.ToInt32(textBox1.Text);
            //dname = textBox2.Text;

            //head = Convert.ToInt32(textBox3.Text);
            sql = "delete from department where departmentid=" + departmentid + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string departmentid = "";

            if (textBox1.Text != null)
            {
                departmentid = textBox1.Text;
                sql = "select * from department t where t.departmentid=" + departmentid + " ";
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hospitalDatabaseDataSet.department);

        }
    }
}
