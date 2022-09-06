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
            this.txtNoteTopic.Text = this.noteTopic;
            this.txtNote.Text = this.note;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetNotesForm getNotesForm = new GetNotesForm(this.user);
            getNotesForm.ShowDialog();
        }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyNotesForm modifyNotesForm = new ModifyNotesForm(this.user,this.note,this.noteId);
            modifyNotesForm.ShowDialog();
        }
    }
}
