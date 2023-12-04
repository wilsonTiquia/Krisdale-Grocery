using Krisdale_Grocery.Model;
using Krisdale_Grocery.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Employee
{
    public partial class MainFormProductUserControl : UserControl
    {
        private ProductModel productModel;
        public MainFormProductUserControl()
        {
            InitializeComponent();
            productModel = new ProductModel();
        }

        public void setId(string id)
        {
            productModel.Id = int.Parse(id);
            productIdLabel.Text = $"ID#{id}";

        }
        public void setName(string name)
        {
            productModel.Name = name;
            productNameLabel.Text = name;

        }
        public void setPrice(string price)
        {
            productModel.Price = price;
            priceLabel.Text = $" ₱ {price}";
        }
        public void setQuantity(string quantity)
        {
            productModel.Quantity = quantity;
            quantityLabel.Text = $"In Stock: {quantity}";
        }

        public void setImage(byte[] imageData)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {

                    productImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
                }

            }
            catch
            {
                MessageBox.Show("An error occured");

            }
        }

        private void MainFormProductUserControl_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent; // Get the immediate parent of the UserControl

            while (parent != null)
            {
                if (parent is FlowLayoutPanel flowLayoutPanel)
                {
                    // Access the FlowLayoutPanel here and perform actions

                    Form parentForm = flowLayoutPanel.FindForm();

                    if (parentForm is MainForm mainForm)
                    {
                        // Add a product to cart
               
                        mainForm.AddProduct(productModel.Id.ToString(),productModel.Price, productModel.Name); // add the product to cart
                    }
                    // Optionally, break out of the loop if found
                    break;
                }

                parent = parent.Parent; // Move up in the control hierarchy
            }
        }
    }
}
