using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class EditEmployeeForm : Form
    {
        public EmployeeModel employeeModel { get; set; }
        private bool changeEmployeeImage = false;
        private byte[] image;

        public String Username = "N/A"; 
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            setEmployee(employeeModel);
        }
        private void setEmployee(EmployeeModel employeeModel)
        {
            string connectionString = DatabaseHelper.getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                       @"
                        SELECT * FROM Employee
                        WHERE Id = @Id";

                    command.Parameters.AddWithValue("@Id", employeeModel.Id);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = reader.GetInt32("Id");
                        string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                        string contactNumber = reader.GetString(reader.GetOrdinal("ContactNumber"));
                        string startedWorking = reader.GetString(reader.GetOrdinal("StartedWorking"));
                        byte[] byteBLOBData = (byte[])reader["Image"];


                        // set image to picture box
                        using (MemoryStream ms = new MemoryStream(byteBLOBData))
                        {

                            employeeImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
                        }
                        // convert the string
                        string format = "MM/dd/yyyy hh:mm:ss tt";
                        // Convert the string to DateTime
                        DateTime parsedDate;
                        if (DateTime.TryParseExact(startedWorking, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
                        {
                            // Set the DateTimePicker value to the parsed date
                            dateTimePicker1.Value = parsedDate;
                        }

                        // set the information to the fields
                        firstNameTextBox.Text = firstName;
                        lastNameTextBox.Text = lastName;
                        contactNumberTextBox.Text = contactNumber;

                        // priceTextBox.Text = price.ToString();
                        //quantityTextBox.Text = quantity.ToString();

                        reader.Close();
                    }
                }
            }
        }

        private byte[] getSavedImage()
        {
            MemoryStream ms = new MemoryStream();
            employeeImagePictureBox.Image.Save(ms, employeeImagePictureBox.Image.RawFormat);
            image = ms.ToArray();
            return image;
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                employeeImagePictureBox.Image = new Bitmap(openFileDialog.FileName);
                changeEmployeeImage = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // check if valid firstname last name and contactnumber

            string namePattern = @"^[a-z]{3,15}$";
            string contactPattern = @"^09\d{9}$";
            bool isValidFName = false;
            bool isValidLName = false;
            bool isValidContact = false;
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
            if (DatabaseHelper.isEmployeeExisting($"{firstNameTextBox.Text}.{lastNameTextBox.Text}".ToLower()) >= 1)
            {
                MessageBox.Show("Employee already exist.");
           
                return;
            }
            string startedWorking = dateTimePicker1.Value.ToString();
            if (isValidLName && isValidFName && isValidContact)
            {
                if (changeEmployeeImage == false)
                {

                    DatabaseHelper.EditEmployeeNoImage(firstNameTextBox.Text, lastNameTextBox.Text, contactNumberTextBox.Text, startedWorking, employeeModel.Id);
                    DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Edited an employee detail  ");
                }
                else
                {
                    DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Edited an employee detail  ");

                    DatabaseHelper.EditEmployee(firstNameTextBox.Text, lastNameTextBox.Text, contactNumberTextBox.Text, startedWorking, getSavedImage(), employeeModel.Id);
               
                }
                MessageBox.Show("Employee successfully edited");
            }
            else
            {
                MessageBox.Show("Make sure that the rules is followed.");
            }


            this.Close();
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Deleted an employee");
            DatabaseHelper.DeleteEmployee(employeeModel.Id);
            // delete also in the password history and credentials
            MessageBox.Show("Employee Deleted");
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
    }
}
