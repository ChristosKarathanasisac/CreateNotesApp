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

namespace WriteNotesApplication
{
    class AppUtilities
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

        public string GetHtml(string note, string noteTopic)
        {
            try
            {
                string messageBody = "<font>The following are the records: </font><br><br>";
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style=\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style=\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";
                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;
                messageBody += htmlTdStart + "Note Topic" + htmlTdEnd;
                messageBody += htmlTdStart + "Note" + htmlTdEnd;                messageBody += htmlHeaderRowEnd; 
                messageBody = messageBody + htmlTrStart;
                messageBody = messageBody + htmlTdStart + noteTopic;
                messageBody = messageBody + htmlTdStart + note;
                messageBody = messageBody + htmlTrEnd;
                
                messageBody = messageBody + htmlTableEnd;
                return messageBody; // return HTML Table as string from this function  
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Email(string htmlString,string subject, string toEmail)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(ConfigurationManager.AppSettings["email"]);
                message.To.Add(new MailAddress(toEmail));
                message.Subject = subject;
                message.IsBodyHtml = true; 
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";   
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["email_key"]);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                return true;
            }
            catch (Exception exc) { return false; }
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

    }
}
