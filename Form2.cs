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

namespace Field_Renting_System

{
    public partial class SellerReg : Form
    {
        private string name, password, email, nid, phone;

        public SellerReg()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = TbName.Text;
            password = TbPass.Text;
            email = TbEmail.Text;
            nid = TbNid.Text;
            phone = TbPhone.Text;

            Insert();
        }

        private void Insert()
        {
            string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=testing_db;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                // ⚠️ This is vulnerable to SQL Injection. Use with caution!
                string q = "INSERT INTO Table_Seller (S_Name, S_Password, S_Email, S_NID, S_Phone) " +
                           "VALUES ('" + name + "', '" + password + "', '" + email + "', '" + nid + "', '" + phone + "')";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Seller registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}


