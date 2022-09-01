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
        public ModifyNotesForm(User user, string note)
        {
            InitializeComponent();
            this.note = note;
            this.user = user;
            this.txtModifyNote.Text = note;
            

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetNotesForm getNotesForm = new GetNotesForm(user);
            getNotesForm.ShowDialog();
        }
    }
}
