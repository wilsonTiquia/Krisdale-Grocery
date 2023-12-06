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

namespace Krisdale_Grocery.Views.Employee
{
    public partial class ItemInCartUserControl : UserControl
    {
        private int id;
        public ItemInCartUserControl()
        {
            InitializeComponent();
        }

        public void setQuantity(string quantity)
        {
            quantityLabel.Text = quantity;

        }
        public string getQuantity()
        {
            return quantityLabel.Text;
        }
        public void setProductName(string productName)
        {
            productNameLabel.Text = productName;
        }
        public void setPrice(string price)
        {
            priceLabel.Text = price;
        }

        public void setTotal(string total)
        {
            totalPriceLabel.Text = total;
        }
        public string getTotal()
        {
            return totalPriceLabel.Text;
        }
        public string getProductName()
        {
            return productNameLabel.Text;
        }
        public string getPrice()
        {
            return priceLabel.Text; 
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        private void ItemInCartUserControl_Click(object sender, EventArgs e)
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
                        // Optionally, call a method in MainForm to remove the product from the cart if needed
                        mainForm.removeItemInCart(id.ToString(), priceLabel.Text, quantityLabel.Text);
                    }
                    if (parent.Controls.Contains(this))
                    {

                        parent.Controls.Remove(this);
                    }

                }

                parent = parent.Parent; // Move up in the control hierarchy
            }
        }
    }
}
