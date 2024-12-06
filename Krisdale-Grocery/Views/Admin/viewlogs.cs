using Krisdale_Grocery.DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class viewlogs : Form
    {
        public viewlogs()
        {
            InitializeComponent();
        }

        private void viewlogs_Load(object sender, EventArgs e)
        {
            DisplayLogsInListBox();

        }
        public void DisplayLogsInListBox()
        {
            List<string> logs = DatabaseHelper.GetAllLogsAsString();

            // Add each log entry to the ListBox
            foreach (string log in logs)
            {
                listBox1.Items.Add(log);
            }
        }
    }
}
