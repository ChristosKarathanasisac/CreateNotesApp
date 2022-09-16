using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderWinService
{
    class clsSendNotes
    {
        clsServiceUtilities serviceUtilities = new clsServiceUtilities();
        public Boolean StartSend() 
        {
            DataTable dt = GetNotesTable();
            return true;
        }

        private DataTable GetNotesTable() 
        {
            DataTable dt = new DataTable();
            dt = serviceUtilities.GetDataTable(GetAllNotesStringBuilder());

            return dt;

        
        }

        public string GetAllNotesStringBuilder() 
        {
            string sql = "";

            sql = @"SELECT *
                    FROM notes
                    WHERE notes.NOTE_REMINDER_FLAG = 1";

            return sql;
        
        }
        

    }
}
