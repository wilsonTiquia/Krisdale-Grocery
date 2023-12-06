using Krisdale_Grocery.DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {

          
            if (double.TryParse(priceTextBox.Text, out double priceDouble))
            {
                if (int.TryParse(quantityTextBox.Text, out int quantityInt)) 
                { 
                    if (nameTextBox.Text != string.Empty) 
                    {
                        DatabaseHelper.AddProduct(nameTextBox.Text, priceDouble, quantityInt, getImage());
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
    }
}
