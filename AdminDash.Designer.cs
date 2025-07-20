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
            this.button1 = new System.Windows.Forms.Button();
            this.GBoxAllBuyers = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GBoxAllField = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAField = new System.Windows.Forms.Button();
            this.btnABuyer = new System.Windows.Forms.Button();
            this.btnASeller = new System.Windows.Forms.Button();
            this.btnSField = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SellerManagement.SuspendLayout();
            this.GBoxAllBuyers.SuspendLayout();
            this.GBoxAllField.SuspendLayout();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(6, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Seller";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GBoxAllBuyers
            // 
            this.GBoxAllBuyers.BackColor = System.Drawing.Color.MediumTurquoise;
            this.GBoxAllBuyers.Controls.Add(this.button2);
            this.GBoxAllBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxAllBuyers.Location = new System.Drawing.Point(406, 48);
            this.GBoxAllBuyers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBoxAllBuyers.Name = "GBoxAllBuyers";
            this.GBoxAllBuyers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBoxAllBuyers.Size = new System.Drawing.Size(302, 162);
            this.GBoxAllBuyers.TabIndex = 2;
            this.GBoxAllBuyers.TabStop = false;
            this.GBoxAllBuyers.Text = "Buyers Management";
            this.GBoxAllBuyers.Enter += new System.EventHandler(this.GBoxAllBuyers_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 116);
            this.button2.TabIndex = 0;
            this.button2.Text = "Manage Buyers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GBoxAllField
            // 
            this.GBoxAllField.BackColor = System.Drawing.Color.Violet;
            this.GBoxAllField.Controls.Add(this.button3);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnAField);
            this.panel1.Controls.Add(this.btnABuyer);
            this.panel1.Controls.Add(this.btnASeller);
            this.panel1.Controls.Add(this.btnSField);
            this.panel1.Location = new System.Drawing.Point(10, 196);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 458);
            this.panel1.TabIndex = 3;
            // 
            // btnAField
            // 
            this.btnAField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAField.Location = new System.Drawing.Point(39, 259);
            this.btnAField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAField.Name = "btnAField";
            this.btnAField.Size = new System.Drawing.Size(144, 70);
            this.btnAField.TabIndex = 11;
            this.btnAField.Text = "Add Field";
            this.btnAField.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAField.UseVisualStyleBackColor = true;
            this.btnAField.Click += new System.EventHandler(this.btnAField_Click);
            // 
            // btnABuyer
            // 
            this.btnABuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABuyer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnABuyer.Location = new System.Drawing.Point(39, 148);
            this.btnABuyer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnABuyer.Name = "btnABuyer";
            this.btnABuyer.Size = new System.Drawing.Size(144, 79);
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
            this.btnASeller.Location = new System.Drawing.Point(39, 48);
            this.btnASeller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnASeller.Name = "btnASeller";
            this.btnASeller.Size = new System.Drawing.Size(144, 72);
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
            this.btnSField.Location = new System.Drawing.Point(39, 363);
            this.btnSField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSField.Name = "btnSField";
            this.btnSField.Size = new System.Drawing.Size(144, 77);
            this.btnSField.TabIndex = 7;
            this.btnSField.Text = "Log Out";
            this.btnSField.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSField.UseVisualStyleBackColor = true;
            this.btnSField.Click += new System.EventHandler(this.BtnSField_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(7, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 26);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.SellerManagement);
            this.panel3.Controls.Add(this.GBoxAllField);
            this.panel3.Controls.Add(this.GBoxAllBuyers);
            this.panel3.Location = new System.Drawing.Point(286, 196);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 461);
            this.panel3.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 111);
            this.button3.TabIndex = 0;
            this.button3.Text = "Manage Fields";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Field_Renting_System.Properties.Resources.full_campus_view_from_stadium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LbDashboard);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SellerManagement.ResumeLayout(false);
            this.GBoxAllBuyers.ResumeLayout(false);
            this.GBoxAllField.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnASeller;
        private System.Windows.Forms.Button btnSField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAField;
        private System.Windows.Forms.Button btnABuyer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

