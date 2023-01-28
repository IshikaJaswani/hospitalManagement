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
    public partial class prescribes : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public prescribes()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from prescribes";
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
                        int physician, patient, medication, appointment;

                        physician = Convert.ToInt32(textBox1.Text);

                        patient = Convert.ToInt32(textBox2.Text);
                        medication = Convert.ToInt32(textBox3.Text);

                        DateTime pdate = Convert.ToDateTime(dateTimePicker1.Value);
                        appointment = Convert.ToInt32(textBox4.Text);
                        string dose = textBox5.Text;

                        sql = "insert into prescribes values(" + physician + "," + patient + "," + medication + ",'" + pdate + "'," + appointment + ",'" + dose + "')";
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
            int physician, patient, medication, appointment;

            physician = Convert.ToInt32(textBox1.Text);

            patient = Convert.ToInt32(textBox2.Text);
            medication = Convert.ToInt32(textBox3.Text);

            DateTime pdate = Convert.ToDateTime(dateTimePicker1.Value);
            appointment = Convert.ToInt32(textBox4.Text);
            string dose = textBox5.Text;
            sql = "Update  prescribes set patient=" + patient + ",medication=" + medication + ",pdate='" + pdate + "',appointment=" + appointment + ",dose='" + dose + "' where physician=" + physician + " AND patient=" + patient + " AND medication=" + medication + " ";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Update successfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int physician, patient, medication, appointment;

            physician = Convert.ToInt32(textBox1.Text);

            patient = Convert.ToInt32(textBox2.Text);
            medication = Convert.ToInt32(textBox3.Text);

            //DateTime pdate = Convert.ToDateTime(dateTimePicker1.Value);
           // appointment = Convert.ToInt32(textBox4.Text);
            string dose = textBox5.Text;
            sql = "delete from prescribes where physician=" + physician + " AND patient=" + patient + " AND medication=" + medication + " ";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string physician, patient, medication;
            DateTime pdate;
            if (textBox1.Text != null)
            {
                physician = textBox1.Text;
                patient = textBox2.Text;
                medication = textBox3.Text;
                //pdate = dateTimePicker1.Value;
                sql = "select * from prescribes t where physician=" + physician + " AND patient=" + patient + " AND medication=" + medication + " ";
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }

        private void prescribes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.prescribes' table. You can move, or remove it, as needed.
            this.prescribesTableAdapter.Fill(this.hospitalDatabaseDataSet.prescribes);

        }
    }
}
