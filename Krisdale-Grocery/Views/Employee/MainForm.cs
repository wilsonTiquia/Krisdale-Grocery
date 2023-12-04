using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Views.Admin;
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

namespace Krisdale_Grocery.Views.Employee
{
    public partial class MainForm : Form
    {
        private int itemsPerPage = 9; // Number of items per page
        private int currentPage = 1; // Current page
        private double totalAmount = 0;
        public Dictionary<string, ItemInCartUserControl> cartItems = new Dictionary<string, ItemInCartUserControl>();

        private int totalRecordsCount;
        public MainForm()
        {
            InitializeComponent();
            InitializeProducts();
            getTotalProducts();
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
        public void AddProduct(string id, string price, string productName)
        {
            double productPrice = double.Parse(price) * double.Parse(quantityTextBox.Text);

            if (cartItems.ContainsKey(id))
            {
                int newQuantity = int.Parse(cartItems[id].getQuantity()) + int.Parse(quantityTextBox.Text);
                cartItems[id].setQuantity(newQuantity.ToString());

                double oldTotalPrice = double.Parse(cartItems[id].getTotal());
                double newTotalPrice = newQuantity * double.Parse(price);
                cartItems[id].setTotal(newTotalPrice.ToString());
                shoppingListFlowLayoutPanel.Refresh();
                totalAmount += newTotalPrice - oldTotalPrice;
                totalAmountLabel.Text = $"{totalAmount.ToString("F2")}";
            }
            else
            {
                double totalPrice = productPrice;
                ItemInCartUserControl itemInCartUserControl = new ItemInCartUserControl();
                itemInCartUserControl.setProductName(productName);
                itemInCartUserControl.setQuantity(quantityTextBox.Text);
                itemInCartUserControl.setPrice(price);
                itemInCartUserControl.setTotal(totalPrice.ToString());

                shoppingListFlowLayoutPanel.Controls.Add(itemInCartUserControl);
                shoppingListFlowLayoutPanel.Refresh();
                cartItems.Add(id, itemInCartUserControl);

                totalAmount += totalPrice;
                totalAmountLabel.Text = $"{totalAmount.ToString("F2")}";
            }

            quantityTextBox.Text = "1";
        }

        //public void AddProduct(string productName, string price)
        //{
        //    // Check if the product is already in the cart
        //    if (cartItems.ContainsKey(productName))
        //    {
        //        // Increment the quantity if the product is already in the cart
        //        int newQuantity = int.Parse(cartItems[productName].getQuantity()) + int.Parse(quantityTextBox.Text);
        //        cartItems[productName].setQuantity(newQuantity.ToString());
        //        double totalPrice = newQuantity * double.Parse(price);
        //        cartItems[productName].setTotal(totalPrice.ToString());
        //        MessageBox.Show(totalPrice.ToString());
        //        totalAmount += totalPrice;
        //        totalAmountLabel.Text = $"{totalAmount.ToString("F2")}";
        //    }
        //    else
        //    {
        //        double totalPrice = double.Parse(quantityTextBox.Text) * double.Parse(price);
        //        ItemInCartUserControl itemInCartUserControl = new ItemInCartUserControl();
        //        itemInCartUserControl.setProductName(productName);
        //        itemInCartUserControl.setQuantity(quantityTextBox.Text);
        //        itemInCartUserControl.setPrice(price);
        //        itemInCartUserControl.setTotal(totalPrice.ToString());
        //        shoppingListFlowLayoutPanel.Controls.Add(itemInCartUserControl);
        //        shoppingListFlowLayoutPanel.Refresh();


        //        // Add the new product to the cartItems dictionary
        //        cartItems.Add(productName, itemInCartUserControl);
        //        // add the total amount
        //        totalAmount += totalPrice;
        //        totalAmountLabel.Text = $"{totalAmount.ToString("F2")}";
        //    }


        //    // reset the quantity
        //    quantityTextBox.Text = "1";
        //}
        public void removeItemInCart(string productName, string price, string quantity)
        {
            double totalPriceToRemove = double.Parse(price) * double.Parse(quantity);
            totalAmount -= totalPriceToRemove;

            cartItems.Remove(productName);
            totalAmountLabel.Text = $"₱ {Math.Max(totalAmount, 0).ToString("F2")}"; // Ensuring the totalAmount is not negative
        }


        public void InitializeProducts()
        {
            // get all products and set it to a user control
            productFlowLayoutPanel.Controls.Clear();
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
                        MainFormProductUserControl mainFormProductUserControl = new MainFormProductUserControl();
                        mainFormProductUserControl.setId(id.ToString());
                        mainFormProductUserControl.setName(name);
                        mainFormProductUserControl.setPrice(price.ToString());
                        mainFormProductUserControl.setQuantity(quantity.ToString());
                        mainFormProductUserControl.setImage(byteBLOBData);
                        productFlowLayoutPanel.Controls.Add(mainFormProductUserControl);
                    }
                    reader.Close();
                    connection.Close();
                }

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchFunction(searchTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = String.Empty;
            pageNumberTextBox.Text = "1";
            searchFunction(searchTextBox.Text);

        }
        private void searchFunction(string searchString)
        {


            string connectionString = DatabaseHelper.getConnectionString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Product WHERE Name LIKE @SearchString LIMIT 12";
                    command.Parameters.AddWithValue("@SearchString", "%" + searchString + "%"); // searchString is your search term (e.g., "Cok")

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            productFlowLayoutPanel.Controls.Clear();
                            while (reader.Read())
                            {
                                // Process the retrieved rows
                                int id = reader.GetInt32("Id");
                                string name = reader.GetString(reader.GetOrdinal("Name"));
                                double price = reader.GetDouble(reader.GetOrdinal("Price"));
                                int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                                byte[] byteBLOBData = (byte[])reader["Image"];
                                // set the product details
                                MainFormProductUserControl mainFormProductUserControl = new MainFormProductUserControl();
                                mainFormProductUserControl.setId(id.ToString());
                                mainFormProductUserControl.setName(name);
                                mainFormProductUserControl.setPrice(price.ToString());
                                mainFormProductUserControl.setQuantity(quantity.ToString());
                                mainFormProductUserControl.setImage(byteBLOBData);
                                productFlowLayoutPanel.Controls.Add(mainFormProductUserControl);
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
        private void UpdatePaginationControls()
        {
            // Disable the Previous Page button if on the first page
            previousPageButton.Enabled = currentPage > 1;

            // Disable the Next Page button if no more records are available
            nextPageButton.Enabled = currentPage * itemsPerPage < totalRecordsCount;
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            currentPage++;
            pageNumberTextBox.Text = currentPage.ToString();
            LoadProducts();
            UpdatePaginationControls();

        }


        private void LoadProducts()
        {
            productFlowLayoutPanel.Controls.Clear();
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
                        MainFormProductUserControl mainFormProductUserControl = new MainFormProductUserControl();
                        mainFormProductUserControl.setId(id.ToString());
                        mainFormProductUserControl.setName(name);
                        mainFormProductUserControl.setPrice(price.ToString());
                        mainFormProductUserControl.setQuantity(quantity.ToString());
                        mainFormProductUserControl.setImage(byteBLOBData);
                        productFlowLayoutPanel.Controls.Add(mainFormProductUserControl);
                    }
                    reader.Close();

                    connection.Close();
                }

            }
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            currentPage--;
            pageNumberTextBox.Text = currentPage.ToString();

            LoadProducts();
            UpdatePaginationControls();

        }

        private void paymentButtonClick_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.cartItems = cartItems;
            paymentForm.totalAmount = totalAmount;
            paymentForm.ShowDialog();
            totalAmount = 0;
            totalAmountLabel.Text = "₱ 0.00";
            shoppingListFlowLayoutPanel.Controls.Clear();
            shoppingListFlowLayoutPanel.Refresh();
            InitializeProducts();
            cartItems.Clear();
        }

        private void clockInButton_Click(object sender, EventArgs e)
        {
            ClockInForm clockInForm = new ClockInForm();
            clockInForm.ShowDialog();
        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {
            ClockOutForm clockOutForm = new ClockOutForm();
            clockOutForm.ShowDialog();
        }
    }
}
