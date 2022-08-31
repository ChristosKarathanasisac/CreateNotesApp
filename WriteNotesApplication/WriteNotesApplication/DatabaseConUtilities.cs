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

        public bool writeNoteToDB(string note,string userName)
        {
            string userId = findUserId(userName);

            if (!string.IsNullOrEmpty(userId)) 
            {
                
                string sql2 = @"INSERT INTO notes(USER_ID, NOTE, NOTE_CREATION,NOTE_LASTMODIFY)" +
                                      " VALUES (" + userId + "," + "'" + note + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                                      + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";

                return insertToDB(sql2);

            }
            else 
            {
                return false;
            
            }


            
        }

        public DataTable getNotesFromDB(string username) 
        {
            DataTable dt = new DataTable();
            string userId = "";
            userId = findUserId(username);

            if (!string.IsNullOrWhiteSpace(userId)) 
            {
                string sql = "SELECT NOTE,NOTE_CREATION,NOTE_LASTMODIFY FROM notes " +
                         "INNER JOIN users ON users.USER_ID = notes.USER_ID " +
                         "WHERE users.USER_ID = " + userId;

                dt = getDataTableFromDB(sql);
                return dt;

            }
            else 
            {
                return null;
            
            }

            


        }

        public DataTable getNotesFromDB(string username,string fromDate,string toDate)
        {
            DataTable dt = new DataTable();
            string userId = "";
            userId = findUserId(username);

            if (!string.IsNullOrWhiteSpace(userId))
            {
                string sql = "SELECT NOTE,NOTE_CREATION,NOTE_LASTMODIFY FROM notes " +
                             "INNER JOIN users ON users.USER_ID = notes.USER_ID " +
                             "WHERE users.USER_ID = " + userId +
                             " AND NOTE_CREATION BETWEEN '"+fromDate+"' AND '"+toDate+"'";




                dt = getDataTableFromDB(sql);
                return dt;

            }
            else
            {
                return null;

            }




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
            try 
            {
                DataTable dt = new DataTable();
                string connString = createConnectionString();


                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                conn.Close();
                da.Dispose();

                return dt;

            }catch(Exception exc) 
            {
                return null;
            
            }
            
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

        public DataTable getLoginUserDT(string userName, string password) 
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * FROM users "+
                         "WHERE USER_NAME = '"+ userName + "' AND USER_PASSWORD = '" + password + "'";
            dt = getDataTableFromDB(sql);

            return dt;
        }

        private string findUserId(string username) 
        {
            string userId= "";

            DataTable dt = new DataTable();
            string sql1 = "SELECT USER_ID FROM users WHERE USER_NAME = '" + username + "'";
            dt = getDataTableFromDB(sql1);
             userId = dt.DefaultView[0]["USER_ID"].ToString();

            return userId;
        
        }
        
    }
}
