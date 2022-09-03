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

    
    public partial class IntroForm : Form
    {
        private User user = null;

        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        AppUtilities appUtilities = new AppUtilities();
        public IntroForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void IntroForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataTable dtUser = new DataTable();

            string username = this.txtUserName.Text.Trim();
            string password = appUtilities.PassWordEncrypt(this.txtPassword.Text.Trim());

            dtUser = databaseConUtilities.getLoginUserDT(username, password);

            if (dtUser.DefaultView.Count > 0) 
            {
                //MessageBox.Show("Welcome to Create Notes App " + dtUser.DefaultView[0]["FIRST_NAME"]);
                

                this.user = new User(dtUser.DefaultView[0]["FIRST_NAME"].ToString(), dtUser.DefaultView[0]["LAST_NAME"].ToString(),
                    dtUser.DefaultView[0]["USER_EMAIL"].ToString(),
                    dtUser.DefaultView[0]["USER_PHONE"].ToString(), dtUser.DefaultView[0]["USER_ADDRESS"].ToString(),
                    dtUser.DefaultView[0]["USER_NAME"].ToString(), dtUser.DefaultView[0]["USER_PASSWORD"].ToString());

                if(this.user != null) 
                {
                    this.Hide();
                    UserOptionsForm userOptionsForm = new UserOptionsForm(this.user);
                    userOptionsForm.ShowDialog();

                }
                

            }
            else 
            {
                MessageBox.Show("Wrong User Name or Password. Please try again!");
            
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                this.txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                this.txtPassword.PasswordChar = '*';
            }
        }
    }
}
