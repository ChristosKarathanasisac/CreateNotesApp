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
        
        public DialogResult ReturnValue { get; set; }
        public int[] invalidPhotosPos { get; set; }
        
        public  UploadPhotosForm(string[] opnfd, User aUser)
        {
            InitializeComponent();
            this.photos = opnfd;
            this.user = aUser;

            ShowPhotos();

        }

        private void CreateInvalidPhotosForm() 
        {
            this.groupBox1.Controls.Clear();
            this.cmdConfirm.BackColor = Color.White;
            this.lblUploadPhotos.Text = "Return to Create Notes and upload pistures " +
                "with max size 600x600px ";
            this.lblUploadPhotos.ForeColor = Color.Red;
            System.Drawing.Font font = new Font("Segoe Print", 8.8f, FontStyle.Italic);
            this.lblUploadPhotos.Font = font;
            this.cmdCancel.Text = "Return";
            this.lblUploadPhotos.Dock = DockStyle.None;
            this.cmdConfirm.Enabled = false;

        }

        private bool CheckPhotoSize(Image img) 
        {
            this.pictureBox1.Image = img;
            if (pictureBox1.Size.Width > 600 || pictureBox1.Size.Height > 600) 
            {
                return false;
            }
            return true;
        }

        private void ShowPhotos() 
        {
           
            int x = 20;
            int y = 20;
            int maxHeight = -1;
            bool flag = false;
            int imagesIndex = 0;
            int invalidImagesCount = 0;
            this.invalidPhotosPos = new int[CalculteInvalidPhotosTableSize()];
            foreach (string p in photos)
            {
                PictureBox pb = new PictureBox();
                if (!CheckPhotoSize(new Bitmap(p)))
                {
                    flag = true;
                    this.invalidPhotosPos[invalidImagesCount] = imagesIndex;
                    invalidImagesCount += 1;
                    imagesIndex += 1;
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
                imagesIndex += 1;
            }

            if (flag) { InvalidPhotosOptionsControl(imagesIndex- invalidImagesCount); }


        }

        private int CalculteInvalidPhotosTableSize() 
        {
            int count = 0;
            foreach (string p in photos) 
            {
                if(!CheckPhotoSize(new Bitmap(p))) 
                {
                    count += 1;
                
                }
            
            }
            return count;

        }
        private void InvalidPhotosOptionsControl(int validPhotos) 
        {
            if(validPhotos > 0) 
            {
                int invalidPhotos = this.photos.Length - validPhotos;
                DialogResult dialogResult = MessageBox.Show(invalidPhotos.ToString() + " Image(s) with size bigger than 600x600px." +
                       " Do you want to upload the only the valid Image(s)?",
                       "Image Size Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {
                        this.ReturnValue = DialogResult.OK;
                        this.Hide();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.ReturnValue = DialogResult.No;
                    CreateInvalidPhotosForm();
                    this.Hide();

                }
            }
            else
            {
                {
                    this.ReturnValue = DialogResult.No;
                    MessageBox.Show("Please select Image(s) with max size 600x600px.");
                    CreateInvalidPhotosForm();
                    this.Hide();
                }

            }


        }

        public DataTable GetPhoto()
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
            
        }
    }
}
            



