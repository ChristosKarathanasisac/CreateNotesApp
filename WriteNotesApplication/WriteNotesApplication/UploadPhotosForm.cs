using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteNotesApplication
{
    public partial class UploadPhotosForm : Form
    {
        private string[] photos;
        private User user;
        private string uploadPhotos = "";
        public DialogResult ReturnValue { get; set; }
       // public string ReturnValue2 { get; set; }
        public  UploadPhotosForm(string[] opnfd, User aUser)
        {
            InitializeComponent();
            this.photos = opnfd;
            this.user = aUser;

            int x = 20;
            int y = 20;
            int maxHeight = -1;
            bool flag = false;
            foreach (string p in photos)
            {
                PictureBox pb = new PictureBox();
                if (!checkImageSize(new Bitmap(p))) 
                {
                    flag = true;
                    continue;
                }
                pb.Image = new Bitmap(p);
                pb.Location = new Point(x, y);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                x += pb.Width + 10;
                maxHeight = Math.Max(pb.Height, maxHeight);

                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHeight + 10;
                }
                this.groupBox1.Controls.Add(pb);
            }
            if (flag) 
            {
                DialogResult dialogResult =MessageBox.Show("Do you want to upload the valid Images?",
                    "Image Size Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if(dialogResult == DialogResult.Yes) 
                {
                    //upload Images
                
                }else if(dialogResult == DialogResult.No) 
                {
                    //Open page
                
                }

            }

        }


        private bool checkImageSize(Image img) 
        {
            this.pictureBox1.Image = img;
            if (pictureBox1.Size.Width > 600 || pictureBox1.Size.Height > 600) 
            {
                return false;
            }
            return true;
        }


        //private void cmdUploadPhoto_Click(object sender, EventArgs e)
        //{
            
         
        //    //if (pictureBox2.Size.Width > 600 || pictureBox2.Size.Height > 600)
        //    //{
        //    //    pictureBox2.Image = null;
        //    //    MessageBox.Show("Image size is too big. Upload an image with max size 600x600px and " +
        //    //        "try again.");
        //    //}
        //    //else
        //    //{
        //    //    Image image = new Bitmap(opnfd.FileName);

        //    //    System.Data.SqlClient.SqlConnection conn = null;
        //    //    try
        //    //    {
        //    //        string connString = "";
        //    //        connString = @"Data Source = " + ConfigurationManager.AppSettings["server_name"] + " ; Trusted_Connection=true; Initial Catalog = " + ConfigurationManager.AppSettings["db_name"] + "; " +
        //    //            "User ID = " + ConfigurationManager.AppSettings["db_username"] + "; Password = " + ConfigurationManager.AppSettings["db_psw"];
        //    //        try
        //    //        {
        //    //            conn = new SqlConnection(connString);
        //    //            conn.Open();

        //    //            System.Data.SqlClient.SqlCommand insertCommand =
        //    //                new System.Data.SqlClient.SqlCommand(
        //    //                "Insert into images (NOTE_ID, IMAGE_FILE) Values (5003, @Pic)", conn);
        //    //            insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value =
        //    //                ConvertImageToByteArray(image, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    //            int queryResult = insertCommand.ExecuteNonQuery();
        //    //            if (queryResult == 1)
        //    //                MessageBox.Show("Image added successfully");
        //    //        }
        //    //        catch (Exception exc)
        //    //        {

        //    //        }
        //    //    }
        //    //    finally
        //    //    {
        //    //        if (conn != null)
        //    //            conn.Close();
        //    //    }

        //    //}


        //}

        //private void cmdUploadPhoto_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = getimage();

        //    byte[] photo_aray = (byte[])dt.Rows[0]["IMAGE_FILE"];

        //    MemoryStream ms = new MemoryStream(photo_aray);
        //    this.pictureBox2.Image = Image.FromStream(ms);

        //}

        private byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert,
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

        public Image byteArrayToImage(byte[] source)
        {
            MemoryStream ms = new MemoryStream(source);
            Image ret = Image.FromStream(ms);
            return ret;
        }

        public DataTable getimage()
        {

            try
            {
                System.Data.SqlClient.SqlConnection conn = null;

                string connString = "";
                DataTable dt = new DataTable();
                connString = @"Data Source = " + ConfigurationManager.AppSettings["server_name"] + " ; Trusted_Connection=true; Initial Catalog = " + ConfigurationManager.AppSettings["db_name"] + "; " +
                    "User ID = " + ConfigurationManager.AppSettings["db_username"] + "; Password = " + ConfigurationManager.AppSettings["db_psw"];

                conn = new SqlConnection(connString);
                string query = "select IMAGE_FILE from images";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                conn.Close();
                da.Dispose();

                return dt;
            }
            catch (Exception exc) { return null; }

        }

        

        private void cmdUploadPhoto_Click(object sender, EventArgs e)
        {

        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            this.ReturnValue = DialogResult.OK;
            this.Hide();
            
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.ReturnValue = DialogResult.No;
            this.Hide();
        }

        private void UploadPhotosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ReturnValue = DialogResult.No;
            this.Hide();
            //CreateNotesForm createNotesForm = new CreateNotesForm(this.user);
            //createNotesForm.ShowDialog();
        }
    }
}
            



