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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Krisdale_Grocery.Views.LogIn
{
    public partial class LogInForm : Form
    {
        int maxAttempts = 5;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = EncryptionService.ComputeSha256Hash(passwordTextBox.Text);
            //string password = passwordTextBox.Text;

            // first check if empty
            if (userNameTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please fill both username and password");
                return;
            }
            // first check if attempts 

            // check if account exist in employee
            if (DatabaseHelper.GetNumberOfAttemptsEmployee(username) > maxAttempts)
            {
                string result = DatabaseHelper.GetTimeoutAccess(username);

                // Parse the result string into a DateTime object
                DateTime timeoutTime;
                if (DateTime.TryParse(result, out timeoutTime))
                {
                    // Compare the timeout time with the current time
                    if (timeoutTime < DateTime.Now)
                    {
                        MessageBox.Show("Account is unlocked, you can try again.");
                        DatabaseHelper.DeleteUserIfTimeoutExpired(username);
                        DatabaseHelper.InsertLog(username, DateTime.Now, "Attempted to log in the username " + username);
                    }
                    else
                    {
                        // Account is still locked
                        MessageBox.Show("Account is locked. Try again later.");
                        DatabaseHelper.InsertLog(username, DateTime.Now, "Attempted to log in while account is locked " + username);

                    }
                }
                else
                {
                    // Handle invalid date format
                    MessageBox.Show("Error: Unable to parse timeout date.");
                  
                }

            }
            // if incorrect
            else if (DatabaseHelper.isEmployeeExisting(username) == 1 && DatabaseHelper.isAccountExisting(username, password) == 0)
            {
               
                // check first if the user exist in the Timeout; if not add it. If it is update the attempts column
             
                if (DatabaseHelper.GetNumberOfAttemptsEmployee(username)  == maxAttempts)
                {

                    // update the database with time now + 5 minutes;
                    DatabaseHelper.InsertLog(username, DateTime.Now, "Attempted to log in the username " + username);
                    DatabaseHelper.UpdateTimeoutAccess(username);
                    DatabaseHelper.CheckOrUpdateTimeout(username);
                    
                }
                else
                {
                    DatabaseHelper.CheckOrUpdateTimeout(username);
                    DatabaseHelper.InsertLog(username, DateTime.Now, "Attempted to log in the username " + username);
                }
                MessageBox.Show("Invalid username or password");
            }

            else if (DatabaseHelper.isAdminAccountExisting(username) == 1 && DatabaseHelper.isAdminAccountExistingPass(username, password) == 0)
            {
                if (DatabaseHelper.GetNumberOfAttemptsEmployee(username) == maxAttempts)
                {

                    // update the database with time now + 5 minutes;
                    DatabaseHelper.InsertLog(username, DateTime.Now, "Attempted to log in ADMIN " + username);
                    DatabaseHelper.UpdateTimeoutAccess(username);
                    DatabaseHelper.CheckOrUpdateTimeout(username);

                }
                else
                {
                    DatabaseHelper.CheckOrUpdateTimeout(username);
                    DatabaseHelper.InsertLog(username, DateTime.Now, "Attempted to log in ADMIN " + username);

                }
                MessageBox.Show("Invalid username or password");
            }
            else if (DatabaseHelper.isAdminAccountExistingPass(username, password) == 1)
            {
                DatabaseHelper.InsertLog(username, DateTime.Now, "Admin Log in " + username);
                DatabaseHelper.DeleteUserIfTimeoutExpired(username);
                // check if existing in admin
                MessageBox.Show("Redirecting you to the Admin page");

                DashBoardForm dashBoardForm = new DashBoardForm();
                dashBoardForm.UsernameLoggedIn = username;
                dashBoardForm.ShowDialog();

                this.Hide();
                this.Show();
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;

            }
            // check if account exist in employee and logged in success
            else if (DatabaseHelper.isAccountExisting(username, password) == 1)
            {
                DatabaseHelper.InsertLog(username, DateTime.Now, "Employee Log In " + username);
                DatabaseHelper.DeleteUserIfTimeoutExpired(username);
                // check if existing in employee
                MessageBox.Show("Redirecting you to the Main page");

                MainForm mainform = new MainForm();
                mainform.UsernameInUse = username;
                mainform.ShowDialog();
               

                this.Hide();
                this.Show();

                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
            // if incorrect username or incorrect password
          

            // incorrect username or password

            else
            {
                // first check if it is a user in employee or admin
                DatabaseHelper.InsertLog("N/A", DateTime.Now, "Attempted to log in with non existing account " + username);
                //
                MessageBox.Show("Invalid username or password");
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;

            }
            userNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
         

        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            bool isUsernameExist = false;
            bool isSecurityKeyValid = false;
            // check first if valid username and the security key exist
            if (DatabaseHelper.isAdminAccountExisting(usernameSecurity.Text.ToLower()) >= 1)
            {
                isUsernameExist = true;
            }
            if (DatabaseHelper.isAdminAccountSecurityKeyValid(usernameSecurity.Text.ToLower(), EncryptionService.ComputeSha256Hash(securityKeyTextBox.Text)) >= 1)
            {
                isSecurityKeyValid = true;
            }

            // check if it is in the employee
            if (isUsernameExist && isSecurityKeyValid) { 
            
                popUpForm popUpForm = new popUpForm();
                popUpForm.Username = usernameSecurity.Text;
                popUpForm.ShowDialog();
            }
            else
            {
                DatabaseHelper.InsertLog("N/A", DateTime.Now, "Attempted to change password " + usernameSecurity.Text);
                MessageBox.Show("Username or security code is incorrect");
               
            }


            usernameSecurity.Text = string.Empty;
            securityKeyTextBox.Text = string.Empty;
            userNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;

        }
    }
}
