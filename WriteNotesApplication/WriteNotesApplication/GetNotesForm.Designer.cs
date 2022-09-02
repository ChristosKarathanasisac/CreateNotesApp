
namespace WriteNotesApplication
{
    partial class GetNotesForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDeleteNote = new System.Windows.Forms.Button();
            this.cmdOpenNote = new System.Windows.Forms.Button();
            this.cmdModifyNote = new System.Windows.Forms.Button();
            this.dateTimePickerToDateM = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDateM = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFilterDateM = new System.Windows.Forms.Button();
            this.cmdFilterText = new System.Windows.Forms.Button();
            this.dateTimePickerToDateC = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDateC = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdFilterDateC = new System.Windows.Forms.Button();
            this.textFilterNote = new System.Windows.Forms.TextBox();
            this.cmdGetAllNotes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_CREATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_LASTMODIFY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.cmdDeleteNote);
            this.groupBox1.Controls.Add(this.cmdOpenNote);
            this.groupBox1.Controls.Add(this.cmdModifyNote);
            this.groupBox1.Controls.Add(this.dateTimePickerToDateM);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDateM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdFilterDateM);
            this.groupBox1.Controls.Add(this.cmdFilterText);
            this.groupBox1.Controls.Add(this.dateTimePickerToDateC);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDateC);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Controls.Add(this.lblFromDate);
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.cmdFilterDateC);
            this.groupBox1.Controls.Add(this.textFilterNote);
            this.groupBox1.Controls.Add(this.cmdGetAllNotes);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(810, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdDeleteNote
            // 
            this.cmdDeleteNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdDeleteNote.Location = new System.Drawing.Point(637, 285);
            this.cmdDeleteNote.Name = "cmdDeleteNote";
            this.cmdDeleteNote.Size = new System.Drawing.Size(124, 32);
            this.cmdDeleteNote.TabIndex = 20;
            this.cmdDeleteNote.Text = "Delete Note";
            this.cmdDeleteNote.UseVisualStyleBackColor = false;
            this.cmdDeleteNote.Click += new System.EventHandler(this.cmdDeleteNote_Click);
            // 
            // cmdOpenNote
            // 
            this.cmdOpenNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdOpenNote.Location = new System.Drawing.Point(385, 285);
            this.cmdOpenNote.Name = "cmdOpenNote";
            this.cmdOpenNote.Size = new System.Drawing.Size(120, 32);
            this.cmdOpenNote.TabIndex = 19;
            this.cmdOpenNote.Text = "Open Full Note";
            this.cmdOpenNote.UseVisualStyleBackColor = false;
            this.cmdOpenNote.Click += new System.EventHandler(this.cmdOpenNote_Click);
            // 
            // cmdModifyNote
            // 
            this.cmdModifyNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdModifyNote.Location = new System.Drawing.Point(511, 285);
            this.cmdModifyNote.Name = "cmdModifyNote";
            this.cmdModifyNote.Size = new System.Drawing.Size(120, 32);
            this.cmdModifyNote.TabIndex = 18;
            this.cmdModifyNote.Text = "Modify Note";
            this.cmdModifyNote.UseVisualStyleBackColor = false;
            this.cmdModifyNote.Click += new System.EventHandler(this.cmdModifyNote_Click);
            // 
            // dateTimePickerToDateM
            // 
            this.dateTimePickerToDateM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerToDateM.Location = new System.Drawing.Point(538, 404);
            this.dateTimePickerToDateM.Name = "dateTimePickerToDateM";
            this.dateTimePickerToDateM.Size = new System.Drawing.Size(267, 23);
            this.dateTimePickerToDateM.TabIndex = 17;
            // 
            // dateTimePickerFromDateM
            // 
            this.dateTimePickerFromDateM.Location = new System.Drawing.Point(209, 405);
            this.dateTimePickerFromDateM.Name = "dateTimePickerFromDateM";
            this.dateTimePickerFromDateM.Size = new System.Drawing.Size(259, 23);
            this.dateTimePickerFromDateM.TabIndex = 16;
            this.dateTimePickerFromDateM.Value = new System.DateTime(2022, 9, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(474, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "To Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(134, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "From Date:";
            // 
            // cmdFilterDateM
            // 
            this.cmdFilterDateM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdFilterDateM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdFilterDateM.Location = new System.Drawing.Point(11, 385);
            this.cmdFilterDateM.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFilterDateM.Name = "cmdFilterDateM";
            this.cmdFilterDateM.Size = new System.Drawing.Size(118, 69);
            this.cmdFilterDateM.TabIndex = 13;
            this.cmdFilterDateM.Text = "Filter With Last Modify Date";
            this.cmdFilterDateM.UseVisualStyleBackColor = false;
            this.cmdFilterDateM.Click += new System.EventHandler(this.cmdFilterDateM_Click);
            // 
            // cmdFilterText
            // 
            this.cmdFilterText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdFilterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdFilterText.Location = new System.Drawing.Point(11, 458);
            this.cmdFilterText.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFilterText.Name = "cmdFilterText";
            this.cmdFilterText.Size = new System.Drawing.Size(137, 40);
            this.cmdFilterText.TabIndex = 11;
            this.cmdFilterText.Text = "Filter With Text";
            this.cmdFilterText.UseVisualStyleBackColor = false;
            this.cmdFilterText.Click += new System.EventHandler(this.cmdFilterText_Click);
            // 
            // dateTimePickerToDateC
            // 
            this.dateTimePickerToDateC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerToDateC.Location = new System.Drawing.Point(538, 338);
            this.dateTimePickerToDateC.Name = "dateTimePickerToDateC";
            this.dateTimePickerToDateC.Size = new System.Drawing.Size(267, 23);
            this.dateTimePickerToDateC.TabIndex = 10;
            // 
            // dateTimePickerFromDateC
            // 
            this.dateTimePickerFromDateC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerFromDateC.Location = new System.Drawing.Point(209, 338);
            this.dateTimePickerFromDateC.Name = "dateTimePickerFromDateC";
            this.dateTimePickerFromDateC.Size = new System.Drawing.Size(259, 23);
            this.dateTimePickerFromDateC.TabIndex = 9;
            this.dateTimePickerFromDateC.Value = new System.DateTime(2022, 9, 2, 11, 38, 32, 0);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblToDate.Location = new System.Drawing.Point(474, 343);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(63, 17);
            this.lblToDate.TabIndex = 8;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFromDate.Location = new System.Drawing.Point(134, 343);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(78, 17);
            this.lblFromDate.TabIndex = 7;
            this.lblFromDate.Text = "From Date:";
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(11, 513);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(50, 24);
            this.cmdBack.TabIndex = 4;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdFilterDateC
            // 
            this.cmdFilterDateC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdFilterDateC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdFilterDateC.Location = new System.Drawing.Point(11, 321);
            this.cmdFilterDateC.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFilterDateC.Name = "cmdFilterDateC";
            this.cmdFilterDateC.Size = new System.Drawing.Size(118, 60);
            this.cmdFilterDateC.TabIndex = 3;
            this.cmdFilterDateC.Text = "Filter With Creation Date";
            this.cmdFilterDateC.UseVisualStyleBackColor = false;
            this.cmdFilterDateC.Click += new System.EventHandler(this.cmdFilterDate_Click);
            // 
            // textFilterNote
            // 
            this.textFilterNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textFilterNote.Location = new System.Drawing.Point(152, 468);
            this.textFilterNote.Margin = new System.Windows.Forms.Padding(2);
            this.textFilterNote.Name = "textFilterNote";
            this.textFilterNote.Size = new System.Drawing.Size(271, 21);
            this.textFilterNote.TabIndex = 2;
            // 
            // cmdGetAllNotes
            // 
            this.cmdGetAllNotes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmdGetAllNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdGetAllNotes.Location = new System.Drawing.Point(11, 279);
            this.cmdGetAllNotes.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGetAllNotes.Name = "cmdGetAllNotes";
            this.cmdGetAllNotes.Size = new System.Drawing.Size(137, 38);
            this.cmdGetAllNotes.TabIndex = 1;
            this.cmdGetAllNotes.Text = "Get All notes";
            this.cmdGetAllNotes.UseVisualStyleBackColor = false;
            this.cmdGetAllNotes.Click += new System.EventHandler(this.cmdGetAllNotes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOTE,
            this.NOTE_CREATION,
            this.NOTE_LASTMODIFY,
            this.NOTE_ID});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(11, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // NOTE
            // 
            this.NOTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NOTE.DataPropertyName = "NOTE";
            this.NOTE.HeaderText = "NOTE";
            this.NOTE.MinimumWidth = 6;
            this.NOTE.Name = "NOTE";
            this.NOTE.ReadOnly = true;
            this.NOTE.Width = 539;
            // 
            // NOTE_CREATION
            // 
            this.NOTE_CREATION.DataPropertyName = "NOTE_CREATION";
            this.NOTE_CREATION.HeaderText = "CREATED AT";
            this.NOTE_CREATION.MinimumWidth = 6;
            this.NOTE_CREATION.Name = "NOTE_CREATION";
            this.NOTE_CREATION.ReadOnly = true;
            this.NOTE_CREATION.Width = 125;
            // 
            // NOTE_LASTMODIFY
            // 
            this.NOTE_LASTMODIFY.DataPropertyName = "NOTE_LASTMODIFY";
            this.NOTE_LASTMODIFY.HeaderText = "MODIFIED AT";
            this.NOTE_LASTMODIFY.MinimumWidth = 6;
            this.NOTE_LASTMODIFY.Name = "NOTE_LASTMODIFY";
            this.NOTE_LASTMODIFY.ReadOnly = true;
            this.NOTE_LASTMODIFY.Width = 125;
            // 
            // NOTE_ID
            // 
            this.NOTE_ID.DataPropertyName = "NOTE_ID";
            this.NOTE_ID.HeaderText = "NOTE_ID";
            this.NOTE_ID.MinimumWidth = 6;
            this.NOTE_ID.Name = "NOTE_ID";
            this.NOTE_ID.ReadOnly = true;
            this.NOTE_ID.Visible = false;
            this.NOTE_ID.Width = 125;
            // 
            // GetNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 551);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GetNotesForm";
            this.Text = "Get Your Notes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetNotesForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdFilterDateC;
        private System.Windows.Forms.TextBox textFilterNote;
        private System.Windows.Forms.Button cmdGetAllNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateC;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDateC;
        private System.Windows.Forms.Button cmdFilterText;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDateM;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFilterDateM;
        private System.Windows.Forms.Button cmdModifyNote;
        private System.Windows.Forms.Button cmdOpenNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_CREATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_LASTMODIFY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_ID;
        private System.Windows.Forms.Button cmdDeleteNote;
    }
}