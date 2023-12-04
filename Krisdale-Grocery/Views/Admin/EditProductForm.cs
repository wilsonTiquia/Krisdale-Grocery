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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class EditProductForm : Form
    {
        public ProductModel productModel { get; set; }
        private bool changeProductImage = false;
        private byte[] image;
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
            double price = double.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);

            if (changeProductImage == false)
            {
               
                DatabaseHelper.EditProductNoImage(productNameTextBox.Text, price, quantity, productModel.Id);
            }
            else
            {
                DatabaseHelper.EditProduct(productNameTextBox.Text, price, quantity, getSavedImage(), productModel.Id);
            }
            MessageBox.Show("Product successfully edited");
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
    }
}
