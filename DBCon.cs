using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWDb
{
    public partial class DBCon : Form
    {
        string id;
        private object dgvStudent;

        public DBCon()
        {
            InitializeComponent();
        }

        private void btnTest_Connection_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;


            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            // string sql;
            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "INSERT INTO [intern]([first_name],[last_name],[gender],[grade],[address])VALUES ('muralee','sanyai','Male','10A','vavuniya')";
            //sql = "INSERT INTO intern (first_name, last_name, gender, grade, address) VALUES ('Mithursan', 'Kalanantharasan', 'Male', '10A', 'Jaffna')";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("data insert successfull ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void btnGet_All_Students_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from intern";

            try
            {
                cnn.Open();


                SqlCommand sqlcommand = new SqlCommand(sql, cnn);


                SqlDataReader sqlReader = sqlcommand.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(sqlReader);


                sqlReader.Close();


                sqlcommand.Dispose();


                dataGridView1.DataSource = dt;


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* if (dataGridView1.SelectedRows.Count > 0)
             {
                 int selectedIndex = dataGridView1.SelectedRows[0].Index;
                 int id = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                 string connectionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True;TrustServerCertificate=True;";


                 using (SqlConnection cnn = new SqlConnection(connectionString))
                 {
                     try
                     {
                         string sql = "DELETE FROM intern WHERE id = @id";
                         cnn.Open();
                         SqlCommand command = new SqlCommand(sql, cnn);
                         command.Parameters.AddWithValue("@id", id);
                         command.ExecuteNonQuery();


                         MessageBox.Show("Row deleted successfully!");




                         cnn.Close();



                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Cannot delete row! ");
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Please select a row to delete.");
             }*/
            string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }




            string connectionString = null;
            connectionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command;
            string sql = "DELETE FROM intern WHERE id = @id";
            try
            {

                cnn.Open();
                SqlCommand Sqlcommand = new SqlCommand(sql, cnn);
                Sqlcommand.Parameters.AddWithValue("@id", id);
                Sqlcommand.ExecuteNonQuery();


                MessageBox.Show("Row deleted successfully!");




                cnn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete row! ");
            }


        }

        private void btnGet_Stu_Click(object sender, EventArgs e)
        {
            // string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            //MessageBox.Show(id);
            // string first_name = dataGridView1.SelectedRows[0].Cells["first_name"].ToString();
            // MessageBox.Show(first_name);

            try
            {
                string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                MessageBox.Show(id);
            }
            catch
            {
                MessageBox.Show("please select row");
            }





        }

        private void btnEdit_StudentClick(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            string firstname = dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString();
            string lastname = dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString();
            string gender = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
            string grade = dataGridView1.SelectedRows[0].Cells["grade"].Value.ToString();
            string address = dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();

            Form2 form2 = new Form2(id, firstname, lastname, gender, grade, address);
            form2.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dbSubmit.Text = "Update";
                this.id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                string firstname = dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString();
                string lastname = dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString();
                string gender = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
                string grade = dataGridView1.SelectedRows[0].Cells["grade"].Value.ToString();
                string address = dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();
                dbFname.Text = firstname;
                dbLname.Text = lastname;
                dbGrade.Text = grade;
                dbAddress.Text = address;
                if (gender == "Male")
                {
                    dbMale.Checked = true;
                }
                else
                {
                    dbFemale.Checked = true;
                }
            }
        }

        private void dbSubmit_Click(object sender, EventArgs e)
        {
            if (dbSubmit.Text == "Create")
            {
                string connetionString = null;
                string gender = null;
                string sql = null;
                if (dbMale.Checked)
                {
                    gender = "Male";
                }
                if (dbFemale.Checked)
                {
                    gender = "Female";
                }
                connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";
                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);
                SqlCommand command;
                sql = "INSERT INTO intern (first_name, last_name, grade, address, gender) VALUES ('" + dbFname.Text + "', '" + dbLname.Text + "', '" + dbGrade.Text + "', '" + dbAddress.Text + "', '" + gender + "')";
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    MessageBox.Show("Save Sucessfully");
                    dbFname.Text = "";
                    dbLname.Text = "";
                    dbGrade.Text = "";
                    dbAddress.Text = "";
                    if (dbMale.Checked)
                    {
                        dbMale.Checked = false;
                    }
                    if (dbFemale.Checked)
                    {
                        dbFemale.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
            }
            else
            {
                string connetionString = null;
                connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";
                string gender = null;
                if (dbMale.Checked)
                {
                    gender = "Male";
                }
                else if (dbFemale.Checked)
                {
                    gender = "Female";
                }
                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);
                SqlCommand command;
                string sql = "UPDATE [intern] SET [first_name] = '" + dbFname.Text + "', [last_name] = '" + dbLname.Text + "', gender = '" + gender + "', [grade] = '" + dbGrade.Text + "', [address] = '" + dbAddress.Text + "' WHERE [id] = '" + this.id + "' ";
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
            }
        }


        private void dbNew_Click_1(object sender, EventArgs e)
        {
            dbSubmit.Text = "Create";
            dbFname.Text = "";
            dbLname.Text = "";
            dbGrade.Text = "";
            dbAddress.Text = "";
            dbMale.Checked = false;
            dbFemale.Checked = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from intern";

            try
            {
                cnn.Open();


                SqlCommand sqlcommand = new SqlCommand(sql, cnn);


                SqlDataReader sqlReader = sqlcommand.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(sqlReader);


                sqlReader.Close();


                sqlcommand.Dispose();


                dataGridView1.DataSource = dt;


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            // string sql = "SELECT * FROM intern WHERE first_name='"+dbFname.Text+"'"; 
           // string sql = "select * from intern where first_name like '%" + txtSearch.Text + "%' or last_name like '%" + txtSearch.Text + "%'   or gender like '%" + txtSearch.Text + "%' or grade like '%" + txtSearch.Text+ "%'  or address like '%" +txtSearch.Text+ "%' " ;
            string sql = "select * from intern where " + cmbColumn.SelectedItem.ToString() + "  like '%" + txtSearch.Text + "%'";


            try
            {
                cnn.Open();


                SqlCommand sqlcommand = new SqlCommand(sql, cnn);


                SqlDataReader sqlReader = sqlcommand.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(sqlReader);


                sqlReader.Close();


                sqlcommand.Dispose();


                dataGridView1.DataSource = dt;


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }

      /* private void cmbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            // string sql = "SELECT * FROM intern WHER E first_name='"+dbFname.Text+"'"; 
            string sql = "select * from intern where "+ cmbColumn.SelectedItem.ToString()+ "  like '%" + txtSearch.Text + "%'";



            try
            {
                cnn.Open();


                SqlCommand sqlcommand = new SqlCommand(sql, cnn);


                SqlDataReader sqlReader = sqlcommand.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(sqlReader);


                sqlReader.Close();


                sqlcommand.Dispose();


                dataGridView1.DataSource = dt;


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }*/
    }
    }
    







