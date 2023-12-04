namespace Krisdale_Grocery.Views.Employee
{
    partial class ItemInCartUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            quantityLabel = new Label();
            productNameLabel = new Label();
            priceLabel = new Label();
            totalPriceLabel = new Label();
            SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(15, 26);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(53, 15);
            quantityLabel.TabIndex = 0;
            quantityLabel.Text = "Quantity";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(164, 26);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(84, 15);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Product Name";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(164, 55);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Price";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(486, 38);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(58, 15);
            totalPriceLabel.TabIndex = 3;
            totalPriceLabel.Text = "TotalPrice";
            // 
            // ItemInCartUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(totalPriceLabel);
            Controls.Add(priceLabel);
            Controls.Add(productNameLabel);
            Controls.Add(quantityLabel);
            Margin = new Padding(25, 10, 0, 0);
            Name = "ItemInCartUserControl";
            Size = new Size(562, 84);
            Click += ItemInCartUserControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quantityLabel;
        private Label productNameLabel;
        private Label priceLabel;
        private Label totalPriceLabel;
    }
}
