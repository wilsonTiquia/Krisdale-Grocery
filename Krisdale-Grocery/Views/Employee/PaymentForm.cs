using Krisdale_Grocery.DatabaseAccess;
using Krisdale_Grocery.Model;
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

namespace Krisdale_Grocery.Views.Employee
{
    public partial class PaymentForm : Form
    {
        public double totalAmount;
        public Dictionary<string, ItemInCartUserControl> cartItems = new Dictionary<string, ItemInCartUserControl>();
        public Dictionary<string, ProductInformation> itemsInCartToUpdateInDatabase = new Dictionary<string, ProductInformation>();

        public PaymentForm()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            // before closing update the database with the items that is used and the quantity

            foreach (var item in itemsInCartToUpdateInDatabase)
            {
                int productid = int.Parse(item.Key);
                int quantity = item.Value.Quantity;

                DatabaseHelper.EditProductQuantity(productid, quantity);

            }
            this.Close();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            string pattern = @"^\d+(\.\d+)?$"; // Regex for numbers only
           

            if (Regex.IsMatch(amountPaidTextBox.Text, pattern))
            {
                if(double.Parse(amountPaidTextBox.Text) < totalAmount)
                {
                    MessageBox.Show("Amount paid must be greater than the total amount");
                }
                if (double.Parse(amountPaidTextBox.Text) > totalAmount)
                {
                    changeTextBox.Text = (double.Parse(amountPaidTextBox.Text) - totalAmount).ToString("F2");
                    closeButton.Enabled = true;
                }
               
            }
            else
            {
                MessageBox.Show("Must only contain numbers");
            }
                
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            totalAmountTextBox.Text = totalAmount.ToString("F2");
            setReceipt();
        }
        private void setReceipt()
        {
            cartRichTextBox.Clear(); // Clear the RichTextBox before printing

            cartRichTextBox.SelectionAlignment = HorizontalAlignment.Center; // Center align the text

            cartRichTextBox.AppendText("------------------------------\n");
            cartRichTextBox.AppendText("        RECEIPT\n");
            cartRichTextBox.AppendText("------------------------------\n\n");

            // Finding the length of the longest product name for padding
            int maxProductNameLength = 0;
            foreach (var cartItem in cartItems)
            {
                int productNameLength = cartItem.Value.getProductName().Length;
                if (productNameLength > maxProductNameLength)
                {
                    maxProductNameLength = productNameLength;
                }
            }

            foreach (var cartItem in cartItems)
            {

                string productId = cartItem.Key; // Assuming the product ID is the key in the dictionary
                string productName = cartItem.Value.getProductName();
                int quantity = int.Parse(cartItem.Value.getQuantity());
                string price = cartItem.Value.getPrice();
                string totalPrice = cartItem.Value.getTotal();
                // add to products to edit in database
                ProductInformation productInformation = new ProductInformation(productId, quantity);
                itemsInCartToUpdateInDatabase.Add(productId, productInformation);
                // Calculate the padding spaces based on the difference in lengths
                int paddingSpaces = maxProductNameLength - productName.Length;
                string padding = new string(' ', paddingSpaces);

                // Format each item with the calculated padding
                string itemLine = $"{productName}{padding} {quantity,5} x {price,-10} = {totalPrice}\n";
                cartRichTextBox.AppendText(itemLine);
            }

            cartRichTextBox.AppendText("\n------------------------------\n");
            cartRichTextBox.SelectionAlignment = HorizontalAlignment.Right; // Right align the total amount
            cartRichTextBox.AppendText($"TOTAL AMOUNT: {totalAmount.ToString("F2")}\n");
        }




    }
    //    private void setReceipt()
    //    {
    //        cartRichTextBox.Clear(); // Clear the RichTextBox before printing

    //        cartRichTextBox.SelectionAlignment = HorizontalAlignment.Center; // Center align the text

    //        cartRichTextBox.AppendText("------------------------------\n");
    //        cartRichTextBox.AppendText("        RECEIPT\n");
    //        cartRichTextBox.AppendText("------------------------------\n\n");

    //        // Finding the length of the longest product name for padding
    //        int maxProductNameLength = 0;
    //        foreach (var cartItem in cartItems)
    //        {
    //            int productNameLength = cartItem.Value.getProductName().Length;
    //            if (productNameLength > maxProductNameLength)
    //            {
    //                maxProductNameLength = productNameLength;
    //            }
    //        }

    //        foreach (var cartItem in cartItems)
    //        {
    //            string productName = cartItem.Value.getProductName();
    //            string quantity = cartItem.Value.getQuantity();
    //            string price = cartItem.Value.getPrice();
    //            string totalPrice = cartItem.Value.getTotal();

    //            // Calculate the padding spaces based on the difference in lengths
    //            int paddingSpaces = maxProductNameLength - productName.Length;
    //            string padding = new string(' ', paddingSpaces);

    //            // Format each item with the calculated padding
    //            string itemLine = $"{productName}{padding} {quantity,5} x {price,-10} = {totalPrice}\n";
    //            cartRichTextBox.AppendText(itemLine);
    //        }

    //        cartRichTextBox.AppendText("\n------------------------------\n");
    //        cartRichTextBox.SelectionAlignment = HorizontalAlignment.Right; // Right align the total amount
    //        cartRichTextBox.AppendText($"TOTAL AMOUNT: {totalAmount.ToString("F2")}\n");
    //    }


    //}
}
