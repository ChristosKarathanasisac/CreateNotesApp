using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mime;


namespace WriteNotesApplication
{
    public class AppUtilities
    {
        
        public bool IsValidEmail(string email)
        {
            //Code from Microsoft.com
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                
                string DomainMapper(Match match)
                {
                    
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public  bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return false;
            }
            var pattern = @"^[\+]?[{1}]?[(]?[2-9]\d{2}[)]?[-\s\.]?[2-9]\d{2}[-\s\.]?[0-9]{4}$";
            var options = System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.IgnoreCase;
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern, options);
        }

        public string PassWordEncrypt(string value)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public bool Email(string subject, string toEmail,DataTable photos,string  note, string noteTopic,DataTable files)
        {
           
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(ConfigurationManager.AppSettings["email"]);
                message.To.Add(new MailAddress(toEmail));
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.AlternateViews.Add(Mail_Body(photos, note, noteTopic, files));
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";   
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["email_key"]);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                message.BodyEncoding = Encoding.Default;
                smtp.Send(message);
                return true;
            }
            catch (Exception exc) { return false; }
        }

        private AlternateView Mail_Body(DataTable photos,string note, string noteTopic,DataTable dtfFile)
        {
            LinkedResource[] imgs = new LinkedResource[photos.DefaultView.Count];
            int count = 0;
            foreach (DataRow row in photos.Rows)
            {
                MemoryStream ms = new MemoryStream();
                byte[] photo_aray = (byte[])row["IMAGE_FILE"];
                ms = new MemoryStream(photo_aray);
                LinkedResource Img = new LinkedResource(ms, MediaTypeNames.Image.Jpeg);
                imgs[count] = Img;
                count++;
            }   
            string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
            string htmlTableEnd = "</table>";
            string htmlTrStart = "<tr style=\"color:#555555;\">";
            string htmlTrEnd = "</tr>";
            string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
            string htmlTdEnd = "</td>";

            string str = htmlTableStart +
                htmlTrStart +
                   htmlTdStart + "'" + noteTopic + "'" +
                    htmlTdEnd +
                htmlTrEnd +
                 htmlTrStart +
                    htmlTdStart + "'" + note + "'" +
                    htmlTdEnd +
                htmlTrEnd +
                htmlTableEnd;
    
            AlternateView AV =
            AlternateView.CreateAlternateViewFromString(str, null, MediaTypeNames.Text.Html);
            for(int i=0;i< imgs.Length; i++) 
            {
                if(imgs[i] == null) 
                {
                    break;
                }
                else 
                {
                    AV.LinkedResources.Add(imgs[i]);
                }           
            }

            if (CreateFileResource(dtfFile) != null ) 
            {
                AV.LinkedResources.Add(CreateFileResource(dtfFile));
            }
            return AV;
        }

        private LinkedResource CreateFileResource(DataTable dtfFile) 
        {
            if (!(dtfFile.DefaultView.Count > 0)) { return null; }
            if (dtfFile != null)
            {
                string fileType = dtfFile.Rows[0]["FILE_CONTENTTYPE"].ToString();
                byte[] file = (byte[])dtfFile.Rows[0]["FILE_DATA"];
                MemoryStream ms = new MemoryStream(file);

                LinkedResource f = null;
                if (fileType.Equals(".pdf"))
                {
                    f = new LinkedResource(ms, MediaTypeNames.Application.Pdf);

                }
                else if (fileType.Equals(".docx") || fileType.Equals(".doc"))
                {
                    f = new LinkedResource(ms, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
                   
                }
                else if (fileType.Equals(".doc") || fileType.Equals(".doc"))
                {
                    f = new LinkedResource(ms, "application/msword");
                    
                }
                else if (fileType.Equals(".xlsx"))
                {
                    f = new LinkedResource(ms, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                }
                else if (fileType.Equals(".xls"))
                {
                    f = new LinkedResource(ms, "application/vnd.ms-excel");
                }
                if (f == null) { return null; }
                return f;
                
            }
            else { return null; }

        }
        public byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert,
                                   System.Drawing.Imaging.ImageFormat formatOfImage)
        {
            byte[] Ret;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;
        }

        public bool WriteNoteToTextFile(string str,string userName,string noteTopic,string note) 
        {
            StreamWriter streamWriter = new StreamWriter(str, true);
            try
            {
                DateTime now = DateTime.Now;
                streamWriter.WriteLine(string.Concat("---", now.ToString("dd/MM/yyyy HH:mm:ss"), ": ", "Download---"));
                streamWriter.WriteLine(string.Concat("Note Created by", ": ", userName));
                streamWriter.WriteLine(string.Concat("Note Topic", ": ", noteTopic));
                streamWriter.WriteLine(string.Concat("Note", ": ", note + "\n"));
              
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
            finally 
            {
                streamWriter.Flush();
                streamWriter.Close();
            }


        }

        public bool DownloadPhotosLocal(string folderName, string noteId) 
        {
            DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
            DataTable photosDt = new DataTable();
            photosDt = databaseConUtilities.GetPhotosFromDB(noteId);
            int counter = 1;
            try 
            {
                foreach (DataRow row in photosDt.Rows)
                {
                    byte[] photo_aray = (byte[])row["IMAGE_FILE"];
                    MemoryStream ms = new MemoryStream(photo_aray);

                    Bitmap myBitmap;
                    ImageCodecInfo myImageCodecInfo;
                    System.Drawing.Imaging.Encoder myEncoder;
                    EncoderParameter myEncoderParameter;
                    EncoderParameters myEncoderParameters;

                    myBitmap = new Bitmap(new Bitmap(ms));
                    myImageCodecInfo = GetEncoderInfo("image/jpeg");
                    myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    myEncoderParameters = new EncoderParameters(1);

                    myEncoderParameter = new EncoderParameter(myEncoder, 75L);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    myBitmap.Save(folderName + @"\pic" + counter.ToString() + ".jpeg", myImageCodecInfo, myEncoderParameters);
                    counter++;
                }
                return true;
            }catch(Exception exc) 
            {
                return false;
            }
        }

        public bool DowloadFileLocal(string noteId,string folderName) 
        {
            DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();

            DataTable dtFiles = databaseConUtilities.GetFilesFromDB(noteId);
            byte[] buffer = (byte[])dtFiles.Rows[0]["FILE_DATA"];
            string fileType = dtFiles.Rows[0]["FILE_CONTENTTYPE"].ToString();

            try 
            {
                File.WriteAllBytes(Path.Combine(folderName, noteId + "File" + fileType), buffer);
                return true;
            }
            catch(Exception exc)
            {
                return false;
            }
            

        }
        public ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        public void ShowFile(DataTable dtFiles,string noteId) 
        {
            byte[] buffer = (byte[])dtFiles.Rows[0]["FILE_DATA"];
            string fileType = dtFiles.Rows[0]["FILE_CONTENTTYPE"].ToString();

            try 
            {
                using (FileStream fstream = new FileStream(noteId + "File" + fileType, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    fstream.Write(buffer, 0, buffer.Length);
                }

                System.Diagnostics.Process.Start(noteId + "File" + fileType);

            }catch(Exception exc) 
            {

            
            }
            

        }

    }
}
