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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Krisdale_Grocery.Views.LogIn
{
    public partial class popUpForm : Form
    {
        public string Username { get; set; }
        public popUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // valid if same password and matches the pattern
            bool isPasswordValid = false;
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{12,15}$";
            if (Regex.IsMatch(passwordTextBox.Text, passwordPattern) && confirmPasswordTextBox.Text == passwordTextBox.Text)
            {
                isPasswordValid = true;
            }
            if (isPasswordValid)
            {
               
                if (DatabaseHelper.IsPasswordInHistory(this.Username, EncryptionService.ComputeSha256Hash(passwordTextBox.Text)))
                {
                    MessageBox.Show("Can't reuse old password");
                }
                else
                {
                    DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Successfully Changed the password of  " + this.Username);
                    DatabaseHelper.ChangeAdminPassword(this.Username, EncryptionService.ComputeSha256Hash(passwordTextBox.Text));
                    MessageBox.Show("Password sucessfully changed!");
                    DatabaseHelper.addPasswordHistory(this.Username, EncryptionService.ComputeSha256Hash(passwordTextBox.Text));

                }

            }
            else
            {
                MessageBox.Show("Please make sure that the password and confirm password matches the rules.");
            }
            this.Close();

        }

        private void popUpForm_Load(object sender, EventArgs e)
        {
            usernamelabel.Text = this.Username;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{12,15}$";
            if (Regex.IsMatch(passwordTextBox.Text, pattern))
            {
                passwordRulesLabel.Visible = false;

            }
            else
            {
                passwordRulesLabel.Visible = true;
            }
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == confirmPasswordTextBox.Text)
            {
                passwordMatchLabel.Visible = false;
            }
            else
            {
                passwordMatchLabel.Visible = true;
            }

        }
    }
}
