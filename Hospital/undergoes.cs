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
    public partial class undergoes : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public undergoes()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from undergoes";
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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Enter all values");
                }
                else
                {
                    if (dateTimePicker1.Value < DateTime.Now )
                    {
                        MessageBox.Show("Enter valid date");
                    }
                    else
                    {
                        int patient, procedure, stay, physician, assistingnurse;

                        patient = Convert.ToInt32(textBox1.Text);
                        procedure = Convert.ToInt32(textBox2.Text);
                        stay = Convert.ToInt32(textBox3.Text);
                        DateTime udate = Convert.ToDateTime(dateTimePicker1.Value);
                        physician = Convert.ToInt32(textBox4.Text);
                        assistingnurse = Convert.ToInt32(textBox5.Text);
                        sql = "insert into undergoes values(" + patient + "," + procedure + "," + stay + ",'" + udate + "'," + physician + "," + assistingnurse + ")";
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
            int patient, procedure, stay, physician, assistingnurse;

            patient = Convert.ToInt32(textBox1.Text);
            procedure = Convert.ToInt32(textBox2.Text);
            stay = Convert.ToInt32(textBox3.Text);
            DateTime udate = Convert.ToDateTime(dateTimePicker1.Value);
            physician = Convert.ToInt32(textBox4.Text);
            assistingnurse = Convert.ToInt32(textBox5.Text);
            sql = "Update  undergoes set procedue=" + procedure + ",stay=" + stay + ",udate='" + udate + "',physician=" + physician + ",assistingnurse=" + assistingnurse + " where patient=" + patient + " ";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int patient, procedure, stay, physician, assistingnurse;

            patient = Convert.ToInt32(textBox1.Text);
            //procedure = Convert.ToInt32(textBox2.Text);
            //stay = Convert.ToInt32(textBox3.Text);
            //DateTime udate = Convert.ToDateTime(dateTimePicker1.Value);
            //physician = Convert.ToInt32(textBox4.Text);
            //assistingnurse = Convert.ToInt32(textBox5.Text);
            sql = "delete from undergoes where patient=" + patient + " ";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int patient, procedure, stay;

            if (textBox1.Text != null)
            {
                patient = Convert.ToInt32(textBox1.Text);
                //procedure = Convert.ToInt32(textBox2.Text);
                //stay = Convert.ToInt32(textBox3.Text);
                sql = "select * from undergoes t where patient=" + patient + " ";
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
                            textBox4.Text = dr[4].ToString();
                            textBox5.Text = dr[5].ToString();

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }

        private void undergoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.undergoes' table. You can move, or remove it, as needed.
            this.undergoesTableAdapter.Fill(this.hospitalDatabaseDataSet.undergoes);

        }
    }
}
