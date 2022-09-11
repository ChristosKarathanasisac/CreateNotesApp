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
    public partial class OpenFullNoteForm : Form
    {
        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        AppUtilities appUtilities = new AppUtilities();

        private string note;
        private User user;
        private string noteId;
        private string noteTopic;

        public OpenFullNoteForm(User aUser, string aNote, string aNoteId,string aNoteTopic)
        {
            InitializeComponent();
            this.note = aNote;
            this.user = aUser;
            this.noteId = aNoteId;
            this.noteTopic = aNoteTopic;
            this.txtEmail.Text = aUser.Email;
            this.txtNoteTopic.Text = this.noteTopic;
            this.txtEmailSubject.Text = this.noteTopic;
            this.txtNote.Text = this.note;
        }

        private void cmdBack_Click(object sender, EventArgs e)
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

        private void cmdModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyNotesForm modifyNotesForm = new ModifyNotesForm(this.user,this.note,this.noteId,this.noteTopic);
            if (this.WindowState == FormWindowState.Maximized)
            {
                modifyNotesForm.WindowState = FormWindowState.Maximized;
            }
            modifyNotesForm.StartPosition = FormStartPosition.CenterScreen;
            modifyNotesForm.ShowDialog();
        }

        private void OpenFullNoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmdSentEmail_Click(object sender, EventArgs e)
        { 
            if (!appUtilities.IsValidEmail(this.txtEmail.Text.Trim()))
            {
                this.txtEmail.Clear();
                this.txtEmail.BackColor = Color.Red;
                MessageBox.Show("Insert a valid email to continue");
                return;
            }
            if (string.IsNullOrEmpty(this.txtEmailSubject.Text.Trim())) 
            {
                this.txtEmailSubject.BackColor = Color.Red;
                MessageBox.Show("Insert a Subject");
                return;

            }
            string htmlString = appUtilities.GetHtml(this.note, this.noteTopic);
            if (appUtilities.Email(htmlString,this.txtEmailSubject.Text.Trim(),this.txtEmail.Text.Trim())) 
            {
                MessageBox.Show("Note sended succesfully to " + this.txtEmail.Text.Trim());
            }
            else 
            {
                MessageBox.Show("Note did not sended please try again");
            } 
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if(this.txtEmail.BackColor == Color.Red) 
            {
                this.txtEmail.BackColor = Color.White;
            }
        }

        private void txtEmailSubject_TextChanged(object sender, EventArgs e)
        {
           if(this.txtEmailSubject.BackColor== Color.Red) 
            {
                this.txtEmailSubject.BackColor = Color.White;
            }
        }
    }
}
