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
using System.IO;

namespace Hospital
{
    public partial class admin : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        string str, sql;
        public admin()
        {
            InitializeComponent();
            str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            con = new OleDbConnection(str);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            On_call f5 = new On_call();
            f5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Physician f1 = new Physician();
            f1.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department f2 = new Department();
            f2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            affiliated_with f3 = new affiliated_with();
            f3.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            block f4 = new block();
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            trained_in f6 = new trained_in();
            f6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nurse f7 = new Nurse();
            f7.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string CurrentDatabasePath = @"C:\Users\ISHIKA\Documents\HospitalDatabase.mdb";
            string test = DateTime.Now.Year.ToString() + "Year" + "-" + DateTime.Now.Month.ToString() + "Month" + "-" + DateTime.Now.Day.ToString() + "Day";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string PathtobackUp = fbd.SelectedPath.ToString();
                File.Copy(CurrentDatabasePath, PathtobackUp + @"\" + test + "BackUp.mdb", true);
                MessageBox.Show("successfully Backup! ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f9 = new Form1();
            f9.ShowDialog();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            change_password f1 = new change_password();
            f1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient p = new Patient();
            p.ShowDialog();
            Form1 f1 = new Form1();
            f1.Close();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stay s = new Stay();
            s.ShowDialog();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            undergoes u = new undergoes();
            u.ShowDialog();
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            prescribes pr = new prescribes();
            pr.ShowDialog();
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            medication m = new medication();
            m.ShowDialog();
                
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room r = new Room();
            r.ShowDialog();
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            appointment1 a = new appointment1();
            a.ShowDialog();
            
        }

        private void button19_Click(object sender, EventArgs e)
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

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            procedure pro = new procedure();
            pro.ShowDialog();
            
        }
    }
}
