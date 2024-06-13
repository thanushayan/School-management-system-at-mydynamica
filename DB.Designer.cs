namespace HWDb
{
    partial class DB
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
            this.btnDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDb
            // 
            this.btnDb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDb.Location = new System.Drawing.Point(56, 48);
            this.btnDb.Name = "btnDb";
            this.btnDb.Size = new System.Drawing.Size(124, 23);
            this.btnDb.TabIndex = 0;
            this.btnDb.Text = "test connection";
            this.btnDb.UseVisualStyleBackColor = true;
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 132);
            this.Controls.Add(this.btnDb);
            this.Name = "DB";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDb;
    }
}