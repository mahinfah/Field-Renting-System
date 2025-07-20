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
using System.Xml.Linq;

namespace Field_Renting_System
{
    public partial class Adminuserupdate: Form
    {
        public Adminuserupdate()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            TbName.Text = "";
            TbPass.Text = "";
            TbEmail.Text = "";
            TbNid.Text = "";
            TbPhone.Text = "";
            TbAge.Text = "";
          //  comboBoxG.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=UserDB;Integrated Security=True;Encrypt=False;";
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "UPDATE Table_reg SET NAME='" + TbName.Text +
           "', phoneno='" + TbPhone.Text +
           "', PASSWORD='" + TbPass.Text +
           "', Age='" + TbAge.Text +
           "', NID='" + TbNid.Text +
           "' WHERE Email='" + TbEmail.Text + "'";

            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            Show();
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=UserDB;Integrated Security=True;Encrypt=False;";
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from Table_reg where Email LIKE '" + TbEmail.Text + "%'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";
           // string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=UserDB;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "DELETE FROM Table_reg WHERE Email='" + TbEmail.Text + "'";

            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            Show();
            Clear();
        }

        private void Show()
        {

          //  string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=UserDB;Integrated Security=True;Encrypt=False;";
            string connectionString = @"Data Source=MAHIN;Initial Catalog=testing_db;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from Table_reg";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TbEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TbPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TbPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TbNid.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TbAge.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
           // comboBoxG.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();
        }
    }
}
