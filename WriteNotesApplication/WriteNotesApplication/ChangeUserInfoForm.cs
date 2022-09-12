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
    public partial class ChangeUserInfoForm : Form
    {
        private User user;

        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        AppUtilities appUtilities = new AppUtilities();

        public ChangeUserInfoForm(User aUser)
        {
            InitializeComponent();
            this.user = aUser;

            string phone = this.user.Phone;
            string email = this.user.Email;

            this.txtFirstName.Text = this.user.FirstName;
            this.txtLastName.Text = this.user.LastName;
            this.txtPhone.Text = this.user.Phone;
            this.txtEmail.Text = this.user.Email;
            this.txtAddress.Text = this.user.Address;
            this.txtUserName.Text = this.user.UserName;

            cmdHide.Visible = false;
            cmdConHide.Visible = false;

        }
        private bool FrmInputsValidation()
        {
            if (!CheckRegisterInputs()) { return false; }
            if (!CheckIfUserNameExist()) { return false; }
            if (!CheckIfEmailIsValid()) { return false; }
            if (!CheckIfPhoneIsValid()) { return false; }
            if (!CheckInputFieldLenght("Password", txtPassWord.Text, 6, 30)) { return false; }
            if (!CheckInputFieldLenght("UserName", txtUserName.Text, 8, 20)) { return false; }

            return true;

        }

        private bool CheckIfUserNameExist()
        {
            if (user.UserName.Equals(this.txtUserName.Text.Trim())) { return true; }
            if (databaseConUtilities.CheckIfUserCredentialsExists("USER_NAME", this.txtUserName.Text.Trim()))
            {
                this.txtUserName.Text = "";
                this.txtUserName.BackColor = Color.Red;
                MessageBox.Show("This username already used. " +
                    "Please select a new username to continue");
                return false;
            }
            return true;
        }

        private bool CheckIfEmailIsValid()
        {
            bool flag = appUtilities.IsValidEmail(this.txtEmail.Text.Trim());
            if (flag)
            {
                return true;
            }
            else
            {
                this.txtEmail.Text = "";
                this.txtEmail.BackColor = Color.Red;
                MessageBox.Show("Insert a valid Email!!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }


        }

        private bool CheckIfPhoneIsValid()
        {
            if (string.IsNullOrEmpty(this.txtPhone.Text.Trim())) {return true;}
            bool flag = appUtilities.IsValidPhoneNumber(this.txtPhone.Text.Trim());
            if (flag)
            {
                return true;
            }
            else
            {
                this.txtPhone.Text = "";
                this.txtPhone.BackColor = Color.Red;
                MessageBox.Show("Insert a valid Phone Number!!", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }

        private bool CheckRegisterInputs()
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
                MessageBox.Show("The Passwords not match");
                this.txtConPassword.Text = "";
                this.txtConPassword.BackColor = Color.Red;
                return false;

            }
            return true;

        }

        private bool CheckInputFieldLenght(string fieldName, string field, int min, int max)
        {
            if (field.Length < min)
            {
                MessageBox.Show("Field: " + fieldName + " must has at least " + min.ToString() + " characters length", fieldName + " lenght",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if ((field.Length > max))
            {
                MessageBox.Show("Field: " + fieldName + " must has max " + max.ToString() + " characters length", fieldName + " lenght",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;


        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            this.txtFirstName.BackColor = Color.White;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtLastName.BackColor == Color.Red)
            {
                this.txtLastName.BackColor = Color.White;
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (this.txtEmail.BackColor == Color.Red)
            {
                this.txtEmail.BackColor = Color.White;
            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtUserName.BackColor == Color.Red)
            {
                this.txtUserName.BackColor = Color.White;
            }

        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPassWord.BackColor == Color.Red)
            {
                this.txtPassWord.BackColor = Color.White;
            }

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPhone.BackColor == Color.Red)
            {
                this.txtPhone.BackColor = Color.White;
            }

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOptionsForm userOptionsForm = new UserOptionsForm(this.user);
            if (this.WindowState == FormWindowState.Maximized)
            {
                userOptionsForm.WindowState = FormWindowState.Maximized;
             
            }
            userOptionsForm.StartPosition = FormStartPosition.CenterScreen;
            userOptionsForm.ShowDialog();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            if (!FrmInputsValidation()) { return; }

            User newUser = new User(this.txtFirstName.Text.Trim(), this.txtLastName.Text.Trim(), 
            this.txtEmail.Text.Trim(), this.txtPhone.Text.Trim(), this.txtAddress.Text.Trim(), this.txtUserName.Text.Trim(),
            appUtilities.PassWordEncrypt(this.txtPassWord.Text.Trim()));

            if (databaseConUtilities.UpdateUserToDB(newUser,this.user.UserName)) 
            {
                MessageBox.Show("Your changes has added succesfully");
                this.Hide();
                IntroForm introForm = new IntroForm();
                if (this.WindowState == FormWindowState.Maximized)
                {
                    introForm.WindowState = FormWindowState.Maximized;
                  
                }
                introForm.StartPosition = FormStartPosition.CenterScreen;
                introForm.ShowDialog();
            
            }
            else 
            {
                MessageBox.Show("Your changes has not added. Please try again");
            
            }
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            if (this.txtPassWord.PasswordChar == '*')
            {
                cmdHide.Visible = true;
                txtPassWord.PasswordChar = '\0';
                cmdShow.Visible = false;
            }
        }

        private void cmdHide_Click(object sender, EventArgs e)
        {
            if (this.txtPassWord.PasswordChar == '\0')
            {
                cmdShow.Visible = true;
                txtPassWord.PasswordChar = '*';
                cmdHide.Visible = false;
            }
        }

        private void cmdConShow_Click(object sender, EventArgs e)
        {
            if (this.txtConPassword.PasswordChar == '*')
            {
                cmdConHide.Visible = true;
                txtConPassword.PasswordChar = '\0';
                cmdConShow.Visible = false;
            }
        }

        private void cmdConHide_Click(object sender, EventArgs e)
        {
            if (this.txtConPassword.PasswordChar == '\0')
            {
                cmdConShow.Visible = true;
                txtConPassword.PasswordChar = '*';
                cmdConHide.Visible = false;
            }
        }

        private void ChangeUserInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
