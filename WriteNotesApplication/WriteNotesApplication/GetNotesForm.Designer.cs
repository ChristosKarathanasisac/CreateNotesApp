
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetNotesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.NOTE_DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_CREATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_LASTMODIFY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.pictureBox1);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1472, 917);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WriteNotesApplication.Properties.Resources.findNotes;
            this.pictureBox1.Location = new System.Drawing.Point(16, 293);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cmdDeleteNote
            // 
            this.cmdDeleteNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdDeleteNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeleteNote.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdDeleteNote.Location = new System.Drawing.Point(1209, 341);
            this.cmdDeleteNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDeleteNote.Name = "cmdDeleteNote";
            this.cmdDeleteNote.Size = new System.Drawing.Size(179, 39);
            this.cmdDeleteNote.TabIndex = 20;
            this.cmdDeleteNote.Text = "Delete Note";
            this.cmdDeleteNote.UseVisualStyleBackColor = false;
            this.cmdDeleteNote.Click += new System.EventHandler(this.cmdDeleteNote_Click);
            // 
            // cmdOpenNote
            // 
            this.cmdOpenNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdOpenNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdOpenNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOpenNote.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdOpenNote.Location = new System.Drawing.Point(825, 341);
            this.cmdOpenNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdOpenNote.Name = "cmdOpenNote";
            this.cmdOpenNote.Size = new System.Drawing.Size(196, 39);
            this.cmdOpenNote.TabIndex = 19;
            this.cmdOpenNote.Text = "Open Full Note";
            this.cmdOpenNote.UseVisualStyleBackColor = false;
            this.cmdOpenNote.Click += new System.EventHandler(this.cmdOpenNote_Click);
            // 
            // cmdModifyNote
            // 
            this.cmdModifyNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdModifyNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdModifyNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModifyNote.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdModifyNote.Location = new System.Drawing.Point(1027, 341);
            this.cmdModifyNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdModifyNote.Name = "cmdModifyNote";
            this.cmdModifyNote.Size = new System.Drawing.Size(175, 39);
            this.cmdModifyNote.TabIndex = 18;
            this.cmdModifyNote.Text = "Modify Note";
            this.cmdModifyNote.UseVisualStyleBackColor = false;
            this.cmdModifyNote.Click += new System.EventHandler(this.cmdModifyNote_Click);
            // 
            // dateTimePickerToDateM
            // 
            this.dateTimePickerToDateM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerToDateM.Font = new System.Drawing.Font("Segoe Print", 8.8F, System.Drawing.FontStyle.Italic);
            this.dateTimePickerToDateM.Location = new System.Drawing.Point(1011, 709);
            this.dateTimePickerToDateM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerToDateM.Name = "dateTimePickerToDateM";
            this.dateTimePickerToDateM.Size = new System.Drawing.Size(388, 33);
            this.dateTimePickerToDateM.TabIndex = 17;
            // 
            // dateTimePickerFromDateM
            // 
            this.dateTimePickerFromDateM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerFromDateM.Font = new System.Drawing.Font("Segoe Print", 8.8F, System.Drawing.FontStyle.Italic);
            this.dateTimePickerFromDateM.Location = new System.Drawing.Point(1011, 674);
            this.dateTimePickerFromDateM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFromDateM.Name = "dateTimePickerFromDateM";
            this.dateTimePickerFromDateM.Size = new System.Drawing.Size(388, 33);
            this.dateTimePickerFromDateM.TabIndex = 16;
            this.dateTimePickerFromDateM.Value = new System.DateTime(2022, 9, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(900, 709);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "To Date:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(892, 679);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "From Date:";
            // 
            // cmdFilterDateM
            // 
            this.cmdFilterDateM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdFilterDateM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdFilterDateM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFilterDateM.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdFilterDateM.Location = new System.Drawing.Point(552, 679);
            this.cmdFilterDateM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdFilterDateM.Name = "cmdFilterDateM";
            this.cmdFilterDateM.Size = new System.Drawing.Size(321, 53);
            this.cmdFilterDateM.TabIndex = 13;
            this.cmdFilterDateM.Text = "Filter With Last Modify Date";
            this.cmdFilterDateM.UseVisualStyleBackColor = false;
            this.cmdFilterDateM.Click += new System.EventHandler(this.cmdFilterDateM_Click);
            // 
            // cmdFilterText
            // 
            this.cmdFilterText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdFilterText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdFilterText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFilterText.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdFilterText.Location = new System.Drawing.Point(552, 448);
            this.cmdFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdFilterText.Name = "cmdFilterText";
            this.cmdFilterText.Size = new System.Drawing.Size(232, 49);
            this.cmdFilterText.TabIndex = 11;
            this.cmdFilterText.Text = "Filter With Text:";
            this.cmdFilterText.UseVisualStyleBackColor = false;
            this.cmdFilterText.Click += new System.EventHandler(this.cmdFilterText_Click);
            // 
            // dateTimePickerToDateC
            // 
            this.dateTimePickerToDateC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerToDateC.Font = new System.Drawing.Font("Segoe Print", 8.8F, System.Drawing.FontStyle.Italic);
            this.dateTimePickerToDateC.Location = new System.Drawing.Point(1008, 601);
            this.dateTimePickerToDateC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerToDateC.Name = "dateTimePickerToDateC";
            this.dateTimePickerToDateC.Size = new System.Drawing.Size(388, 33);
            this.dateTimePickerToDateC.TabIndex = 10;
            // 
            // dateTimePickerFromDateC
            // 
            this.dateTimePickerFromDateC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerFromDateC.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePickerFromDateC.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePickerFromDateC.Font = new System.Drawing.Font("Segoe Print", 8.8F, System.Drawing.FontStyle.Italic);
            this.dateTimePickerFromDateC.Location = new System.Drawing.Point(1008, 566);
            this.dateTimePickerFromDateC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFromDateC.Name = "dateTimePickerFromDateC";
            this.dateTimePickerFromDateC.Size = new System.Drawing.Size(388, 33);
            this.dateTimePickerFromDateC.TabIndex = 9;
            this.dateTimePickerFromDateC.Value = new System.DateTime(2022, 9, 5, 0, 0, 0, 0);
            // 
            // lblToDate
            // 
            this.lblToDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.lblToDate.Location = new System.Drawing.Point(892, 601);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(87, 30);
            this.lblToDate.TabIndex = 8;
            this.lblToDate.Text = "To Date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            this.lblFromDate.Location = new System.Drawing.Point(880, 571);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(112, 30);
            this.lblFromDate.TabIndex = 7;
            this.lblFromDate.Text = "From Date:";
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic);
            this.cmdBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdBack.Location = new System.Drawing.Point(21, 841);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(80, 41);
            this.cmdBack.TabIndex = 4;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdFilterDateC
            // 
            this.cmdFilterDateC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdFilterDateC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdFilterDateC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFilterDateC.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdFilterDateC.Location = new System.Drawing.Point(552, 571);
            this.cmdFilterDateC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdFilterDateC.Name = "cmdFilterDateC";
            this.cmdFilterDateC.Size = new System.Drawing.Size(304, 47);
            this.cmdFilterDateC.TabIndex = 3;
            this.cmdFilterDateC.Text = "Filter With Creation Date";
            this.cmdFilterDateC.UseVisualStyleBackColor = false;
            this.cmdFilterDateC.Click += new System.EventHandler(this.cmdFilterDate_Click);
            // 
            // textFilterNote
            // 
            this.textFilterNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFilterNote.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.textFilterNote.Location = new System.Drawing.Point(789, 458);
            this.textFilterNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFilterNote.Name = "textFilterNote";
            this.textFilterNote.Size = new System.Drawing.Size(361, 32);
            this.textFilterNote.TabIndex = 2;
            // 
            // cmdGetAllNotes
            // 
            this.cmdGetAllNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdGetAllNotes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdGetAllNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGetAllNotes.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic);
            this.cmdGetAllNotes.Location = new System.Drawing.Point(552, 337);
            this.cmdGetAllNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdGetAllNotes.Name = "cmdGetAllNotes";
            this.cmdGetAllNotes.Size = new System.Drawing.Size(183, 47);
            this.cmdGetAllNotes.TabIndex = 1;
            this.cmdGetAllNotes.Text = "Get All notes";
            this.cmdGetAllNotes.UseVisualStyleBackColor = false;
            this.cmdGetAllNotes.Click += new System.EventHandler(this.cmdGetAllNotes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOTE_DESCRIPTION,
            this.NOTE_CREATION,
            this.NOTE_LASTMODIFY,
            this.NOTE,
            this.NOTE_ID});
            this.dataGridView1.DataSource = this.bindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(21, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Print", 9.8F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1385, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // NOTE_DESCRIPTION
            // 
            this.NOTE_DESCRIPTION.DataPropertyName = "NOTE_DESCRIPTION";
            this.NOTE_DESCRIPTION.HeaderText = "NOTE TOPIC";
            this.NOTE_DESCRIPTION.MinimumWidth = 6;
            this.NOTE_DESCRIPTION.Name = "NOTE_DESCRIPTION";
            this.NOTE_DESCRIPTION.ReadOnly = true;
            this.NOTE_DESCRIPTION.Width = 300;
            // 
            // NOTE_CREATION
            // 
            this.NOTE_CREATION.DataPropertyName = "NOTE_CREATION";
            this.NOTE_CREATION.HeaderText = "CREATED AT";
            this.NOTE_CREATION.MinimumWidth = 6;
            this.NOTE_CREATION.Name = "NOTE_CREATION";
            this.NOTE_CREATION.ReadOnly = true;
            this.NOTE_CREATION.Width = 145;
            // 
            // NOTE_LASTMODIFY
            // 
            this.NOTE_LASTMODIFY.DataPropertyName = "NOTE_LASTMODIFY";
            this.NOTE_LASTMODIFY.HeaderText = "MODIFIED AT";
            this.NOTE_LASTMODIFY.MinimumWidth = 6;
            this.NOTE_LASTMODIFY.Name = "NOTE_LASTMODIFY";
            this.NOTE_LASTMODIFY.ReadOnly = true;
            this.NOTE_LASTMODIFY.Width = 145;
            // 
            // NOTE
            // 
            this.NOTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NOTE.DataPropertyName = "NOTE";
            this.NOTE.HeaderText = "NOTE";
            this.NOTE.MinimumWidth = 6;
            this.NOTE.Name = "NOTE";
            this.NOTE.ReadOnly = true;
            this.NOTE.Width = 395;
            // 
            // NOTE_ID
            // 
            this.NOTE_ID.DataPropertyName = "NOTE_ID";
            this.NOTE_ID.HeaderText = "NOTE_ID";
            this.NOTE_ID.MinimumWidth = 6;
            this.NOTE_ID.Name = "NOTE_ID";
            this.NOTE_ID.ReadOnly = true;
            this.NOTE_ID.Visible = false;
            this.NOTE_ID.Width = 385;
            // 
            // GetNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1421, 895);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smart. note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetNotesForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button cmdDeleteNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_CREATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_LASTMODIFY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_ID;
    }
}