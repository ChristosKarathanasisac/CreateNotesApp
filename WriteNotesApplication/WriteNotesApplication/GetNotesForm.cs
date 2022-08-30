using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteNotesApplication
{
    public partial class GetNotesForm : Form
    {
        DatabaseConUtilities databaseConUtilities = new DatabaseConUtilities();
        public GetNotesForm()
        {
            InitializeComponent();
        }

        private void cmdGetAllNotes_Click(object sender, EventArgs e)
        {
            //DataTable dt = databaseConUtilities.getDataTableFromDB();
            //if(dt != null) 
            //{
            //    this.bindingSource1.DataSource = dt;
            //    this.dataGridView1.DataSource = this.bindingSource1;
            //}

            
        }
    }
}
