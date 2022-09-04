﻿
namespace WriteNotesApplication
{
    partial class ChangeUserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserInfoForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.lblConPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmdConHide = new System.Windows.Forms.Button();
            this.cmdConShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.cmdConHide);
            this.groupBox1.Controls.Add(this.cmdConShow);
            this.groupBox1.Controls.Add(this.btnHide);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.lblRegister);
            this.groupBox1.Controls.Add(this.txtConPassword);
            this.groupBox1.Controls.Add(this.txtPassWord);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.cmdRegister);
            this.groupBox1.Controls.Add(this.lblConPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblFLastName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdBack.Location = new System.Drawing.Point(8, 479);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(81, 28);
            this.cmdBack.TabIndex = 29;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblRegister.Location = new System.Drawing.Point(8, 20);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(337, 39);
            this.lblRegister.TabIndex = 28;
            this.lblRegister.Text = "Update Personal Info";
            // 
            // txtConPassword
            // 
            this.txtConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtConPassword.Location = new System.Drawing.Point(304, 377);
            this.txtConPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '*';
            this.txtConPassword.Size = new System.Drawing.Size(267, 27);
            this.txtConPassword.TabIndex = 27;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPassWord.Location = new System.Drawing.Point(304, 335);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(267, 27);
            this.txtPassWord.TabIndex = 26;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtUserName.Location = new System.Drawing.Point(304, 289);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(267, 27);
            this.txtUserName.TabIndex = 25;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // cmdRegister
            // 
            this.cmdRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdRegister.Location = new System.Drawing.Point(8, 436);
            this.cmdRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(148, 36);
            this.cmdRegister.TabIndex = 24;
            this.cmdRegister.Text = "Update Info";
            this.cmdRegister.UseVisualStyleBackColor = false;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // lblConPassword
            // 
            this.lblConPassword.AutoSize = true;
            this.lblConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblConPassword.Location = new System.Drawing.Point(21, 377);
            this.lblConPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConPassword.Name = "lblConPassword";
            this.lblConPassword.Size = new System.Drawing.Size(161, 22);
            this.lblConPassword.TabIndex = 22;
            this.lblConPassword.Text = "Confirm Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPassword.Location = new System.Drawing.Point(23, 335);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(243, 22);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password* (6-30 characters):";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblUserName.Location = new System.Drawing.Point(21, 289);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(254, 22);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "User Name* (8-20 characters):";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtAddress.Location = new System.Drawing.Point(148, 244);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(207, 27);
            this.txtAddress.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtEmail.Location = new System.Drawing.Point(148, 201);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 27);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPhone.Location = new System.Drawing.Point(148, 151);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(207, 27);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAddress.Location = new System.Drawing.Point(21, 244);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 22);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEmail.Location = new System.Drawing.Point(21, 204);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 22);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email*:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPhone.Location = new System.Drawing.Point(23, 155);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 22);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblFirstName.Location = new System.Drawing.Point(144, 119);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // lblFLastName
            // 
            this.lblFLastName.AutoSize = true;
            this.lblFLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblFLastName.Location = new System.Drawing.Point(359, 119);
            this.lblFLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFLastName.Name = "lblFLastName";
            this.lblFLastName.Size = new System.Drawing.Size(86, 20);
            this.lblFLastName.TabIndex = 11;
            this.lblFLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtLastName.Location = new System.Drawing.Point(363, 91);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(208, 27);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtFirstName.Location = new System.Drawing.Point(148, 92);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 27);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblName.Location = new System.Drawing.Point(21, 94);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name*:";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            //this.btnShow.Image = global::WriteNotesApplication.Properties.Resources.show;
            this.btnShow.Location = new System.Drawing.Point(569, 335);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(33, 27);
            this.btnShow.TabIndex = 30;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cmdConHide
            // 
            this.cmdConHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            
            this.cmdConHide.Location = new System.Drawing.Point(600, 377);
            this.cmdConHide.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConHide.Name = "cmdConHide";
            this.cmdConHide.Size = new System.Drawing.Size(33, 27);
            this.cmdConHide.TabIndex = 33;
            this.cmdConHide.Click += new System.EventHandler(this.cmdConHide_Click);
            // 
            // cmdConShow
            // 
            this.cmdConShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            
            this.cmdConShow.Location = new System.Drawing.Point(569, 377);
            this.cmdConShow.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConShow.Name = "cmdConShow";
            this.cmdConShow.Size = new System.Drawing.Size(33, 27);
            this.cmdConShow.TabIndex = 32;
            this.cmdConShow.Click += new System.EventHandler(this.cmdConShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            
            this.btnHide.Location = new System.Drawing.Point(600, 335);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(33, 27);
            this.btnHide.TabIndex = 31;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // ChangeUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeUserInfoForm";
            this.Text = "Create Notes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConPassword;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button cmdConHide;
        private System.Windows.Forms.Button cmdConShow;
        private System.Windows.Forms.Button btnHide;
    }
}