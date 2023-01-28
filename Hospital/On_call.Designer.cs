namespace Hospital
{
    partial class On_call
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nurseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockfloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncallstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncallendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new Hospital.HospitalDatabaseDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.on_callTableAdapter = new Hospital.HospitalDatabaseDataSetTableAdapters.on_callTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nurse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Block Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Block Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "On Call Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "On Call End";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 20;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(329, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 21;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 25;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 26;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(329, 288);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nurseDataGridViewTextBoxColumn,
            this.blockfloorDataGridViewTextBoxColumn,
            this.blockcodeDataGridViewTextBoxColumn,
            this.oncallstartDataGridViewTextBoxColumn,
            this.oncallendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oncallBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(324, 230);
            this.dataGridView1.TabIndex = 29;
            // 
            // nurseDataGridViewTextBoxColumn
            // 
            this.nurseDataGridViewTextBoxColumn.DataPropertyName = "nurse";
            this.nurseDataGridViewTextBoxColumn.HeaderText = "nurse";
            this.nurseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nurseDataGridViewTextBoxColumn.Name = "nurseDataGridViewTextBoxColumn";
            this.nurseDataGridViewTextBoxColumn.Width = 125;
            // 
            // blockfloorDataGridViewTextBoxColumn
            // 
            this.blockfloorDataGridViewTextBoxColumn.DataPropertyName = "blockfloor";
            this.blockfloorDataGridViewTextBoxColumn.HeaderText = "blockfloor";
            this.blockfloorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blockfloorDataGridViewTextBoxColumn.Name = "blockfloorDataGridViewTextBoxColumn";
            this.blockfloorDataGridViewTextBoxColumn.Width = 125;
            // 
            // blockcodeDataGridViewTextBoxColumn
            // 
            this.blockcodeDataGridViewTextBoxColumn.DataPropertyName = "blockcode";
            this.blockcodeDataGridViewTextBoxColumn.HeaderText = "blockcode";
            this.blockcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blockcodeDataGridViewTextBoxColumn.Name = "blockcodeDataGridViewTextBoxColumn";
            this.blockcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // oncallstartDataGridViewTextBoxColumn
            // 
            this.oncallstartDataGridViewTextBoxColumn.DataPropertyName = "oncallstart";
            this.oncallstartDataGridViewTextBoxColumn.HeaderText = "oncallstart";
            this.oncallstartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oncallstartDataGridViewTextBoxColumn.Name = "oncallstartDataGridViewTextBoxColumn";
            this.oncallstartDataGridViewTextBoxColumn.Width = 125;
            // 
            // oncallendDataGridViewTextBoxColumn
            // 
            this.oncallendDataGridViewTextBoxColumn.DataPropertyName = "oncallend";
            this.oncallendDataGridViewTextBoxColumn.HeaderText = "oncallend";
            this.oncallendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oncallendDataGridViewTextBoxColumn.Name = "oncallendDataGridViewTextBoxColumn";
            this.oncallendDataGridViewTextBoxColumn.Width = 125;
            // 
            // oncallBindingSource
            // 
            this.oncallBindingSource.DataMember = "on_call";
            this.oncallBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 35);
            this.label6.TabIndex = 30;
            this.label6.Text = "On_Call";
            // 
            // on_callTableAdapter
            // 
            this.on_callTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(805, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 32;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // On_call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "On_call";
            this.Text = "On_call";
            this.Load += new System.EventHandler(this.On_call_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource oncallBindingSource;
        private HospitalDatabaseDataSetTableAdapters.on_callTableAdapter on_callTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockfloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncallstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncallendDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}