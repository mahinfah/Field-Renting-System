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
    public partial class Userbookingreq : Form
    {
        public Userbookingreq()
        {
            InitializeComponent();
        }
        private string userEmail;
        public Userbookingreq(string userEmail)
        {
            this.userEmail = userEmail;
            InitializeComponent();      // Ensure this is called to initialize the form components  
                                        //    RetrieveUserName();
                                        //  RetrieveUserDetails();
        }

        private void show()
        {
            string connectionString = @"Data Source=DESKTOP-OCNS2DA\SQLEXPRESS;Initial Catalog=GUMSDb;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string q = "select * from Table_bookingreq where email = @userEmail";
                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@userEmail", userEmail); // Pass the userEmail parameter securely
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            DataTable dt = ds.Tables[0];
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

    }
}
