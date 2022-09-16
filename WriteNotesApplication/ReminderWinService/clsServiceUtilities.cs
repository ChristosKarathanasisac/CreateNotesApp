using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderWinService
{
    class clsServiceUtilities
    {
        private String currentPath = "";
        private static int numOfLogFiles = 10;
        public string CurrendPath { set => currentPath = value; }
        public  bool CheckConnection()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = GetConfigValueString("server_name");
                builder.UserID = GetConfigValueString("db_username");
                builder.Password = GetConfigValueString("db_psw");
                builder.InitialCatalog = GetConfigValueString("db_name");
                builder.ConnectTimeout = 0;


                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    WriteLog("Try connect to database");

                    connection.Open();
                    connection.Close();
                }
            }
            catch (SqlException e)
            {
                WriteLog("Connect to database error.");
                WriteLog(e.ToString());

                return false;
            }

            WriteLog("Connect to database success!!");
            return true;

        }

        public  void WriteLog(string Message)
        {
            string LogPath = AppDomain.CurrentDomain.BaseDirectory + "log";
            string OldName = DateTime.Now.Year.ToString() + "_" +
                             DateTime.Now.Month.ToString("00") + "_" +
                             DateTime.Now.Day.ToString("00") + "_" + DateTime.Now.Hour.ToString("00") + "_" + DateTime.Now.Minute.ToString("00") + "_" + DateTime.Now.Second.ToString("00") + ".log";
            try
            {
                if (!Directory.Exists(LogPath))
                {
                    Directory.CreateDirectory(LogPath);
                }

                long length = (long)0;
                string str = string.Concat(LogPath, @"\" + "current.log");
                if (File.Exists(str))
                {
                    length = (new FileInfo(str)).Length;
                }
                if (length > (long)10485760)

                {
                    File.Copy(str, LogPath + @"\" + OldName, true);
                    File.Delete(LogPath + @"\" + "current.log");
                }
                StreamWriter streamWriter = new StreamWriter(str, true);
                DateTime now = DateTime.Now;
                streamWriter.WriteLine(string.Concat(now.ToString("dd/MM/yyyy HH:mm:ss"), ": ", Message));
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch
            {
            }
        }

        public string GetConfigValueString(string strKey)
        {
            string str;
            string item = "notFound";
            try
            {
                item = ConfigurationManager.AppSettings[strKey];
                return item;
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                WriteLog(string.Concat("Exception: GetConfigValueString:", exception.Message, "Value not Found: ", strKey));
                str = item;
            }
            return str;
        }

        public  bool ExecuteNonQuery(string sql)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = GetConfigValueString("DataSource");
            builder.UserID = GetConfigValueString("UserID");
            builder.Password = GetConfigValueString("Password");
            builder.InitialCatalog = GetConfigValueString("InitialCatalog");
            builder.ConnectTimeout = 0;



            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))

                {

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.CommandTimeout = 0;
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    WriteLog("Function ExecuteNonQuery : Εκτέλεση sql : " + sql);
                }
            }
            catch (Exception exc)
            {
                WriteLog("Error Function ExecuteNonQuery : " + exc.Message);
                return false;
            }

            return true;
        }
        public  void DeleteLogFiles()
        {
            DataTable DtTable = null;
            DataView dv = null;

            try
            {
               
                int NumOfLogFiles = numOfLogFiles;

                string LogPath = AppDomain.CurrentDomain.BaseDirectory + "log";
                DirectoryInfo di = new DirectoryInfo(LogPath);
                FileInfo[] files = di.GetFiles("*.log");

                DtTable = new DataTable();
                DtTable.Columns.Add("filename", typeof(string));
                DtTable.Columns.Add("FilenameAndPath", typeof(string));
                DtTable.Columns.Add("Created", typeof(DateTime));

                foreach (FileInfo fi in files)
                {
                    DataRow DrNewRow = DtTable.NewRow();
                    DrNewRow["filename"] = fi.Name.ToString();
                    DrNewRow["FilenameAndPath"] = fi.FullName.ToString();
                    DrNewRow["Created"] = fi.CreationTime;
                    DtTable.Rows.Add(DrNewRow);
                }

                dv = new DataView(DtTable);

                dv.RowFilter = "filename <> 'current.log'";

                dv.Sort = "Created Desc";

                if (dv.Count <= NumOfLogFiles)
                {
                    DtTable.Dispose();
                    dv.Dispose();
                    return;
                }

                int iRowsToDelete = dv.Count - NumOfLogFiles;

                for (int i = 0; i < iRowsToDelete; i++)
                {
                    File.Delete(dv[i]["FilenameAndPath"].ToString());
                }
            }
            catch (Exception exc)
            {
               WriteLog("Function DeleteLogFiles : " + exc.Message);
            }
            finally
            {
                DtTable.Dispose();
                dv.Dispose();
            }
        }

        public  DataTable GetDataTable(string sql)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = GetConfigValueString("server_name");
                builder.UserID = GetConfigValueString("db_username");
                builder.Password = GetConfigValueString("db_psw");
                builder.InitialCatalog = GetConfigValueString("db_name");
                builder.ConnectTimeout = 0;

                using (SqlConnection con = new SqlConnection(builder.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.CommandTimeout = 0;
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                WriteLog("GetDataTable Error. Error Message: " + exp.Message);
                return null;
            }


        }
    }
}
