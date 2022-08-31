
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
            this.cmdModifyUser = new System.Windows.Forms.Button();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.cmdDeleteNote = new System.Windows.Forms.Button();
            this.cmdModifyNote = new System.Windows.Forms.Button();
            this.cmdSearhNote = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdCreateNote = new System.Windows.Forms.Button();
            this.userOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userOptionsGroupBox
            // 
            this.userOptionsGroupBox.Controls.Add(this.cmdModifyUser);
            this.userOptionsGroupBox.Controls.Add(this.cmdLogOut);
            this.userOptionsGroupBox.Controls.Add(this.cmdDeleteNote);
            this.userOptionsGroupBox.Controls.Add(this.cmdModifyNote);
            this.userOptionsGroupBox.Controls.Add(this.cmdSearhNote);
            this.userOptionsGroupBox.Controls.Add(this.button2);
            this.userOptionsGroupBox.Controls.Add(this.cmdCreateNote);
            this.userOptionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.userOptionsGroupBox.Name = "userOptionsGroupBox";
            this.userOptionsGroupBox.Size = new System.Drawing.Size(305, 211);
            this.userOptionsGroupBox.TabIndex = 0;
            this.userOptionsGroupBox.TabStop = false;
            this.userOptionsGroupBox.Text = "What do you want to do?";
            // 
            // cmdModifyUser
            // 
            this.cmdModifyUser.Location = new System.Drawing.Point(28, 148);
            this.cmdModifyUser.Name = "cmdModifyUser";
            this.cmdModifyUser.Size = new System.Drawing.Size(125, 23);
            this.cmdModifyUser.TabIndex = 7;
            this.cmdModifyUser.Text = "Modify User";
            this.cmdModifyUser.UseVisualStyleBackColor = true;
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.Location = new System.Drawing.Point(28, 182);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(125, 23);
            this.cmdLogOut.TabIndex = 6;
            this.cmdLogOut.Text = "Log Out";
            this.cmdLogOut.UseVisualStyleBackColor = true;
            this.cmdLogOut.Click += new System.EventHandler(this.cmdLogOut_Click);
            // 
            // cmdDeleteNote
            // 
            this.cmdDeleteNote.Location = new System.Drawing.Point(28, 119);
            this.cmdDeleteNote.Name = "cmdDeleteNote";
            this.cmdDeleteNote.Size = new System.Drawing.Size(125, 23);
            this.cmdDeleteNote.TabIndex = 5;
            this.cmdDeleteNote.Text = "Delete Note";
            this.cmdDeleteNote.UseVisualStyleBackColor = true;
            // 
            // cmdModifyNote
            // 
            this.cmdModifyNote.Location = new System.Drawing.Point(28, 89);
            this.cmdModifyNote.Name = "cmdModifyNote";
            this.cmdModifyNote.Size = new System.Drawing.Size(125, 23);
            this.cmdModifyNote.TabIndex = 4;
            this.cmdModifyNote.Text = "Modify Note";
            this.cmdModifyNote.UseVisualStyleBackColor = true;
            // 
            // cmdSearhNote
            // 
            this.cmdSearhNote.Location = new System.Drawing.Point(28, 60);
            this.cmdSearhNote.Name = "cmdSearhNote";
            this.cmdSearhNote.Size = new System.Drawing.Size(125, 23);
            this.cmdSearhNote.TabIndex = 3;
            this.cmdSearhNote.Text = "Search Note";
            this.cmdSearhNote.UseVisualStyleBackColor = true;
            this.cmdSearhNote.Click += new System.EventHandler(this.cmdSearhNote_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmdCreateNote
            // 
            this.cmdCreateNote.Location = new System.Drawing.Point(28, 31);
            this.cmdCreateNote.Name = "cmdCreateNote";
            this.cmdCreateNote.Size = new System.Drawing.Size(125, 23);
            this.cmdCreateNote.TabIndex = 0;
            this.cmdCreateNote.Text = " New Note";
            this.cmdCreateNote.UseVisualStyleBackColor = true;
            this.cmdCreateNote.Click += new System.EventHandler(this.cmdCreateNote_Click);
            // 
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 226);
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
        private System.Windows.Forms.Button cmdDeleteNote;
        private System.Windows.Forms.Button cmdModifyNote;
        private System.Windows.Forms.Button cmdSearhNote;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdCreateNote;
        private System.Windows.Forms.Button cmdModifyUser;
    }
}