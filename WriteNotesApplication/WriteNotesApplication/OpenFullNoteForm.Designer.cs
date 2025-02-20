﻿
namespace WriteNotesApplication
{
    partial class OpenFullNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenFullNoteForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdOpenFile = new System.Windows.Forms.Button();
            this.cmdSaveToFile = new System.Windows.Forms.Button();
            this.cmdShowPhotos = new System.Windows.Forms.Button();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.lblNoteSubject = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmdSentEmail = new System.Windows.Forms.Button();
            this.lblNoteTopic = new System.Windows.Forms.Label();
            this.txtNoteTopic = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.lblReminderAt = new System.Windows.Forms.Label();
            this.lblRemDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lblRemDate);
            this.groupBox1.Controls.Add(this.lblReminderAt);
            this.groupBox1.Controls.Add(this.cmdOpenFile);
            this.groupBox1.Controls.Add(this.cmdSaveToFile);
            this.groupBox1.Controls.Add(this.cmdShowPhotos);
            this.groupBox1.Controls.Add(this.txtEmailSubject);
            this.groupBox1.Controls.Add(this.lblNoteSubject);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.cmdSentEmail);
            this.groupBox1.Controls.Add(this.lblNoteTopic);
            this.groupBox1.Controls.Add(this.txtNoteTopic);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmdModify);
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 717);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdOpenFile
            // 
            this.cmdOpenFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdOpenFile.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOpenFile.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdOpenFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdOpenFile.Location = new System.Drawing.Point(394, 658);
            this.cmdOpenFile.Name = "cmdOpenFile";
            this.cmdOpenFile.Size = new System.Drawing.Size(149, 46);
            this.cmdOpenFile.TabIndex = 13;
            this.cmdOpenFile.Text = "Open File";
            this.cmdOpenFile.UseVisualStyleBackColor = false;
            this.cmdOpenFile.Click += new System.EventHandler(this.cmdOpenFile_Click);
            // 
            // cmdSaveToFile
            // 
            this.cmdSaveToFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSaveToFile.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdSaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveToFile.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdSaveToFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdSaveToFile.Location = new System.Drawing.Point(704, 658);
            this.cmdSaveToFile.Name = "cmdSaveToFile";
            this.cmdSaveToFile.Size = new System.Drawing.Size(145, 46);
            this.cmdSaveToFile.TabIndex = 12;
            this.cmdSaveToFile.Text = "Save To PC";
            this.cmdSaveToFile.UseVisualStyleBackColor = false;
            this.cmdSaveToFile.Click += new System.EventHandler(this.cmdSaveToFile_Click);
            // 
            // cmdShowPhotos
            // 
            this.cmdShowPhotos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdShowPhotos.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdShowPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShowPhotos.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdShowPhotos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdShowPhotos.Location = new System.Drawing.Point(549, 658);
            this.cmdShowPhotos.Name = "cmdShowPhotos";
            this.cmdShowPhotos.Size = new System.Drawing.Size(149, 46);
            this.cmdShowPhotos.TabIndex = 11;
            this.cmdShowPhotos.Text = "Show Photos";
            this.cmdShowPhotos.UseVisualStyleBackColor = false;
            this.cmdShowPhotos.Click += new System.EventHandler(this.cmdShowPhotos_Click);
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailSubject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailSubject.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.txtEmailSubject.Location = new System.Drawing.Point(668, 171);
            this.txtEmailSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(339, 26);
            this.txtEmailSubject.TabIndex = 10;
            this.txtEmailSubject.TextChanged += new System.EventHandler(this.txtEmailSubject_TextChanged);
            // 
            // lblNoteSubject
            // 
            this.lblNoteSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteSubject.AutoSize = true;
            this.lblNoteSubject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoteSubject.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.lblNoteSubject.ForeColor = System.Drawing.Color.Black;
            this.lblNoteSubject.Location = new System.Drawing.Point(544, 169);
            this.lblNoteSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoteSubject.Name = "lblNoteSubject";
            this.lblNoteSubject.Size = new System.Drawing.Size(120, 26);
            this.lblNoteSubject.TabIndex = 9;
            this.lblNoteSubject.Text = "Email Subject:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.txtEmail.Location = new System.Drawing.Point(674, 128);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 31);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // cmdSentEmail
            // 
            this.cmdSentEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSentEmail.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdSentEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSentEmail.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdSentEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdSentEmail.Location = new System.Drawing.Point(515, 120);
            this.cmdSentEmail.Name = "cmdSentEmail";
            this.cmdSentEmail.Size = new System.Drawing.Size(149, 46);
            this.cmdSentEmail.TabIndex = 6;
            this.cmdSentEmail.Text = "Send note to:";
            this.cmdSentEmail.UseVisualStyleBackColor = false;
            this.cmdSentEmail.Click += new System.EventHandler(this.cmdSentEmail_Click);
            // 
            // lblNoteTopic
            // 
            this.lblNoteTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteTopic.AutoSize = true;
            this.lblNoteTopic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoteTopic.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.lblNoteTopic.ForeColor = System.Drawing.Color.Black;
            this.lblNoteTopic.Location = new System.Drawing.Point(509, 234);
            this.lblNoteTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoteTopic.Name = "lblNoteTopic";
            this.lblNoteTopic.Size = new System.Drawing.Size(116, 31);
            this.lblNoteTopic.TabIndex = 5;
            this.lblNoteTopic.Text = "Note Topic:";
            // 
            // txtNoteTopic
            // 
            this.txtNoteTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoteTopic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNoteTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoteTopic.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.txtNoteTopic.Location = new System.Drawing.Point(629, 234);
            this.txtNoteTopic.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoteTopic.Name = "txtNoteTopic";
            this.txtNoteTopic.ReadOnly = true;
            this.txtNoteTopic.Size = new System.Drawing.Size(256, 31);
            this.txtNoteTopic.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WriteNotesApplication.Properties.Resources.ShowNote;
            this.pictureBox1.Location = new System.Drawing.Point(5, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cmdModify
            // 
            this.cmdModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdModify.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModify.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdModify.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdModify.Location = new System.Drawing.Point(889, 658);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(149, 46);
            this.cmdModify.TabIndex = 2;
            this.cmdModify.Text = "Modify Note";
            this.cmdModify.UseVisualStyleBackColor = false;
            this.cmdModify.Click += new System.EventHandler(this.cmdModify_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdBack.BackColor = System.Drawing.SystemColors.ControlText;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Segoe Print", 8.8F, System.Drawing.FontStyle.Italic);
            this.cmdBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdBack.Location = new System.Drawing.Point(5, 684);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(55, 27);
            this.cmdBack.TabIndex = 1;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNote.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.txtNote.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNote.Location = new System.Drawing.Point(510, 270);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(528, 382);
            this.txtNote.TabIndex = 0;
            this.txtNote.Text = "";
            // 
            // lblReminderAt
            // 
            this.lblReminderAt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReminderAt.AutoSize = true;
            this.lblReminderAt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReminderAt.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.lblReminderAt.ForeColor = System.Drawing.Color.Maroon;
            this.lblReminderAt.Location = new System.Drawing.Point(509, 36);
            this.lblReminderAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReminderAt.Name = "lblReminderAt";
            this.lblReminderAt.Size = new System.Drawing.Size(136, 31);
            this.lblReminderAt.TabIndex = 14;
            this.lblReminderAt.Text = "Reminder At:";
            this.lblReminderAt.Visible = false;
            // 
            // lblRemDate
            // 
            this.lblRemDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemDate.AutoSize = true;
            this.lblRemDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemDate.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.lblRemDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblRemDate.Location = new System.Drawing.Point(642, 36);
            this.lblRemDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemDate.Name = "lblRemDate";
            this.lblRemDate.Size = new System.Drawing.Size(0, 31);
            this.lblRemDate.TabIndex = 15;
            this.lblRemDate.Visible = false;
            // 
            // OpenFullNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 741);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenFullNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smart. note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenFullNoteForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNoteTopic;
        private System.Windows.Forms.Label lblNoteTopic;
        private System.Windows.Forms.Button cmdSentEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.Label lblNoteSubject;
        private System.Windows.Forms.Button cmdShowPhotos;
        private System.Windows.Forms.Button cmdSaveToFile;
        private System.Windows.Forms.Button cmdOpenFile;
        private System.Windows.Forms.Label lblRemDate;
        private System.Windows.Forms.Label lblReminderAt;
    }
}