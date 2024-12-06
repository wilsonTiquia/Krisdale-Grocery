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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class DashBoardForm : Form
    {
        private int itemsPerPage = 25; // Number of items per page
        private int currentPage = 1; // Current page
        int numberOfEmployee;
        private int totalRecordsCount;

        public String UsernameLoggedIn { get; set; }
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
            userNameExistingTextBox.Text = this.UsernameLoggedIn;
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
            addEmployeeForm.Username = this.UsernameLoggedIn;
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
            addProductForm.Username = this.UsernameLoggedIn;
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
            // check if ADMIN  account already exist
            if (DatabaseHelper.isAdminAccountExisting(newAccountUsernameTextBox.Text.ToLower()) >= 1)
            {
                MessageBox.Show("Account already exist");

            }
            // check if the username length is valid
            else
            {
                // first check the length 
                bool isUsernameLengthValid = false;
                bool isPasswordValid = false;
                bool isSecurityKeyValid = false;
                string usernamePattern = @"^[a-z]{3,15}$";

                string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{12,15}$";

                // if username is valid
                if (Regex.IsMatch(newAccountUsernameTextBox.Text, usernamePattern))
                {
                    isUsernameLengthValid = true;
                }
                // if password is valid 
                if (Regex.IsMatch(newAccountPasswordTextBox.Text, passwordPattern) && newAccountPasswordTextBox.Text == confirmPassword.Text)
                {
                    isPasswordValid = true;
                }
                // if security key is valid
                if (Regex.IsMatch(securityKeyTextBox.Text, usernamePattern))
                {
                    isSecurityKeyValid = true;
                }
                // if all is valid create the account
                if (isUsernameLengthValid && isPasswordValid && isSecurityKeyValid)
                {
                    string username = newAccountUsernameTextBox.Text;
                    string password = EncryptionService.ComputeSha256Hash(newAccountPasswordTextBox.Text);

                    // add the admin account
                    DatabaseHelper.AddAdminAccount(username, password, EncryptionService.ComputeSha256Hash(securityKeyTextBox.Text));
                    DatabaseHelper.addPasswordHistory(username, password);
                    MessageBox.Show("Account Sucessfully Created");
                    DatabaseHelper.InsertLog(this.UsernameLoggedIn, DateTime.Now, "created a new admin account: " + username);
                    // add into the password history


                    // clear the fields
                    newAccountUsernameTextBox.Text = String.Empty;
                    newAccountPasswordTextBox.Text = String.Empty;
                    confirmPassword.Text = String.Empty;
                    securityKeyTextBox.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Please make sure that the username, password and security key matches the rules.");
                }

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
            if (DatabaseHelper.isAdminAccountExistingPass(userNameExistingTextBox.Text, EncryptionService.ComputeSha256Hash(passwordExistingTextBox.Text)) >= 1)
            {
                // change the password here if the name and password is correct but make sure new pass follows the standard

                if (DatabaseHelper.IsPasswordInHistory(userNameExistingTextBox.Text, EncryptionService.ComputeSha256Hash(newPasswordForExistingTextBox.Text)))
                {
                    MessageBox.Show("Can't reuse old passwords");
                    passwordExistingTextBox.Text = String.Empty;
                    newPasswordForExistingTextBox.Text = string.Empty;
                }
                else
                {
                    DatabaseHelper.InsertLog(this.UsernameLoggedIn, DateTime.Now, "Successfully Changed the password of  " + this.UsernameLoggedIn);
                    DatabaseHelper.ChangeAdminAccountPassword(userNameExistingTextBox.Text, EncryptionService.ComputeSha256Hash(passwordExistingTextBox.Text), EncryptionService.ComputeSha256Hash(newPasswordForExistingTextBox.Text));
                    MessageBox.Show("Account Password Change Successfully.");
                    this.Close();



                }

            }
            // check if it is in the employee
            // otherwise 
            else if (DatabaseHelper.isAdminAccountExistingPass(userNameExistingTextBox.Text, EncryptionService.ComputeSha256Hash(passwordExistingTextBox.Text)) == 0)
            {
                DatabaseHelper.InsertLog(this.UsernameLoggedIn, DateTime.Now, "Failed attempt to change the password of  " + userNameExistingTextBox.Text);
                MessageBox.Show("Invalid username or password");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void newAccountPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{12,15}$";
            if (Regex.IsMatch(newAccountPasswordTextBox.Text, pattern))
            {
                passwordRulesLabel.Visible = false;

            }
            else
            {
                passwordRulesLabel.Visible = true;
            }
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (newAccountPasswordTextBox.Text == confirmPassword.Text)
            {
                passwordMatchLabel.Visible = false;
            }
            else
            {
                passwordMatchLabel.Visible = true;
            }
        }

        private void newAccountUsernameTextBox_TextChanged(object sender, EventArgs e)
        {

            string pattern = @"^[a-z]{3,15}$";
            if (Regex.IsMatch(newAccountUsernameTextBox.Text, pattern))
            {
                usernameRuleLabel.Visible = false;
            }
            else
            {
                usernameRuleLabel.Visible = true;
            }
        }

        private void securityKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-z]{3,15}$";
            if (Regex.IsMatch(securityKeyTextBox.Text, pattern))
            {
                securityKeyRule.Visible = false;
            }
            else
            {
                securityKeyRule.Visible = true;
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newPasswordForExistingTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{12,15}$";
            if (Regex.IsMatch(newPasswordForExistingTextBox.Text, pattern))
            {
                changePassRules.Visible = false;
            }
            else
            {
                changePassRules.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewlogs viewlogs = new viewlogs();
            viewlogs.ShowDialog();
            List<string> logs = DatabaseHelper.GetAllLogsAsString();

            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
