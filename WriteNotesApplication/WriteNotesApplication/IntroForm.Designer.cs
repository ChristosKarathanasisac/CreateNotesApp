
namespace WriteNotesApplication
{
    partial class IntroForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txdPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPasword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateAccount);
            this.groupBox1.Controls.Add(this.btnLogIn);
            this.groupBox1.Controls.Add(this.txdPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.lblPasword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblWelcome);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(356, 309);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(260, 28);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Don\'t Have Account? Create! ";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(423, 252);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(123, 28);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txdPassword
            // 
            this.txdPassword.Location = new System.Drawing.Point(446, 202);
            this.txdPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txdPassword.Name = "txdPassword";
            this.txdPassword.Size = new System.Drawing.Size(259, 22);
            this.txdPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(446, 146);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(259, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // lblPasword
            // 
            this.lblPasword.AutoSize = true;
            this.lblPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblPasword.Location = new System.Drawing.Point(240, 185);
            this.lblPasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(176, 39);
            this.lblPasword.TabIndex = 2;
            this.lblPasword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblUserName.Location = new System.Drawing.Point(240, 129);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(198, 39);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.lblWelcome.Location = new System.Drawing.Point(208, 43);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(615, 86);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Notes Creation App\r\n";
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IntroForm";
            this.Text = "IntroForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IntroForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txdPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPasword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}