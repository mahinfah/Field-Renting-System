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

    

    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //resetform4
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();

        }
        
private void check()
        {
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string connString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill all fields.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    string query = "";

                    if (Admin.Checked)
                    {
                        // Check if admin  
                        if (email == "admin" && password == "admin")
                        {
                            AdminDash form2 = new AdminDash();
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid admin credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                    else if (buyer.Checked)
                    {
                        // Check buyer credentials  
                        query = "SELECT Email FROM Table_reg WHERE Email=@Email AND password=@Password";
                    }
                    else if (Seller.Checked)
                    {
                        // Check seller credentials  
                        query = "SELECT Email FROM Seller_table WHERE Email=@Email AND password=@Password";
                    }

                    if (!string.IsNullOrEmpty(query))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string userEmail = reader["Email"].ToString();
                            Dashboard form2 = new Dashboard(userEmail);
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }
    }

        


}
