using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteNotesApplication
{
    public partial class RegistrationForm : Form
    {

        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(this.txtPassWord.PasswordChar == '*') 
            {
                btnHide.BringToFront();
                txtPassWord.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (this.txtPassWord.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassWord.PasswordChar = '*';
            }
        }

        private void cmdConShow_Click(object sender, EventArgs e)
        {
            if (this.txtConPassword.PasswordChar == '*')
            {
                cmdConHide.BringToFront();
                txtConPassword.PasswordChar = '\0';
            }
        }

        private void cmdConHide_Click(object sender, EventArgs e)
        {
            if (this.txtConPassword.PasswordChar == '\0')
            {
                cmdConShow.BringToFront();
                txtConPassword.PasswordChar = '*';
            }
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
           if (checkRegisterInputs())
           {
                User aUser = new User(this.txtFirstName.Text.Trim(), this.txtLastName.Text.Trim(), this.txtPhone.Text.Trim(),
                this.txtEmail.Text.Trim(), this.txtAddress.Text.Trim(), this.txtUserName.Text.Trim(),
                this.txtPassWord.Text.Trim());

                if (databaseConUtilities.insertUserToDB(aUser))
                {
                    MessageBox.Show("New User Added Successfully");

                }
                else
                {
                    MessageBox.Show("Registration Problem. Try again");
                    RegistrationForm registrationForm = new RegistrationForm();
                    registrationForm.ShowDialog();

                }

            }
            
                
           
         
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            this.txtFirstName.BackColor = Color.White;
        }

        private bool checkRegisterInputs() 
        {
            if (string.IsNullOrEmpty(this.txtFirstName.Text.ToString()))
            {
                this.txtFirstName.BackColor = Color.Red;
                MessageBox.Show("Fill the field and try again", "First Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (string.IsNullOrEmpty(this.txtLastName.Text.ToString()))
            {
                this.txtLastName.BackColor = Color.Red;
                MessageBox.Show("Fill the field and try again", "Last Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(this.txtUserName.Text.ToString()))
            {
                this.txtUserName.BackColor = Color.Red;
                MessageBox.Show("Fill the field and try again", "User Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(this.txtPassWord.Text.ToString()))
            {
                this.txtPassWord.BackColor = Color.Red;
                MessageBox.Show("Fill the field and try again", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.txtEmail.Text.ToString()))
            {
                this.txtEmail.BackColor = Color.Red;
                MessageBox.Show("Fill the field and try again", "Email Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (this.txtPassWord.Text.ToString() != this.txtConPassword.Text.ToString())
            {
                MessageBox.Show("The Passwords do not match");
                this.txtConPassword.Text = "";
                this.txtConPassword.BackColor = Color.Red;
             
            }
            return true;

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            this.txtLastName.BackColor = Color.White;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.txtEmail.BackColor = Color.White;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            this.txtEmail.BackColor = Color.White; 
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            this.txtPassWord.BackColor = Color.White;
        }
    }
}
