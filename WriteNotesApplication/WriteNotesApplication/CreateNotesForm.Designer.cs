
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
            this.lblDateTime = new System.Windows.Forms.Label();
            this.cmdDeleteRem = new System.Windows.Forms.Button();
            this.lblAddedReminder = new System.Windows.Forms.Label();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.cmdSaveRem = new System.Windows.Forms.Button();
            this.dateTimePickerReminder = new System.Windows.Forms.DateTimePicker();
            this.checkBoxReminder = new System.Windows.Forms.CheckBox();
            this.cmdCancelFileUpload = new System.Windows.Forms.Button();
            this.cmdUploadFile = new System.Windows.Forms.Button();
            this.cmdCancelPhotos = new System.Windows.Forms.Button();
            this.cmdUploadPhoto = new System.Windows.Forms.Button();
            this.txtNoteTopic = new System.Windows.Forms.TextBox();
            this.lblNoteTopic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
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
            this.gridcondrol1.Controls.Add(this.lblDateTime);
            this.gridcondrol1.Controls.Add(this.cmdDeleteRem);
            this.gridcondrol1.Controls.Add(this.lblAddedReminder);
            this.gridcondrol1.Controls.Add(this.dateTimePickerTime);
            this.gridcondrol1.Controls.Add(this.cmdSaveRem);
            this.gridcondrol1.Controls.Add(this.dateTimePickerReminder);
            this.gridcondrol1.Controls.Add(this.checkBoxReminder);
            this.gridcondrol1.Controls.Add(this.cmdCancelFileUpload);
            this.gridcondrol1.Controls.Add(this.cmdUploadFile);
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
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.lblDateTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblDateTime.Location = new System.Drawing.Point(668, 38);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(1);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 24);
            this.lblDateTime.TabIndex = 16;
            // 
            // cmdDeleteRem
            // 
            this.cmdDeleteRem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdDeleteRem.BackColor = System.Drawing.Color.Maroon;
            this.cmdDeleteRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeleteRem.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.cmdDeleteRem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdDeleteRem.Location = new System.Drawing.Point(871, 34);
            this.cmdDeleteRem.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDeleteRem.Name = "cmdDeleteRem";
            this.cmdDeleteRem.Size = new System.Drawing.Size(142, 31);
            this.cmdDeleteRem.TabIndex = 15;
            this.cmdDeleteRem.Text = "Delete Reminder";
            this.cmdDeleteRem.UseVisualStyleBackColor = false;
            this.cmdDeleteRem.Click += new System.EventHandler(this.cmdDeleteRem_Click);
            // 
            // lblAddedReminder
            // 
            this.lblAddedReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddedReminder.AutoSize = true;
            this.lblAddedReminder.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.lblAddedReminder.ForeColor = System.Drawing.Color.Maroon;
            this.lblAddedReminder.Location = new System.Drawing.Point(513, 38);
            this.lblAddedReminder.Margin = new System.Windows.Forms.Padding(1);
            this.lblAddedReminder.Name = "lblAddedReminder";
            this.lblAddedReminder.Size = new System.Drawing.Size(153, 24);
            this.lblAddedReminder.TabIndex = 14;
            this.lblAddedReminder.Text = "Added Reminder at:";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTime.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(517, 137);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(157, 33);
            this.dateTimePickerTime.TabIndex = 13;
            this.dateTimePickerTime.ValueChanged += new System.EventHandler(this.dateTimePickerTime_ValueChanged);
            // 
            // cmdSaveRem
            // 
            this.cmdSaveRem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSaveRem.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdSaveRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveRem.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.cmdSaveRem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSaveRem.Location = new System.Drawing.Point(691, 140);
            this.cmdSaveRem.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSaveRem.Name = "cmdSaveRem";
            this.cmdSaveRem.Size = new System.Drawing.Size(130, 31);
            this.cmdSaveRem.TabIndex = 12;
            this.cmdSaveRem.Text = "Save Reminder";
            this.cmdSaveRem.UseVisualStyleBackColor = false;
            this.cmdSaveRem.Click += new System.EventHandler(this.cmdSaveRem_Click);
            // 
            // dateTimePickerReminder
            // 
            this.dateTimePickerReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerReminder.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.dateTimePickerReminder.Location = new System.Drawing.Point(517, 102);
            this.dateTimePickerReminder.Name = "dateTimePickerReminder";
            this.dateTimePickerReminder.Size = new System.Drawing.Size(304, 33);
            this.dateTimePickerReminder.TabIndex = 11;
            this.dateTimePickerReminder.ValueChanged += new System.EventHandler(this.dateTimePickerReminder_ValueChanged);
            // 
            // checkBoxReminder
            // 
            this.checkBoxReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxReminder.AutoSize = true;
            this.checkBoxReminder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxReminder.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.checkBoxReminder.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxReminder.Location = new System.Drawing.Point(517, 66);
            this.checkBoxReminder.Name = "checkBoxReminder";
            this.checkBoxReminder.Size = new System.Drawing.Size(105, 30);
            this.checkBoxReminder.TabIndex = 10;
            this.checkBoxReminder.Text = "Reminder";
            this.checkBoxReminder.UseVisualStyleBackColor = false;
            this.checkBoxReminder.CheckedChanged += new System.EventHandler(this.checkBoxReminder_CheckedChanged);
            // 
            // cmdCancelFileUpload
            // 
            this.cmdCancelFileUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCancelFileUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancelFileUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelFileUpload.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdCancelFileUpload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancelFileUpload.Image = global::WriteNotesApplication.Properties.Resources.delete;
            this.cmdCancelFileUpload.Location = new System.Drawing.Point(680, 671);
            this.cmdCancelFileUpload.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancelFileUpload.Name = "cmdCancelFileUpload";
            this.cmdCancelFileUpload.Size = new System.Drawing.Size(41, 37);
            this.cmdCancelFileUpload.TabIndex = 9;
            this.cmdCancelFileUpload.UseVisualStyleBackColor = false;
            this.cmdCancelFileUpload.Click += new System.EventHandler(this.cmdCancelFileUpload_Click);
            // 
            // cmdUploadFile
            // 
            this.cmdUploadFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdUploadFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUploadFile.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdUploadFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdUploadFile.Image = global::WriteNotesApplication.Properties.Resources.files;
            this.cmdUploadFile.Location = new System.Drawing.Point(625, 671);
            this.cmdUploadFile.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUploadFile.Name = "cmdUploadFile";
            this.cmdUploadFile.Size = new System.Drawing.Size(41, 37);
            this.cmdUploadFile.TabIndex = 8;
            this.cmdUploadFile.UseVisualStyleBackColor = false;
            this.cmdUploadFile.Click += new System.EventHandler(this.cmdUploadFile_Click);
            // 
            // cmdCancelPhotos
            // 
            this.cmdCancelPhotos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCancelPhotos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancelPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelPhotos.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdCancelPhotos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancelPhotos.Image = global::WriteNotesApplication.Properties.Resources.delete;
            this.cmdCancelPhotos.Location = new System.Drawing.Point(560, 671);
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
            this.cmdUploadPhoto.Location = new System.Drawing.Point(515, 671);
            this.cmdUploadPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUploadPhoto.Name = "cmdUploadPhoto";
            this.cmdUploadPhoto.Size = new System.Drawing.Size(41, 37);
            this.cmdUploadPhoto.TabIndex = 6;
            this.cmdUploadPhoto.UseVisualStyleBackColor = false;
            this.cmdUploadPhoto.Click += new System.EventHandler(this.cmdUploadPhoto_Click);
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
            this.txtNote.Size = new System.Drawing.Size(519, 388);
            this.txtNote.TabIndex = 0;
            this.txtNote.Text = "";
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
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
        private System.Windows.Forms.Button cmdUploadFile;
        private System.Windows.Forms.Button cmdCancelFileUpload;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminder;
        private System.Windows.Forms.CheckBox checkBoxReminder;
        private System.Windows.Forms.Button cmdSaveRem;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button cmdDeleteRem;
        private System.Windows.Forms.Label lblAddedReminder;
    }
}

