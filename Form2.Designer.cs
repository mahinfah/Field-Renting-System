using System;

namespace Field_Renting_System

{
    partial class SellerReg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbNid = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.LbPhone = new System.Windows.Forms.Label();
            this.LbNID = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbPass = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.TbName);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.TbPhone);
            this.panel1.Controls.Add(this.TbNid);
            this.panel1.Controls.Add(this.TbEmail);
            this.panel1.Controls.Add(this.TbPass);
            this.panel1.Controls.Add(this.LbPhone);
            this.panel1.Controls.Add(this.LbNID);
            this.panel1.Controls.Add(this.LbEmail);
            this.panel1.Controls.Add(this.LbPass);
            this.panel1.Controls.Add(this.LbName);
            this.panel1.Location = new System.Drawing.Point(235, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 420);
            this.panel1.TabIndex = 0;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(155, 89);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(224, 22);
            this.TbName.TabIndex = 11;
            this.TbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(155, 321);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 32);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(155, 259);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(224, 22);
            this.TbPhone.TabIndex = 9;
            // 
            // TbNid
            // 
            this.TbNid.Location = new System.Drawing.Point(155, 220);
            this.TbNid.Name = "TbNid";
            this.TbNid.Size = new System.Drawing.Size(224, 22);
            this.TbNid.TabIndex = 8;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(155, 175);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(224, 22);
            this.TbEmail.TabIndex = 7;
            // 
            // TbPass
            // 
            this.TbPass.Location = new System.Drawing.Point(155, 130);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(224, 22);
            this.TbPass.TabIndex = 6;
            // 
            // LbPhone
            // 
            this.LbPhone.AutoSize = true;
            this.LbPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbPhone.Location = new System.Drawing.Point(33, 259);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(68, 23);
            this.LbPhone.TabIndex = 4;
            this.LbPhone.Text = "PHONE";
            // 
            // LbNID
            // 
            this.LbNID.AutoSize = true;
            this.LbNID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbNID.Location = new System.Drawing.Point(33, 220);
            this.LbNID.Name = "LbNID";
            this.LbNID.Size = new System.Drawing.Size(71, 23);
            this.LbNID.TabIndex = 3;
            this.LbNID.Text = "NID NO";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbEmail.Location = new System.Drawing.Point(33, 175);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(59, 23);
            this.LbEmail.TabIndex = 2;
            this.LbEmail.Text = "EMAIL";
            // 
            // LbPass
            // 
            this.LbPass.AutoSize = true;
            this.LbPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbPass.Location = new System.Drawing.Point(33, 130);
            this.LbPass.Name = "LbPass";
            this.LbPass.Size = new System.Drawing.Size(100, 23);
            this.LbPass.TabIndex = 1;
            this.LbPass.Text = "PASSWORD";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbName.Location = new System.Drawing.Point(33, 89);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(59, 23);
            this.LbName.TabIndex = 0;
            this.LbName.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(273, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 59);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seller Registration";
            // 
            // SellerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      //      this.BackgroundImage = global::Field_Renting_System.Properties.Resources.full_campus_view_from_stadium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "SellerReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD SELLER";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            
        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbPhone;
        private System.Windows.Forms.Label LbNID;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbPass;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.TextBox TbNid;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox TbName;
    }
}