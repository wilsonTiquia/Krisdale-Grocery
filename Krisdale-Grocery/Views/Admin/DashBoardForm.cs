using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Service;
using Krisdale_Grocery.Views.Employee;
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
    public partial class DashBoardForm : Form
    {
        private int itemsPerPage = 25; // Number of items per page
        private int currentPage = 1; // Current page
        int numberOfEmployee;
        private int totalRecordsCount;
        public DashBoardForm()
        {
            InitializeComponent();
            InitializeEmployeeCount();
            InitializeEmployee();

            getTotalProducts();
            LoadProducts();

            InitializeAttendance();

        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            mainPanel.Show();

            crudEmployeeLabel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void getTotalProducts()
        {
            string connectionString = DatabaseHelper.getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT COUNT(*) AS total_items FROM Product;";
                    SQLiteDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int totalItems = Convert.ToInt32(reader["total_items"]);
                        // Use the 'totalItems' value as needed
                        totalRecordsCount = totalItems; // Set the value to your global variable for pagination
                    }
                    reader.Close();
                }
            }
        }
        public void InitializeEmployeeCount()
        {
            numberOfEmployee = DatabaseHelper.GetNumberOfEmployees();
            employeeCountLabel.Text = numberOfEmployee.ToString();
        }
        public void InitializeEmployee()
        {
            searchTextBox.Text = string.Empty;
            string connectionString = DatabaseHelper.getConnectionString();
            employeeFlowLayoutPanel.Controls.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"
                        SELECT * FROM Employee
                        ";

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("Id");
                        string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                        string contactNumber = reader.GetString(reader.GetOrdinal("ContactNumber"));
                        string startedWorking = reader.GetString(reader.GetOrdinal("StartedWorking"));
                        byte[] byteBLOBData = (byte[])reader["Image"];
                        // set the product details
                        EmployeeUserControl employeeUserControl = new EmployeeUserControl();
                        employeeUserControl.setId(id.ToString());
                        employeeUserControl.setFirstName(firstName);
                        employeeUserControl.setLastName(lastName);
                        employeeUserControl.setContactNumber(contactNumber);
                        employeeUserControl.setStartedWorking(startedWorking);
                        employeeUserControl.setEmployeeImage(byteBLOBData);
                        employeeFlowLayoutPanel.Controls.Add(employeeUserControl);
                    }

                    connection.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();

            employeeFlowLayoutPanel.Controls.Clear();
            searchTextBox.Text = String.Empty;
            InitializeEmployee();
            InitializeEmployeeCount();
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseHelper.getConnectionString();
            string searchString = searchTextBox.Text;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Employee WHERE FirstName LIKE @SearchString";
                    command.Parameters.AddWithValue("@SearchString", "%" + searchString + "%"); // searchString is your search term (e.g., "Cok")

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            employeeFlowLayoutPanel.Controls.Clear();
                            while (reader.Read())
                            {
                                // Process the retrieved rows
                                int id = reader.GetInt32("Id");
                                string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                                string contactNumber = reader.GetString(reader.GetOrdinal("ContactNumber"));
                                string startedWorking = reader.GetString(reader.GetOrdinal("StartedWorking"));
                                byte[] byteBLOBData = (byte[])reader["Image"];
                                // set the product details
                                EmployeeUserControl employeeUserControl = new EmployeeUserControl();
                                employeeUserControl.setId(id.ToString());
                                employeeUserControl.setFirstName(firstName);
                                employeeUserControl.setLastName(lastName);
                                employeeUserControl.setContactNumber(contactNumber);
                                employeeUserControl.setStartedWorking(startedWorking);
                                employeeUserControl.setEmployeeImage(byteBLOBData);
                                employeeFlowLayoutPanel.Controls.Add(employeeUserControl);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No items found");
                        }

                    }
                }
            }
        }

        private void crudProductsLabel_Click(object sender, EventArgs e)
        {
            // remove all the border so that we know which one is selected
            viewAttendanceLabel.BorderStyle = BorderStyle.None;
            crudEmployeeLabel.BorderStyle = BorderStyle.None;
            crudProductsLabel.BorderStyle = BorderStyle.FixedSingle;

            // hide the panels
            viewAttendancePanel.Hide();
            crudEmployeePanel.Hide();
            settingsPanel.Hide();

            crudProductPanel.Show();
            selectedOptionLabel.Text = "List Of Products";
        }

        private void crudEmployeeLabel_Click(object sender, EventArgs e)
        {
            // remove all border so that we know which one is selected
            viewAttendanceLabel.BorderStyle = BorderStyle.None;
            crudEmployeeLabel.BorderStyle = BorderStyle.FixedSingle;
            crudProductsLabel.BorderStyle = BorderStyle.None;

            settingsPanel.Hide();
            viewAttendancePanel.Hide();
            crudEmployeePanel.Show();
            crudProductPanel.Hide();

            selectedOptionLabel.Text = "Employees";
            searchTextBox.Text = String.Empty;
            InitializeEmployeeCount();
            InitializeEmployee();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            currentPage++;
            pageNumberTextBox.Text = currentPage.ToString();
            LoadProducts();
            UpdatePaginationControls();

        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            currentPage--;
            pageNumberTextBox.Text = currentPage.ToString();

            LoadProducts();
            UpdatePaginationControls();
        }
        private void UpdatePaginationControls()
        {
            // Disable the Previous Page button if on the first page
            previousPageButton.Enabled = currentPage > 1;

            // Disable the Next Page button if no more records are available
            nextPageButton.Enabled = currentPage * itemsPerPage < totalRecordsCount;
        }
        public void LoadProducts()
        {
            searchProductTextBox.Text = string.Empty;
            productsFlowLayoutPanel.Controls.Clear();
            string connectionString = DatabaseHelper.getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    int offset = (currentPage - 1) * itemsPerPage;

                    command.CommandText =
                       @"
                         SELECT * FROM Product 
                        LIMIT @ItemsPerPage OFFSET @Offset
                        ";

                    command.Parameters.AddWithValue("@ItemsPerPage", itemsPerPage);
                    command.Parameters.AddWithValue("@Offset", offset);

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("Id");
                        string name = reader.GetString(reader.GetOrdinal("Name"));
                        double price = reader.GetDouble(reader.GetOrdinal("Price"));
                        int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                        byte[] byteBLOBData = (byte[])reader["Image"];
                        // set the product details
                        ProductUserControl productUserControl = new ProductUserControl();
                        productUserControl.setId(id.ToString());
                        productUserControl.setName(name);
                        productUserControl.setPrice(price.ToString());
                        productUserControl.setQuantity(quantity.ToString());
                        productUserControl.setImage(byteBLOBData);
                        productsFlowLayoutPanel.Controls.Add(productUserControl);
                    }
                    reader.Close();

                    connection.Close();
                }

            }
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            searchFunction(searchProductTextBox.Text);

        }
        private void searchFunction(string searchString)
        {


            string connectionString = DatabaseHelper.getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Product WHERE Name LIKE @SearchString";
                    command.Parameters.AddWithValue("@SearchString", "%" + searchString + "%"); // searchString is your search term (e.g., "Cok")

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            productsFlowLayoutPanel.Controls.Clear();
                            while (reader.Read())
                            {
                                // Process the retrieved rows
                                int id = reader.GetInt32("Id");
                                string name = reader.GetString(reader.GetOrdinal("Name"));
                                double price = reader.GetDouble(reader.GetOrdinal("Price"));
                                int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                                byte[] byteBLOBData = (byte[])reader["Image"];
                                // set the product details
                                ProductUserControl productUserControl = new ProductUserControl();
                                productUserControl.setId(id.ToString());
                                productUserControl.setName(name);
                                productUserControl.setPrice(price.ToString());
                                productUserControl.setQuantity(quantity.ToString());
                                productUserControl.setImage(byteBLOBData);
                                productsFlowLayoutPanel.Controls.Add(productUserControl);
                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("No items found");
                        }

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchProductTextBox.Text = String.Empty;
            pageNumberTextBox.Text = "1";
            searchFunction(searchTextBox.Text);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();

            LoadProducts();
        }

        public void InitializeAttendance()
        {

            string connectionString = DatabaseHelper.getConnectionString();
            attendanceFlowLayOutPanel.Controls.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                      @"
                     SELECT Attendance.Id, Attendance.TimeIn, Attendance.TimeOut, Attendance.HoursWorked, Employee.FirstName, Employee.LastName
                     FROM Attendance
                     INNER JOIN Employee ON Attendance.Id = Employee.Id
                     ";

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("Id"));
                        string timeIn = reader.GetString(reader.GetOrdinal("TimeIn"));
                        string timeOut = reader.GetString(reader.GetOrdinal("TimeOut"));
                        double hoursWorked = reader.GetDouble(reader.GetOrdinal("HoursWorked"));
                        string hoursWorkedStr = hoursWorked.ToString();

                        string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        string lastName = reader.GetString(reader.GetOrdinal("LastName"));

                        // Use retrieved data as needed
                        AttendanceUserControl attendanceUserControl = new AttendanceUserControl();
                        attendanceUserControl.setId(id.ToString());
                        attendanceUserControl.setFirstName(firstName);
                        attendanceUserControl.setLastName(lastName);
                        attendanceUserControl.setTimeIn(timeIn);
                        attendanceUserControl.setTimeOut(timeOut);
                        attendanceUserControl.setHoursWorked(hoursWorkedStr);

                        attendanceFlowLayOutPanel.Controls.Add(attendanceUserControl);
                    }
                    reader.Close();
                    connection.Close();
                }

            }
        }

        private void searchDateButton_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseHelper.getConnectionString();
            attendanceFlowLayOutPanel.Controls.Clear();

            DateTime selectedDate = attendanceDateTimePicker.Value;
            string formattedCurrentDate = selectedDate.ToString("dd/MM/yyyy");
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                      @"
                     SELECT Attendance.Id, Attendance.TimeIn, Attendance.TimeOut, Attendance.HoursWorked, Employee.FirstName, Employee.LastName
                     FROM Attendance
                     INNER JOIN Employee ON Attendance.Id = Employee.Id
                     WHERE SUBSTR(Attendance.TimeIn, 1, 10) = @TimeIn OR SUBSTR(Attendance.TimeOut, 1, 10) = @TimeOut
                     ";
                    command.Parameters.AddWithValue("@TimeIn", formattedCurrentDate);
                    command.Parameters.AddWithValue("@TimeOut", formattedCurrentDate);
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("Id"));
                        string timeIn = reader.GetString(reader.GetOrdinal("TimeIn"));
                        string timeOut = reader.GetString(reader.GetOrdinal("TimeOut"));
                        double hoursWorked = reader.GetDouble(reader.GetOrdinal("HoursWorked"));
                        string hoursWorkedStr = hoursWorked.ToString();

                        string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        string lastName = reader.GetString(reader.GetOrdinal("LastName"));

                        // Use retrieved data as needed
                        AttendanceUserControl attendanceUserControl = new AttendanceUserControl();
                        attendanceUserControl.setId(id.ToString());
                        attendanceUserControl.setFirstName(firstName);
                        attendanceUserControl.setLastName(lastName);
                        attendanceUserControl.setTimeIn(timeIn);
                        attendanceUserControl.setTimeOut(timeOut);
                        attendanceUserControl.setHoursWorked(hoursWorkedStr);

                        attendanceFlowLayOutPanel.Controls.Add(attendanceUserControl);
                    }
                    reader.Close();
                    connection.Close();
                }

            }
        }



        private void allTimeButton_Click(object sender, EventArgs e)
        {
            InitializeAttendance();
        }

        private void viewAttendanceLabel_Click(object sender, EventArgs e)
        {
            crudEmployeePanel.Hide();
            crudProductPanel.Hide();
            settingsPanel.Hide();
            crudEmployeeLabel.BorderStyle = BorderStyle.None;
            crudProductsLabel.BorderStyle = BorderStyle.None;

            viewAttendanceLabel.BorderStyle = BorderStyle.FixedSingle;
            viewAttendancePanel.Show();
            selectedOptionLabel.Text = "Attendance";

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseHelper.getConnectionString();
            string searchString = string.Empty;
            searchTextBox.Text = string.Empty;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Employee WHERE FirstName LIKE @SearchString";
                    command.Parameters.AddWithValue("@SearchString", "%" + searchString + "%"); // searchString is your search term (e.g., "Cok")

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            employeeFlowLayoutPanel.Controls.Clear();
                            while (reader.Read())
                            {
                                // Process the retrieved rows
                                int id = reader.GetInt32("Id");
                                string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                                string contactNumber = reader.GetString(reader.GetOrdinal("ContactNumber"));
                                string startedWorking = reader.GetString(reader.GetOrdinal("StartedWorking"));
                                byte[] byteBLOBData = (byte[])reader["Image"];
                                // set the product details
                                EmployeeUserControl employeeUserControl = new EmployeeUserControl();
                                employeeUserControl.setId(id.ToString());
                                employeeUserControl.setFirstName(firstName);
                                employeeUserControl.setLastName(lastName);
                                employeeUserControl.setContactNumber(contactNumber);
                                employeeUserControl.setStartedWorking(startedWorking);
                                employeeUserControl.setEmployeeImage(byteBLOBData);
                                employeeFlowLayoutPanel.Controls.Add(employeeUserControl);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No items found");
                        }

                    }
                }
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            selectedOptionLabel.Text = "Admin Settings";



            crudEmployeeLabel.BorderStyle = BorderStyle.None;
            crudProductsLabel.BorderStyle = BorderStyle.None;
            viewAttendanceLabel.BorderStyle = BorderStyle.None;

            crudEmployeePanel.Hide();
            crudProductPanel.Hide();
            viewAttendancePanel.Hide();
            settingsPanel.Show();
        }

        private void addNewAdminAccount_Click(object sender, EventArgs e)
        {

            if (DatabaseHelper.isAdminAccountExisting(EncryptionService.ComputeSha256Hash(newAccountUsernameTextBox.Text)) >= 1)
            {
                MessageBox.Show("Account already exist");

            }

            else if (newAccountUsernameTextBox.Text.Length > 0 && newAccountPasswordTextBox.Text.Length > 0 && DatabaseHelper.isAdminAccountExisting(EncryptionService.ComputeSha256Hash(newAccountUsernameTextBox.Text)) == 0)
            {
                // save the account

                string username = EncryptionService.ComputeSha256Hash(newAccountUsernameTextBox.Text);
                string password = EncryptionService.ComputeSha256Hash(newAccountPasswordTextBox.Text);

                DatabaseHelper.AddAdminAccount(username, password);
                MessageBox.Show("The new Admin has been added!");

                newAccountUsernameTextBox.Text = String.Empty;
                newAccountPasswordTextBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Please write a username and password");
            }
        }

        private void newAccountShowPassword_Click(object sender, EventArgs e)
        {
            newAccountPasswordTextBox.PasswordChar = '\0';
        }

        private void newAccountHidePassword_Click(object sender, EventArgs e)
        {
            newAccountPasswordTextBox.PasswordChar = '*';
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.isAdminAccountExistingPass(EncryptionService.ComputeSha256Hash(userNameExistingTextBox.Text), EncryptionService.ComputeSha256Hash(passwordExistingTextBox.Text)) >= 1)
            {
                // change the password here
                MessageBox.Show("ACCOUNT EXIST");
                DatabaseHelper.ChangeAdminAccountPassword(EncryptionService.ComputeSha256Hash(userNameExistingTextBox.Text), EncryptionService.ComputeSha256Hash(passwordExistingTextBox.Text), EncryptionService.ComputeSha256Hash(newPasswordForExistingTextBox.Text));
            }
            else if (DatabaseHelper.isAdminAccountExistingPass(EncryptionService.ComputeSha256Hash(userNameExistingTextBox.Text), EncryptionService.ComputeSha256Hash(passwordExistingTextBox.Text)) == 0)
            {
                MessageBox.Show("ACCOUNT DOES NOT EXIST");
            }
        }
    }
}
