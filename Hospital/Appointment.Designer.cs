namespace Hospital
{
    partial class Appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Appointment
            // 
            this.ClientSize = new System.Drawing.Size(933, 506);
            this.Name = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource hospitalDatabaseDataSetBindingSource;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private HospitalDatabaseDataSet2 hospitalDatabaseDataSet2;
        private System.Windows.Forms.BindingSource hospitalDatabaseDataSet2BindingSource;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private HospitalDatabaseDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepnurseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examinationroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}