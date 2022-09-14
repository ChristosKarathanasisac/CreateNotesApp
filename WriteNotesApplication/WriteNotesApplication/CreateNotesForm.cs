using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteNotesApplication
{
    public partial class CreateNotesForm : Form
    {
        private User user;
        private bool uploadPhotosFlag = false;
        private bool uploadFilesFlag = false;
        private FileToUpload file = null;
        DatabaseConUtilities dbUtilities = new DatabaseConUtilities();

        Image[] photos;

        public CreateNotesForm(User aUser)
        {
            InitializeComponent();
            this.user = aUser;
            this.cmdUploadPhoto.Enabled = false;
            this.cmdUploadFile.Enabled = false;
            this.cmdCancelPhotos.Visible = false;
            this.cmdCancelFileUpload.Visible = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string noteTopic = this.txtNoteTopic.Text.Trim();
            string note = this.txtNote.Text;

            if(this.uploadFilesFlag && this.uploadPhotosFlag) 
            {
                if(photos.Length > 0 && this.file != null)
                {
                    if (SaveNote(note, noteTopic, this.file, this.photos)) 
                    {
                        MessageBox.Show("Your note has added successfully");
                        photos = null;
                        this.uploadPhotosFlag = false;
                        this.uploadFilesFlag = false;

                    }
                }
            
            }
            else if (this.uploadPhotosFlag) 
            {
                if (photos.Length > 0) 
                {
                    if (SaveNote(note, noteTopic, photos))
                    {
                        MessageBox.Show("Your note has added successfully");
                        photos = null;
                        this.uploadPhotosFlag = false;
                    }
                }                
            }
            else if (this.uploadFilesFlag)
            {
                if (this.file != null)
                {
                    if (SaveNote(note, noteTopic,this.file))
                    {
                        MessageBox.Show("Your note has added successfully");
                        this.file = null;
                        this.uploadFilesFlag = false;
                    }
                }
            }
            else
            {
                if (SaveNote(note, noteTopic))
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
                
                string[] allSelectedphotos = opnfd.FileNames;
                using (var uploadPhotosForm = new UploadPhotosForm(allSelectedphotos, this.user))
                {
                    uploadPhotosForm.ShowDialog();
                    var result = uploadPhotosForm.ReturnValue;
                    int[] invalidPhotos = uploadPhotosForm.invalidPhotosPos;
                    if (result == DialogResult.OK)
                    {
                        this.cmdUploadPhoto.BackColor = Color.GreenYellow;
                        this.uploadPhotosFlag = true;
                        this.cmdCancelPhotos.Visible = true;

                        FillPhotosForUploadArray(allSelectedphotos, invalidPhotos);
                    }
                }
            }
            else 
            {
                if(this.cmdUploadPhoto.BackColor == Color.GreenYellow) 
                {
                    this.cmdUploadPhoto.BackColor = Color.White;
                }
            
            }
        }

        private void FillPhotosForUploadArray(string[] allSelectedphotos, int[] invalidPhotos) 
        {
            photos = new Image[allSelectedphotos.Length - invalidPhotos.Length];
            int allSelectedphotosCount = 0;
            int photosCount = 0;
            foreach (string fileName in allSelectedphotos)
            {
                if (invalidPhotos.Contains(allSelectedphotosCount))
                {
                    allSelectedphotosCount += 1;
                    continue;
                }
                Image photo = new Bitmap(fileName);

                photos[photosCount] = photo;
                photosCount += 1;
                allSelectedphotosCount += 1;

            }
        }
        private bool SaveNote(string note, string noteTopic) 
        {
            if (!GeneralChecks(note, noteTopic)) { return false; }
            if (this.dbUtilities.WriteNoteToDB(note, noteTopic, user.UserName.ToString(), DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")))
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

        private bool SaveNote(string note, string noteTopic,Image[] imgs)
        {
            if (!GeneralChecks(note, noteTopic)){ return false; }

            if (this.dbUtilities.WriteNoteWithPhotosToDB(note, noteTopic, user.UserName.ToString(),imgs))
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

        private bool SaveNote(string note, string noteTopic,FileToUpload aFile)
        {
            if (!GeneralChecks(note, noteTopic)) { return false; }
            if (this.dbUtilities.WriteNoteWithFileToDB(note, noteTopic, user.UserName.ToString(),
                aFile.Bytes, aFile.ContentType)) 
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

        private bool SaveNote(string note, string noteTopic, FileToUpload aFile, Image[] imgs)
        {
            if (!GeneralChecks(note, noteTopic)) { return false; }
            if (this.dbUtilities.WriteNoteWithFileAndPhotoToDB(note, noteTopic, user.UserName.ToString(),imgs,
                aFile.Bytes, aFile.ContentType))
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

        private bool GeneralChecks(string note,string noteTopic) 
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
            return true;
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNote.Text))
            {
                this.cmdUploadPhoto.Enabled = true;
                this.cmdUploadFile.Enabled = true;
            }
            else 
            {
                this.cmdUploadPhoto.Enabled = false;
                this.cmdUploadFile.Enabled = false;
                this.cmdUploadPhoto.BackColor = Color.White;
                this.cmdUploadFile.BackColor = Color.White;
                this.cmdCancelPhotos.Visible = false;
                this.cmdCancelFileUpload.Visible = false;
                this.photos = null;
                this.file = null;
            }
        }

        private void cmdCancelPhotos_Click(object sender, EventArgs e)
        {
            this.uploadPhotosFlag = false;
            this.cmdUploadPhoto.BackColor = Color.White;
            this.cmdCancelPhotos.Visible = false;
        }

        private void cmdUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();

            
            opnfd.Filter = @"All Files| *.docx; *.doc; *.xls; *.xlsx; *.pdf";


            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream fs = opnfd.OpenFile())
                {
                    string extension = Path.GetExtension(opnfd.FileName);
                    
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((Int32)fs.Length); 
                        this.uploadFilesFlag = true;
                        this.cmdUploadFile.BackColor = Color.GreenYellow;
                        this.cmdCancelFileUpload.Visible = true;
                        this.file = new FileToUpload(bytes, extension);
                    }
                }

            }
        }

        private void cmdCancelFileUpload_Click(object sender, EventArgs e)
        {
            this.file = null;
            this.uploadFilesFlag = false;
            this.cmdCancelFileUpload.Visible = false;
            this.cmdUploadFile.BackColor = Color.White;
            this.file = null;
        }
    }
}
