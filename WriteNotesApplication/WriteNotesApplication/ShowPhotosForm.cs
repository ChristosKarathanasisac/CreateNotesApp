using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteNotesApplication
{
    public partial class ShowPhotosForm : Form
    {
        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        private string noteId;
        public ShowPhotosForm(string aNoteId)
        {
            InitializeComponent();
            this.noteId = aNoteId;

            FillPhotosForm();
        }

        private void FillPhotosForm() 
        {
            DataTable photosDt = new DataTable();

            photosDt = databaseConUtilities.GetPhotosFromDB(this.noteId);

            if (!(photosDt.DefaultView.Count > 0)) 
            {
                this.lblPhotos.Text = "This note has no photos";
                this.Hide();
            }

            System.Byte[] photos = photosDt.AsEnumerable().Select(r => r.Field<System.Byte>("IMAGE_FILE")).ToArray();

            int x = 20;
            int y = 20;
            int maxHeight = -1;
            foreach (System.Byte p in photos)
            {
                //PictureBox pb = new PictureBox();
               
                //pb.Image = new Bitmap(p);
                //pb.Location = new Point(x, y);
                //pb.SizeMode = PictureBoxSizeMode.StretchImage;
                //x += pb.Width + 10;
                //maxHeight = Math.Max(pb.Height, maxHeight);

                //if (x > this.ClientSize.Width - 100)
                //{
                //    x = 20;
                //    y += maxHeight + 10;
                //}
                //this.groupBox1.Controls.Add(pb);
                
            }

        }
    }
}
