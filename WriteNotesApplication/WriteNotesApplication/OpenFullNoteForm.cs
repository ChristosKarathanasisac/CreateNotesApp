﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        private string noteRemFlag;
        private string noteRemDate;

        public OpenFullNoteForm(User aUser, string aNote, string aNoteId,string aNoteTopic,
             string aNoteRemFlag,string  aNoteRemDate )
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
            this.noteRemFlag = aNoteRemFlag;
            this.noteRemDate = aNoteRemDate;

            ShowReminder();
        }
        private void ShowReminder() 
        {
            if (this.noteRemFlag.Equals("True"))
            {
                this.lblReminderAt.Visible = true;
                this.lblRemDate.Visible = true;
                this.lblRemDate.Text = this.noteRemDate;


            }
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
            ModifyNotesForm modifyNotesForm = new ModifyNotesForm(this.user,this.note,this.noteId,this.noteTopic,this.noteRemFlag,this.noteRemDate);
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
            DataTable photosDt = databaseConUtilities.GetPhotosFromDB(this.noteId);
            DataTable filesDt = databaseConUtilities.GetFilesFromDB(this.noteId);
            if (appUtilities.Email(this.txtEmailSubject.Text.Trim(),this.txtEmail.Text.Trim(), photosDt,note,noteTopic, filesDt)) 
            {
                MessageBox.Show("Note sent successfully to " + this.txtEmail.Text.Trim());
            }
            else 
            {
                MessageBox.Show("Note did not sent please try again");
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

        private void cmdShowPhotos_Click(object sender, EventArgs e)
        {
            ShowPhotosForm showPhotosForm = new ShowPhotosForm(this.noteId);
            showPhotosForm.ShowDialog();
        }

        private void cmdSaveToFile_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();

            string folderName = string.Empty;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                string str = string.Concat(folderName, @"\" + this.noteId + ".log");

                if (appUtilities.WriteNoteToTextFile(str, this.user.UserName, this.noteTopic, this.note) &&
                    appUtilities.DownloadPhotosLocal(folderName,this.noteId)
                    &&appUtilities.DowloadFileLocal(this.noteId,folderName))
                {  
                    MessageBox.Show("Your note saved to folder: " + folderName);
                }
                else
                {
                    MessageBox.Show("Note Save Error. Please try again!");
                }

               

            }
        }

        private void cmdOpenFile_Click(object sender, EventArgs e)
        {
            DataTable dtFiles = databaseConUtilities.GetFilesFromDB(this.noteId);

            if (!(dtFiles.DefaultView.Count > 0)) 
            {
                MessageBox.Show("That note has no files");
                return;
            }

            appUtilities.ShowFile(dtFiles, this.noteId);
        }
    }
    }

