using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string gender = null;
            string sql = null;
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            if (radioFemale.Checked)
            {
                gender = "Female";
            }
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            SqlCommand command;
            sql = "INSERT INTO intern  (first_name, last_name, grade, address, gender) VALUES ('" + txtFname.Text + "', '" + txtLname.Text + "', '" + comboGrade.Text + "', '" + txtAdd.Text + "', '" + gender + "')";
           
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Save Sucessfully");
                txtFname.Text = "";
                txtLname.Text = "";
                comboGrade.Text = "";
                txtAdd.Text = "";
                if (radioMale.Checked)
                {
                    radioMale.Checked = false;
                }
                if (radioFemale.Checked)
                {
                    radioFemale.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
    }
}
