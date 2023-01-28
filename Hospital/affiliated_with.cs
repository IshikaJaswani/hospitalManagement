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
    public partial class affiliated_with : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public affiliated_with()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from affiliated_with";
            da = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int physician, department;
            string paffiliation;
            physician = Convert.ToInt32(textBox1.Text);

            department = Convert.ToInt32(textBox2.Text);
            paffiliation = comboBox1.Text;
            sql = "Update affiliated_with set primaryaffiliation='" + paffiliation + "' where physician=" + physician + " AND department=" + department + " ";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int physician, department;
            //string paffiliation;
            physician = Convert.ToInt32(textBox1.Text);

            department = Convert.ToInt32(textBox2.Text);
            //paffiliation = comboBox1.Text;
            sql = "delete from affiliated_with where physician=" + physician + " AND department=" + department + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void affiliated_with_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet1.affiliated_with' table. You can move, or remove it, as needed.
            this.affiliated_withTableAdapter.Fill(this.hospitalDatabaseDataSet1.affiliated_with);
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string physician, department;
            if (textBox1.Text != null)
            {
                physician = textBox1.Text;
                department = textBox2.Text;
                sql = "select * from affiliated_with t where physician=" + physician + " AND department=" + department + " ";
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
                            comboBox1.SelectedItem = dr[2].ToString();
                            
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Enter all values");
                }
                else
                {
                    int physician, department;
                    string paffiliation;
                    physician = Convert.ToInt32(textBox1.Text);


                    department = Convert.ToInt32(textBox2.Text);
                    paffiliation = comboBox1.Text;
                    sql = "insert into affiliated_with values(" + physician + "," + department + ",'" + paffiliation + "')";
                    cmd = new OleDbCommand(sql, con);
                    con.Open();
                    int r = cmd.ExecuteNonQuery();
                    con.Close();
                    populate();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Wrong entry");
            }
        }
    }
}
