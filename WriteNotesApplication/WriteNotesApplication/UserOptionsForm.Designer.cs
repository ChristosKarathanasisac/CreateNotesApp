
namespace WriteNotesApplication
{
    partial class UserOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOptionsForm));
            this.userOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.cmdChangeUserInfo = new System.Windows.Forms.Button();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.cmdSearhNote = new System.Windows.Forms.Button();
            this.cmdCreateNote = new System.Windows.Forms.Button();
            this.userOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userOptionsGroupBox
            // 
            this.userOptionsGroupBox.Controls.Add(this.cmdChangeUserInfo);
            this.userOptionsGroupBox.Controls.Add(this.cmdLogOut);
            this.userOptionsGroupBox.Controls.Add(this.cmdSearhNote);
            this.userOptionsGroupBox.Controls.Add(this.cmdCreateNote);
            this.userOptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.userOptionsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.userOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userOptionsGroupBox.Name = "userOptionsGroupBox";
            this.userOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userOptionsGroupBox.Size = new System.Drawing.Size(701, 326);
            this.userOptionsGroupBox.TabIndex = 0;
            this.userOptionsGroupBox.TabStop = false;
            this.userOptionsGroupBox.Text = "What do you want to do?";
            // 
            // cmdChangeUserInfo
            // 
            this.cmdChangeUserInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdChangeUserInfo.Location = new System.Drawing.Point(37, 130);
            this.cmdChangeUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdChangeUserInfo.Name = "cmdChangeUserInfo";
            this.cmdChangeUserInfo.Size = new System.Drawing.Size(167, 55);
            this.cmdChangeUserInfo.TabIndex = 7;
            this.cmdChangeUserInfo.Text = "Change User Info";
            this.cmdChangeUserInfo.UseVisualStyleBackColor = false;
            this.cmdChangeUserInfo.Click += new System.EventHandler(this.cmdChangeUserInfo_Click);
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdLogOut.Location = new System.Drawing.Point(37, 224);
            this.cmdLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(167, 41);
            this.cmdLogOut.TabIndex = 6;
            this.cmdLogOut.Text = "Log Out";
            this.cmdLogOut.UseVisualStyleBackColor = false;
            this.cmdLogOut.Click += new System.EventHandler(this.cmdLogOut_Click);
            // 
            // cmdSearhNote
            // 
            this.cmdSearhNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdSearhNote.Location = new System.Drawing.Point(37, 87);
            this.cmdSearhNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSearhNote.Name = "cmdSearhNote";
            this.cmdSearhNote.Size = new System.Drawing.Size(167, 36);
            this.cmdSearhNote.TabIndex = 3;
            this.cmdSearhNote.Text = "Search Note";
            this.cmdSearhNote.UseVisualStyleBackColor = false;
            this.cmdSearhNote.Click += new System.EventHandler(this.cmdSearhNote_Click);
            // 
            // cmdCreateNote
            // 
            this.cmdCreateNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdCreateNote.Location = new System.Drawing.Point(37, 38);
            this.cmdCreateNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCreateNote.Name = "cmdCreateNote";
            this.cmdCreateNote.Size = new System.Drawing.Size(167, 42);
            this.cmdCreateNote.TabIndex = 0;
            this.cmdCreateNote.Text = " New Note";
            this.cmdCreateNote.UseVisualStyleBackColor = false;
            this.cmdCreateNote.Click += new System.EventHandler(this.cmdCreateNote_Click);
            // 
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 345);
            this.Controls.Add(this.userOptionsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserOptionsForm";
            this.Text = "Create Notes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserOptionsForm_FormClosed);
            this.userOptionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userOptionsGroupBox;
        private System.Windows.Forms.Button cmdLogOut;
        private System.Windows.Forms.Button cmdSearhNote;
        private System.Windows.Forms.Button cmdCreateNote;
        private System.Windows.Forms.Button cmdChangeUserInfo;
    }
}