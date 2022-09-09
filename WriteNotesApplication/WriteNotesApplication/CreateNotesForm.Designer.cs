
namespace WriteNotesApplication
{
    partial class CreateNotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNotesForm));
            this.gridcondrol1 = new System.Windows.Forms.GroupBox();
            this.txtNoteTopic = new System.Windows.Forms.TextBox();
            this.lblNoteTopic = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.cmdCancelPhotos = new System.Windows.Forms.Button();
            this.cmdUploadPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridcondrol1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcondrol1
            // 
            this.gridcondrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridcondrol1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gridcondrol1.Controls.Add(this.cmdCancelPhotos);
            this.gridcondrol1.Controls.Add(this.cmdUploadPhoto);
            this.gridcondrol1.Controls.Add(this.txtNoteTopic);
            this.gridcondrol1.Controls.Add(this.lblNoteTopic);
            this.gridcondrol1.Controls.Add(this.pictureBox1);
            this.gridcondrol1.Controls.Add(this.cmdBack);
            this.gridcondrol1.Controls.Add(this.cmdSave);
            this.gridcondrol1.Controls.Add(this.txtNote);
            this.gridcondrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gridcondrol1.Location = new System.Drawing.Point(10, 11);
            this.gridcondrol1.Margin = new System.Windows.Forms.Padding(2);
            this.gridcondrol1.Name = "gridcondrol1";
            this.gridcondrol1.Padding = new System.Windows.Forms.Padding(2);
            this.gridcondrol1.Size = new System.Drawing.Size(1044, 717);
            this.gridcondrol1.TabIndex = 0;
            this.gridcondrol1.TabStop = false;
            // 
            // txtNoteTopic
            // 
            this.txtNoteTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoteTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoteTopic.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.txtNoteTopic.Location = new System.Drawing.Point(638, 240);
            this.txtNoteTopic.Name = "txtNoteTopic";
            this.txtNoteTopic.Size = new System.Drawing.Size(399, 31);
            this.txtNoteTopic.TabIndex = 5;
            this.txtNoteTopic.TextChanged += new System.EventHandler(this.txtNoteTopic_TextChanged);
            // 
            // lblNoteTopic
            // 
            this.lblNoteTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteTopic.AutoSize = true;
            this.lblNoteTopic.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.lblNoteTopic.Location = new System.Drawing.Point(509, 240);
            this.lblNoteTopic.Margin = new System.Windows.Forms.Padding(1);
            this.lblNoteTopic.Name = "lblNoteTopic";
            this.lblNoteTopic.Size = new System.Drawing.Size(125, 31);
            this.lblNoteTopic.TabIndex = 4;
            this.lblNoteTopic.Text = "Note Topic*:";
            // 
            // cmdBack
            // 
            this.cmdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdBack.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic);
            this.cmdBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdBack.Location = new System.Drawing.Point(4, 678);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(1);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(60, 33);
            this.cmdBack.TabIndex = 2;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(515, 200);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(197, 37);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save Your Note";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNote.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.txtNote.Location = new System.Drawing.Point(510, 279);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtNote.Size = new System.Drawing.Size(519, 426);
            this.txtNote.TabIndex = 0;
            this.txtNote.Text = "";
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // cmdCancelPhotos
            // 
            this.cmdCancelPhotos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCancelPhotos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancelPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelPhotos.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdCancelPhotos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancelPhotos.Image = global::WriteNotesApplication.Properties.Resources.delete;
            this.cmdCancelPhotos.Location = new System.Drawing.Point(770, 200);
            this.cmdCancelPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancelPhotos.Name = "cmdCancelPhotos";
            this.cmdCancelPhotos.Size = new System.Drawing.Size(41, 37);
            this.cmdCancelPhotos.TabIndex = 7;
            this.cmdCancelPhotos.UseVisualStyleBackColor = false;
            this.cmdCancelPhotos.Click += new System.EventHandler(this.cmdCancelPhotos_Click);
            // 
            // cmdUploadPhoto
            // 
            this.cmdUploadPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdUploadPhoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUploadPhoto.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdUploadPhoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdUploadPhoto.Image = global::WriteNotesApplication.Properties.Resources.upload_image;
            this.cmdUploadPhoto.Location = new System.Drawing.Point(725, 200);
            this.cmdUploadPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUploadPhoto.Name = "cmdUploadPhoto";
            this.cmdUploadPhoto.Size = new System.Drawing.Size(41, 37);
            this.cmdUploadPhoto.TabIndex = 6;
            this.cmdUploadPhoto.UseVisualStyleBackColor = false;
            this.cmdUploadPhoto.Click += new System.EventHandler(this.cmdUploadPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WriteNotesApplication.Properties.Resources._NewNote__2_;
            this.pictureBox1.Location = new System.Drawing.Point(5, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CreateNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 741);
            this.Controls.Add(this.gridcondrol1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smart. note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateNotesForm_FormClosed);
            this.gridcondrol1.ResumeLayout(false);
            this.gridcondrol1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gridcondrol1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNoteTopic;
        private System.Windows.Forms.Label lblNoteTopic;
        private System.Windows.Forms.Button cmdUploadPhoto;
        private System.Windows.Forms.Button cmdCancelPhotos;
    }
}

