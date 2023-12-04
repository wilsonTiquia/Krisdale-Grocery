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

namespace Krisdale_Grocery.Views.LogIn
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = EncryptionService.ComputeSha256Hash(userNameTextBox.Text);
            string password = EncryptionService.ComputeSha256Hash(passwordTextBox.Text);


            if (DatabaseHelper.isAccountExisting(username,password) == 0)
            {

                MessageBox.Show("Error account does not exist");
            }
            else if(DatabaseHelper.isAccountExisting(username, password) == 1) 
            {
                MessageBox.Show("Account Exist. Redirecting you to the Main page");
            }
            else
            {
                MessageBox.Show("Unknown Error");
            }

        }
    }
}
