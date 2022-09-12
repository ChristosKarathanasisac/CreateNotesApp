using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNotesApplication
{
    class DatabaseConUtilities
    {
        AppUtilities appUtilities = new AppUtilities();
        private string CreateConnectionString() 
        {
            string connString = "";
            connString = @"Data Source = " + ConfigurationManager.AppSettings["server_name"] + " ; Trusted_Connection=true; Initial Catalog = " + ConfigurationManager.AppSettings["db_name"] + "; " +
                "User ID = " + ConfigurationManager.AppSettings["db_username"] + "; Password = " + ConfigurationManager.AppSettings["db_psw"];
            return connString;
        }

        public bool WriteNoteToDB(string note,string noteTopic,string userName)
        {
            string userId = FindUserId(userName);

            if (!string.IsNullOrEmpty(userId)) 
            {
                
                string sql2 = @"INSERT INTO notes(USER_ID, NOTE, NOTE_CREATION,NOTE_LASTMODIFY,NOTE_DESCRIPTION)" +
                                      " VALUES (" + userId + "," + "'" + note + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                                      + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','"+noteTopic+"')";

                return InsertToDB(sql2);

            }
            else 
            {
                return false;
            
            }


            
        }

        public bool WriteNoteWithPhotosToDB(string note, string noteTopic, string userName,Image[] images)
        {
            string userId = FindUserId(userName);
            string cretionDate = "";
            bool flag = false;

            if (!string.IsNullOrEmpty(userId))
            {
                cretionDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                string sql2 = @"INSERT INTO notes(USER_ID, NOTE, NOTE_CREATION,NOTE_LASTMODIFY,NOTE_DESCRIPTION)" +
                                      " VALUES (" + userId + "," + "'" + note + "','" + cretionDate
                                      + "', '" + cretionDate + "','" + noteTopic + "')";

                flag = InsertToDB(sql2);

            }

            string noteId = "";

            if (flag) 
            {
                noteId = GetNoteID(userId, note, noteTopic, cretionDate);

            }
            if (noteId.Equals("")) 
            {
                return false;
            }

            return InsertPhotosToDB(noteId, images);
        }

        private bool InsertPhotosToDB(string noteId, Image[] images) 
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(CreateConnectionString());

            try
            {
                conn.Open();

                bool loopFlag = true;
                for (int i = 0; i < images.Length; i++)
                {
                    System.Data.SqlClient.SqlCommand insertCommand =
                              new System.Data.SqlClient.SqlCommand(
                              "Insert into images (NOTE_ID, IMAGE_FILE) Values (+" + noteId + ", @Pic)", conn);
                    insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value =
                        appUtilities.ConvertImageToByteArray(images[0], System.Drawing.Imaging.ImageFormat.Jpeg);
                    int queryResult = insertCommand.ExecuteNonQuery();
                    if (!(queryResult == 1)) { loopFlag = false; }

                }

                if (!loopFlag)
                {
                    DeleteNoteFromDB(noteId);
                    return false;
                }

                return loopFlag;

            }
            catch (Exception exc)
            {
                return false;
            }
            finally
            {
                conn.Close();

            }


        }
        private string GetNoteID(string userId,string note,string noteTopic,string noteCreationDate) 
        {
            string sql = "SELECT NOTE_ID FROM notes " +
                         " INNER JOIN users ON users.USER_ID = notes.USER_ID " +
                          "WHERE users.USER_ID=" + userId +
                         " AND NOTE LIKE'" + note +"'"+
                         " AND NOTE_DESCRIPTION='" + noteTopic +"'"+
                         " AND NOTE_CREATION='" + noteCreationDate+"'";
            DataTable dt = new DataTable();
            dt = GetDataTableFromDB(sql);

            if (dt.DefaultView.Count > 0) 
            {
                return dt.Rows[0]["NOTE_ID"].ToString();

            }
            else
            { return ""; }
            
        }

        public DataTable GetPhotosFromDB(string noteId) 
        {
            string sql = "SELECT IMAGE_FILE FROM images " +
                         "WHERE NOTE_ID = '" + noteId + "'";

            DataTable dt = new DataTable();

            dt = GetDataTableFromDB(sql);
            return dt;

        }

        public DataTable GetNotesFromDB(string username) 
        {
            DataTable dt = new DataTable();
            string userId = "";
            userId = FindUserId(username);

            if (!string.IsNullOrWhiteSpace(userId)) 
            {
                string sql = "SELECT NOTE_ID,NOTE,NOTE_CREATION,NOTE_LASTMODIFY,NOTE_DESCRIPTION FROM notes " +
                         "INNER JOIN users ON users.USER_ID = notes.USER_ID " +
                         "WHERE users.USER_ID = " + userId+
                         " ORDER BY NOTE_LASTMODIFY DESC";

                dt = GetDataTableFromDB(sql);
                return dt;

            }
            else 
            {
                return null;
            
            }
        }

        public DataTable GetNotesFromDB(string username,string fromDate,string toDate,string field)
        {
            DataTable dt = new DataTable();
            string userId = "";
            userId = FindUserId(username);

            if (field.Equals("create")) 
            {
                if (!string.IsNullOrWhiteSpace(userId))
                {
                    string sql = "SELECT NOTE_ID,NOTE,NOTE_CREATION,NOTE_LASTMODIFY,NOTE_DESCRIPTION FROM notes " +
                                 "INNER JOIN users ON users.USER_ID = notes.USER_ID " +
                                 "WHERE users.USER_ID = " + userId +
                                 " AND NOTE_CREATION BETWEEN '" + fromDate + "' AND '" + toDate + "' "+
                                 "ORDER BY NOTE_LASTMODIFY DESC";




                    dt = GetDataTableFromDB(sql);
                    return dt;

                }
                else
                {
                    return null;

                }

            }
            else if (field.Equals("modify"))
            {
                if (!string.IsNullOrWhiteSpace(userId))
                {
                    string sql = "SELECT NOTE_ID,NOTE,NOTE_CREATION,NOTE_LASTMODIFY,NOTE_DESCRIPTION FROM notes " +
                                 "INNER JOIN users ON users.USER_ID = notes.USER_ID " +
                                 "WHERE users.USER_ID = " + userId +
                                 " AND NOTE_LASTMODIFY BETWEEN '" + fromDate + "' AND '" + toDate + "'";


                    dt = GetDataTableFromDB(sql);
                    return dt;

                }
                else
                {
                    return null;

                }

            }
            else 
            {
                return null;
            
            }







        }

        public DataTable GetNotesFromDB(string username,string filertxt) 
        {
            DataTable dt = new DataTable();
            string userId = "";
            userId = FindUserId(username);

            if (!string.IsNullOrWhiteSpace(userId))
            {
                string sql = "SELECT NOTE,NOTE_CREATION,NOTE_LASTMODIFY,NOTE_ID,NOTE_DESCRIPTION FROM notes " +
                         "INNER JOIN users ON users.USER_ID = notes.USER_ID " +
                         "WHERE users.USER_ID = " + userId + "AND NOTE LIKE '%"+ filertxt + "%' "+
                         "ORDER BY NOTE_LASTMODIFY DESC";

                dt = GetDataTableFromDB(sql);
                return dt;

            }
            else
            {
                return null;

            }

        }

        public bool ModifyNoteToDB(string username,string newnote,string noteId) 
        {
            string sql = "UPDATE notes " +
                         "SET NOTE = '" + newnote +
                         "', NOTE_LASTMODIFY = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'" +
                        "WHERE NOTE_ID = " + noteId;

            return InsertToDB(sql);
            


        }

        public bool DeleteNoteFromDB(string noteId) 
        {
            string sql1 = "DELETE FROM notes WHERE NOTE_ID = " + noteId;
            string sql2 = "DELETE FROM images WHERE NOTE_ID = " + noteId;

            bool deletePhotoExec = InsertToDB(sql2);
            bool deleteNoteExec = InsertToDB(sql1);
            

            return (deleteNoteExec && deletePhotoExec);


        }

        public bool InsertUserToDB(User user)
        {
           
            string sql = @"INSERT INTO users (FIRST_NAME, LAST_NAME, USER_NAME, USER_PASSWORD,USER_EMAIL,USER_PHONE,USER_ADDRESS)
                                VALUES ('" + user.FirstName + "', '" + user.LastName + "', '" + user.UserName + "', '" + user.Password + "','" +
                                user.Email + "','" + user.Phone + "','" + user.Address + "')";

            return InsertToDB(sql);

        }

        public bool UpdateUserToDB(User user,string oldusername) 
        {
            string userId = FindUserId(oldusername);
            string sql = @"UPDATE users
                           SET FIRST_NAME = '"+user.FirstName+"',"+
	                       "LAST_NAME = '"+user.LastName+"',"+
	                       "USER_NAME = '"+user.UserName+"',"+
	                       "USER_PASSWORD = '"+ user.Password+ "',"+
	                       "USER_EMAIL ='"+user.Email+"',"+
	                       "USER_PHONE = '"+user.Phone+"'," +
	                       "USER_ADDRESS = '"+user.Address+"' "+
                           "WHERE USER_ID = " + userId;
            return InsertToDB(sql);


        }

        private bool InsertToDB(string query)
        {
            bool flag = false;

            string connetionString = this.CreateConnectionString();

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

        public DataTable GetDataTableFromDB(string query)
        {
            try 
            {
                DataTable dt = new DataTable();
                string connString = CreateConnectionString();


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

        public bool CheckIfUserCredentialsExists(string credential,string value) 
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM users " +
                         "WHERE "+ credential+ "='" + value + "'";

            dt = null;
            try 
            {
                dt = GetDataTableFromDB(sql);
            }
            catch(Exception exc) 
            {

            
            }
           
            if(dt == null) { return false; }
            if (dt.DefaultView.Count>0) 
            {
                return true;
            }   
            else 
            {
                return false;
            }
        
        }

        public DataTable GetLoginUserDT(string userName, string password) 
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * FROM users "+
                         "WHERE USER_NAME = '"+ userName + "' AND USER_PASSWORD = '" + password + "'";
            dt = GetDataTableFromDB(sql);

            return dt;
        }

        private string FindUserId(string username) 
        {
            string userId= "";

            DataTable dt = new DataTable();
            string sql1 = "SELECT USER_ID FROM users WHERE USER_NAME = '" + username + "'";
            dt = GetDataTableFromDB(sql1);
             userId = dt.DefaultView[0]["USER_ID"].ToString();

            return userId;
        
        }


        
    }
}
