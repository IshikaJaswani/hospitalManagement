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
    public partial class trained_in : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public trained_in()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from trained_in";
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
                if (textBox1.Text == "" || textBox2.Text == "" )
                {
                    MessageBox.Show("Enter all values");
                }
                else
                {
                    int physician, treatment;

                    physician = Convert.ToInt32(textBox1.Text);

                    treatment = Convert.ToInt32(textBox2.Text);
                    DateTime certificationdate = Convert.ToDateTime(dateTimePicker1.Value);
                    DateTime certificationexpires = Convert.ToDateTime(dateTimePicker2.Value);
                    sql = "insert into trained_in values(" + physician + "," + treatment + ",'" + certificationdate + "','" + certificationexpires + "')";
                    cmd = new OleDbCommand(sql, con);
                    con.Open();
                    int r = cmd.ExecuteNonQuery();
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
            int physician, treatment;

            physician = Convert.ToInt32(textBox1.Text);

            treatment = Convert.ToInt32(textBox2.Text);
            DateTime certificationdate = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime certificationexpires = Convert.ToDateTime(dateTimePicker2.Value);
            sql = "Update  trained_in set physician=" + physician + ",treatment=" + treatment + ",certificationdate='" + certificationdate + "',certificationexpires='" + certificationexpires + "' where physician=" + physician + " AND treatment=" + treatment + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int physician, treatment;

            physician = Convert.ToInt32(textBox1.Text);

            treatment = Convert.ToInt32(textBox2.Text);
            //DateTime certificationdate = Convert.ToDateTime(dateTimePicker1.Value);
            //DateTime certificationexpires = Convert.ToDateTime(dateTimePicker2.Value);
            sql = "delete from trained_in where physician=" + physician + " AND treatment=" + treatment + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string physician, treatment;

            if (textBox1.Text != null)
            {
                physician = textBox1.Text;
                treatment = textBox2.Text;
                sql = "select * from trained_in t where physician=" + physician + " AND treatment=" + treatment + " ";
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
                            dateTimePicker1.Value = Convert.ToDateTime(dr[2].ToString());
                            dateTimePicker2.Value = Convert.ToDateTime(dr[3].ToString());
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }

        private void trained_in_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.trained_in' table. You can move, or remove it, as needed.
            this.trained_inTableAdapter.Fill(this.hospitalDatabaseDataSet.trained_in);

        }
    }
}
