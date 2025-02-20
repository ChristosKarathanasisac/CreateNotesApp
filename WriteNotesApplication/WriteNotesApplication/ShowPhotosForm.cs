﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
           
            int x = 20;
            int y = 20;
            int maxHeight = -1;
            foreach (DataRow row in photosDt.Rows)
            {
                
                byte[] photo_aray = (byte[])row["IMAGE_FILE"];
                PictureBox pb = new PictureBox();

                MemoryStream ms = new MemoryStream(photo_aray);
                
                pb.Image = new Bitmap(new Bitmap(ms));
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

        }

        private void ShowPhotosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
