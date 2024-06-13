using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWDb
{
    public partial class Form3 : Form
    {
        string id;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string grade = null;
            string sql = null;
            string name = null;
             
            
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            SqlCommand command;
            sql = "INSERT INTO grade_1 (  grade) VALUES ( '"+ txtGrade.Text +"')";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Save Sucessfully");
                
                txtGrade.Text = "";
                 
                
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                
                this.id = dataGridView2.SelectedRows[0].Cells["id"].Value.ToString();
                 
                
               // string name = dataGridView2.SelectedRows[0].Cells["name"].Value.ToString();

                string grade = dataGridView2.SelectedRows[0].Cells["grade"].Value.ToString();

               // txtName.Text = name;
                txtGrade.Text = grade;
                 
            }
        }

      

        private void btnRead_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from grade_1";

            try
            {
                cnn.Open();


                SqlCommand sqlcommand = new SqlCommand(sql, cnn);


                SqlDataReader sqlReader = sqlcommand.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(sqlReader);


                sqlReader.Close();


                sqlcommand.Dispose();


                dataGridView2.DataSource = dt;


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.CurrentRow.Cells["id"].Value.ToString();

            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }




            string connectionString = null;
            connectionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command;
            string sql = "DELETE FROM grade_1 WHERE id = @id";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from grade_1";

            try
            {
                cnn.Open();


                SqlCommand sqlcommand = new SqlCommand(sql, cnn);


                SqlDataReader sqlReader = sqlcommand.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(sqlReader);


                sqlReader.Close();


                sqlcommand.Dispose();


                dataGridView2.DataSource = dt;


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }
    }
    }
    
   
    