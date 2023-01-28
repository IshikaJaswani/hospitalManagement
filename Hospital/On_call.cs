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
    public partial class On_call : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public On_call()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from on_call";
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
                    if (dateTimePicker1.Value < DateTime.Now || dateTimePicker2.Value < DateTime.Now)
                    {
                        MessageBox.Show("Enter valid date");
                    }
                    else
                    {
                        int nurse, blockfloor, blockcode;

                        nurse = Convert.ToInt32(textBox1.Text);

                        blockfloor = Convert.ToInt32(textBox2.Text);
                        blockcode = Convert.ToInt32(textBox3.Text);

                        DateTime oncallstart = Convert.ToDateTime(dateTimePicker1.Value);
                        DateTime oncallend = Convert.ToDateTime(dateTimePicker2.Value);

                        sql = "insert into on_call values(" + nurse + "," + blockfloor + "," + blockcode + ",'" + oncallstart + "','" + oncallend + "')";
                        cmd = new OleDbCommand(sql, con);
                        con.Open();
                        int r = cmd.ExecuteNonQuery();
                        con.Close();
                        populate();
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
            int nurse, blockfloor, blockcode;

            nurse = Convert.ToInt32(textBox1.Text);

            blockfloor = Convert.ToInt32(textBox2.Text);
            blockcode = Convert.ToInt32(textBox3.Text);

            DateTime oncallstart = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime oncallend = Convert.ToDateTime(dateTimePicker2.Value);
            sql = "Update  on_call set blockfloor=" + blockfloor + ",blockcode=" + blockcode + ",oncallstart='" + oncallstart + "',oncallend='" + oncallend + "' where nurse=" + nurse + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nurse, blockfloor, blockcode;

            nurse = Convert.ToInt32(textBox1.Text);

            //blockfloor = Convert.ToInt32(textBox2.Text);
            //blockcode = Convert.ToInt32(textBox3.Text);

            DateTime oncallstart = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime oncallend = Convert.ToDateTime(dateTimePicker2.Value);
            sql = "delete from on_call where nurse=" + nurse + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }

        private void On_call_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.on_call' table. You can move, or remove it, as needed.
            this.on_callTableAdapter.Fill(this.hospitalDatabaseDataSet.on_call);

        }
    }
}
