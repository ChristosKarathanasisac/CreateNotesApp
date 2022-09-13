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
    public partial class UserOptionsForm : Form
    {
        private User user;

        public UserOptionsForm(User aUser)
        {
            InitializeComponent();
            this.user = aUser; 
        }

        private void cmdCreateNote_Click(object sender, EventArgs e)
        {
            if (user != null) 
            {
                this.Hide();
                CreateNotesForm createNotesForm = new CreateNotesForm(user);
                if (this.WindowState == FormWindowState.Maximized)
                {
                    createNotesForm.WindowState = FormWindowState.Maximized;
                }
                createNotesForm.StartPosition = FormStartPosition.CenterScreen;
                createNotesForm.ShowDialog();

            }
            

        }

        private void cmdLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            IntroForm introForm = new IntroForm();
            if (this.WindowState == FormWindowState.Maximized)
            {
                introForm.WindowState = FormWindowState.Maximized;
            }
            introForm.StartPosition = FormStartPosition.CenterScreen;
            introForm.ShowDialog();
        }

       

        private void cmdSearhNote_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetNotesForm getNotesForm = new GetNotesForm(this.user);
            if (this.WindowState == FormWindowState.Maximized)
            {
                getNotesForm.WindowState = FormWindowState.Maximized;

            }
            getNotesForm.StartPosition = FormStartPosition.CenterScreen;
            getNotesForm.ShowDialog();
        }

        private void UserOptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmdChangeUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeUserInfoForm changeUserInfoForm = new ChangeUserInfoForm(this.user);
            if (this.WindowState == FormWindowState.Maximized)
            {
                changeUserInfoForm.WindowState = FormWindowState.Maximized;

            }
            changeUserInfoForm.StartPosition = FormStartPosition.CenterScreen;
            changeUserInfoForm.ShowDialog();

        }
    }
}
