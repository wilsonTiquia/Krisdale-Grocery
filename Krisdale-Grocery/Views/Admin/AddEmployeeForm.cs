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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class AddEmployeeForm : Form
    {
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
        private void saveButton_Click(object sender, EventArgs e)
        {
            string startedWorking = dateStartedWorkingPicker.Value.ToString();
            string username = $"{firstNameTextBox.Text}.{lastNameTextBox.Text}";
            string password = $"{firstNameTextBox.Text}.{lastNameTextBox.Text}123";
            string encryptedUsername = EncryptionService.ComputeSha256Hash(username);
            string encryptedPassword = EncryptionService.ComputeSha256Hash(password);
            EncryptionService.ComputeSha256Hash(password);
            DatabaseHelper.AddEmployee(firstNameTextBox.Text, lastNameTextBox.Text, contactNumberTextBox.Text, startedWorking, getImage(), encryptedUsername, encryptedPassword);

            MessageBox.Show("Employee Saved!");
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
    }
}
