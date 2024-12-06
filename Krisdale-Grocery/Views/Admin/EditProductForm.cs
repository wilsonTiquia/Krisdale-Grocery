using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class EditProductForm : Form
    {
        public ProductModel productModel { get; set; }
        private bool changeProductImage = false;
        private byte[] image;

        public String Username { get; set; }    
        public EditProductForm()
        {
            InitializeComponent();

            image = new byte[0];

        }
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            setProduct(productModel);

        }
        private void setProduct(ProductModel product)
        {
            string connectionString = DatabaseHelper.getConnectionString();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                       @"
                        SELECT * FROM Product
                        WHERE Id = @Id";

                    command.Parameters.AddWithValue("@Id", product.Id);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = reader.GetInt32("Id");
                        string name = reader.GetString(reader.GetOrdinal("Name"));
                        double price = reader.GetDouble(reader.GetOrdinal("Price"));
                        int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                        byte[] byteBLOBData = (byte[])reader["Image"];

                        using (MemoryStream ms = new MemoryStream(byteBLOBData))
                        {

                            uploadedImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
                        }

                        productNameTextBox.Text = name;
                        priceTextBox.Text = price.ToString();
                        quantityTextBox.Text = quantity.ToString();

                        reader.Close();
                    }
                }


            }
        }


        private byte[] getSavedImage()
        {
            MemoryStream ms = new MemoryStream();
            uploadedImagePictureBox.Image.Save(ms, uploadedImagePictureBox.Image.RawFormat);
            image = ms.ToArray();
            return image;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.isProductExisting(productNameTextBox.Text) >= 1)
            {
                MessageBox.Show("Product already exist!");
                return;
            }
            bool isValidName = false;
            bool isValidQuantity = false;
            bool isValidPrice = false;
            string namePattern = "^[a-zA-Z0-9 ]{3,15}$";

            string pricePattern = @"^-?\d+(\.\d+)?$";
            string quantityPattern = @"^\d+$";

            if (Regex.IsMatch(productNameTextBox.Text, namePattern))
            {
                isValidName = true;
            }
            if (Regex.IsMatch(quantityTextBox.Text, quantityPattern))
            {
                isValidQuantity = true;
            }
            if (Regex.IsMatch(priceTextBox.Text, pricePattern))
            {
                isValidPrice = true;
            }

            if (isValidName && isValidQuantity && isValidPrice)
            {
                double price = double.Parse(priceTextBox.Text);
                int quantity = int.Parse(quantityTextBox.Text);

                if (changeProductImage == false)
                {

                    DatabaseHelper.EditProductNoImage(productNameTextBox.Text, price, quantity, productModel.Id);
                    DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Edited a new product ");
                }
                else
                {
                    DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Edited a new product ");
                    DatabaseHelper.EditProduct(productNameTextBox.Text, price, quantity, getSavedImage(), productModel.Id);
                }
                MessageBox.Show("Product successfully edited");

            }
            else
            {
                MessageBox.Show("Please make sure that the rules are followed in naming, price and quantity");
            }
           
            this.Close();
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedImagePictureBox.Image = new Bitmap(openFileDialog.FileName);
                changeProductImage = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Deleted a  product ");
            DatabaseHelper.DeleteProduct(productModel.Id);
            MessageBox.Show("Product Deleted");
            this.Close();
        }

        private void EditProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();

        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string namePattern = "^[a-zA-Z0-9 ]{3,15}$";

            if (Regex.IsMatch(productNameTextBox.Text, namePattern))
            {
                pNameRule.Visible = false;
            }
            else
            {
                pNameRule.Visible = true;
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^-?\d+(\.\d+)?$";
            if (Regex.IsMatch(priceTextBox.Text, pattern))
            {
                pRule.Visible = false;
            }
            else
            {
                pRule.Visible = true;
            }

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\d+$";
            if (Regex.IsMatch(quantityTextBox.Text, pattern))
            {
                qRule.Visible = false;
            }
            else
            {
                qRule.Visible = true;
            }
        }
    }
}
