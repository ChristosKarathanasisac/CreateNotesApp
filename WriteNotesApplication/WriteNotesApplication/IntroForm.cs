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
            string password = appUtilities.PassWordEncrypt(this.txdPassword.Text.Trim());

            dtUser = databaseConUtilities.getLoginUserDT(username, password);

            if (dtUser.DefaultView.Count > 0) 
            {
                MessageBox.Show("Welcome to Create Notes App " + dtUser.DefaultView[0]["FIRST_NAME"]);
            
            }
        }
    }
}
