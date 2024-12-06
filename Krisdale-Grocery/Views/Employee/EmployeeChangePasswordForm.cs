using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Employee
{
    public partial class EmployeeChangePasswordForm : Form
    {
        public String UsernameLoggedIn { get; set; }
        public event Action PasswordChangedSuccessfully;
        public EmployeeChangePasswordForm()
        {
            InitializeComponent();
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = EncryptionService.ComputeSha256Hash(passwordTextBox.Text);

            bool isPasswordValid = false;
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{12,15}$";
            if (DatabaseHelper.isAccountExisting(username, password) == 1)
            {
                if (Regex.IsMatch(newPasswordTextBox.Text, pattern))
                {
                    isPasswordValid = true;
                }
                if (isPasswordValid)
                {

                    if (DatabaseHelper.IsPasswordInHistory(username, EncryptionService.ComputeSha256Hash(newPasswordTextBox.Text)))
                    {
                        MessageBox.Show("Can't reuse old passwords");
                    }
                    else
                    {
                        DatabaseHelper.InsertLog(username, DateTime.Now, "Successfully changed a product ");
                        DatabaseHelper.ChangeEmployeeAccountPassword(username, password, EncryptionService.ComputeSha256Hash(newPasswordTextBox.Text));
                        MessageBox.Show("Password Successfully Changed");
                        PasswordChangedSuccessfully?.Invoke();
                        this.Close();

                        passwordTextBox.Text = String.Empty;
                        newPasswordTextBox.Text = string.Empty;

                    }
                   
                 
                }
                else
                {
                    MessageBox.Show("The password must be valid. It must follow all the rules.");
                  
                    passwordTextBox.Text = String.Empty;
                    newPasswordTextBox.Text = string.Empty;
                }
                // allow to change pass

            }
            else
            {
           
                MessageBox.Show("Username or password is incorrect!");
                DatabaseHelper.InsertLog(usernameTextBox.Text, DateTime.Now, "Tried to change the password failed ");
                passwordTextBox.Text = String.Empty;
                newPasswordTextBox.Text = string.Empty;
            }
        }

        private void EmployeeChangePasswordForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = this.UsernameLoggedIn;
        }

        private void newPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{12,15}$";
            if (Regex.IsMatch(newPasswordTextBox.Text, pattern))
            {
                passwordRulesLabel.Visible = false;

            }
            else
            {
                passwordRulesLabel.Visible = true;
            }
        }
    }
}
