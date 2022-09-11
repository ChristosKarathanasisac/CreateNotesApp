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
    public partial class ModifyNotesForm : Form
    {
        private string note;
        private User user;
        private string noteId;
        private string noteTopic;

        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        public ModifyNotesForm(User user, string note,string noteId,string noteTopic)
        {
            InitializeComponent();
            this.note = note;
            this.user = user;
            this.noteId = noteId;
            this.noteTopic = noteTopic;
            this.txtNoteTopic.Text = this.noteTopic;
            this.txtModifyNote.Text = note;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string newNote = this.txtModifyNote.Text.Trim();
            if (!newNote.Trim().Equals(this.note.Trim())) 
            {
                if (string.IsNullOrEmpty(newNote))
                {
                    MessageBox.Show("Write something to continue", "Empty Note", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (databaseConUtilities.ModifyNoteToDB(this.user.UserName,
                    newNote, this.noteId)) 
                {
                    this.note = newNote;
                    MessageBox.Show("Your note has modified successfully");

                }
                else 
                {
                    MessageBox.Show("Please try again", "Note not modified",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

            }
           

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetNotesForm getNotesForm = new GetNotesForm(user);
            if (this.WindowState == FormWindowState.Maximized)
            {
                getNotesForm.WindowState = FormWindowState.Maximized;

            }
            getNotesForm.StartPosition = FormStartPosition.CenterScreen;
            getNotesForm.ShowDialog();
        }

        private void ModifyNotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
