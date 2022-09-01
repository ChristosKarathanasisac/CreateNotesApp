
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModifyNote = new System.Windows.Forms.RichTextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtModifyNote);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify your Note";
            // 
            // txtModifyNote
            // 
            this.txtModifyNote.Location = new System.Drawing.Point(6, 19);
            this.txtModifyNote.Name = "txtModifyNote";
            this.txtModifyNote.Size = new System.Drawing.Size(813, 228);
            this.txtModifyNote.TabIndex = 0;
            this.txtModifyNote.Text = "";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(6, 253);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(6, 314);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(54, 20);
            this.cmdBack.TabIndex = 2;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // ModifyNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 362);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyNotesForm";
            this.Text = "ModifyNotesForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.RichTextBox txtModifyNote;
    }
}