using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteNotesApplication
{
    public partial class CreateNotesForm : Form
    {
       //Να μπορεί να επεξεργαστεί και υπάρχουσες σημειώσεις.
       DatabaseConUtilities dbUtilities = new DatabaseConUtilities();
         
        public CreateNotesForm()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            string note = this.richTextBox1.Text;
            if (string.IsNullOrEmpty(note)) 
            {
                MessageBox.Show("Write a note and try again");
                return;
            }
            if (this.dbUtilities.writeNoteToDB(note)) 
            {
                this.richTextBox1.Clear();
                MessageBox.Show("Your note has added successfully");
                
            }
            else 
            {
                MessageBox.Show("Your note was not registered");
                return;

            }
            

        }
    }
}
