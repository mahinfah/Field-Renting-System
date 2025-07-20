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
    public partial class View_Table_approved : Form
    {
        public View_Table_approved()
        {
            InitializeComponent();
            try
            {
                show();
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void show()
        {
            try
            {
                //string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database ; Integrated Security = True;";
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string q = "select * from Table_approved";
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["Email"].HeaderText = "User email";
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
                MessageBox.Show("Error displaying data: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            try
            {
                string srch = textBox1.Text.ToString();

                //string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database; Integrated Security = True;";
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string q = "SELECT * FROM Table_approved WHERE Email='" + srch + "' OR field_name='" + srch + "' OR field_type='" + srch + "' OR CAST(fee AS NVARCHAR)='" + srch + "' OR location='" + srch + "'";
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["Email"].HeaderText = "User email";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                seller_home home = new seller_home();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening seller home: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database ; Integrated Security = True;";
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                if (comboBox1.SelectedIndex == 1)
                {
                    string q = "SELECT * FROM Table_approved ORDER BY fee ASC";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["Email"].HeaderText = "User email";
                    dataGridView1.Columns["field_id"].HeaderText = "Field ID";
                    dataGridView1.Columns["field_name"].HeaderText = "Field Name";
                    dataGridView1.Columns["field_type"].HeaderText = "Field Type";
                    dataGridView1.Columns["fee"].HeaderText = "Fee Amount";
                    dataGridView1.Columns["location"].HeaderText = "Location Details";
                    dataGridView1.Columns["slots"].HeaderText = "Available Slots";
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    string q = "SELECT * FROM Table_approved ORDER BY field_id ASC";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["Email"].HeaderText = "User email";
                    dataGridView1.Columns["field_id"].HeaderText = "Field ID";
                    dataGridView1.Columns["field_name"].HeaderText = "Field Name";
                    dataGridView1.Columns["field_type"].HeaderText = "Field Type";
                    dataGridView1.Columns["fee"].HeaderText = "Fee Amount";
                    dataGridView1.Columns["location"].HeaderText = "Location Details";
                    dataGridView1.Columns["slots"].HeaderText = "Available Slots";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }
    }
}
