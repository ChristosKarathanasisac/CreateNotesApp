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
            string sql  = @"INSERT INTO notes(USER_ID, NOTE, NOTE_CREATION,NOTE_LASTMODIFY)" +
                                      " VALUES (1," + "'" + note + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") 
                                      + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";

            return insertToDB(sql);
        }

        public bool insertUserToDB(User user)
        {
           
            string sql = @"INSERT INTO users (FIRST_NAME, LAST_NAME, USER_NAME, USER_PASSWORD,USER_EMAIL,USER_PHONE,USER_ADDRESS)
                                VALUES ('" + user.FirstName + "', '" + user.LastName + "', '" + user.UserName + "', '" + user.Password + "','" +
                                user.Email + "','" + user.Phone + "','" + user.Address + "')";

            return insertToDB(sql);

        }

        private bool insertToDB(string query)
        {
            bool flag = false;

            string connetionString = this.createConnectionString();

            using (SqlConnection conn = new SqlConnection(connetionString))
            {

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
                    conn.Close();
                }

                return flag;


            }

        }

        public DataTable getDataTableFromDB(string query)
        {

            DataTable dt = new DataTable();
            string connString = createConnectionString();
            //string query = "select * from notes";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
           
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            return dt;
        }

        public bool checkIfUserCredentialsExists(string credential,string value) 
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM users " +
                         "WHERE "+ credential+ "='" + value + "'";

            dt = null;
            dt = getDataTableFromDB(sql);
            if (dt.DefaultView.Count>0) 
            {
                return true;
            }   
            else 
            {
                return false;
            }
        
        }
    }
}
