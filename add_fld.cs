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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Field_Renting_System
{
    public partial class add_fld : Form
    {
        private string fldName, fldType, fldfee, fldlocation, fldslot;
        private int fieldID;

        private void button2_Click(object sender, EventArgs e)
        {
           seller_home home = new seller_home();
            home.Show();
           this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_fld_Load(object sender, EventArgs e)
        {

        }
        private void insert()
        {
         //   string ConnectionString1 = @"Data Source=DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog=seller_database; Integrated Security=True;";
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(connectionString);
            conn1.Open();

            string query = "SELECT TOP 1 field_id FROM field_table1 ORDER BY field_id DESC;";
            SqlCommand cmd1 = new SqlCommand(query, conn1);

            object result = cmd1.ExecuteScalar();

            fieldID = Convert.ToInt32(result);

            conn1.Close();

            fieldID += 1;



          //  string ConnectionString = @"Data Source = DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog = seller_database; Integrated Security = True;";
            string ConnectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            string q = "INSERT INTO field_table1 (field_id, field_name, field_type, fee, location, slots) VALUES ('" + fieldID + "','" + fldName + "', '" + fldType + "', '" + fldfee + "', '" + fldlocation + "', '" + fldslot + "')";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();


            MessageBox.Show("Value Inserted");
        }

        public add_fld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fldName = textBox1.Text;
            fldType = comboBox1.Text;
            fldfee = textBox2.Text;
            fldlocation = textBox3.Text;
            fldslot = "";

            if (radioButton1.Checked)
                fldslot += radioButton1.Text;
            else if (radioButton2.Checked)
                fldslot += radioButton2.Text;
            else if (radioButton3.Checked)
                fldslot += radioButton3.Text;
            else if (radioButton4.Checked)
                fldslot += radioButton4.Text;
            else if (radioButton5.Checked)
                fldslot += radioButton5.Text;

         //   string connStr = @"Data Source=DESKTOP-9GN058N\SQLEXPRESS; Initial Catalog=seller_database; Integrated Security=True;";
            string connStr = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM field_table1 WHERE field_name = @name AND slots = @type";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@name", fldName);
                checkCmd.Parameters.AddWithValue("@type", fldslot);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (exists == 0)
                {
                    insert();
                }
                else
                {
                    MessageBox.Show("Field with the same name and type already exists!");
                }

            
        }

    }
}
