namespace Hospital
{
    partial class block
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blockfloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new Hospital.HospitalDatabaseDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.blockTableAdapter = new Hospital.HospitalDatabaseDataSetTableAdapters.blockTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block Floor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Block Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(380, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 232);
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
            this.blockfloorDataGridViewTextBoxColumn,
            this.blockcodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.blockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(540, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(316, 157);
            this.dataGridView1.TabIndex = 17;
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
            // blockBindingSource
            // 
            this.blockBindingSource.DataMember = "block";
            this.blockBindingSource.DataSource = this.hospitalDatabaseDataSetBindingSource;
            // 
            // hospitalDatabaseDataSetBindingSource
            // 
            this.hospitalDatabaseDataSetBindingSource.DataSource = this.hospitalDatabaseDataSet;
            this.hospitalDatabaseDataSetBindingSource.Position = 0;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 18;
            this.label3.Text = "Block";
            // 
            // blockTableAdapter
            // 
            this.blockTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(781, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 24;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // block
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "block";
            this.Text = "block";
            this.Load += new System.EventHandler(this.block_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource hospitalDatabaseDataSetBindingSource;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource blockBindingSource;
        private HospitalDatabaseDataSetTableAdapters.blockTableAdapter blockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockfloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}