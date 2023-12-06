using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using Krisdale_Grocery.Model;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Globalization;

namespace Krisdale_Grocery.DatabaseAccess
{
    public class DatabaseHelper
    {
        public static string getConnectionString()
        {
            string assemblyPath = Assembly.GetExecutingAssembly().Location;

            // Get the directory path from the assembly path
            string projectFolderPath = Path.GetDirectoryName(assemblyPath);

            for (int i = 0; i < 3; i++)
            {
                projectFolderPath = Path.GetDirectoryName(projectFolderPath);
            }


            return $"Data Source={projectFolderPath}/Database/Krisdale.db";
        }

        public static void AddEmployee(string firstName, string lastName, string contactNumber, string startedWorking, byte[] photo, string username, string password)
        {
            string connectionString = getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        INSERT INTO 
                        Employee (FirstName, LastName, ContactNumber, StartedWorking, Image) 
                        VALUES
                        (@FirstName, @LastName, @ContactNumber, @StartedWorking, @Image);
                        ";

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@StartedWorking", startedWorking);
                    command.Parameters.AddWithValue("@Image", photo);

                    command.ExecuteNonQuery();

                    // select the last inserted row
                    command.CommandText = "SELECT last_insert_rowid();";
                    int employeeId = Convert.ToInt32(command.ExecuteScalar());

                    // Insert into EmployeeCredential using the retrieved Employee Id
                    command.CommandText =
                        @"
                        INSERT INTO 
                        EmployeeCredential (EmployeeId, Username, Password) 
                        VALUES
                        (@EmployeeId, @Username, @Password);";

                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery(); // Execute the credential insert query
                    connection.Close();



                    connection.Close();
                }
            }

        }

        public static void ClockIn(string username, string password, string timeIn)
        {
            string connectionString = getConnectionString();
            int employeeId = -1;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        SELECT * FROM EmployeeCredential 
                        WHERE
                        Username = @Username AND Password = @Password;";

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();


                    // get the employee id
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeId = reader.GetInt32("EmployeeId");
                        }
                    }

                    command.CommandText = @"

                        INSERT INTO Attendance 
                        (Id,TimeIn) 
                        VALUES (@IdAttendance, @TimeIn) ";

                    command.Parameters.AddWithValue("@TimeIn", timeIn);
                    command.Parameters.AddWithValue("@IdAttendance", employeeId);

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }
        public static void ClockOut(string username, string password, string timeOut)
        {
            string connectionString = getConnectionString();
            int employeeId = -1;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        SELECT * FROM EmployeeCredential 
                        WHERE
                        Username = @Username AND Password = @Password;";

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();


                    // get the employee id
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeId = reader.GetInt32("EmployeeId");
                        }
                    }
                    DateTime currentDate = DateTime.Now;
                    string formattedCurrentDate = currentDate.ToString("dd/MM/yyyy");

                    command.CommandText = @"

                        UPDATE Attendance 
                        SET TimeOut = @TimeOut 
                        WHERE Id = @Id AND SUBSTR(TimeIn, 1, 10) = @TimeIn ";

                    command.Parameters.AddWithValue("@TimeOut", timeOut);
                    command.Parameters.AddWithValue("@Id", employeeId);
                    command.Parameters.AddWithValue("@TimeIn", formattedCurrentDate);


                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }


        public static void InsertHoursWorked(string username, string password)
        {
            string connectionString = getConnectionString();
            int employeeId = -1;
            string timeIn = "";
            string timeOut = "";
            DateTime currentDate = DateTime.Now;
            string formattedCurrentDate = currentDate.ToString("dd/MM/yyyy");

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                SELECT EmployeeId FROM EmployeeCredential 
                WHERE Username = @Username AND Password = @Password;";

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId"));
                        }
                    }

                    // Query to fetch the most recent time-in and time-out pair for the employee on the specified date
                    command.CommandText = @"
                SELECT TimeIn, TimeOut 
                FROM ATTENDANCE 
                WHERE Id = @Id AND SUBSTR(TimeIn, 1, 10) = @FormattedCurrentDate
                ORDER BY TimeIn DESC
                LIMIT 1;";

                    command.Parameters.Clear(); // Clear previous parameters
                    command.Parameters.AddWithValue("@Id", employeeId);
                    command.Parameters.AddWithValue("@FormattedCurrentDate", formattedCurrentDate);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            timeIn = reader.GetString(reader.GetOrdinal("TimeIn"));
                            timeOut = reader.GetString(reader.GetOrdinal("TimeOut"));
                        }
                    }

                    // Calculate hours worked if both time-in and time-out are available
                    if (!string.IsNullOrEmpty(timeIn) && !string.IsNullOrEmpty(timeOut))
                    {
                        DateTime timeInDT = DateTime.ParseExact(timeIn, "dd/MM/yyyy h:mm:ss tt", null);
                        DateTime timeOutDT = DateTime.ParseExact(timeOut, "dd/MM/yyyy h:mm:ss tt", null);

                        // Calculate the time difference
                        TimeSpan timeDifference = timeOutDT - timeInDT;

                        // Extract the hour difference
                        double hourDifference = timeDifference.TotalHours;

                        // Update the hours worked in the database
                        command.CommandText = @"
                        UPDATE ATTENDANCE
                        SET HoursWorked = @HoursWorked
                        WHERE Id = @Id AND TimeIn = @TimeIn AND TimeOut = @TimeOut;
                    ";



                        Console.WriteLine(timeIn);
                        Console.WriteLine(timeOut);
                        Console.WriteLine(hourDifference);
                        command.Parameters.Clear(); // Clear previous parameters
                        command.Parameters.AddWithValue("@Id", employeeId);
                        command.Parameters.AddWithValue("@HoursWorked", hourDifference);
                        command.Parameters.AddWithValue("@TimeIn", timeIn);
                        command.Parameters.AddWithValue("@TimeOut", timeOut);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Hours worked updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No rows were updated.");
                        }
                    }
                    else
                    {
                        // Handle scenarios where time-in or time-out records are not available
                        // This might indicate that the employee hasn't both clocked in and out for the day
                        // Handle it accordingly to avoid incorrect hours worked calculation.
                    }

                    connection.Close();
                }
            }
        }



        public static void EditEmployee(string firstName, string lastName, string contactNumber, string startedWorking, byte[] photo, int id)
        {
            string connectionString = getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        UPDATE Employee 
                        SET FirstName = @FirstName, LastName = @LastName, ContactNumber = @ContactNumber, StartedWorking = @StartedWorking, Image = @Image
                        WHERE
                        Id = @Id;";

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@StartedWorking", startedWorking);
                    command.Parameters.AddWithValue("@Image", photo);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public static void EditEmployeeNoImage(string firstName, string lastName, string contactNumber, string startedWorking, int id)
        {
            string connectionString = getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        UPDATE Employee 
                        SET FirstName = @FirstName, LastName = @LastName, ContactNumber = @ContactNumber, StartedWorking = @StartedWorking
                        WHERE
                        Id = @Id;";

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@StartedWorking", startedWorking);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public static void DeleteEmployee(int productId)
        {
            string connectionString = getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                       DELETE FROM Employee 
                        WHERE Id = @Id;";

                    command.Parameters.AddWithValue("@Id", productId);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public static void AddProduct(string productName, double price, int quantity, byte[] photo)
        {
            string connectionString = getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        INSERT INTO 
                        Product (Name, Price, Quantity, Image) 
                        VALUES
                        (@Name, @Price, @Quantity, @Image);";

                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Image", photo);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void EditProduct(string productName, double price, int quantity, byte[] photo, int id)
        {
            string connectionString = getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        UPDATE Product 
                        SET Name = @Name, Price = @Price, Quantity = @Quantity, Image = @Image
                        WHERE
                        Id = @Id;";

                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Image", photo);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public static void EditProductQuantity(int productId, int quantity)
        {
            string connectionString = getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        UPDATE Product 
                        SET Quantity = Quantity - @Quantity
                        WHERE
                        Id = @Id;";

                    command.Parameters.AddWithValue("@Id", productId);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public static void EditProductNoImage(string productName, double price, int quantity, int id)
        {
            string connectionString = getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        UPDATE Product 
                        SET Name = @Name, Price = @Price, Quantity = @Quantity
                        WHERE
                        Id = @Id;";

                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }
        public static void DeleteProduct(int productId)
        {
            string connectionString = getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                       DELETE FROM PRODUCT 
                        WHERE Id = @Id;";

                    command.Parameters.AddWithValue("@Id", productId);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static int isAccountExisting(string username, string password)
        {
            string connectionString = getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"
                        SELECT COUNT(*) 
                        FROM EmployeeCredential 
                        WHERE Username = @Username AND Password = @Password";

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);


                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return count;



                }
            }
        }
        public static int isAdminAccountExisting(string username)
        {
            string connectionString = getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"
                        SELECT COUNT(*) 
                        FROM Admin 
                        WHERE Username = @Username";

                    command.Parameters.AddWithValue("@Username", username);
                

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return count;



                }
            }
        }
        public static int isAdminAccountExistingPass(string username, string password)
        {
            string connectionString = getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"
                        SELECT COUNT(*) 
                        FROM Admin 
                        WHERE Username = @Username AND Password = @Password" ;

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return count;



                }
            }
        }
        public static void ChangeAdminAccountPassword (string username, string password, string newpassword)
        {
            string connectionString = getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"
                        UPDATE Admin
                        SET Password = @NewPassword
                        WHERE Username = @Username AND Password = @Password";

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@NewPassword", newpassword);

                    command.ExecuteNonQuery();
                    connection.Close();



                }
            }
        }
        public static void ChangeEmployeeAccountPassword(string username, string password, string newpassword)
        {
            string connectionString = getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"
                        UPDATE EmployeeCredential
                        SET Password = @NewPassword
                        WHERE Username = @Username AND Password = @Password";

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@NewPassword", newpassword);

                    command.ExecuteNonQuery();
                    connection.Close();



                }
            }
        }

        public static int GetNumberOfEmployees()
        {
            string connectionString = getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"
                        SELECT COUNT(*) 
                        FROM Employee
                        ";




                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return count;



                }
            }

        }

        public static void AddAdminAccount(string username, string password)
        {
            string connectionString = getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"

                        INSERT INTO 
                        Admin (Username, Password) 
                        VALUES
                        (@Username, @Password);
                        ";

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                    connection.Close();
                }


            }
        }
    }
}
