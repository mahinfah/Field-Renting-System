using System;
using System.Windows.Forms;

namespace Field_Renting_System

{
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
          InitializeComponent();
        }

        private void GbSeller_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnRPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reset Password Clicked");
        }

        private void btnASeller_Click(object sender, EventArgs e)
        {
           //// SellerReg sellerRegForm = new SellerReg(); // Create an instance of SellerReg form
         //   sellerRegForm.Show(); // Show the SellerReg form
           // MessageBox.Show("Added Seller Clicked");
            SellerReg eee = new SellerReg();
            eee.Show();
            this.Hide();
        }

        private void BtnSBuyer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search Buyer Clicked");
        }

        private void BtnSField_Click(object sender, EventArgs e)
        {//
          //  MessageBox.Show("Search Field Clicked");
          LoginUser eeee = new LoginUser();
            eeee.Show();
            this.Hide(); // Hide the current form


        }

        private void btnABuyer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("View All Buyers Clicked");
            Registration n = new Registration();
            n.Show();
            this.Close();


        }

        private void btnDBuyer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Total Payment Clicked");
        }

        private void btnUBuyer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View All Sellers Clicked");
        }

        private void btnAField_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Add Field Clicked");
          add_fld add = new add_fld();
            add.Show();
            this.Hide(); // Hide the current form
        }

        private void btnDField_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Field Clicked");
        }

        private void btnUField_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Field Details Clicked");
        }

        private void GBoxAllField_Enter(object sender, EventArgs e)
        {
        }

        private void GBoxTotalPayment_Enter(object sender, EventArgs e)
        {
        }

        private void GBoxAllBuyers_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seller_info bn = new seller_info();
            bn.Show();
            this.Hide(); // Hide the current form


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminuserupdate adminuserupdate = new Adminuserupdate();
            adminuserupdate.Show();
            this.Hide(); // Hide the current form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listed_fields f = new listed_fields();
            f.Show();
            this.Close();

        }
    }
}
