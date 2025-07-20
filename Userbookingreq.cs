using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task;

namespace Field_Renting_System
{
    public partial class Userbookingreq : Form
    {
        private string userEmail;

        public Userbookingreq()
        {
            InitializeComponent();
        }

        public Userbookingreq(string userEmail)
        {
            this.userEmail = userEmail;
            InitializeComponent();
            ShowBookingDetails();
        }

        private void ShowBookingDetails()
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Table_bookingreq WHERE email = @userEmail";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userEmail", userEmail);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No booking details found for the provided email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowBookingDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard(userEmail);
            d.Show();
        }

        private void Userbookingreq_Load(object sender, EventArgs e)
        {

        }
    }
}
