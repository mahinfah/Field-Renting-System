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

namespace Field_Renting_System
{
    public partial class bookingreq : Form
    {
        public bookingreq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show 
            Show();

        }

        private void Show()
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from Table_bookingreq";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    if (selectedRow.DataBoundItem is DataRowView rowView)
                    {
                        DataRow row = rowView.Row;

                        string insertQuery = "INSERT INTO Table_approved (Email, field_id, field_name, field_type, fee, location, slots) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                        insertCmd.Parameters.AddWithValue("@Value1", row["Email"]);
                        insertCmd.Parameters.AddWithValue("@Value2", row["field_id"]);
                        insertCmd.Parameters.AddWithValue("@Value3", row["field_name"]);
                        insertCmd.Parameters.AddWithValue("@Value4", row["field_type"]);

                        float feeValue = 0;
                        float.TryParse(row["fee"]?.ToString(), out feeValue);
                        insertCmd.Parameters.AddWithValue("@Value5", feeValue);

                        insertCmd.Parameters.AddWithValue("@Value6", row["location"]);
                        insertCmd.Parameters.AddWithValue("@Value7", row["slots"]);

                        insertCmd.ExecuteNonQuery();

                        string deleteQuery = "DELETE FROM Table_bookingreq WHERE field_id = @FieldId";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@FieldId", row["field_id"]);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show($"Failed to delete record with field_id: {row["field_id"]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

              
                Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
  
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    if (selectedRow.DataBoundItem is DataRowView rowView)
                    {
                        DataRow row = rowView.Row;

                                                string insertQuery = "INSERT INTO field_table1 (field_id, field_name, field_type, fee, location, slots) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                        insertCmd.Parameters.AddWithValue("@Value1", row["field_id"]);
                        insertCmd.Parameters.AddWithValue("@Value2", row["field_name"]);
                        insertCmd.Parameters.AddWithValue("@Value3", row["field_type"]);

                
                        float feeValue = 0;
                        float.TryParse(row["fee"]?.ToString(), out feeValue);
                        insertCmd.Parameters.AddWithValue("@Value4", feeValue);

                        insertCmd.Parameters.AddWithValue("@Value5", row["location"]);
                        insertCmd.Parameters.AddWithValue("@Value6", row["slots"]);
                      
                        insertCmd.ExecuteNonQuery();
 
                        string deleteQuery = "DELETE FROM Table_bookingreq WHERE field_id = @FieldId";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@FieldId", row["field_id"]);

                     
                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show($"Failed to delete record with field_id: {row["field_id"]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
 
                Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seller_home nnn = new seller_home();
            nnn.Show();
            this.Close();
        }
    }
}
