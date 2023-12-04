using Krisdale_Grocery.DatabaseAccess;
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
    public partial class ViewEmployeeForm : Form
    {
        public ViewEmployeeForm()
        {
            InitializeComponent();
            InitializeEmployee();
        }

        private void ViewEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        public void InitializeEmployee()
        {
            string connectionString = DatabaseHelper.getConnectionString();
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
                        flowLayoutPanel1.Controls.Add(employeeUserControl);
                    }

                    connection.Close();
                }

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
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
                            flowLayoutPanel1.Controls.Clear();
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
                                flowLayoutPanel1.Controls.Add(employeeUserControl);
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
    }
}
