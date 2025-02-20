﻿using System;
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
            this.cmdHide.Visible = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            if (this.WindowState == FormWindowState.Maximized)
            {
                registrationForm.WindowState = FormWindowState.Maximized;

            }
            registrationForm.StartPosition = FormStartPosition.CenterScreen;
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

            dtUser = databaseConUtilities.GetLoginUserDT(username, password);

            if(dtUser == null) { return; }
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
                    if(this.WindowState == FormWindowState.Maximized) 
                    {
                        userOptionsForm.WindowState = FormWindowState.Maximized; 
                    }
                    userOptionsForm.StartPosition = FormStartPosition.CenterScreen;
                    userOptionsForm.Show();

                }
                

            }
            else 
            {
                MessageBox.Show("Wrong User Name or Password. Please try again!");
            
            }
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '*')
            {
                cmdHide.Visible = true;
                this.txtPassword.PasswordChar = '\0';
                cmdShow.Visible = false;
            }
        }

        private void cmdHide_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '\0')
            {
                
                cmdShow.Visible = true;
                this.txtPassword.PasswordChar = '*';
                cmdHide.Visible = false;
            }
        }

        
    }
}
