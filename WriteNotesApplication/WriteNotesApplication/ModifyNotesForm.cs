using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
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
        private string noteReminderFlag;
        private string noteReminderDate;

        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();

        SpeechRecognitionEngine recognizer =
                    new SpeechRecognitionEngine(
                  new System.Globalization.CultureInfo("en-US"));
        public ModifyNotesForm(User user, string note,string noteId,string noteTopic,
            string noteRemFlag,string noteRemDate)
        {
            InitializeComponent();
            this.note = note;
            this.user = user;
            this.noteId = noteId;
            this.noteTopic = noteTopic;
            this.txtNoteTopic.Text = this.noteTopic;
            this.txtModifyNote.Text = note;
            this.noteReminderFlag = noteRemFlag;
            this.noteReminderDate = noteRemDate;
            SetReminder();
        }

        private void SetReminder() 
        {
            if (this.noteReminderFlag.Equals("True")) 
            {
                this.cmdDeleteRem.Visible = true;
                this.cmdModifyRem.Visible = true;
                this.lblReminderAt.Visible = true;
                this.lblReminderDate.Text = this.noteReminderDate;
                this.lblReminderDate.Visible = true;

                this.dateTimePickerTime.Format = DateTimePickerFormat.Custom;
                this.dateTimePickerTime.CustomFormat = "HH:mm";
                this.dateTimePickerTime.ShowUpDown = true;
            }
            else
            {
                this.cmdModifyRem.Text = "Add Reminder";
                this.cmdModifyRem.BackColor = Color.Black;
                this.cmdModifyRem.Visible = true;
                this.dateTimePickerReminder.Visible = true;
                this.dateTimePickerTime.Visible = true;
                this.cmdSaveRem.Visible = true;

                this.dateTimePickerTime.Format = DateTimePickerFormat.Custom;
                this.dateTimePickerTime.CustomFormat = "HH:mm";
                this.dateTimePickerTime.ShowUpDown = true;
            }
        
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

        private void cmdDeleteRem_Click(object sender, EventArgs e)
        {
            if (databaseConUtilities.DeleteReminderToDB(this.noteId)) 
            {
                MessageBox.Show("Reminder Deleted Successfully");
                JobsAfterDelete();
            }
            else
            {
                MessageBox.Show("Reminder did not deleted. Please try again");
            }
            
        }
        private void JobsAfterDelete() 
        {
            this.cmdModifyRem.Text = "Add Reminder";
            this.cmdModifyRem.Visible = true;
            this.lblReminderAt.Visible = false;
            this.lblReminderAt.Visible = false;
            this.cmdDeleteRem.Visible = false;
            this.lblReminderDate.Text = "";
            this.lblReminderDate.Visible = false;
        }

        private void cmdModifyRem_Click(object sender, EventArgs e)
        {
            this.dateTimePickerReminder.Visible = true;
            this.dateTimePickerTime.Visible = true;
            this.cmdSaveRem.Visible = true;
            this.lblReminderAt.Visible = false;
            this.lblReminderDate.Text = "";
            this.lblReminderDate.Visible = false;
        }

        private void cmdSaveRem_Click(object sender, EventArgs e)
        {
            DateTime remDate = dateTimePickerReminder.Value.Date +
                   dateTimePickerTime.Value.TimeOfDay;

            if (remDate <= DateTime.Now)
            {
                MessageBox.Show("Εnter a future date");
                return;
            }


            if (databaseConUtilities.InsertReminderToDB(this.noteId,remDate.ToString("yyyy-MM-dd HH:mm"))) 
            {
                if(this.cmdModifyRem.Text.Equals("Modify Reminder")) 
                {
                    SuccessfullModifyRemJobs(remDate.ToString("yyyy-MM-dd HH:mm"));
                }
                else 
                {
                    SuccessfullAddJobs(remDate.ToString("yyyy-MM-dd HH:mm"));
                }
                
            }
            else 
            {
                MessageBox.Show("Reminder save Error. Please try again");
            }
        }

        private void SuccessfullModifyRemJobs(string remDate) 
        {
            MessageBox.Show("Reminder added Successfully");
            this.noteReminderFlag = "True";
            this.noteReminderDate = remDate;
            this.lblReminderDate.Visible = true;
            this.lblReminderDate.Text = remDate;
            this.lblReminderAt.Visible = true;
            this.dateTimePickerReminder.Visible = false;
            this.dateTimePickerTime.Visible = false;
            this.cmdSaveRem.Visible = false;
          
        }

        private void SuccessfullAddJobs(string remDate) 
        {
            MessageBox.Show("Reminder added Successfully");
            this.noteReminderFlag = "True";
            this.noteReminderDate = remDate;
            this.lblReminderDate.Visible = true;
            this.lblReminderDate.Text = remDate;
            this.lblReminderAt.Visible = true;
            this.dateTimePickerReminder.Visible = false;
            this.dateTimePickerTime.Visible = false;
            this.cmdSaveRem.Visible = false;
            this.cmdModifyRem.Text = "Modify Reminder";
            this.cmdDeleteRem.Visible = true;
        }

        private void cmdMicrophone_MouseUp(object sender, MouseEventArgs e)
        {
            recognizer.RecognizeAsyncStop();
        }

        private void cmdMicrophone_MouseDown(object sender, MouseEventArgs e)
        {
            {
                try
                {
                    recognizer.RequestRecognizerUpdate();
                    recognizer.LoadGrammar(new DictationGrammar());
                    recognizer.SpeechRecognized +=
                      new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
                    recognizer.SetInputToDefaultAudioDevice();
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Voice Recognition Error: " + exc.Message);
                }
            }
        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            this.txtModifyNote.Text = this.txtModifyNote.Text + Environment.NewLine + e.Result.Text.ToString() + Environment.NewLine;
        }
    }
}
