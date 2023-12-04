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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class EditEmployeeForm : Form
    {
        public EmployeeModel employeeModel { get; set; }
        private bool changeEmployeeImage = false;
        private byte[] image;
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
            string startedWorking = dateTimePicker1.Value.ToString();
            if (changeEmployeeImage == false)
            {

                DatabaseHelper.EditEmployeeNoImage(firstNameTextBox.Text, lastNameTextBox.Text, contactNumberTextBox.Text, startedWorking, employeeModel.Id);
            }
            else
            {

                DatabaseHelper.EditEmployee(firstNameTextBox.Text, lastNameTextBox.Text, contactNumberTextBox.Text, startedWorking, getSavedImage(), employeeModel.Id);
            }
            MessageBox.Show("Employee successfully edited");
            this.Close();
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper.DeleteEmployee(employeeModel.Id);
            MessageBox.Show("Employee Deleted");
            this.Close();
        }
    }
}
