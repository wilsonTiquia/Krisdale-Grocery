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
    public partial class ClockOutForm : Form
    {
        public ClockOutForm()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {
            string username = EncryptionService.ComputeSha256Hash(userNameTextBox.Text);
            string password = EncryptionService.ComputeSha256Hash(passwordTextBox.Text);
            if (DatabaseHelper.isAccountExisting(username, password) == 0)
            {

                MessageBox.Show("Error: Invalid username or password");
                DatabaseHelper.InsertLog(username, DateTime.Now, "Attempted to clock in with incorrect credentials:" + username);
            }
            else if (DatabaseHelper.isAccountExisting(username, password) == 1)
            {
                MessageBox.Show("You are now Clocked Out!");
                // save to database
                DateTime date = DateTime.Now.AddHours(5);
                DatabaseHelper.ClockOut(username, password, date.ToString());
                DatabaseHelper.InsertLog(username, DateTime.Now, "Clock out success at this time:" + username);
                DatabaseHelper.InsertHoursWorked(username, password);
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Unknown Error");
            }
        }
    }
}
