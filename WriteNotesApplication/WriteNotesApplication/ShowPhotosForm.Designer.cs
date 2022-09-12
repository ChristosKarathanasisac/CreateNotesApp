
namespace WriteNotesApplication
{
    partial class ShowPhotosForm
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
            this.lblPhotos = new System.Windows.Forms.Label();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(15, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblPhotos
            // 
            this.lblPhotos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhotos.AutoSize = true;
            this.lblPhotos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhotos.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.lblPhotos.ForeColor = System.Drawing.Color.Black;
            this.lblPhotos.Location = new System.Drawing.Point(11, 24);
            this.lblPhotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhotos.Name = "lblPhotos";
            this.lblPhotos.Size = new System.Drawing.Size(106, 26);
            this.lblPhotos.TabIndex = 6;
            this.lblPhotos.Text = "Note Photos:";
            // 
            // cmdReturn
            // 
            this.cmdReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdReturn.BackColor = System.Drawing.Color.DarkRed;
            this.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReturn.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.cmdReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdReturn.Location = new System.Drawing.Point(467, 24);
            this.cmdReturn.Margin = new System.Windows.Forms.Padding(2);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(84, 29);
            this.cmdReturn.TabIndex = 9;
            this.cmdReturn.Text = "Return";
            this.cmdReturn.UseVisualStyleBackColor = false;
            // 
            // ShowPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(566, 357);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.lblPhotos);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowPhotosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smart .note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPhotos;
        private System.Windows.Forms.Button cmdReturn;
    }
}