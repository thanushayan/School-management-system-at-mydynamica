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
    public partial class DB : Form
    {
        public DB()
        {
            InitializeComponent();
        }

        private void btnDb_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=THANU\\SQLEXPRESS;Database=dynamica;Trusted_Connection=True; TrustServerCertificate=True;";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
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
    }
}
