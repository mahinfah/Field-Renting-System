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

        private void button2_Click(object sender, EventArgs e)
        {
            // Insert photo and email into Table_userimage  
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Table_userimage (Email, imageq) VALUES (@Email, @Photo)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", textBox_email.Text);

                    // Convert image to byte array  
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
                    MessageBox.Show("Photo and email inserted successfully.");
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
          /*  int num;
            if (int.TryParse(textBox_Age.Text, out num))
            {
                if (num <11)
                {
                    //  MessageBox.Show("Age is greater than 18.");
                    // You can proceed with registration here
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid digit.");
            }
          */
            Nid = textBox_NID.Text;
           if (Male.Checked)
               gender = "Male";
           else if (Female.Checked)
                gender = "Female";

            int age;
            if (int.TryParse(textBox_Age.Text, out age))
            {
                if (age > 18)
                {
                  //  MessageBox.Show("Age is greater than 18.");
                    // You can proceed with registration here
                }
                else
                {
                    MessageBox.Show("Age must be greater than 18.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for age.");
            }


            //   if (cbprogramming.Checked)
            //     skills = "Programming,";
            // if (cbcommunication.Checked)
            //     skills += "Communication,";
            // if (cbresearch.Checked)
            //     skills += "Research";
            // dept = comboBox1.Text;

            MessageBox.Show("Name:" + name + "\n Email:" + email 
               + " \n Password" + pass 
                + "\n Gender:" + 
               gender 
               +"\n age"+age  );
           
            insert();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
