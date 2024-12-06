using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class AddEmployeeForm : Form
    {
        public String Username {get; set; }
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedImagePictureBox.Image = new Bitmap(openFileDialog.FileName);
            }

        }
        private byte[] getImage()
        {
            MemoryStream ms = new MemoryStream();
            uploadedImagePictureBox.Image.Save(ms, uploadedImagePictureBox.Image.RawFormat);
            return ms.ToArray();
        }
        static string GenerateRandomPassword(int minLength, int maxLength)
        {
            // Define character pools
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specialChars = "@$!%*?&";

            // Combine all pools
            string allChars = lowercase + uppercase + digits + specialChars;

            Random random = new Random();
            int passwordLength = random.Next(minLength, maxLength + 1);

            // Ensure at least one character from each required pool
            char[] password = new char[passwordLength];
            password[0] = lowercase[random.Next(lowercase.Length)];
            password[1] = uppercase[random.Next(uppercase.Length)];
            password[2] = digits[random.Next(digits.Length)];
            password[3] = specialChars[random.Next(specialChars.Length)];

            // Fill the rest with random characters from all pools
            for (int i = 4; i < passwordLength; i++)
            {
                password[i] = allChars[random.Next(allChars.Length)];
            }

            // Shuffle the array to randomize the order
            password = password.OrderBy(_ => random.Next()).ToArray();

            return new string(password);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // validate username and password

            string startedWorking = dateStartedWorkingPicker.Value.ToString();
            string username = $"{firstNameTextBox.Text}.{lastNameTextBox.Text}".ToLower();
            string password = GenerateRandomPassword(12, 15);

            string namePattern = @"^[a-z]{3,15}$";
            string contactPattern = @"^09\d{9}$";

            bool isValidFName = false;
            bool isValidLName = false;
            bool isValidContact = false;

            string encryptedPassword = EncryptionService.ComputeSha256Hash(password);
            if (DatabaseHelper.isEmployeeExisting(username )>= 1 ){
                MessageBox.Show("Employee already exist.");
                clearAllFields();
                return;
            }
            if (Regex.IsMatch(contactNumberTextBox.Text, contactPattern))
            {
                isValidContact = true;
            }
            if (Regex.IsMatch(firstNameTextBox.Text, namePattern))
            {
                isValidFName = true;
            }
            if (Regex.IsMatch(lastNameTextBox.Text, namePattern))
            {
                isValidLName = true;
            }
           
            if (isValidFName && isValidContact && isValidLName)
            {
                DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Successfully created a new employee the username of  " + username);
                DatabaseHelper.AddEmployee(firstNameTextBox.Text, lastNameTextBox.Text, contactNumberTextBox.Text, startedWorking, getImage(), username, encryptedPassword);
                DatabaseHelper.addPasswordHistory(username, encryptedPassword);
                MessageBox.Show("Employee Saved!");
                MessageBox.Show("Employee Credentials: \nUsername : " + username + "\nPassword: " + password);

            }
      



          
            clearAllFields();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }
        private void clearAllFields()
        {
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            contactNumberTextBox.Text = String.Empty;
            uploadedImagePictureBox.Image = Krisdale_Grocery.Images.blank_picture;
        }

        private void clearImageButton_Click(object sender, EventArgs e)
        {
            uploadedImagePictureBox.Image = Krisdale_Grocery.Images.blank_picture;
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^09\d{9}$";

            if (Regex.IsMatch(contactNumberTextBox.Text, pattern))
            {
                numberRules.Visible = false;
            }
            else
            {
                numberRules.Visible = true;
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string usernamePattern = @"^[a-z]{3,15}$";
            if (Regex.IsMatch(firstNameTextBox.Text, usernamePattern))
            {
                fNameRule.Visible = false;
            }
            else
            {
                fNameRule.Visible = true;
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string usernamePattern = @"^[a-z]{3,15}$";
            if (Regex.IsMatch(lastNameTextBox.Text, usernamePattern))
            {
                lNameRule.Visible = false;
            }
            else
            {
                lNameRule.Visible = true;
            }
        }
    }
}
