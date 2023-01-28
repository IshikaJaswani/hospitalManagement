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
    public partial class viewbill : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        public viewbill()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        private void viewbill_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            int ssn;
            int code;
            if (textBox1.Text != null)
            {

                ssn = Convert.ToInt32(textBox1.Text);
                sql = "select * from patient where patient.ssn=" + ssn + "";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox1.Text = dr[0].ToString();
                        textBox2.Text = dr[1].ToString();
                        textBox3.Text = dr[2].ToString();
                        textBox7.Text = dr[3].ToString();
                        textBox4.Text = dr[5].ToString();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                dr.Close();
                con.Close();
                cmd.Dispose();
                ssn = Convert.ToInt32(textBox1.Text);
                sql = "select * from undergoes where undergoes.patient=" + ssn + "";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox5.Text = dr[1].ToString();
                       
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                dr.Close();
                con.Close();
                cmd.Dispose();
                code = Convert.ToInt32(textBox5.Text);
                sql = "select * from procedures where procedures.code=" + code + "";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox6.Text = dr[2].ToString();
                        

                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                dr.Close();
                con.Close();
                cmd.Dispose();
                sql = "select * from stay where stay.patient=" + ssn + "";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox8.Text = dr[2].ToString();
                        textBox11.Text = dr[3].ToString();
                        textBox12.Text = dr[4].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                dr.Close();
                con.Close();
                cmd.Dispose();
                int room = Convert.ToInt32(textBox8.Text);
                sql = "select * from room where room.roomnumber=" + room + "";
                cmd = new OleDbCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox9.Text = dr[1].ToString();
                        if(textBox9.Text=="ac")
                        {
                            textBox10.Text = "1500";
                        }
                        else
                        {
                            textBox10.Text = "500";
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
                DateTime sd = Convert.ToDateTime(textBox11.Text);
                DateTime ed = Convert.ToDateTime(textBox12.Text);
                int diff = Convert.ToInt32((sd - ed).TotalDays);
                if(diff==0)
                {
                    diff = 1;
                }
                double t = Convert.ToDouble(Convert.ToDouble(textBox6.Text) + (diff * Convert.ToInt32(textBox10.Text)));
                textBox13.Text = t.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User u = new User();
            u.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           // int d = dateTimePicker1.Value.Day;
           // int m = dateTimePicker1.Value.Month;
           // int y = dateTimePicker1.Value.Year;
            //string da = dateTimePicker1.Value.Date.ToString();
            Report f1 = new Report();
            //f1.Show();
            f1.ShowDialog();
            f1.Show();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string s = "select patient.ssn,undergoes.procedue,procedures.cost,stay.room,room.roomtype from patient, undergoes,procedures,stay,room where (patient.ssn=undergoes.patient) AND (undergoes.procedue=procedures.code) AND (undergoes.patient=stay.patient) AND (stay.room=room.roomnumber) ";
            OleDbCommand cmd = new OleDbCommand(s, con);
            OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds, "patient");
            CrystalReport5 cr1 = new CrystalReport5();
            cr1.SetDataSource(ds);
            //cr1.SetDataSource(ds.Tables[0]);
            f1.crystalReportViewer1.ReportSource = cr1;
            f1.crystalReportViewer1.Refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
