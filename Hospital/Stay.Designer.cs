namespace Hospital
{
    partial class Stay
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
            this.stayidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new Hospital.HospitalDatabaseDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.stayTableAdapter = new Hospital.HospitalDatabaseDataSetTableAdapters.stayTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stay ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start_time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Time";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(369, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(369, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 28;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 234);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(369, 286);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stayidDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(618, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(339, 204);
            this.dataGridView1.TabIndex = 31;
            // 
            // stayidDataGridViewTextBoxColumn
            // 
            this.stayidDataGridViewTextBoxColumn.DataPropertyName = "stayid";
            this.stayidDataGridViewTextBoxColumn.HeaderText = "stayid";
            this.stayidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stayidDataGridViewTextBoxColumn.Name = "stayidDataGridViewTextBoxColumn";
            this.stayidDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "patient";
            this.patientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "room";
            this.roomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.Width = 125;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // stayBindingSource
            // 
            this.stayBindingSource.DataMember = "stay";
            this.stayBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 35);
            this.label6.TabIndex = 32;
            this.label6.Text = "Stay";
            // 
            // stayTableAdapter
            // 
            this.stayTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(494, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 33;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 61);
            this.button5.TabIndex = 34;
            this.button5.Text = "Check Availability";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(869, 342);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 35;
            this.button6.Text = "Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Stay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
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
            this.Name = "Stay";
            this.Text = "Stay";
            this.Load += new System.EventHandler(this.Stay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stayBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource stayBindingSource;
        private HospitalDatabaseDataSetTableAdapters.stayTableAdapter stayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stayidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}