
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
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdModify);
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1047, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdModify
            // 
            this.cmdModify.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdModify.Location = new System.Drawing.Point(12, 306);
            this.cmdModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(153, 36);
            this.cmdModify.TabIndex = 2;
            this.cmdModify.Text = "Modify Note";
            this.cmdModify.UseVisualStyleBackColor = false;
            this.cmdModify.Click += new System.EventHandler(this.cmdModify_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdBack.Location = new System.Drawing.Point(12, 478);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(73, 27);
            this.cmdBack.TabIndex = 1;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNote.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNote.Location = new System.Drawing.Point(12, 23);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(1025, 253);
            this.txtNote.TabIndex = 0;
            this.txtNote.Text = "";
            // 
            // OpenFullNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OpenFullNoteForm";
            this.Text = "Create Notes";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.RichTextBox txtNote;
    }
}