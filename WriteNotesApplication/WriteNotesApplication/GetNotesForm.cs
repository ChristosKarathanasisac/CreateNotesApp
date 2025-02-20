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
    public partial class GetNotesForm : Form
    {
        private User user;

        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        public GetNotesForm(User aUser)
        {
            InitializeComponent();
            this.user = aUser;
            this.dateTimePickerFromDateC.Value = DateTime.Now;
            this.dateTimePickerToDateC.Value = DateTime.Now;
            this.dateTimePickerFromDateM.Value = DateTime.Now;
            this.dateTimePickerToDateM.Value = DateTime.Now;
        }

        private void cmdGetAllNotes_Click(object sender, EventArgs e)
        {
            DataTable dt = databaseConUtilities.GetNotesFromDB(this.user.UserName.ToString());
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
            if (this.WindowState == FormWindowState.Maximized)
            {
                userOptionsForm.WindowState = FormWindowState.Maximized;
                

            }
            userOptionsForm.StartPosition = FormStartPosition.CenterScreen;
            userOptionsForm.ShowDialog();
        }

        private void cmdFilterDate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = databaseConUtilities.GetNotesFromDB(this.user.UserName.ToString(),
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
            dt = databaseConUtilities.GetNotesFromDB(this.user.UserName.ToString(),
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
            dt = databaseConUtilities.GetNotesFromDB(this.user.UserName.ToString(), textFilter);

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

                string noteId = "";
                string note = "";
                string noteTopic = "";
                string noteRemFlag = "";
                string noteRemDate = "";

                DataGridViewRow r = this.dataGridView1.SelectedRows[0];
                if (r.Cells["NOTE_ID"].Value == null)
                {
                    MessageBox.Show("No data Selected");
                    return;
                }
                try
                {
                    noteId = r.Cells["NOTE_ID"].Value.ToString();
                    note = r.Cells["NOTE"].Value.ToString();
                    noteTopic = r.Cells["NOTE_DESCRIPTION"].Value.ToString();
                    noteRemFlag = r.Cells["NOTE_REMINDER_FLAG"].Value.ToString();
                    if (noteRemFlag.Equals("True"))
                    {
                        noteRemDate = r.Cells["NOTE_REMINDER_DATE"].Value.ToString();
                    }

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error:" + exc.Message);

                }

                if (!string.IsNullOrEmpty(note) && !string.IsNullOrEmpty(noteId)) 
                {
                    this.Hide();
                    ModifyNotesForm modifyNotesForm = new ModifyNotesForm(this.user, note,noteId,noteTopic, noteRemFlag, noteRemDate);
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        modifyNotesForm.WindowState = FormWindowState.Maximized;
                        
                    }
                    modifyNotesForm.StartPosition = FormStartPosition.CenterScreen;
                    modifyNotesForm.ShowDialog();
                }

            }
            else if (selectedRowCount < 1) 
            {
                MessageBox.Show("Select a note to modify!");

            }
            else 
            {
                MessageBox.Show("You have selected multiple notes. Please choose only one to" +
                    "modify!");
            
            }
        }

        private void cmdOpenNote_Click(object sender, EventArgs e)
        {

          Int32 selectedRowCount =
          dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string noteId = "";
                string note = "";
                string noteTopic = "";
                string noteRemFlag = "";
                string noteRemDate = "";
                DataGridViewRow r = this.dataGridView1.SelectedRows[0];
                if(r.Cells["NOTE_ID"].Value == null) 
                {
                    MessageBox.Show("No data Selected");
                    return;
                }
                try
                {
                    noteId = r.Cells["NOTE_ID"].Value.ToString();
                    note = r.Cells["NOTE"].Value.ToString();
                    noteTopic = r.Cells["NOTE_DESCRIPTION"].Value.ToString();
                    noteRemFlag = r.Cells["NOTE_REMINDER_FLAG"].Value.ToString();
                    if (noteRemFlag.Equals("True"))
                    {
                        noteRemDate = r.Cells["NOTE_REMINDER_DATE"].Value.ToString();

                    }
                        

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error:" + exc.Message);

                }
                if (!string.IsNullOrEmpty(note) && !string.IsNullOrEmpty(noteId))
                {
                    this.Hide();
                    OpenFullNoteForm openFullNoteForm = new OpenFullNoteForm(this.user, note, noteId,noteTopic,noteRemFlag, noteRemDate);
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        openFullNoteForm.WindowState = FormWindowState.Maximized;
                       
                    }
                    openFullNoteForm.StartPosition = FormStartPosition.CenterScreen;
                    openFullNoteForm.ShowDialog();
                }

            }
            else if (selectedRowCount < 1)
            {
                MessageBox.Show("Select a note!");
            }
            else
            {
                MessageBox.Show("You have selected multiple notes. Please choose only one");
            }
        }

        private void cmdDeleteNote_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string noteId = "";
                DataGridViewRow r = this.dataGridView1.SelectedRows[0];
                if (r.Cells["NOTE_ID"].Value == null)
                {
                    MessageBox.Show("No data Selected");
                    return;
                }
                try 
                {
                     noteId = r.Cells["NOTE_ID"].Value.ToString();
                }
                catch(Exception exc) 
                {
                    MessageBox.Show("Error:" + exc.Message);
                
                }

                if(!string.IsNullOrEmpty(noteId))
                {
                    if (databaseConUtilities.DeleteNoteFromDB(noteId))
                    {
                        MessageBox.Show("Note deleted successfully");

                    }
                    else
                    {
                        MessageBox.Show("Note did not deleted. Please try Again!");

                    }

                } 
            }
            else if (selectedRowCount < 1)
            {
                MessageBox.Show("Select a note to delete!");
            }
            else
            {
                MessageBox.Show("You have selected multiple notes. Please choose only one to delete");
            }

        }

    }
}
