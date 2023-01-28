namespace Hospital
{
    partial class trained_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.physicianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificationexpiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainedinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new Hospital.HospitalDatabaseDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.trained_inTableAdapter = new Hospital.HospitalDatabaseDataSetTableAdapters.trained_inTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainedinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physician";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Treatment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Certification Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Certification Expires";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(442, 269);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.physicianDataGridViewTextBoxColumn,
            this.treatmentDataGridViewTextBoxColumn,
            this.certificationdateDataGridViewTextBoxColumn,
            this.certificationexpiresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainedinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(749, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(342, 283);
            this.dataGridView1.TabIndex = 17;
            // 
            // physicianDataGridViewTextBoxColumn
            // 
            this.physicianDataGridViewTextBoxColumn.DataPropertyName = "physician";
            this.physicianDataGridViewTextBoxColumn.HeaderText = "physician";
            this.physicianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.physicianDataGridViewTextBoxColumn.Name = "physicianDataGridViewTextBoxColumn";
            this.physicianDataGridViewTextBoxColumn.Width = 125;
            // 
            // treatmentDataGridViewTextBoxColumn
            // 
            this.treatmentDataGridViewTextBoxColumn.DataPropertyName = "treatment";
            this.treatmentDataGridViewTextBoxColumn.HeaderText = "treatment";
            this.treatmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.treatmentDataGridViewTextBoxColumn.Name = "treatmentDataGridViewTextBoxColumn";
            this.treatmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // certificationdateDataGridViewTextBoxColumn
            // 
            this.certificationdateDataGridViewTextBoxColumn.DataPropertyName = "certificationdate";
            this.certificationdateDataGridViewTextBoxColumn.HeaderText = "certificationdate";
            this.certificationdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.certificationdateDataGridViewTextBoxColumn.Name = "certificationdateDataGridViewTextBoxColumn";
            this.certificationdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // certificationexpiresDataGridViewTextBoxColumn
            // 
            this.certificationexpiresDataGridViewTextBoxColumn.DataPropertyName = "certificationexpires";
            this.certificationexpiresDataGridViewTextBoxColumn.HeaderText = "certificationexpires";
            this.certificationexpiresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.certificationexpiresDataGridViewTextBoxColumn.Name = "certificationexpiresDataGridViewTextBoxColumn";
            this.certificationexpiresDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainedinBindingSource
            // 
            this.trainedinBindingSource.DataMember = "trained_in";
            this.trainedinBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Trained In";
            // 
            // trained_inTableAdapter
            // 
            this.trained_inTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 19;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1016, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 24;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // trained_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "trained_in";
            this.Text = "trained_in";
            this.Load += new System.EventHandler(this.trained_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainedinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource trainedinBindingSource;
        private HospitalDatabaseDataSetTableAdapters.trained_inTableAdapter trained_inTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificationexpiresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}