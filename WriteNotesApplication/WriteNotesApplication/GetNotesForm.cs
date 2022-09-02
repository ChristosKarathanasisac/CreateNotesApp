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
    public partial class GetNotesForm : Form
    {
        private User user;

        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        public GetNotesForm(User aUser)
        {
            InitializeComponent();
            this.user = aUser;
        }

        private void cmdGetAllNotes_Click(object sender, EventArgs e)
        {
            DataTable dt = databaseConUtilities.getNotesFromDB(this.user.UserName.ToString());
            if(dt != null) 
            {
                this.bindingSource1.DataSource = dt;
                this.dataGridView1.DataSource = this.bindingSource1;
            }
            else 
            {
                MessageBox.Show("No notes found created by "+this.user.UserName);
            
            }

            
        }

        private void GetNotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //UserOptionsForm UserOptionsForm = new UserOptionsForm(user);
            //UserOptionsForm.ShowDialog();
            Application.Exit();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOptionsForm userOptionsForm = new UserOptionsForm(user);
            userOptionsForm.ShowDialog();
        }

        private void cmdFilterDate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = databaseConUtilities.getNotesFromDB(this.user.UserName.ToString(),
                this.dateTimePickerFromDateC.Value.ToString("yyyy-MM-dd 00:00:00"),
                this.dateTimePickerToDateC.Value.ToString("yyyy-MM-dd 23:59:59"),"create");

            if (dt.DefaultView.Count > 0) 
            {
                this.bindingSource1.DataSource = dt;
                this.dataGridView1.DataSource = this.bindingSource1;
            }
            else 
            {
                MessageBox.Show("No notes found created by " + this.user.UserName + " from " +
                    this.dateTimePickerFromDateC.Value.ToString("yyyy-MM-dd 00:00:00") + " to "
                    + this.dateTimePickerToDateC.Value.ToString("yyyy-MM-dd 23:59:59"));

            }
            


        }

        private void cmdFilterDateM_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = databaseConUtilities.getNotesFromDB(this.user.UserName.ToString(),
                this.dateTimePickerFromDateM.Value.ToString("yyyy-MM-dd 00:00:00"),
                this.dateTimePickerToDateM.Value.ToString("yyyy-MM-dd 23:59:59"),"modify");

            if (dt.DefaultView.Count > 0)
            {
                this.bindingSource1.DataSource = dt;
                this.dataGridView1.DataSource = this.bindingSource1;
            }
            else
            {
                MessageBox.Show("No notes found modified by " + this.user.UserName + " from " +
                    this.dateTimePickerFromDateM.Value.ToString("yyyy-MM-dd 00:00:00") + " to "
                    + this.dateTimePickerToDateM.Value.ToString("yyyy-MM-dd 23:59:59"));

            }
        }

        private void cmdFilterText_Click(object sender, EventArgs e)
        {
            string textFilter = this.textFilterNote.Text.Trim();
            DataTable dt = new DataTable();
            dt = databaseConUtilities.getNotesFromDB(this.user.UserName.ToString(), textFilter);

            if (dt != null)
            {
                this.bindingSource1.DataSource = dt;
                this.dataGridView1.DataSource = this.bindingSource1;
            }
            else
            {
                MessageBox.Show("Νo notes found containing " + "'"+textFilter+"'");

            }
        }

        private void cmdModifyNote_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount ==1)
            {
                DataGridViewRow r = this.dataGridView1.SelectedRows[0];
                string note = r.Cells[0].Value.ToString();
                string noteId = r.Cells[3].Value.ToString();

                if (!string.IsNullOrWhiteSpace(note)) 
                {
                    this.Hide();
                    ModifyNotesForm modifyNotesForm = new ModifyNotesForm(this.user, note,noteId);
                    modifyNotesForm.ShowDialog();
                }

            }
            else if (selectedRowCount < 1) 
            {
                MessageBox.Show("Select a note to modify!");

            }
            else 
            {
                MessageBox.Show("Yoy have selected multiple notes. Please choose only one to" +
                    "modify!");
            
            }
        }
    }
}
