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
    public partial class Appointment : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        OleDbDataAdapter da;
        public Appointment()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        void populate()
        {
            con.Open();
            sql = "select * from appointment";
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
            int appointmentid, patient, prepnurse,physician;
            string examinationroom;
            appointmentid = Convert.ToInt32(textBox1.Text);

            patient = Convert.ToInt32(textBox2.Text);
            prepnurse = Convert.ToInt32(textBox3.Text);
            physician = Convert.ToInt32(textBox4.Text);
            DateTime start_dt_time = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime end_dt_time = Convert.ToDateTime(dateTimePicker2.Value);
            examinationroom = textBox5.Text;
            sql = "insert into appointment values(" + appointmentid + "," + patient + "," + prepnurse + "," + physician + ",'" + start_dt_time + "','" + end_dt_time + "','" + examinationroom + "')";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            con.Close();
            populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong entry");
            }
        }

        private void button2_Click(object sender, EventArgs e)
            {
                int appointmentid, patient, prepnurse, physician;
                string examinationroom;
                appointmentid = Convert.ToInt32(textBox1.Text);

                patient = Convert.ToInt32(textBox2.Text);
                prepnurse = Convert.ToInt32(textBox3.Text);
                physician = Convert.ToInt32(textBox4.Text);
                DateTime start_dt_time = Convert.ToDateTime(dateTimePicker1.Value);
                DateTime end_dt_time = Convert.ToDateTime(dateTimePicker2.Value);
                examinationroom = textBox5.Text;
                sql = "Update  appointment set appointmentid=" + appointmentid + ",patient=" + patient + ",prepnurse=" + prepnurse + ",physician=" + physician + ",start_dt_time='" + start_dt_time + "',end_dt_time='" + end_dt_time + "' where appointmentid=" + appointmentid + " ";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show(r + "Update successfully");
                con.Close();
                populate();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int appointmentid, patient, prepnurse, physician;
            string examinationroom;
            appointmentid = Convert.ToInt32(textBox1.Text);

            patient = Convert.ToInt32(textBox2.Text);
            prepnurse = Convert.ToInt32(textBox3.Text);
            physician = Convert.ToInt32(textBox4.Text);
            DateTime start_dt_time = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime end_dt_time = Convert.ToDateTime(dateTimePicker2.Value);
            examinationroom = textBox5.Text;
            sql = "delete from appointment where appointmentid=" + appointmentid + " AND patient=" + patient + " AND prepnurse=" + prepnurse + "";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r + "Deleted successfully");
            con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime start_dt_time = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime end_dt_time = Convert.ToDateTime(dateTimePicker2.Value);


            sql = "select start_dt_time,end_dt_time from appointment ";
            cmd = new OleDbCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DateTime s1 = Convert.ToDateTime(dr[0]);
                    DateTime e1 = Convert.ToDateTime(dr[1]);
                    int t1 = 15;
                    int t2 = 17;

                    int hour = s1.Hour;
                    int hours = e1.Hour;
                    if (hour > t1 && hours < 17)
                    { 
                    int c = DateTime.Compare(e1.Date, end_dt_time.Date);
                    if (c == 0)
                    {
                        int c1 = DateTime.Compare(e1, end_dt_time);
                        if (c1 == 1)
                        {
                            TimeSpan span = e1.Subtract(end_dt_time);
                            if (span.Minutes > 14)
                            {
                                MessageBox.Show("booked1");
                            }
                            else
                            {
                                MessageBox.Show("choose another slot");
                            }
                        }
                        else if (c1 == -1)
                        {
                            TimeSpan span = end_dt_time.Subtract(e1);
                            if (span.Minutes > 14)
                            {
                                MessageBox.Show("booked2");
                            }
                            else
                            {

                                MessageBox.Show(span.Minutes.ToString());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Not Booked");
                    }
                }
                    else
                    {
                        MessageBox.Show("This slot is not available");
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

        private void button5_Click(object sender, EventArgs e)
        {
            string appointmentid = "";

            if (textBox1.Text != null)
            {
                appointmentid = textBox1.Text;
                sql = "select * from appointment t where t.appointmentid=" + appointmentid + " ";
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
                            dateTimePicker1.Value = Convert.ToDateTime(dr[4].ToString());
                            dateTimePicker2.Value = Convert.ToDateTime(dr[5].ToString());
                            textBox5.Text = dr[6].ToString();
                            
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

        private void Appointment_Load_1(object sender, EventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.hospitalDatabaseDataSet.appointment);
            populate();
            
           
        }
    }
}
