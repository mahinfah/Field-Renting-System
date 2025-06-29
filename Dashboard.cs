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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;
namespace task
{
    public partial class Dashboard : Form
    {
        private string userEmail;

        public Dashboard(string userEmail)
        {
            this.userEmail = userEmail;
            InitializeComponent();      // Ensure this is called to initialize the form components  
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
            profilepanel.SendToBack();
            mainpanel.SendToBack();
            // Ensure profilepanel is sent to the back  
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
            f.Show(); // Open Form1 as a dialog  
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
                    string query = "SELECT name, email, nid, phoneno, age, gender, password FROM Table_reg WHERE email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtname.Text = reader["name"]?.ToString() ?? "Name not found.";
                        txtemail.Text = reader["email"]?.ToString() ?? "Email not found.";
                        txtnid.Text = reader["nid"]?.ToString() ?? "NID not found.";
                        txtphone.Text = reader["phoneno"]?.ToString() ?? "Phone number not found.";
                        txtage.Text = reader["age"]?.ToString() ?? "Age not found.";
                        txtpass.Text = reader["password"]?.ToString() ?? "Password not found.";

                        label6.Text = reader["name"]?.ToString() ?? "Name not found.";
                        Email.Text = reader["email"]?.ToString() ?? "Email not found.";
                        nid.Text = reader["nid"]?.ToString() ?? "NID not found.";
                        phoneno.Text = reader["phoneno"]?.ToString() ?? "Phone number not found.";
                        age.Text = reader["age"]?.ToString() ?? "Age not found.";
                        pass.Text = reader["password"]?.ToString() ?? "Password not found.";

                        string genderValue = reader["gender"]?.ToString();
                        gender.Text = genderValue ?? "Gender not found."; 
                        if (genderValue == "Male")
                        {
                            Male.Checked = true;
                        }
                        else if (genderValue == "Female")
                        {
                            Female.Checked = true;
                        }
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
            
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string qq = "UPDATE Table_reg SET NAME='" + txtname.Text + "', PASSWORD='" + txtpass.Text + "', phoneno='" + txtphone.Text + "', NID='" + txtnid.Text + "', Age='" + txtage.Text + "' WHERE email='" + userEmail + "'";
            SqlCommand cmd = new SqlCommand(qq, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("User details updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Show();
            clear();  
        }

        private void clear()
        {
            txtname.Clear();
            txtemail.Clear();
            txtnid.Clear();
            txtphone.Clear();
            txtage.Clear();
            txtpass.Clear();
           Male.Checked = false;
            Female.Checked = false;

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
            mainpanel.BringToFront();
            panel19.SendToBack();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current Dashboard form  
            Booking bookingForm = new Booking(userEmail); // Pass the email to the Booking class  
            bookingForm.ShowDialog(); // Open the Booking form as a dialog  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rentrecord r = new rentrecord(userEmail);
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //see booking request
           Userbookingreq r= new Userbookingreq(userEmail);
            r.Show();
            this.Close(); // Close the current Dashboard form

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //payment

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //show rent records 
            rentrecord r = new rentrecord(userEmail);
            r.Show();
            this.Close(); // Close the current Dashboard form

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel19.SendToBack();
            profilepanel.SendToBack();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtnid_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            payment();
        }


        private void payment()
        {
            try
            {
                string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
                string email = userEmail;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT SUM(fee) AS TotalFee FROM Table_approved WHERE email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal totalFee = Convert.ToDecimal(result);
                        MessageBox.Show($"Total fee for the user is: {totalFee}", "Payment Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No fee records found for the provided email.", "Payment Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}