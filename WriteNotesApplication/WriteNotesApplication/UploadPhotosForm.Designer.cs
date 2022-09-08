
namespace WriteNotesApplication
{
    partial class UploadPhotosForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdUploadPhoto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(214, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(15, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmdUploadPhoto);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1036, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cmdBack
            // 
            this.cmdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdBack.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic);
            this.cmdBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdBack.Location = new System.Drawing.Point(12, 700);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(1);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(60, 33);
            this.cmdBack.TabIndex = 3;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            // 
            // cmdUploadPhoto
            // 
            this.cmdUploadPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdUploadPhoto.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUploadPhoto.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdUploadPhoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdUploadPhoto.Location = new System.Drawing.Point(431, 18);
            this.cmdUploadPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUploadPhoto.Name = "cmdUploadPhoto";
            this.cmdUploadPhoto.Size = new System.Drawing.Size(158, 37);
            this.cmdUploadPhoto.TabIndex = 7;
            this.cmdUploadPhoto.Text = "Upload Photo";
            this.cmdUploadPhoto.UseVisualStyleBackColor = false;
            this.cmdUploadPhoto.Click += new System.EventHandler(this.cmdUploadPhoto_Click);
            // 
            // UploadPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 741);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UploadPhotosForm";
            this.Text = "smart.note";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdUploadPhoto;
    }
}