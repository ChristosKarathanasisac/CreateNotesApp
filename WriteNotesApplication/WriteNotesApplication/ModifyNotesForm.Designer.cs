
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
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.cmdSaveRem = new System.Windows.Forms.Button();
            this.dateTimePickerReminder = new System.Windows.Forms.DateTimePicker();
            this.cmdModifyRem = new System.Windows.Forms.Button();
            this.cmdDeleteRem = new System.Windows.Forms.Button();
            this.lblReminderDate = new System.Windows.Forms.Label();
            this.lblReminderAt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNoteTopic = new System.Windows.Forms.TextBox();
            this.lblNoteTopic = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtModifyNote = new System.Windows.Forms.RichTextBox();
            this.cmdMicrophone = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.cmdMicrophone);
            this.groupBox1.Controls.Add(this.dateTimePickerTime);
            this.groupBox1.Controls.Add(this.cmdSaveRem);
            this.groupBox1.Controls.Add(this.dateTimePickerReminder);
            this.groupBox1.Controls.Add(this.cmdModifyRem);
            this.groupBox1.Controls.Add(this.cmdDeleteRem);
            this.groupBox1.Controls.Add(this.lblReminderDate);
            this.groupBox1.Controls.Add(this.lblReminderAt);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtNoteTopic);
            this.groupBox1.Controls.Add(this.lblNoteTopic);
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtModifyNote);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 717);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTime.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(705, 184);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(157, 33);
            this.dateTimePickerTime.TabIndex = 16;
            this.dateTimePickerTime.Visible = false;
            // 
            // cmdSaveRem
            // 
            this.cmdSaveRem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSaveRem.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdSaveRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveRem.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.cmdSaveRem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSaveRem.Location = new System.Drawing.Point(879, 187);
            this.cmdSaveRem.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSaveRem.Name = "cmdSaveRem";
            this.cmdSaveRem.Size = new System.Drawing.Size(130, 31);
            this.cmdSaveRem.TabIndex = 15;
            this.cmdSaveRem.Text = "Save Reminder";
            this.cmdSaveRem.UseVisualStyleBackColor = false;
            this.cmdSaveRem.Visible = false;
            this.cmdSaveRem.Click += new System.EventHandler(this.cmdSaveRem_Click);
            // 
            // dateTimePickerReminder
            // 
            this.dateTimePickerReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerReminder.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.dateTimePickerReminder.Location = new System.Drawing.Point(705, 149);
            this.dateTimePickerReminder.Name = "dateTimePickerReminder";
            this.dateTimePickerReminder.Size = new System.Drawing.Size(304, 33);
            this.dateTimePickerReminder.TabIndex = 14;
            this.dateTimePickerReminder.Visible = false;
            // 
            // cmdModifyRem
            // 
            this.cmdModifyRem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdModifyRem.BackColor = System.Drawing.SystemColors.ControlText;
            this.cmdModifyRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModifyRem.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdModifyRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdModifyRem.Location = new System.Drawing.Point(705, 76);
            this.cmdModifyRem.Name = "cmdModifyRem";
            this.cmdModifyRem.Size = new System.Drawing.Size(158, 38);
            this.cmdModifyRem.TabIndex = 12;
            this.cmdModifyRem.Text = "Modify Reminder";
            this.cmdModifyRem.UseVisualStyleBackColor = false;
            this.cmdModifyRem.Visible = false;
            this.cmdModifyRem.Click += new System.EventHandler(this.cmdModifyRem_Click);
            // 
            // cmdDeleteRem
            // 
            this.cmdDeleteRem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdDeleteRem.BackColor = System.Drawing.SystemColors.ControlText;
            this.cmdDeleteRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeleteRem.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdDeleteRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdDeleteRem.Location = new System.Drawing.Point(538, 76);
            this.cmdDeleteRem.Name = "cmdDeleteRem";
            this.cmdDeleteRem.Size = new System.Drawing.Size(158, 38);
            this.cmdDeleteRem.TabIndex = 11;
            this.cmdDeleteRem.Text = "Delete Reminder";
            this.cmdDeleteRem.UseVisualStyleBackColor = false;
            this.cmdDeleteRem.Visible = false;
            this.cmdDeleteRem.Click += new System.EventHandler(this.cmdDeleteRem_Click);
            // 
            // lblReminderDate
            // 
            this.lblReminderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReminderDate.AutoSize = true;
            this.lblReminderDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReminderDate.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.lblReminderDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblReminderDate.Location = new System.Drawing.Point(663, 42);
            this.lblReminderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReminderDate.Name = "lblReminderDate";
            this.lblReminderDate.Size = new System.Drawing.Size(0, 31);
            this.lblReminderDate.TabIndex = 10;
            this.lblReminderDate.Visible = false;
            // 
            // lblReminderAt
            // 
            this.lblReminderAt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReminderAt.AutoSize = true;
            this.lblReminderAt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReminderAt.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.lblReminderAt.ForeColor = System.Drawing.Color.Maroon;
            this.lblReminderAt.Location = new System.Drawing.Point(526, 42);
            this.lblReminderAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReminderAt.Name = "lblReminderAt";
            this.lblReminderAt.Size = new System.Drawing.Size(133, 31);
            this.lblReminderAt.TabIndex = 9;
            this.lblReminderAt.Text = "Reminder at:";
            this.lblReminderAt.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WriteNotesApplication.Properties.Resources.modifyNote;
            this.pictureBox1.Location = new System.Drawing.Point(6, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtNoteTopic.Location = new System.Drawing.Point(641, 245);
            this.txtNoteTopic.Margin = new System.Windows.Forms.Padding(2);
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
            this.lblNoteTopic.Location = new System.Drawing.Point(526, 245);
            this.lblNoteTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoteTopic.Name = "lblNoteTopic";
            this.lblNoteTopic.Size = new System.Drawing.Size(116, 31);
            this.lblNoteTopic.TabIndex = 6;
            this.lblNoteTopic.Text = "Note Topic:";
            // 
            // cmdBack
            // 
            this.cmdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdBack.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Segoe Print", 8.8F, System.Drawing.FontStyle.Italic);
            this.cmdBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdBack.Location = new System.Drawing.Point(6, 676);
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
            this.cmdSave.Location = new System.Drawing.Point(538, 159);
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
            this.txtModifyNote.Location = new System.Drawing.Point(511, 281);
            this.txtModifyNote.Name = "txtModifyNote";
            this.txtModifyNote.Size = new System.Drawing.Size(527, 387);
            this.txtModifyNote.TabIndex = 0;
            this.txtModifyNote.Text = "";
            // 
            // cmdMicrophone
            // 
            this.cmdMicrophone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdMicrophone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdMicrophone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMicrophone.Font = new System.Drawing.Font("Segoe Print", 12.8F, System.Drawing.FontStyle.Italic);
            this.cmdMicrophone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdMicrophone.Image = global::WriteNotesApplication.Properties.Resources.microphone;
            this.cmdMicrophone.Location = new System.Drawing.Point(511, 673);
            this.cmdMicrophone.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMicrophone.Name = "cmdMicrophone";
            this.cmdMicrophone.Size = new System.Drawing.Size(41, 37);
            this.cmdMicrophone.TabIndex = 18;
            this.cmdMicrophone.UseVisualStyleBackColor = false;
            this.cmdMicrophone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdMicrophone_MouseDown);
            this.cmdMicrophone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmdMicrophone_MouseUp);
            // 
            // ModifyNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 741);
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
        private System.Windows.Forms.Label lblReminderAt;
        private System.Windows.Forms.Label lblReminderDate;
        private System.Windows.Forms.Button cmdModifyRem;
        private System.Windows.Forms.Button cmdDeleteRem;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Button cmdSaveRem;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminder;
        private System.Windows.Forms.Button cmdMicrophone;
    }
}