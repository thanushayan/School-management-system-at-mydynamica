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
    public partial class Form2 : Form
    {
        string id = null;
        string firstname = null;
        string lastname = null;
        string gender = null;
        string grade = null;
        string address = null;

        public Form2(string id, string firstname, string lastname, string gender, string grade, string address)
        {
            InitializeComponent();
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.grade = grade;
            this.address = address;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form2Fname.Text = this.firstname;
            form2Lname.Text = this.lastname;
            form2Grade.Text = this.grade;
            form2Address.Text = this.address;

            if(gender == "Male")
            {
                form2Male.Checked = true;
            } else if (gender == "Female")
            {
                form2Female.Checked = true;
            }

        }

        private void form2Update_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";
            
            if (form2Male.Checked)
            {
                gender = "Male";
            }
            else if (form2Female.Checked)
            {
                gender = "Female";
            }

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "UPDATE [intern] SET [first_name] = '" + form2Fname.Text + "', [last_name] = '" + form2Lname.Text + "', gender = '" + gender + "', [grade] = '" + form2Grade.Text + "', [address] = '" + form2Address.Text + "' WHERE [id] = '" + this.id + "' ";
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            this.Close();
        }
    }
    }

