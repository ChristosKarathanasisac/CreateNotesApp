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

        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        public ModifyNotesForm(User user, string note,string noteId)
        {
            InitializeComponent();
            this.note = note;
            this.user = user;
            this.noteId = noteId;
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

                if (databaseConUtilities.modifyNoteToDB(this.user.UserName,
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
            getNotesForm.ShowDialog();
        }
    }
}
