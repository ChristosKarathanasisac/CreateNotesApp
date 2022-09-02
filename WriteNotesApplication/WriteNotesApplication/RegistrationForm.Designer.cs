
namespace WriteNotesApplication
{
    partial class RegistrationForm
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.cmdConHide = new System.Windows.Forms.Button();
            this.cmdConShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblConPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblRegister.Location = new System.Drawing.Point(6, 16);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(279, 31);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Register new Account";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.cmdRegister);
            this.groupBox1.Controls.Add(this.cmdConHide);
            this.groupBox1.Controls.Add(this.cmdConShow);
            this.groupBox1.Controls.Add(this.btnHide);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtConPassword);
            this.groupBox1.Controls.Add(this.txtPassWord);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblFLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblConPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblRegister);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdBack.Location = new System.Drawing.Point(12, 387);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(63, 23);
            this.cmdBack.TabIndex = 24;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdRegister
            // 
            this.cmdRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdRegister.Location = new System.Drawing.Point(17, 336);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(127, 27);
            this.cmdRegister.TabIndex = 23;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = false;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // cmdConHide
            // 
            this.cmdConHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.cmdConHide.Location = new System.Drawing.Point(359, 266);
            this.cmdConHide.Name = "cmdConHide";
            this.cmdConHide.Size = new System.Drawing.Size(41, 24);
            this.cmdConHide.TabIndex = 22;
            this.cmdConHide.Text = "Hide";
            this.cmdConHide.Click += new System.EventHandler(this.cmdConHide_Click);
            // 
            // cmdConShow
            // 
            this.cmdConShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.cmdConShow.Location = new System.Drawing.Point(319, 267);
            this.cmdConShow.Name = "cmdConShow";
            this.cmdConShow.Size = new System.Drawing.Size(43, 23);
            this.cmdConShow.TabIndex = 21;
            this.cmdConShow.Text = "Show";
            this.cmdConShow.Click += new System.EventHandler(this.cmdConShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.btnHide.Location = new System.Drawing.Point(456, 232);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(41, 23);
            this.btnHide.TabIndex = 20;
            this.btnHide.Text = "Hide";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.btnShow.Location = new System.Drawing.Point(419, 232);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(42, 23);
            this.btnShow.TabIndex = 19;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(218, 201);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 23);
            this.txtUserName.TabIndex = 18;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 166);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 23);
            this.txtAddress.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 23);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAddress.Location = new System.Drawing.Point(11, 172);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEmail.Location = new System.Drawing.Point(12, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email*:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPhone.Location = new System.Drawing.Point(10, 111);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone:";
            // 
            // txtConPassword
            // 
            this.txtConPassword.Location = new System.Drawing.Point(145, 267);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '*';
            this.txtConPassword.Size = new System.Drawing.Size(181, 23);
            this.txtConPassword.TabIndex = 12;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(218, 232);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(201, 23);
            this.txtPassWord.TabIndex = 11;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(69, 108);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 23);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtLastName.Location = new System.Drawing.Point(228, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(157, 23);
            this.txtLastName.TabIndex = 9;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtFirstName.Location = new System.Drawing.Point(69, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 23);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblFLastName
            // 
            this.lblFLastName.AutoSize = true;
            this.lblFLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblFLastName.Location = new System.Drawing.Point(225, 89);
            this.lblFLastName.Name = "lblFLastName";
            this.lblFLastName.Size = new System.Drawing.Size(73, 16);
            this.lblFLastName.TabIndex = 7;
            this.lblFLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblFirstName.Location = new System.Drawing.Point(66, 86);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblConPassword
            // 
            this.lblConPassword.AutoSize = true;
            this.lblConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblConPassword.Location = new System.Drawing.Point(14, 270);
            this.lblConPassword.Name = "lblConPassword";
            this.lblConPassword.Size = new System.Drawing.Size(125, 17);
            this.lblConPassword.TabIndex = 5;
            this.lblConPassword.Text = "Confirm Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPassword.Location = new System.Drawing.Point(12, 238);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(192, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password* (6-30 characters):";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblUserName.Location = new System.Drawing.Point(12, 207);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(202, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name* (8-20 characters):";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblName.Location = new System.Drawing.Point(9, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name*:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblConPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button cmdConHide;
        private System.Windows.Forms.Button cmdConShow;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Button cmdBack;
    }
}