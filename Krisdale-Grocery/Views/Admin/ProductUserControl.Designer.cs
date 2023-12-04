namespace Krisdale_Grocery.Views.Admin
{
    partial class ProductUserControl
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
            productImagePictureBox = new PictureBox();
            productNameLabel = new Label();
            quantityLabel = new Label();
            priceLabel = new Label();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // productImagePictureBox
            // 
            productImagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            productImagePictureBox.Image = Images.NOPRODUCTAVAILABLE;
            productImagePictureBox.Location = new Point(37, 20);
            productImagePictureBox.Name = "productImagePictureBox";
            productImagePictureBox.Size = new Size(122, 103);
            productImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productImagePictureBox.TabIndex = 0;
            productImagePictureBox.TabStop = false;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(61, 126);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(84, 15);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Product Name";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(61, 151);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(55, 15);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "In Stock: ";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(61, 176);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 2);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(28, 15);
            idLabel.TabIndex = 4;
            idLabel.Text = "ID# ";
            // 
            // ProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            Controls.Add(idLabel);
            Controls.Add(priceLabel);
            Controls.Add(quantityLabel);
            Controls.Add(productNameLabel);
            Controls.Add(productImagePictureBox);
            Name = "ProductUserControl";
            Size = new Size(199, 200);
            Click += ProductUserControl_Click;
            ((System.ComponentModel.ISupportInitialize)productImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productImagePictureBox;
        private Label productNameLabel;
        private Label quantityLabel;
        private Label priceLabel;
        private Label idLabel;
    }
}
