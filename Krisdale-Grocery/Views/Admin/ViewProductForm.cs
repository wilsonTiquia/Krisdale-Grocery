using Krisdale_Grocery.DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class ViewProductForm : Form
    {
        public ViewProductForm()
        {
            InitializeComponent();
            // initialize here all the products
            InitializeProducts();
        }

        private void ViewProductForm_Load(object sender, EventArgs e)
        {

        }


        public void InitializeProducts()
        {

            // get all products and set it to a user control
            string connectionString = DatabaseHelper.getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"
                        SELECT * FROM Product
                        ";

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
                        flowLayoutPanel1.Controls.Add(productUserControl);
                    }

                    connection.Close();
                }

            }
        }

        private void searchClicked_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseHelper.getConnectionString();
            string searchString = searchTextBox.Text;
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
                            flowLayoutPanel1.Controls.Clear();
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
                                flowLayoutPanel1.Controls.Add(productUserControl);
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
