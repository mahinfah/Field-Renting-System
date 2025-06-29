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
    public partial class rentrecord : Form
    {
        public rentrecord()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Show()
        {
            string connectionString = @"Data Source=DESKTOP-OCNS2DA\SQLEXPRESS;Initial Catalog=GUMSDb;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from ";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }


    }
}
