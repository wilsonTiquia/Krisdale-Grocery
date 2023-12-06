using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Service;
using Krisdale_Grocery.Views.Admin;
using Krisdale_Grocery.Views.Employee;
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


          
            if (DatabaseHelper.isAdminAccountExistingPass(username,password) == 1)
            {
                // check if existing in admin
                MessageBox.Show("Account Exist. Redirecting you to the Admin page");

                DashBoardForm dashBoardForm = new DashBoardForm();
                dashBoardForm.ShowDialog();

                this.Hide();
                this.Show();
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;

            }
            else if (DatabaseHelper.isAccountExisting(username, password) == 1)
            {
                // check if existing in employee
                MessageBox.Show("Account Exist. Redirecting you to the Main page");

                MainForm mainform = new MainForm();
                mainform.ShowDialog();

                this.Hide();
                this.Show();

                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }

            else if (DatabaseHelper.isAdminAccountExistingPass(username, password) == 0)
            {

                MessageBox.Show("Error: Account does not exist.");
            }

            else
            {
                MessageBox.Show("Unknown Error");
            }

        }
    }
}
