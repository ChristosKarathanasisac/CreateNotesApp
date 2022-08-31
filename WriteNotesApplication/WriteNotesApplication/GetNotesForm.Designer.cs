
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
            this.dateTimePickerFromDateC = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdFilterDate = new System.Windows.Forms.Button();
            this.textFilterNote = new System.Windows.Forms.TextBox();
            this.cmdGetAllNotes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerToDateC = new System.Windows.Forms.DateTimePicker();
            this.cmdFilterText = new System.Windows.Forms.Button();
            this.cmbFilterDateText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateM = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDateM = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerToDateM);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDateM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbFilterDateText);
            this.groupBox1.Controls.Add(this.cmdFilterText);
            this.groupBox1.Controls.Add(this.dateTimePickerToDateC);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDateC);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Controls.Add(this.lblFromDate);
            this.groupBox1.Controls.Add(this.cmdBack);
            this.groupBox1.Controls.Add(this.cmdFilterDate);
            this.groupBox1.Controls.Add(this.textFilterNote);
            this.groupBox1.Controls.Add(this.cmdGetAllNotes);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(809, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerFromDateC
            // 
            this.dateTimePickerFromDateC.Location = new System.Drawing.Point(268, 329);
            this.dateTimePickerFromDateC.Name = "dateTimePickerFromDateC";
            this.dateTimePickerFromDateC.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerFromDateC.TabIndex = 9;
            this.dateTimePickerFromDateC.Value = new System.DateTime(2022, 8, 31, 13, 24, 29, 0);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblToDate.Location = new System.Drawing.Point(488, 333);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(60, 16);
            this.lblToDate.TabIndex = 8;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblFromDate.Location = new System.Drawing.Point(188, 333);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(74, 16);
            this.lblFromDate.TabIndex = 7;
            this.lblFromDate.Text = "From Date:";
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(11, 502);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(42, 24);
            this.cmdBack.TabIndex = 4;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdFilterDate
            // 
            this.cmdFilterDate.Location = new System.Drawing.Point(11, 321);
            this.cmdFilterDate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFilterDate.Name = "cmdFilterDate";
            this.cmdFilterDate.Size = new System.Drawing.Size(137, 40);
            this.cmdFilterDate.TabIndex = 3;
            this.cmdFilterDate.Text = "Filter With Creation Date";
            this.cmdFilterDate.UseVisualStyleBackColor = true;
            this.cmdFilterDate.Click += new System.EventHandler(this.cmdFilterDate_Click);
            // 
            // textFilterNote
            // 
            this.textFilterNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textFilterNote.Location = new System.Drawing.Point(160, 416);
            this.textFilterNote.Margin = new System.Windows.Forms.Padding(2);
            this.textFilterNote.Name = "textFilterNote";
            this.textFilterNote.Size = new System.Drawing.Size(271, 21);
            this.textFilterNote.TabIndex = 2;
            // 
            // cmdGetAllNotes
            // 
            this.cmdGetAllNotes.Location = new System.Drawing.Point(11, 279);
            this.cmdGetAllNotes.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGetAllNotes.Name = "cmdGetAllNotes";
            this.cmdGetAllNotes.Size = new System.Drawing.Size(137, 38);
            this.cmdGetAllNotes.TabIndex = 1;
            this.cmdGetAllNotes.Text = "Get All notes";
            this.cmdGetAllNotes.UseVisualStyleBackColor = true;
            this.cmdGetAllNotes.Click += new System.EventHandler(this.cmdGetAllNotes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePickerToDateC
            // 
            this.dateTimePickerToDateC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dateTimePickerToDateC.Location = new System.Drawing.Point(554, 328);
            this.dateTimePickerToDateC.Name = "dateTimePickerToDateC";
            this.dateTimePickerToDateC.Size = new System.Drawing.Size(235, 21);
            this.dateTimePickerToDateC.TabIndex = 10;
            // 
            // cmdFilterText
            // 
            this.cmdFilterText.Location = new System.Drawing.Point(11, 407);
            this.cmdFilterText.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFilterText.Name = "cmdFilterText";
            this.cmdFilterText.Size = new System.Drawing.Size(137, 40);
            this.cmdFilterText.TabIndex = 11;
            this.cmdFilterText.Text = "Filter With Text";
            this.cmdFilterText.UseVisualStyleBackColor = true;
            // 
            // cmbFilterDateText
            // 
            this.cmbFilterDateText.Location = new System.Drawing.Point(162, 457);
            this.cmbFilterDateText.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilterDateText.Name = "cmbFilterDateText";
            this.cmbFilterDateText.Size = new System.Drawing.Size(147, 40);
            this.cmbFilterDateText.TabIndex = 12;
            this.cmbFilterDateText.Text = "Filter With Date and Text";
            this.cmbFilterDateText.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Filter With Last Modify Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(188, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "From Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(488, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "To Date:";
            // 
            // dateTimePickerFromDateM
            // 
            this.dateTimePickerFromDateM.Location = new System.Drawing.Point(268, 373);
            this.dateTimePickerFromDateM.Name = "dateTimePickerFromDateM";
            this.dateTimePickerFromDateM.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerFromDateM.TabIndex = 16;
            this.dateTimePickerFromDateM.Value = new System.DateTime(2022, 8, 31, 13, 24, 29, 0);
            // 
            // dateTimePickerToDateM
            // 
            this.dateTimePickerToDateM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dateTimePickerToDateM.Location = new System.Drawing.Point(554, 373);
            this.dateTimePickerToDateM.Name = "dateTimePickerToDateM";
            this.dateTimePickerToDateM.Size = new System.Drawing.Size(235, 21);
            this.dateTimePickerToDateM.TabIndex = 17;
            // 
            // GetNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdFilterDate;
        private System.Windows.Forms.TextBox textFilterNote;
        private System.Windows.Forms.Button cmdGetAllNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateC;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDateC;
        private System.Windows.Forms.Button cmbFilterDateText;
        private System.Windows.Forms.Button cmdFilterText;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDateM;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}