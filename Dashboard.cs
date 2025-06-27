using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace task
{
    public partial class Dashboard : Form
    {
        private string userEmail;

        public Dashboard(string userEmail)
        {
            this.userEmail = userEmail;
            InitializeComponent(); // Ensure this is called to initialize the form components  
            RetrieveUserName();
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // No changes needed here  
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadUserImage();

        }





        private void LoadUserImage()
        {
            try
            {
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                string email = userEmail;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT image FROM Table_userimage WHERE email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        byte[] imageData = reader["image"] as byte[];
                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                            MessageBox.Show("Image data is null.");
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        MessageBox.Show("No image found for the provided email.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            RetrieveUserName();
        }

        private void RetrieveUserName()
        {
            try
            {
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                string email = userEmail;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT name FROM Table_reg WHERE email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string userName = reader["name"] as string;
                        if (!string.IsNullOrEmpty(userName))
                        {
                            label3.Text = userName;
                        }
                        else
                        {
                            label3.Text = "Name not found.";
                            MessageBox.Show("Name data is null.");
                        }
                    }
                    else
                    {
                        label3.Text = "Name not found.";
                        MessageBox.Show("No name found for the provided email.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                label3.Text = "Error";
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}