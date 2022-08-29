
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmdGetAllNotes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdSearch);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmdGetAllNotes);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmdGetAllNotes
            // 
            this.cmdGetAllNotes.Location = new System.Drawing.Point(12, 356);
            this.cmdGetAllNotes.Name = "cmdGetAllNotes";
            this.cmdGetAllNotes.Size = new System.Drawing.Size(88, 23);
            this.cmdGetAllNotes.TabIndex = 1;
            this.cmdGetAllNotes.Text = "All notes";
            this.cmdGetAllNotes.UseVisualStyleBackColor = true;
            this.cmdGetAllNotes.Click += new System.EventHandler(this.cmdGetAllNotes_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 22);
            this.textBox1.TabIndex = 2;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(320, 357);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // GetNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "GetNotesForm";
            this.Text = "Get Your Notes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdGetAllNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}