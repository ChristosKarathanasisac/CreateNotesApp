
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
            this.lblOptions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdChangeUserInfo = new System.Windows.Forms.Button();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.cmdSearhNote = new System.Windows.Forms.Button();
            this.cmdCreateNote = new System.Windows.Forms.Button();
            this.userOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userOptionsGroupBox
            // 
            this.userOptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userOptionsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userOptionsGroupBox.Controls.Add(this.lblOptions);
            this.userOptionsGroupBox.Controls.Add(this.pictureBox1);
            this.userOptionsGroupBox.Controls.Add(this.cmdChangeUserInfo);
            this.userOptionsGroupBox.Controls.Add(this.cmdLogOut);
            this.userOptionsGroupBox.Controls.Add(this.cmdSearhNote);
            this.userOptionsGroupBox.Controls.Add(this.cmdCreateNote);
            this.userOptionsGroupBox.Font = new System.Drawing.Font("Segoe Print", 11.8F, System.Drawing.FontStyle.Italic);
            this.userOptionsGroupBox.Location = new System.Drawing.Point(10, 10);
            this.userOptionsGroupBox.Margin = new System.Windows.Forms.Padding(1);
            this.userOptionsGroupBox.Name = "userOptionsGroupBox";
            this.userOptionsGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.userOptionsGroupBox.Size = new System.Drawing.Size(1044, 717);
            this.userOptionsGroupBox.TabIndex = 0;
            this.userOptionsGroupBox.TabStop = false;
            // 
            // lblOptions
            // 
            this.lblOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOptions.AutoSize = true;
            this.lblOptions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOptions.Font = new System.Drawing.Font("Segoe Print", 20.8F, System.Drawing.FontStyle.Italic);
            this.lblOptions.ForeColor = System.Drawing.Color.Black;
            this.lblOptions.Location = new System.Drawing.Point(429, 469);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(131, 49);
            this.lblOptions.TabIndex = 24;
            this.lblOptions.Text = "Options";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::WriteNotesApplication.Properties.Resources.logowhite;
            this.pictureBox1.Location = new System.Drawing.Point(263, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 375);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cmdChangeUserInfo
            // 
            this.cmdChangeUserInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdChangeUserInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdChangeUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdChangeUserInfo.Font = new System.Drawing.Font("Segoe Print", 11.8F, System.Drawing.FontStyle.Italic);
            this.cmdChangeUserInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdChangeUserInfo.Location = new System.Drawing.Point(520, 521);
            this.cmdChangeUserInfo.Name = "cmdChangeUserInfo";
            this.cmdChangeUserInfo.Size = new System.Drawing.Size(172, 41);
            this.cmdChangeUserInfo.TabIndex = 7;
            this.cmdChangeUserInfo.Text = "Change User Info";
            this.cmdChangeUserInfo.UseVisualStyleBackColor = false;
            this.cmdChangeUserInfo.Click += new System.EventHandler(this.cmdChangeUserInfo_Click);
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogOut.Font = new System.Drawing.Font("Segoe Print", 11.8F, System.Drawing.FontStyle.Italic);
            this.cmdLogOut.Location = new System.Drawing.Point(520, 582);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(172, 41);
            this.cmdLogOut.TabIndex = 6;
            this.cmdLogOut.Text = "Log Out";
            this.cmdLogOut.UseVisualStyleBackColor = false;
            this.cmdLogOut.Click += new System.EventHandler(this.cmdLogOut_Click);
            // 
            // cmdSearhNote
            // 
            this.cmdSearhNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSearhNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdSearhNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearhNote.Font = new System.Drawing.Font("Segoe Print", 11.8F, System.Drawing.FontStyle.Italic);
            this.cmdSearhNote.Location = new System.Drawing.Point(343, 582);
            this.cmdSearhNote.Name = "cmdSearhNote";
            this.cmdSearhNote.Size = new System.Drawing.Size(172, 41);
            this.cmdSearhNote.TabIndex = 3;
            this.cmdSearhNote.Text = "Search Note";
            this.cmdSearhNote.UseVisualStyleBackColor = false;
            this.cmdSearhNote.Click += new System.EventHandler(this.cmdSearhNote_Click);
            // 
            // cmdCreateNote
            // 
            this.cmdCreateNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCreateNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCreateNote.Font = new System.Drawing.Font("Segoe Print", 11.8F, System.Drawing.FontStyle.Italic);
            this.cmdCreateNote.Location = new System.Drawing.Point(343, 521);
            this.cmdCreateNote.Name = "cmdCreateNote";
            this.cmdCreateNote.Size = new System.Drawing.Size(172, 41);
            this.cmdCreateNote.TabIndex = 0;
            this.cmdCreateNote.Text = " New Note";
            this.cmdCreateNote.UseVisualStyleBackColor = false;
            this.cmdCreateNote.Click += new System.EventHandler(this.cmdCreateNote_Click);
            // 
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1062, 737);
            this.Controls.Add(this.userOptionsGroupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smart. note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserOptionsForm_FormClosed);
            this.userOptionsGroupBox.ResumeLayout(false);
            this.userOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userOptionsGroupBox;
        private System.Windows.Forms.Button cmdLogOut;
        private System.Windows.Forms.Button cmdSearhNote;
        private System.Windows.Forms.Button cmdCreateNote;
        private System.Windows.Forms.Button cmdChangeUserInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOptions;
    }
}