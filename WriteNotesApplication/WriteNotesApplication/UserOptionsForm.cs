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
                createNotesForm.ShowDialog();

            }
            

        }

        private void cmdLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            IntroForm introForm = new IntroForm();
            introForm.ShowDialog();
        }

       

        private void cmdSearhNote_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetNotesForm getNotesForm = new GetNotesForm(this.user);
            getNotesForm.ShowDialog();
        }

        private void UserOptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //IntroForm introForm = new IntroForm();
            //introForm.ShowDialog();

            Application.Exit();
        }

        private void cmdChangeUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeUserInfoForm changeUserInfoForm = new ChangeUserInfoForm(this.user);
            changeUserInfoForm.ShowDialog();

        }
    }
}
