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
    public partial class EmployeeChangePasswordForm : Form
    {
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
            string username = EncryptionService.ComputeSha256Hash(usernameTextBox.Text);
            string password = EncryptionService.ComputeSha256Hash(passwordTextBox.Text);
            if (DatabaseHelper.isAccountExisting(username, password) == 1)
            {
                // allow to change pass
                DatabaseHelper.ChangeEmployeeAccountPassword(username, password, EncryptionService.ComputeSha256Hash(newPasswordTextBox.Text));
                MessageBox.Show("Password Successfully Changed");
                usernameTextBox.Text = String.Empty;
                passwordTextBox.Text = String.Empty;
                newPasswordTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid account.");
            }
        }
    }
}
