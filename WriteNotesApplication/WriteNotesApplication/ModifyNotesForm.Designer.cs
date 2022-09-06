
namespace WriteNotesApplication
{
    partial class ModifyNotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyNotesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNoteTopic = new System.Windows.Forms.TextBox();
            this.lblNoteTopic = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtModifyNote = new System.Windows.Forms.RichTextBox();
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
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtNoteTopic);
            this.groupBox1.Controls.Add(this.lblNoteTopic);
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtModifyNote);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 703);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WriteNotesApplication.Properties.Resources.modifyNote;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtNoteTopic
            // 
            this.txtNoteTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoteTopic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNoteTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoteTopic.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.txtNoteTopic.Location = new System.Drawing.Point(641, 238);
            this.txtNoteTopic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoteTopic.Name = "txtNoteTopic";
            this.txtNoteTopic.ReadOnly = true;
            this.txtNoteTopic.Size = new System.Drawing.Size(387, 31);
            this.txtNoteTopic.TabIndex = 7;
            // 
            // lblNoteTopic
            // 
            this.lblNoteTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteTopic.AutoSize = true;
            this.lblNoteTopic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoteTopic.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.lblNoteTopic.ForeColor = System.Drawing.Color.Black;
            this.lblNoteTopic.Location = new System.Drawing.Point(526, 238);
            this.lblNoteTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoteTopic.Name = "lblNoteTopic";
            this.lblNoteTopic.Size = new System.Drawing.Size(116, 31);
            this.lblNoteTopic.TabIndex = 6;
            this.lblNoteTopic.Text = "Note Topic:";
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Segoe Print", 8.8F, System.Drawing.FontStyle.Italic);
            this.cmdBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdBack.Location = new System.Drawing.Point(6, 662);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(54, 35);
            this.cmdBack.TabIndex = 2;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSave.BackColor = System.Drawing.SystemColors.ControlText;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdSave.Location = new System.Drawing.Point(696, 144);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(104, 38);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtModifyNote
            // 
            this.txtModifyNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModifyNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtModifyNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModifyNote.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.txtModifyNote.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtModifyNote.Location = new System.Drawing.Point(511, 274);
            this.txtModifyNote.Name = "txtModifyNote";
            this.txtModifyNote.Size = new System.Drawing.Size(527, 423);
            this.txtModifyNote.TabIndex = 0;
            this.txtModifyNote.Text = "";
            // 
            // ModifyNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 727);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smart. note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifyNotesForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.RichTextBox txtModifyNote;
        private System.Windows.Forms.Label lblNoteTopic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNoteTopic;
    }
}