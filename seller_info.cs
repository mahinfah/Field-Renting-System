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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Field_Renting_System
{
    public partial class seller_info : Form
    {
        private string name, password, email, nid, phone;
        public seller_info()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
              //string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database ; Integrated Security = True;";
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string q = "UPDATE Table_Seller SET S_Name='" + textBox1.Text +
           "', S_Password='" + textBox2.Text +
           "', S_NID='" + textBox4.Text +
           "', S_Phone='" + textBox5.Text +
           "' WHERE S_Email='" + textBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
               
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
            seller_home seller_Home = new seller_home();
              seller_Home.Show();
             this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {  
             
        
            try
            {
                string connectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database ; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string q = "select * from Table_Seller";
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["S_Name"].HeaderText = "Seller Name";
                dataGridView1.Columns["S_Password"].HeaderText = "Seller Password";
                dataGridView1.Columns["S_Email"].HeaderText = "Seller Email";
                dataGridView1.Columns["S_NID"].HeaderText = "Seller NID";
                dataGridView1.Columns["S_Phone"].HeaderText = "Seller Phone";
                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing Data " );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }

        }
    }
    }


