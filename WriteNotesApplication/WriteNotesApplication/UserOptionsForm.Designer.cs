
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
            this.userOptionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.userOptionsGroupBox.Name = "userOptionsGroupBox";
            this.userOptionsGroupBox.Size = new System.Drawing.Size(526, 265);
            this.userOptionsGroupBox.TabIndex = 0;
            this.userOptionsGroupBox.TabStop = false;
            this.userOptionsGroupBox.Text = "What do you want to do?";
            // 
            // cmdChangeUserInfo
            // 
            this.cmdChangeUserInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdChangeUserInfo.Location = new System.Drawing.Point(28, 106);
            this.cmdChangeUserInfo.Name = "cmdChangeUserInfo";
            this.cmdChangeUserInfo.Size = new System.Drawing.Size(125, 45);
            this.cmdChangeUserInfo.TabIndex = 7;
            this.cmdChangeUserInfo.Text = "Change User Info";
            this.cmdChangeUserInfo.UseVisualStyleBackColor = false;
            this.cmdChangeUserInfo.Click += new System.EventHandler(this.cmdChangeUserInfo_Click);
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdLogOut.Location = new System.Drawing.Point(28, 182);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(125, 33);
            this.cmdLogOut.TabIndex = 6;
            this.cmdLogOut.Text = "Log Out";
            this.cmdLogOut.UseVisualStyleBackColor = false;
            this.cmdLogOut.Click += new System.EventHandler(this.cmdLogOut_Click);
            // 
            // cmdSearhNote
            // 
            this.cmdSearhNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdSearhNote.Location = new System.Drawing.Point(28, 71);
            this.cmdSearhNote.Name = "cmdSearhNote";
            this.cmdSearhNote.Size = new System.Drawing.Size(125, 29);
            this.cmdSearhNote.TabIndex = 3;
            this.cmdSearhNote.Text = "Search Note";
            this.cmdSearhNote.UseVisualStyleBackColor = false;
            this.cmdSearhNote.Click += new System.EventHandler(this.cmdSearhNote_Click);
            // 
            // cmdCreateNote
            // 
            this.cmdCreateNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdCreateNote.Location = new System.Drawing.Point(28, 31);
            this.cmdCreateNote.Name = "cmdCreateNote";
            this.cmdCreateNote.Size = new System.Drawing.Size(125, 34);
            this.cmdCreateNote.TabIndex = 0;
            this.cmdCreateNote.Text = " New Note";
            this.cmdCreateNote.UseVisualStyleBackColor = false;
            this.cmdCreateNote.Click += new System.EventHandler(this.cmdCreateNote_Click);
            // 
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 280);
            this.Controls.Add(this.userOptionsGroupBox);
            this.Name = "UserOptionsForm";
            this.Text = "UserOptionsForm";
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