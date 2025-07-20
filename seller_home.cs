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
    public partial class seller_home : Form
    {
       
        public seller_home()
        {
            InitializeComponent();
        }

        private void add_fld_Click(object sender, EventArgs e)
        {
            add_fld newform = new add_fld();
            newform.Show();
            this.Close();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {//
            listed_fields showfield = new listed_fields();
            showfield.Show();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                View_Table_approved Table_approved = new View_Table_approved();
                Table_approved.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the table_app form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seller_info seller_Info = new seller_info();    
            seller_Info.Show();
            this.Close();
        }

        private void seller_home_MouseHover(object sender, EventArgs e)
        {

        }

        private void seller_home_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bookingreq req = new bookingreq();
            req.Show();
            this.Close();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginUser u = new LoginUser();
            u.Show();
            this.Close();

        }
    }
}
