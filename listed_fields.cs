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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Field_Renting_System
{
    public partial class listed_fields : Form
    {
        public listed_fields()
        {
            InitializeComponent();
        }

        private void listed_fields_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
        }

        public void show()
        {
            try
            {
                string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database ; Integrated Security = True;";
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

                dataGridView1.Columns["field_id"].HeaderText = "Field ID";
                dataGridView1.Columns["field_name"].HeaderText = "Field Name";
                dataGridView1.Columns["field_type"].HeaderText = "Field Type";
                dataGridView1.Columns["fee"].HeaderText = "Fee Amount";
                dataGridView1.Columns["location"].HeaderText = "Location Details";
                dataGridView1.Columns["slots"].HeaderText = "Available Slots";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please select a row before updating.");
                return;
            }

            try
            {
              //  string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database ; Integrated Security = True;";
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string q = "UPDATE field_table1 SET field_name='" + textBox1.Text + "',field_type='" + textBox2.Text + "',fee='" + textBox3.Text + "',location='" + textBox4.Text + "' WHERE field_id=" + textBox6.Text;
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                show();
                MessageBox.Show("Value updated");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please select a row before deleting.");
                return;
            }

            try
            {
                // string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database ; Integrated Security = True;";
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string q = "DELETE FROM field_table1 WHERE field_id=" + textBox6.Text;
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                show();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            try
            {
                string srch = textBox7.Text.ToString();

               // string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database; Integrated Security = True;";
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string q = "SELECT * FROM field_table1 WHERE field_name='" + srch + "' OR field_type='" + srch + "' OR CAST(fee AS NVARCHAR)='" + srch + "' OR location='" + srch + "' OR CAST(field_id AS NVARCHAR)='" + srch + "'";
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["field_id"].HeaderText = "Field ID";
                dataGridView1.Columns["field_name"].HeaderText = "Field Name";
                dataGridView1.Columns["field_type"].HeaderText = "Field Type";
                dataGridView1.Columns["fee"].HeaderText = "Fee Amount";
                dataGridView1.Columns["location"].HeaderText = "Location Details";
                dataGridView1.Columns["slots"].HeaderText = "Available Slots";

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No results found for: " + srch);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                seller_home seller_Home = new seller_home();
                seller_Home.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning to home: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
