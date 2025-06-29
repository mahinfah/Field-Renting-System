using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task;

namespace Field_Renting_System
{
    public partial class rentrecord : Form
    {


        private string userEmail;

        public rentrecord(string userEmail)
        {
            this.userEmail = userEmail;
            InitializeComponent();      // Ensure this is called to initialize the form components  
        //    RetrieveUserName();
          //  RetrieveUserDetails();
        }


        public rentrecord()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Show()
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string q = "SELECT * FROM Table_approved WHERE email = @userEmail";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@userEmail", userEmail); // Use the userEmail field to pass the email parameter  
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard(userEmail);
            d.Show();
            this.Hide(); // Hide the current form
        }
    }
}
