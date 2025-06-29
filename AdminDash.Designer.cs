using System;
namespace Field_Renting_System

{
    partial class AdminDash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbDashboard = new System.Windows.Forms.Label();
            this.SellerManagement = new System.Windows.Forms.GroupBox();
            this.GBoxAllBuyers = new System.Windows.Forms.GroupBox();
            this.GBoxAllField = new System.Windows.Forms.GroupBox();
            this.GBoxTotalPayment = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUField = new System.Windows.Forms.Button();
            this.btnDField = new System.Windows.Forms.Button();
            this.btnAField = new System.Windows.Forms.Button();
            this.btnUBuyer = new System.Windows.Forms.Button();
            this.btnSBuyer = new System.Windows.Forms.Button();
            this.btnDBuyer = new System.Windows.Forms.Button();
            this.btnABuyer = new System.Windows.Forms.Button();
            this.btnASeller = new System.Windows.Forms.Button();
            this.btnSField = new System.Windows.Forms.Button();
            this.btnRPass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbDashboard
            // 
            this.LbDashboard.AutoSize = true;
            this.LbDashboard.BackColor = System.Drawing.Color.Transparent;
            this.LbDashboard.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDashboard.ForeColor = System.Drawing.Color.DarkOrange;
            this.LbDashboard.Location = new System.Drawing.Point(252, 62);
            this.LbDashboard.Name = "LbDashboard";
            this.LbDashboard.Size = new System.Drawing.Size(654, 96);
            this.LbDashboard.TabIndex = 0;
            this.LbDashboard.Text = "Admin Dashboard";
            this.LbDashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // SellerManagement
            // 
            this.SellerManagement.BackColor = System.Drawing.Color.Yellow;
            this.SellerManagement.Controls.Add(this.button1);
            this.SellerManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerManagement.Location = new System.Drawing.Point(60, 48);
            this.SellerManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellerManagement.Name = "SellerManagement";
            this.SellerManagement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellerManagement.Size = new System.Drawing.Size(308, 162);
            this.SellerManagement.TabIndex = 1;
            this.SellerManagement.TabStop = false;
            this.SellerManagement.Text = "Seller Management";
            this.SellerManagement.Enter += new System.EventHandler(this.GbSeller_Enter);
            // 
            // GBoxAllBuyers
            // 
            this.GBoxAllBuyers.BackColor = System.Drawing.Color.MediumTurquoise;
            this.GBoxAllBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxAllBuyers.Location = new System.Drawing.Point(406, 48);
            this.GBoxAllBuyers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBoxAllBuyers.Name = "GBoxAllBuyers";
            this.GBoxAllBuyers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBoxAllBuyers.Size = new System.Drawing.Size(302, 162);
            this.GBoxAllBuyers.TabIndex = 2;
            this.GBoxAllBuyers.TabStop = false;
            this.GBoxAllBuyers.Text = "View All Buyers";
            this.GBoxAllBuyers.Enter += new System.EventHandler(this.GBoxAllBuyers_Enter);
            // 
            // GBoxAllField
            // 
            this.GBoxAllField.BackColor = System.Drawing.Color.Violet;
            this.GBoxAllField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxAllField.Location = new System.Drawing.Point(60, 235);
            this.GBoxAllField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBoxAllField.Name = "GBoxAllField";
            this.GBoxAllField.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBoxAllField.Size = new System.Drawing.Size(308, 154);
            this.GBoxAllField.TabIndex = 2;
            this.GBoxAllField.TabStop = false;
            this.GBoxAllField.Text = "View All Fields";
            this.GBoxAllField.Enter += new System.EventHandler(this.GBoxAllField_Enter);
            // 
            // GBoxTotalPayment
            // 
            this.GBoxTotalPayment.BackColor = System.Drawing.Color.MediumVioletRed;
            this.GBoxTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxTotalPayment.Location = new System.Drawing.Point(406, 235);
            this.GBoxTotalPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBoxTotalPayment.Name = "GBoxTotalPayment";
            this.GBoxTotalPayment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBoxTotalPayment.Size = new System.Drawing.Size(302, 154);
            this.GBoxTotalPayment.TabIndex = 2;
            this.GBoxTotalPayment.TabStop = false;
            this.GBoxTotalPayment.Text = "Total Payment";
            this.GBoxTotalPayment.Enter += new System.EventHandler(this.GBoxTotalPayment_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnUField);
            this.panel1.Controls.Add(this.btnDField);
            this.panel1.Controls.Add(this.btnAField);
            this.panel1.Controls.Add(this.btnUBuyer);
            this.panel1.Controls.Add(this.btnSBuyer);
            this.panel1.Controls.Add(this.btnDBuyer);
            this.panel1.Controls.Add(this.btnABuyer);
            this.panel1.Controls.Add(this.btnASeller);
            this.panel1.Controls.Add(this.btnSField);
            this.panel1.Controls.Add(this.btnRPass);
            this.panel1.Location = new System.Drawing.Point(7, 252);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 461);
            this.panel1.TabIndex = 3;
            // 
            // btnUField
            // 
            this.btnUField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUField.Location = new System.Drawing.Point(39, 399);
            this.btnUField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUField.Name = "btnUField";
            this.btnUField.Size = new System.Drawing.Size(144, 35);
            this.btnUField.TabIndex = 13;
            this.btnUField.Text = "Update Field";
            this.btnUField.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUField.UseVisualStyleBackColor = true;
            this.btnUField.Click += new System.EventHandler(this.btnUField_Click);
            // 
            // btnDField
            // 
            this.btnDField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDField.Location = new System.Drawing.Point(39, 354);
            this.btnDField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDField.Name = "btnDField";
            this.btnDField.Size = new System.Drawing.Size(144, 35);
            this.btnDField.TabIndex = 12;
            this.btnDField.Text = "Delete Field";
            this.btnDField.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDField.UseVisualStyleBackColor = true;
            this.btnDField.Click += new System.EventHandler(this.btnDField_Click);
            // 
            // btnAField
            // 
            this.btnAField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAField.Location = new System.Drawing.Point(39, 311);
            this.btnAField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAField.Name = "btnAField";
            this.btnAField.Size = new System.Drawing.Size(144, 35);
            this.btnAField.TabIndex = 11;
            this.btnAField.Text = "Add Field";
            this.btnAField.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAField.UseVisualStyleBackColor = true;
            this.btnAField.Click += new System.EventHandler(this.btnAField_Click);
            // 
            // btnUBuyer
            // 
            this.btnUBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUBuyer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUBuyer.Location = new System.Drawing.Point(39, 269);
            this.btnUBuyer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUBuyer.Name = "btnUBuyer";
            this.btnUBuyer.Size = new System.Drawing.Size(144, 35);
            this.btnUBuyer.TabIndex = 10;
            this.btnUBuyer.Text = "Update Buyers";
            this.btnUBuyer.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUBuyer.UseVisualStyleBackColor = true;
            this.btnUBuyer.Click += new System.EventHandler(this.btnUBuyer_Click);
            // 
            // btnSBuyer
            // 
            this.btnSBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSBuyer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSBuyer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSBuyer.Location = new System.Drawing.Point(39, 99);
            this.btnSBuyer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSBuyer.Name = "btnSBuyer";
            this.btnSBuyer.Size = new System.Drawing.Size(144, 35);
            this.btnSBuyer.TabIndex = 6;
            this.btnSBuyer.Text = "Search Buyer";
            this.btnSBuyer.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSBuyer.UseVisualStyleBackColor = true;
            this.btnSBuyer.Click += new System.EventHandler(this.BtnSBuyer_Click);
            // 
            // btnDBuyer
            // 
            this.btnDBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBuyer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDBuyer.Location = new System.Drawing.Point(39, 226);
            this.btnDBuyer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDBuyer.Name = "btnDBuyer";
            this.btnDBuyer.Size = new System.Drawing.Size(144, 35);
            this.btnDBuyer.TabIndex = 9;
            this.btnDBuyer.Text = "Delete Buyers";
            this.btnDBuyer.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDBuyer.UseVisualStyleBackColor = true;
            this.btnDBuyer.Click += new System.EventHandler(this.btnDBuyer_Click);
            // 
            // btnABuyer
            // 
            this.btnABuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABuyer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnABuyer.Location = new System.Drawing.Point(39, 184);
            this.btnABuyer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnABuyer.Name = "btnABuyer";
            this.btnABuyer.Size = new System.Drawing.Size(144, 35);
            this.btnABuyer.TabIndex = 8;
            this.btnABuyer.Text = "Add Buyers";
            this.btnABuyer.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnABuyer.UseVisualStyleBackColor = true;
            this.btnABuyer.Click += new System.EventHandler(this.btnABuyer_Click);
            // 
            // btnASeller
            // 
            this.btnASeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASeller.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnASeller.Location = new System.Drawing.Point(39, 56);
            this.btnASeller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnASeller.Name = "btnASeller";
            this.btnASeller.Size = new System.Drawing.Size(144, 35);
            this.btnASeller.TabIndex = 5;
            this.btnASeller.Text = "Add Seller";
            this.btnASeller.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnASeller.UseVisualStyleBackColor = true;
            this.btnASeller.Click += new System.EventHandler(this.btnASeller_Click);
            // 
            // btnSField
            // 
            this.btnSField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSField.Location = new System.Drawing.Point(39, 141);
            this.btnSField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSField.Name = "btnSField";
            this.btnSField.Size = new System.Drawing.Size(144, 35);
            this.btnSField.TabIndex = 7;
            this.btnSField.Text = "Search Field";
            this.btnSField.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSField.UseVisualStyleBackColor = true;
            this.btnSField.Click += new System.EventHandler(this.BtnSField_Click);
            // 
            // btnRPass
            // 
            this.btnRPass.BackColor = System.Drawing.Color.Transparent;
            this.btnRPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRPass.Location = new System.Drawing.Point(39, 14);
            this.btnRPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRPass.Name = "btnRPass";
            this.btnRPass.Size = new System.Drawing.Size(144, 35);
            this.btnRPass.TabIndex = 4;
            this.btnRPass.Text = "Reset Password";
            this.btnRPass.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRPass.UseVisualStyleBackColor = false;
            this.btnRPass.Click += new System.EventHandler(this.btnRPass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(7, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 32);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.SellerManagement);
            this.panel3.Controls.Add(this.GBoxAllField);
            this.panel3.Controls.Add(this.GBoxAllBuyers);
            this.panel3.Controls.Add(this.GBoxTotalPayment);
            this.panel3.Location = new System.Drawing.Point(274, 252);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 461);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(6, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Seller";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 754);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbDashboard);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SellerManagement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbDashboard;
        private System.Windows.Forms.GroupBox SellerManagement;
        private System.Windows.Forms.GroupBox GBoxAllBuyers;
        private System.Windows.Forms.GroupBox GBoxAllField;
        private System.Windows.Forms.GroupBox GBoxTotalPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnASeller;
        private System.Windows.Forms.Button btnSBuyer;
        private System.Windows.Forms.Button btnSField;
        private System.Windows.Forms.Button btnRPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUField;
        private System.Windows.Forms.Button btnDField;
        private System.Windows.Forms.Button btnAField;
        private System.Windows.Forms.Button btnUBuyer;
        private System.Windows.Forms.Button btnDBuyer;
        private System.Windows.Forms.Button btnABuyer;
        private System.Windows.Forms.Button button1;
    }
}

