namespace Hospital
{
    partial class appointment1
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepnurseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examinationroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new Hospital.HospitalDatabaseDataSet();
            this.appointmentTableAdapter = new Hospital.HospitalDatabaseDataSetTableAdapters.appointmentTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(455, 312);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(455, 354);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 41;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(455, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 40;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(455, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 39;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 38;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 37;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 36;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Examination Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "End_dt_time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Start_dt_time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Physician";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Prep nurse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Appointment ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentidDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.prepnurseDataGridViewTextBoxColumn,
            this.physicianDataGridViewTextBoxColumn,
            this.startdttimeDataGridViewTextBoxColumn,
            this.enddttimeDataGridViewTextBoxColumn,
            this.examinationroomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(682, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(521, 250);
            this.dataGridView1.TabIndex = 45;
            // 
            // appointmentidDataGridViewTextBoxColumn
            // 
            this.appointmentidDataGridViewTextBoxColumn.DataPropertyName = "appointmentid";
            this.appointmentidDataGridViewTextBoxColumn.HeaderText = "appointmentid";
            this.appointmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentidDataGridViewTextBoxColumn.Name = "appointmentidDataGridViewTextBoxColumn";
            this.appointmentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "patient";
            this.patientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.Width = 125;
            // 
            // prepnurseDataGridViewTextBoxColumn
            // 
            this.prepnurseDataGridViewTextBoxColumn.DataPropertyName = "prepnurse";
            this.prepnurseDataGridViewTextBoxColumn.HeaderText = "prepnurse";
            this.prepnurseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prepnurseDataGridViewTextBoxColumn.Name = "prepnurseDataGridViewTextBoxColumn";
            this.prepnurseDataGridViewTextBoxColumn.Width = 125;
            // 
            // physicianDataGridViewTextBoxColumn
            // 
            this.physicianDataGridViewTextBoxColumn.DataPropertyName = "physician";
            this.physicianDataGridViewTextBoxColumn.HeaderText = "physician";
            this.physicianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.physicianDataGridViewTextBoxColumn.Name = "physicianDataGridViewTextBoxColumn";
            this.physicianDataGridViewTextBoxColumn.Width = 125;
            // 
            // startdttimeDataGridViewTextBoxColumn
            // 
            this.startdttimeDataGridViewTextBoxColumn.DataPropertyName = "start_dt_time";
            this.startdttimeDataGridViewTextBoxColumn.HeaderText = "start_dt_time";
            this.startdttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdttimeDataGridViewTextBoxColumn.Name = "startdttimeDataGridViewTextBoxColumn";
            this.startdttimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // enddttimeDataGridViewTextBoxColumn
            // 
            this.enddttimeDataGridViewTextBoxColumn.DataPropertyName = "end_dt_time";
            this.enddttimeDataGridViewTextBoxColumn.HeaderText = "end_dt_time";
            this.enddttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enddttimeDataGridViewTextBoxColumn.Name = "enddttimeDataGridViewTextBoxColumn";
            this.enddttimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // examinationroomDataGridViewTextBoxColumn
            // 
            this.examinationroomDataGridViewTextBoxColumn.DataPropertyName = "examinationroom";
            this.examinationroomDataGridViewTextBoxColumn.HeaderText = "examinationroom";
            this.examinationroomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examinationroomDataGridViewTextBoxColumn.Name = "examinationroomDataGridViewTextBoxColumn";
            this.examinationroomDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 35);
            this.label8.TabIndex = 46;
            this.label8.Text = "Appointment";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(682, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 31);
            this.button4.TabIndex = 47;
            this.button4.Text = "Check Availability";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(580, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 31);
            this.button5.TabIndex = 48;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(940, 409);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 49;
            this.button6.Text = "Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // appointment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 535);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "appointment1";
            this.Text = "appointment1";
            this.Load += new System.EventHandler(this.appointment1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private HospitalDatabaseDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepnurseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examinationroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}