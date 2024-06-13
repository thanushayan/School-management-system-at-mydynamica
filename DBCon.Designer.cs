namespace HWDb
{
    partial class DBCon
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGet_All_Students = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGet_Stu = new System.Windows.Forms.Button();
            this.dbGrade = new System.Windows.Forms.ComboBox();
            this.dbSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbFemale = new System.Windows.Forms.RadioButton();
            this.dbMale = new System.Windows.Forms.RadioButton();
            this.dbAddress = new System.Windows.Forms.TextBox();
            this.dbLname = new System.Windows.Forms.TextBox();
            this.dbFname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbColumn = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label7.Location = new System.Drawing.Point(188, 9);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(459, 36);
            label7.TabIndex = 36;
            label7.Text = "Student Management System";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGet_All_Students
            // 
            this.btnGet_All_Students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGet_All_Students.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet_All_Students.Location = new System.Drawing.Point(9, 388);
            this.btnGet_All_Students.Name = "btnGet_All_Students";
            this.btnGet_All_Students.Size = new System.Drawing.Size(109, 62);
            this.btnGet_All_Students.TabIndex = 0;
            this.btnGet_All_Students.Text = "Get All Students";
            this.btnGet_All_Students.UseVisualStyleBackColor = false;
            this.btnGet_All_Students.Click += new System.EventHandler(this.btnGet_All_Students_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(9, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(492, 245);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(239, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 62);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Students ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGet_Stu
            // 
            this.btnGet_Stu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGet_Stu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet_Stu.Location = new System.Drawing.Point(124, 388);
            this.btnGet_Stu.Name = "btnGet_Stu";
            this.btnGet_Stu.Size = new System.Drawing.Size(109, 62);
            this.btnGet_Stu.TabIndex = 0;
            this.btnGet_Stu.Text = "Get Student ";
            this.btnGet_Stu.UseVisualStyleBackColor = false;
            this.btnGet_Stu.Click += new System.EventHandler(this.btnGet_Stu_Click);
            // 
            // dbGrade
            // 
            this.dbGrade.FormattingEnabled = true;
            this.dbGrade.Items.AddRange(new object[] {
            "9A",
            "9B",
            "9C",
            "10A",
            "10B",
            "10C",
            "11A",
            "11B",
            "11C"});
            this.dbGrade.Location = new System.Drawing.Point(619, 244);
            this.dbGrade.Name = "dbGrade";
            this.dbGrade.Size = new System.Drawing.Size(179, 21);
            this.dbGrade.TabIndex = 31;
            // 
            // dbSubmit
            // 
            this.dbSubmit.BackColor = System.Drawing.Color.Magenta;
            this.dbSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbSubmit.Location = new System.Drawing.Point(708, 395);
            this.dbSubmit.Name = "dbSubmit";
            this.dbSubmit.Size = new System.Drawing.Size(84, 33);
            this.dbSubmit.TabIndex = 35;
            this.dbSubmit.Text = "Create";
            this.dbSubmit.UseVisualStyleBackColor = false;
            this.dbSubmit.Click += new System.EventHandler(this.dbSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(478, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 1);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = "  Registration";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbFemale
            // 
            this.dbFemale.AutoSize = true;
            this.dbFemale.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbFemale.Location = new System.Drawing.Point(687, 205);
            this.dbFemale.Name = "dbFemale";
            this.dbFemale.Size = new System.Drawing.Size(64, 19);
            this.dbFemale.TabIndex = 30;
            this.dbFemale.TabStop = true;
            this.dbFemale.Text = "Female";
            this.dbFemale.UseVisualStyleBackColor = true;
            // 
            // dbMale
            // 
            this.dbMale.AutoSize = true;
            this.dbMale.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbMale.Location = new System.Drawing.Point(619, 205);
            this.dbMale.Name = "dbMale";
            this.dbMale.Size = new System.Drawing.Size(52, 19);
            this.dbMale.TabIndex = 29;
            this.dbMale.TabStop = true;
            this.dbMale.Text = "Male";
            this.dbMale.UseVisualStyleBackColor = true;
            // 
            // dbAddress
            // 
            this.dbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbAddress.Location = new System.Drawing.Point(619, 271);
            this.dbAddress.Multiline = true;
            this.dbAddress.Name = "dbAddress";
            this.dbAddress.Size = new System.Drawing.Size(179, 82);
            this.dbAddress.TabIndex = 34;
            // 
            // dbLname
            // 
            this.dbLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbLname.Location = new System.Drawing.Point(619, 164);
            this.dbLname.Name = "dbLname";
            this.dbLname.Size = new System.Drawing.Size(188, 20);
            this.dbLname.TabIndex = 28;
            // 
            // dbFname
            // 
            this.dbFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbFname.Location = new System.Drawing.Point(619, 118);
            this.dbFname.Name = "dbFname";
            this.dbFname.Size = new System.Drawing.Size(188, 20);
            this.dbFname.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(514, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name";
            // 
            // dbNew
            // 
            this.dbNew.BackColor = System.Drawing.Color.YellowGreen;
            this.dbNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbNew.Location = new System.Drawing.Point(538, 403);
            this.dbNew.Name = "dbNew";
            this.dbNew.Size = new System.Drawing.Size(95, 33);
            this.dbNew.TabIndex = 35;
            this.dbNew.Text = "New";
            this.dbNew.UseVisualStyleBackColor = false;
            this.dbNew.Click += new System.EventHandler(this.dbNew_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(354, 388);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 62);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(103, 340);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 20);
            this.txtSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(9, 328);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 38);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbColumn
            // 
            this.cmbColumn.FormattingEnabled = true;
            this.cmbColumn.Items.AddRange(new object[] {
            "first_name",
            "last_name",
            "gender",
            "grade",
            "address"});
            this.cmbColumn.Location = new System.Drawing.Point(239, 339);
            this.cmbColumn.Name = "cmbColumn";
            this.cmbColumn.Size = new System.Drawing.Size(121, 21);
            this.cmbColumn.TabIndex = 38;
            // 
            // DBCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(828, 465);
            this.Controls.Add(this.cmbColumn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(label7);
            this.Controls.Add(this.dbGrade);
            this.Controls.Add(this.dbNew);
            this.Controls.Add(this.dbSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dbFemale);
            this.Controls.Add(this.dbMale);
            this.Controls.Add(this.dbAddress);
            this.Controls.Add(this.dbLname);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dbFname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGet_Stu);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGet_All_Students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DBCon";
            this.Text = "Student management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGet_All_Students;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGet_Stu;
        private System.Windows.Forms.ComboBox dbGrade;
        private System.Windows.Forms.Button dbSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton dbFemale;
        private System.Windows.Forms.RadioButton dbMale;
        private System.Windows.Forms.TextBox dbAddress;
        private System.Windows.Forms.TextBox dbLname;
        private System.Windows.Forms.TextBox dbFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dbNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbColumn;
    }
}