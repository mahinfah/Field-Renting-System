using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Field_Renting_System
{
    public partial class Registration : Form
    {
        private string name, email,age, pass, Nid, gender, phoneno;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Hide the current form instead of closing it  
                LoginUser u = new LoginUser();
                u.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the LoginUser page: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string query = "INSERT INTO Table_userimage (Email, image) VALUES (@Email, @Photo)";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", textBox_email.Text);


                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            byte[] imageBytes = System.IO.File.ReadAllBytes(openFileDialog.FileName);


                            cmd.Parameters.AddWithValue("@Photo", imageBytes);
                        }
                        else
                        {
                            MessageBox.Show("Please select an image.");


                            return;
                        }
                    }

                    cmd.ExecuteNonQuery();
                   
                }
            }
        }

        public Registration()
        {
            InitializeComponent();
        }

        private void insert()
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "INSERT INTO Table_reg VALUES('" + textBox_name.Text + "','" + textBox_email.Text + "' ,'" + textBox_pass.Text + "','" + textBox_phoneno.Text + "','" + textBox_NID.Text + "','" + textBox_Age.Text + "','" + gender + "')";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox_name.Text;
            email = textBox_email.Text;
            pass = textBox_pass.Text;
            phoneno = textBox_phoneno.Text;
            Nid = textBox_NID.Text;

            if (Male.Checked)
                gender = "Male";
            else if (Female.Checked)
                gender = "Female";

            try
            {
                insert();
                MessageBox.Show("Registration completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  LoginUser l = new LoginUser();
              //  l.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
