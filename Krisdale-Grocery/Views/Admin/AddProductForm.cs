using Krisdale_Grocery.DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class AddProductForm : Form
    {
        public String Username { get; set; }
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if(DatabaseHelper.isProductExisting(nameTextBox.Text) >= 1)
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

            if (Regex.IsMatch(nameTextBox.Text, namePattern)){
                isValidName = true;
            }
            if (Regex.IsMatch(quantityTextBox.Text, quantityPattern)) {
                isValidQuantity = true;
            }
            if (Regex.IsMatch(priceTextBox.Text, pricePattern)) {
                isValidPrice = true;
            }

            if (isValidName && isValidQuantity && isValidPrice)
            {
                if (double.TryParse(priceTextBox.Text, out double priceDouble))
                {
                    if (int.TryParse(quantityTextBox.Text, out int quantityInt))
                    {
                        if (nameTextBox.Text != string.Empty)
                        {
                            DatabaseHelper.InsertLog(this.Username, DateTime.Now, "Added a new product ");
                            DatabaseHelper.AddProduct(nameTextBox.Text.ToLower(), priceDouble, quantityInt, getImage());
                            MessageBox.Show("Product Added");
                            clearAllFields();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Make sure to add a product name. Make sure the price contains floating point or whole number. Make Sure that the quantity contains Whole Number");
                }

            }
            else
            {
                MessageBox.Show("Please follow the rules for the naming, price and quantity");
            }




        }
        private byte[] getImage()
        {
            MemoryStream ms = new MemoryStream();
            uploadedImagePictureBox.Image.Save(ms, uploadedImagePictureBox.Image.RawFormat);
            return ms.ToArray();
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedImagePictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void clearImageButton_Click(object sender, EventArgs e)
        {
            uploadedImagePictureBox.Image = Krisdale_Grocery.Images.NOPRODUCTAVAILABLE;
        }

        private void clearAllFieldsButton_Click(object sender, EventArgs e)
        {
            clearAllFields();

        }
        private void clearAllFields()
        {
            nameTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            uploadedImagePictureBox.Image = Krisdale_Grocery.Images.NOPRODUCTAVAILABLE;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string namePattern = "^[a-zA-Z0-9 ]{3,15}$";

            if (Regex.IsMatch(nameTextBox.Text, namePattern))
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
