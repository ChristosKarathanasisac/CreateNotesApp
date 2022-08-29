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
      
        private string createConnectionString() 
        {
            string connString = "";
            connString = @"Data Source = " + ConfigurationManager.AppSettings["server_name"] + " ; Trusted_Connection=true; Initial Catalog = " + ConfigurationManager.AppSettings["db_name"] + "; " +
                "User ID = " + ConfigurationManager.AppSettings["db_username"] + "; Password = " + ConfigurationManager.AppSettings["db_psw"];
            return connString;
        }

        public bool writeNoteToDB(String note)
        {
            bool flag = false;

            string connetionString = this.createConnectionString();

            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                string query = @"INSERT INTO notes(USER_ID, NOTE, NOTE_CREATION,NOTE_LASTMODIFY)" +
                                      " VALUES (1,"+"'"+ note+"','"+ DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") +"', '"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") +"')";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 60;
                cmd.Connection = conn;
                cmd.CommandText = query;

                try
                {
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {
                        cmd.ExecuteScalar();
                        flag = true;
                    }
                }
                catch (Exception exp)
                {
                    string message = exp.Message;
                }
                finally
                {
                    conn.Close(); // close the connection  
                }

                return flag;

                
            }
                
            
            

        }


    }
}
