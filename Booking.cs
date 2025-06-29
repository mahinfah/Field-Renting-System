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
using task;

namespace Field_Renting_System
{

public partial class Booking : Form
    {
        private string userEmail;
        public string em;
        public Booking(string email)
        {
            InitializeComponent();
            userEmail = email;
            em = email;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Show()
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from field_table1";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            Show();
        }



        private void Bookbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get selected row data  
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string fieldId = selectedRow.Cells["field_id"].Value.ToString();
                    string fieldName = selectedRow.Cells["field_name"].Value.ToString();
                    string fieldType = selectedRow.Cells["field_type"].Value.ToString(); // e.g., "football"
                    string location = selectedRow.Cells["location"].Value.ToString();    // e.g., "uttara"
                    float fee = Convert.ToSingle(selectedRow.Cells["fee"].Value);        // e.g., 3500
                    string slots = selectedRow.Cells["slots"].Value.ToString();

                    // Insert into Table_bookingreq  
                    string insertQuery = "INSERT INTO Table_bookingreq (email, field_id, field_name, field_type, fee, location, slots) VALUES (@userEmail, @fieldId, @fieldName, @fieldType, @fee, @location, @slots)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@userEmail", em);
                        insertCmd.Parameters.AddWithValue("@fieldId", fieldId);
                        insertCmd.Parameters.AddWithValue("@fieldName", fieldName);
                        insertCmd.Parameters.AddWithValue("@fieldType", fieldType);
                        insertCmd.Parameters.AddWithValue("@fee", fee);
                        insertCmd.Parameters.AddWithValue("@location", location);
                        insertCmd.Parameters.AddWithValue("@slots", slots);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Delete from field_table1  
                    string deleteQuery = "DELETE FROM field_table1 WHERE field_id = @fieldId";

                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@fieldId", fieldId);
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView  
                Show();
                MessageBox.Show("Booking request submitted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a field to book.");
            }
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search()
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from field_table1 where field_name LIKE '" + txtsearch.Text + "%'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard(userEmail);
            f.Show();
            this.Close();

        }
    }
}
