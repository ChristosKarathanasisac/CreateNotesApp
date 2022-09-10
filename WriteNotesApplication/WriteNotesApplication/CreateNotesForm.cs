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
    public partial class CreateNotesForm : Form
    {
        private User user;
        private bool uploadPhotosFlag = false;
        DatabaseConUtilities dbUtilities = new DatabaseConUtilities();

        Image[] images;

        public CreateNotesForm(User aUser)
        {
            InitializeComponent();
            this.user = aUser;
            this.cmdUploadPhoto.Enabled = false;
            this.cmdCancelPhotos.Visible = false;
        }

        //private void showUploadLabel() 
        //{
            
        //    Label lblPhotosUploaded = new Label();
        //    lblPhotosUploaded.Text = "Your photos have uploaded";
        //    lblPhotosUploaded.Location = this.cmdUploadPhoto.Location;
        //    System.Drawing.Font font = new Font("Segoe Print", 10.8f, FontStyle.Italic);
        //    lblPhotosUploaded.Font = font;
        //    lblPhotosUploaded.ForeColor = Color.Red;
        //    lblPhotosUploaded.BackColor = Color.White;
        //    lblPhotosUploaded.Size = new Size(260,35);
        //    lblPhotosUploaded.Dock = DockStyle.None;
        //    this.cmdUploadPhoto.Hide();
        //    this.gridcondrol1.Controls.Add(lblPhotosUploaded);
        //    lblPhotosUploaded.Show();

        //}

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string noteTopic = this.txtNoteTopic.Text.Trim();
            string note = this.txtNote.Text;

            if (this.uploadPhotosFlag) 
            {
                if (images.Length > 0) 
                {
                    if (saveNote(note, noteTopic, images))
                    {
                        MessageBox.Show("Your note has added successfully");
                    }
                }
                
            }
            else
            {
                if (saveNote(note, noteTopic))
                {
                    MessageBox.Show("Your note has added successfully");
                }

            }

            

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOptionsForm userOptionsForm = new UserOptionsForm(this.user);
            if (this.WindowState == FormWindowState.Maximized)
            {
                userOptionsForm.WindowState = FormWindowState.Maximized;
                userOptionsForm.StartPosition = FormStartPosition.CenterScreen;

            }
            userOptionsForm.ShowDialog();


        }

        private void CreateNotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtNoteTopic_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNoteTopic.BackColor == Color.Red)
            {
                this.txtNoteTopic.BackColor = Color.White;

            }
            
           
        }

        private void cmdUploadPhoto_Click(object sender, EventArgs e)
        {
         
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png";
            opnfd.Multiselect = true;

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                
                string[] allSelectedImages = opnfd.FileNames;
                using (var uploadPhotosForm = new UploadPhotosForm(allSelectedImages, this.user))
                {
                    uploadPhotosForm.ShowDialog();
                    var result = uploadPhotosForm.ReturnValue;
                    int[] invalidPhotos = uploadPhotosForm.invalidPhotosPos;
                    if (result == DialogResult.OK)
                    {
                        this.cmdUploadPhoto.BackColor = Color.GreenYellow;
                        this.uploadPhotosFlag = true;
                        this.cmdCancelPhotos.Visible = true;

                        images = new Image[allSelectedImages.Length - invalidPhotos.Length];
                        int allSelectedImagesCount = 0;
                        int imagesCount = 0;
                        foreach(string fileName in allSelectedImages) 
                        {
                            if (invalidPhotos.Contains(allSelectedImagesCount)) 
                            {
                                allSelectedImagesCount += 1;
                                continue;
                            }
                            Image image = new Bitmap(fileName);

                            images[imagesCount] = image;
                            imagesCount += 1;
                            allSelectedImagesCount += 1;

                        }
                    }
                }


            }

            //if (pictureBox2.Size.Width > 600 || pictureBox2.Size.Height > 600)
            //{
            //    pictureBox2.Image = null;
            //    MessageBox.Show("Image size is too big. Upload an image with max size 600x600px and " +
            //        "try again.");
            //}
            //else
            //{
            //    Image image = new Bitmap(opnfd.FileName);

            //    System.Data.SqlClient.SqlConnection conn = null;
            //    try
            //    {
            //        string connString = "";
            //        connString = @"Data Source = " + ConfigurationManager.AppSettings["server_name"] + " ; Trusted_Connection=true; Initial Catalog = " + ConfigurationManager.AppSettings["db_name"] + "; " +
            //            "User ID = " + ConfigurationManager.AppSettings["db_username"] + "; Password = " + ConfigurationManager.AppSettings["db_psw"];
            //        try
            //        {
            //            conn = new SqlConnection(connString);
            //            conn.Open();

            //            System.Data.SqlClient.SqlCommand insertCommand =
            //                new System.Data.SqlClient.SqlCommand(
            //                "Insert into images (NOTE_ID, IMAGE_FILE) Values (5003, @Pic)", conn);
            //            insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value =
            //                ConvertImageToByteArray(image, System.Drawing.Imaging.ImageFormat.Jpeg);
            //            int queryResult = insertCommand.ExecuteNonQuery();
            //            if (queryResult == 1)
            //                MessageBox.Show("Image added successfully");
            //        }
            //        catch (Exception exc)
            //        {

            //        }
            //    }
            //    finally
            //    {
            //        if (conn != null)
            //            conn.Close();
            //    }




            //}
        }


        private bool saveNote(string note, string noteTopic) 
        {
            if (string.IsNullOrEmpty(noteTopic))
            {
                this.txtNoteTopic.BackColor = Color.Red;
                MessageBox.Show("Please add a note topic to continue!");
                return false;

            }
            if (noteTopic.Length > 40)
            {
                MessageBox.Show("The Topic is too long");
                this.txtNoteTopic.BackColor = Color.Red;
                return false; 

            }
            if (string.IsNullOrEmpty(note))
            {
                MessageBox.Show("Write a note and try again");
                return  false;
            }
            if (this.dbUtilities.writeNoteToDB(note, noteTopic, user.UserName.ToString()))
            {
                this.txtNote.Clear();
                this.txtNoteTopic.Clear();
                return true;
            }
            else
            {
                MessageBox.Show("Your note was not stored");
                return false;

            }

        }

        private bool saveNote(string note, string noteTopic,Image[] imgs)
        {
            if (string.IsNullOrEmpty(noteTopic))
            {
                this.txtNoteTopic.BackColor = Color.Red;
                MessageBox.Show("Please add a note topic to continue!");
                return false;

            }
            if (noteTopic.Length > 40)
            {
                MessageBox.Show("The Topic is too long");
                this.txtNoteTopic.BackColor = Color.Red;
                return false;

            }
            if (string.IsNullOrEmpty(note))
            {
                MessageBox.Show("Write a note and try again");
                return false;
            }
            if (this.dbUtilities.writeNoteWithPhotosToDB(note, noteTopic, user.UserName.ToString(),imgs))
            {
                this.txtNote.Clear();
                this.txtNoteTopic.Clear();
                return true;
            }
            else
            {
                MessageBox.Show("Your note was not stored");
                return false;

            }

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNote.Text))
            {
                this.cmdUploadPhoto.Enabled = true;
            }
            else 
            {
                this.cmdUploadPhoto.Enabled = false;
                this.cmdUploadPhoto.BackColor = Color.White;
                this.cmdCancelPhotos.Visible = false;
            }
        }

        private void cmdCancelPhotos_Click(object sender, EventArgs e)
        {
            this.uploadPhotosFlag = false;
            this.cmdUploadPhoto.BackColor = Color.White;
            this.cmdCancelPhotos.Visible = false;
        }
    }
}
