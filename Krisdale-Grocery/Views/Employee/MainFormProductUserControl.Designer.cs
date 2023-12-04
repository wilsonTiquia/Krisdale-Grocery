namespace Krisdale_Grocery.Views.Employee
{
    partial class MainFormProductUserControl
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
            productIdLabel = new Label();
            productNameLabel = new Label();
            priceLabel = new Label();
            quantityLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // productImagePictureBox
            // 
            productImagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            productImagePictureBox.BorderStyle = BorderStyle.Fixed3D;
            productImagePictureBox.Image = Images.NOPRODUCTAVAILABLE;
            productImagePictureBox.Location = new Point(25, 23);
            productImagePictureBox.Name = "productImagePictureBox";
            productImagePictureBox.Size = new Size(100, 89);
            productImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productImagePictureBox.TabIndex = 0;
            productImagePictureBox.TabStop = false;
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new Point(45, 6);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(67, 15);
            productIdLabel.TabIndex = 1;
            productIdLabel.Text = "PRODUCT#";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(32, 124);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(81, 15);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "ProductName";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(52, 148);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(45, 171);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(53, 15);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Quantity";
            // 
            // MainFormProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(quantityLabel);
            Controls.Add(priceLabel);
            Controls.Add(productNameLabel);
            Controls.Add(productIdLabel);
            Controls.Add(productImagePictureBox);
            Cursor = Cursors.Hand;
            Margin = new Padding(8);
            Name = "MainFormProductUserControl";
            Padding = new Padding(10);
            Size = new Size(153, 198);
            Click += MainFormProductUserControl_Click;
            ((System.ComponentModel.ISupportInitialize)productImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productImagePictureBox;
        private Label productIdLabel;
        private Label productNameLabel;
        private Label priceLabel;
        private Label quantityLabel;
    }
}
