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
    public partial class block : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public block()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from block";
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
                    int blockfloor, blockcode;

                    blockfloor = Convert.ToInt32(textBox1.Text);
                    blockcode = Convert.ToInt32(textBox2.Text);

                    sql = "insert into block values(" + blockfloor + "," + blockcode + ")";
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
            int blockfloor, blockcode;

            blockfloor = Convert.ToInt32(textBox1.Text);
            blockcode = Convert.ToInt32(textBox2.Text);
            sql = "Update block set blockfloor=" + blockfloor + ",blockcode=" + blockcode + " where blockfloor=" + blockfloor + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int blockfloor, blockcode;

            blockfloor = Convert.ToInt32(textBox1.Text);
            //blockcode = Convert.ToInt32(textBox2.Text);
            sql = "delete from block where blockfloor=" + blockfloor + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
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

        private void block_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.block' table. You can move, or remove it, as needed.
            this.blockTableAdapter.Fill(this.hospitalDatabaseDataSet.block);
            populate();
        }
    }
}
