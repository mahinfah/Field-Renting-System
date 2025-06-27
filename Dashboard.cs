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
using Field_Renting_System;
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
            RetrieveUserDetails();
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
                            label6.Text = userName;
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

        private void button2_Click(object sender, EventArgs e)
        {
            panel19.Visible = true;
            panel19.BringToFront();
            profilepanel.SendToBack(); // Ensure profilepanel is sent to the back  
            RetrieveUserDetails();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RetrieveUserDetails();
            profilepanel.Visible = true;
            profilepanel.BringToFront();
            panel19.SendToBack();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current Dashboard form  
            LoginUser f = new LoginUser();
            f.ShowDialog(); // Open Form1 as a dialog  
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RetrieveUserDetails()
        {
            try
            {
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                string email = userEmail;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT email, nid, phoneno, age, gender, password FROM Table_reg WHERE email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                  

                        Email.Text = reader["email"]?.ToString() ?? "Email not found.";
                        nid.Text = reader["nid"]?.ToString() ?? "NID not found.";
                        phoneno.Text = reader["phoneno"]?.ToString() ?? "Phone number not found.";
                        age.Text = reader["age"]?.ToString() ?? "Age not found.";
                        gender.Text = reader["gender"]?.ToString() ?? "Gender not found.";
                        pass.Text = reader["password"]?.ToString() ?? "Password not found.";
                      
                    }
                    else
                    {
                        MessageBox.Show("No details found for the provided email.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void phoneno_Click(object sender, EventArgs e)
        {

        }

        private void profilepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateUserDetails()
        {
            try
            {
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                string email = userEmail;
                string columnToUpdate = comboBox1.SelectedItem?.ToString();
                string newValue = update.Text;

                if (string.IsNullOrEmpty(columnToUpdate) || string.IsNullOrEmpty(newValue))
                {
                    MessageBox.Show("Please select a field and provide a value to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"UPDATE Table_reg SET {columnToUpdate} = @NewValue WHERE email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No details were updated. Please check the field and value.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            UpdateUserDetails();

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            profilepanel.SendToBack();
           panel18.BringToFront();
            panel19.SendToBack();

        }
    }
}