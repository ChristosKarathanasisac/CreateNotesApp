using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteNotesApplication;

namespace ReminderWinService
{
    class clsSendNotes
    {
        clsServiceUtilities serviceUtilities = new clsServiceUtilities();
        AppUtilities appUtilities = new AppUtilities();
        public void StartSend() 
        {
            serviceUtilities.WriteLog("StartSend Start");
            DataTable dtNotes = GetNotesTable();

            DataTable tblFilteredNotes = new DataTable();
            try
            {
               tblFilteredNotes = dtNotes.AsEnumerable()
         .Where(row => row.Field<DateTime>("NOTE_REMINDER_DATE") <= DateTime.Now).CopyToDataTable();
            }
            catch 
            {
            
            }
            if(tblFilteredNotes == null) { return; }
          

            if (tblFilteredNotes.DefaultView.Count > 0) 
            {
                SentEmail(tblFilteredNotes);
            }
            else 
            {
                serviceUtilities.WriteLog("No notes to sent");
                return;
            }

            serviceUtilities.WriteLog("StartSend End");
        }

        public void SentEmail(DataTable dtNotes) 
        {
            serviceUtilities.WriteLog("SentEmail Start");
            serviceUtilities.WriteLog("Notes to sent = "+ dtNotes.DefaultView.Count);
            int count = 0;

            DataTable photos = new DataTable();
            DataTable files = new DataTable();
            foreach (DataRow row in dtNotes.Rows)
            {
                string noteSubject = row["NOTE_DESCRIPTION"].ToString()+" Reminder";
                string userEmail = GetUserEmail(row["NOTE_ID"].ToString());
                photos = GetPhotosTable(row["NOTE_ID"].ToString());
                files = GetFilesTable(row["NOTE_ID"].ToString());
                string note = row["NOTE"].ToString();
                string noteTopic = row["NOTE_DESCRIPTION"].ToString();

                if (string.IsNullOrEmpty(userEmail))
                {
                    serviceUtilities.WriteLog("Note with NOTE_ID:" + row["NOTE_ID"].ToString() + " did not sent. User Email " +
                        "not found");
                    continue;
                }
                if(appUtilities.Email(noteSubject, userEmail, photos, note, noteTopic, files))
                {
                    UpdateReminders(row["NOTE_ID"].ToString());
                    count++;
                }
                else 
                {
                    serviceUtilities.WriteLog("Note with NOTE_ID:" + row["NOTE_ID"].ToString() + " did not sent.");
                }
                
            }

            serviceUtilities.WriteLog("Notes Sent Count = " + count);
            serviceUtilities.WriteLog("Notes With Error = "+(dtNotes.DefaultView.Count -count));
            serviceUtilities.WriteLog("SentEmail End");
            dtNotes.Dispose();
            photos.Dispose();
            files.Dispose();

        }


        private void UpdateReminders(string noteId) 
        {
            string sql = "UPDATE notes SET NOTE_REMINDER_FLAG = 0 WHERE NOTE_ID = " + noteId;

            if (serviceUtilities.ExecuteNonQuery(sql)) 
            {
                serviceUtilities.WriteLog("Note: " + noteId + ". NOTE_REMINDER_FLAG = 0. Email sent OK");

            }
            else 
            {
                serviceUtilities.WriteLog("Note: " + noteId + ". NOTE_REMINDER_FLAG NOT UPDATED. ---Email sent ERROR---");

            }

               


        }
        private string GetUserEmail(string noteId) 
        {
            DataTable dtUser = new DataTable();
            try 
            {
                dtUser = serviceUtilities.GetDataTable(GetUserEmailStringBuilder(noteId));
                return dtUser.Rows[0]["USER_EMAIL"].ToString();
            }
            catch (Exception exc) 
            {
                serviceUtilities.WriteLog("GetUserEmail ERROR. ERROR Message: " + exc.Message);
                return "";
            }
       
        }


        private DataTable GetNotesTable() 
        {
            DataTable dt = new DataTable();
            try 
            {
                dt = serviceUtilities.GetDataTable(GetAllNotesStringBuilder());
                dt.AcceptChanges();

            }
            catch (Exception exc)
            {
                serviceUtilities.WriteLog("GetNotesTable ERROR. ERROR Message: " + exc.Message);
                return null;
            }


            return dt;

        
        }

        private DataTable GetFilesTable(string noteId)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = serviceUtilities.GetDataTable(GetFilesStringBuilder(noteId));
                dt.AcceptChanges();
            }
            catch (Exception exc)
            {
                serviceUtilities.WriteLog("GetFilesTable ERROR. ERROR Message: " + exc.Message);
                return null;
            }
            return dt;
        }

        private DataTable GetPhotosTable(string noteId) 
        {
            DataTable dt = new DataTable();
            try 
            {
                dt = serviceUtilities.GetDataTable(GetPhotosStringBuilder(noteId));
                dt.AcceptChanges();
                return dt;

            }
            catch (Exception exc)
            {
                serviceUtilities.WriteLog("GetPhotosTable ERROR. ERROR Message: " + exc.Message);
                return null;
            }
          
        }

        private string GetAllNotesStringBuilder() 
        {
            string sql = "";

            sql = @"SELECT *
                    FROM notes
                    WHERE notes.NOTE_REMINDER_FLAG = 1";

            return sql;
        
        }
        
        private string GetUserEmailStringBuilder(string noteID) 
        {
            string sql = "SELECT users.USER_EMAIL " +
                         "FROM users " +
                         "INNER JOIN notes ON notes.USER_ID = users.USER_ID " +
                         "WHERE notes.NOTE_ID = " + noteID;
            return sql;

        }

        private string GetPhotosStringBuilder(string noteID) 
        {
            string sql = "SELECT IMAGE_FILE FROM images " +
                        "WHERE NOTE_ID = " + noteID;


            return sql;

        }

        private string GetFilesStringBuilder(string noteID) 
        {
            string sql = "SELECT FILE_CONTENTTYPE,FILE_DATA FROM files " +
                        "WHERE NOTE_ID = " + noteID;

            return sql;

        }
    }
}
