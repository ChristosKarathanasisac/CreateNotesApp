using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNotesApplication
{
    class DatabaseConUtilities
    {
        private SqlConnection cnn;
        private DataTable dataTable = new DataTable();
       
        private string createConnectionString() 
        {
            string connString = "";
            connString = @"Data Source = " + ConfigurationManager.AppSettings["server_name"] + " ; Trusted_Connection=true; Initial Catalog = " + ConfigurationManager.AppSettings["db_name"] + "; " +
                "User ID = " + ConfigurationManager.AppSettings["db_username"] + "; Password = " + ConfigurationManager.AppSettings["db_psw"];
            return connString;
        }

        public bool writeNoteToDB(String note) 
        {  
            try
            {
                string connetionString = this.createConnectionString();
                
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    string query = @"INSERT INTO notes(USER_ID, NOTE, NOTE_CREATION,NOTE_LASTMODIFY)"+
                                      " VALUES (1,"+"'"+ note+"','"+ DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") +"', '"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") +"')";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    //Αυτόν τον κώδικα θα τον χρεισιμοποιήσω όταν διαβάζω δεδομένα
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //da.Fill(dataTable);
                    
                    conn.Close();
                    da.Dispose();
                }
                return true;
            }
            catch (Exception exc)
            {  
                return false;
            }

        }


    }
}
