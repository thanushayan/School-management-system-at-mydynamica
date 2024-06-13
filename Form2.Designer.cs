namespace HWDb
{
    partial class Form2
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
            this.form2Grade = new System.Windows.Forms.ComboBox();
            this.form2Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.form2Female = new System.Windows.Forms.RadioButton();
            this.form2Male = new System.Windows.Forms.RadioButton();
            this.form2Address = new System.Windows.Forms.TextBox();
            this.form2Lname = new System.Windows.Forms.TextBox();
            this.form2Fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form2Grade
            // 
            this.form2Grade.FormattingEnabled = true;
            this.form2Grade.Items.AddRange(new object[] {
            "9A",
            "9B",
            "9C",
            "10A",
            "10B",
            "10C",
            "11A",
            "11B",
            "11C"});
            this.form2Grade.Location = new System.Drawing.Point(103, 177);
            this.form2Grade.Name = "form2Grade";
            this.form2Grade.Size = new System.Drawing.Size(179, 21);
            this.form2Grade.TabIndex = 17;
            // 
            // form2Update
            // 
            this.form2Update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.form2Update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2Update.Location = new System.Drawing.Point(198, 320);
            this.form2Update.Name = "form2Update";
            this.form2Update.Size = new System.Drawing.Size(84, 33);
            this.form2Update.TabIndex = 21;
            this.form2Update.Text = "Update";
            this.form2Update.UseVisualStyleBackColor = false;
            this.form2Update.Click += new System.EventHandler(this.form2Update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(-104, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 1);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Student Registration";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form2Female
            // 
            this.form2Female.AutoSize = true;
            this.form2Female.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2Female.Location = new System.Drawing.Point(159, 136);
            this.form2Female.Name = "form2Female";
            this.form2Female.Size = new System.Drawing.Size(64, 19);
            this.form2Female.TabIndex = 16;
            this.form2Female.TabStop = true;
            this.form2Female.Text = "Female";
            this.form2Female.UseVisualStyleBackColor = true;
            // 
            // form2Male
            // 
            this.form2Male.AutoSize = true;
            this.form2Male.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2Male.Location = new System.Drawing.Point(101, 136);
            this.form2Male.Name = "form2Male";
            this.form2Male.Size = new System.Drawing.Size(52, 19);
            this.form2Male.TabIndex = 15;
            this.form2Male.TabStop = true;
            this.form2Male.Text = "Male";
            this.form2Male.UseVisualStyleBackColor = true;
            // 
            // form2Address
            // 
            this.form2Address.Location = new System.Drawing.Point(103, 214);
            this.form2Address.Multiline = true;
            this.form2Address.Name = "form2Address";
            this.form2Address.Size = new System.Drawing.Size(179, 82);
            this.form2Address.TabIndex = 20;
            // 
            // form2Lname
            // 
            this.form2Lname.Location = new System.Drawing.Point(103, 95);
            this.form2Lname.Name = "form2Lname";
            this.form2Lname.Size = new System.Drawing.Size(188, 20);
            this.form2Lname.TabIndex = 14;
            // 
            // form2Fname
            // 
            this.form2Fname.Location = new System.Drawing.Point(103, 59);
            this.form2Fname.Name = "form2Fname";
            this.form2Fname.Size = new System.Drawing.Size(188, 20);
            this.form2Fname.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.form2Grade);
            this.Controls.Add(this.form2Update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.form2Female);
            this.Controls.Add(this.form2Male);
            this.Controls.Add(this.form2Address);
            this.Controls.Add(this.form2Lname);
            this.Controls.Add(this.form2Fname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox form2Grade;
        private System.Windows.Forms.Button form2Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton form2Female;
        private System.Windows.Forms.RadioButton form2Male;
        private System.Windows.Forms.TextBox form2Address;
        private System.Windows.Forms.TextBox form2Lname;
        private System.Windows.Forms.TextBox form2Fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}