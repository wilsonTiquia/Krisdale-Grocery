using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Employee
{
    public partial class ClockInForm : Form
    {
        public ClockInForm()
        {
            InitializeComponent();
        }

        private void clockInButton_Click(object sender, EventArgs e)
        {
            string username = EncryptionService.ComputeSha256Hash(userNameTextBox.Text);
            string password = EncryptionService.ComputeSha256Hash(passwordTextBox.Text);
            if (DatabaseHelper.isAccountExisting(username, password) == 0)
            {

                MessageBox.Show("Error: Invalid username or password");
            }
            else if (DatabaseHelper.isAccountExisting(username, password) == 1)
            {
                MessageBox.Show("You are now Clocked In!");
                // save to database
                DateTime date = DateTime.Now;
                DatabaseHelper.ClockIn(username, password, date.ToString());
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Unknown Error");
            }

        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClockInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
