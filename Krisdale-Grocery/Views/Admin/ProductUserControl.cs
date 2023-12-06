using Krisdale_Grocery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Krisdale_Grocery.Views.Admin
{

    public partial class ProductUserControl : UserControl
    {

        private EditProductForm editProductForm;
        private ProductModel productModel;
        private byte[] imgData;
        public ProductUserControl()
        {
            InitializeComponent();
            productModel = new ProductModel();
            // load here immediately all the products
        }

        public void setId(string id)
        {
            productModel.Id = int.Parse(id);
            idLabel.Text = $"ID#{id}";

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


        private void ProductUserControl_Click(object sender, EventArgs e)
        {
            // create a product model



            //
            editProductForm = new EditProductForm();
            editProductForm.productModel = productModel;

            editProductForm.ShowDialog();

            Control parent = this.Parent; // Get the immediate parent of the UserControl

            while (parent != null)
            {
                if (parent is FlowLayoutPanel flowLayoutPanel)
                {
                    // Access the FlowLayoutPanel here and perform actions
                    flowLayoutPanel.Controls.Clear(); // For example, clear its controls

                    Form parentForm = flowLayoutPanel.FindForm();

                    if (parentForm is DashBoardForm dashboardForm)
                    {
                        // Assuming initializeProducts is a public method in ViewProductsForm
                        dashboardForm.LoadProducts(); // Call initializeProducts
                    }
                    // Optionally, break out of the loop if found
                    break;
                }

                parent = parent.Parent; // Move up in the control hierarchy
            }




        }
    }
}
