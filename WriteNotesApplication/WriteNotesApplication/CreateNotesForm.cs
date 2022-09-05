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
        private User user;
       DatabaseConUtilities dbUtilities = new DatabaseConUtilities();
         
        public CreateNotesForm(User aUser)
        {
            InitializeComponent();
            this.user = aUser;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string noteTopic = this.txtNoteTopic.Text.Trim();
            if (string.IsNullOrEmpty(noteTopic)) 
            {
                this.txtNoteTopic.BackColor = Color.Red;
                MessageBox.Show("Please add a note topic to continue!");
                return;
            
            }
            if(noteTopic.Length > 40) 
            {
                MessageBox.Show("The Topic is too long");
                this.txtNoteTopic.BackColor = Color.Red;
                return;

            }

            string note = this.richTextBox1.Text;
            if (string.IsNullOrEmpty(note)) 
            {
                MessageBox.Show("Write a note and try again");
                return;
            }
            if (this.dbUtilities.writeNoteToDB(note,noteTopic,user.UserName.ToString())) 
            {
                this.richTextBox1.Clear();
                this.txtNoteTopic.Clear();
                MessageBox.Show("Your note has added successfully");
                
            }
            else 
            {
                MessageBox.Show("Your note was not stored");
                return;

            }
            

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOptionsForm userOptionsForm = new UserOptionsForm(this.user);
            userOptionsForm.ShowDialog();


        }

        private void CreateNotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //UserOptionsForm userOptionsForm = new UserOptionsForm(user);
            //userOptionsForm.ShowDialog();
            Application.Exit();

        
        }

        private void txtNoteTopic_TextChanged(object sender, EventArgs e)
        {
            if(this.txtNoteTopic.BackColor == Color.Red) 
            {
                this.txtNoteTopic.BackColor = Color.White;
            
            }
        }
    }
}
