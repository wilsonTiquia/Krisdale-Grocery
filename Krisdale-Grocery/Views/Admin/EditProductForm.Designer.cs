namespace Krisdale_Grocery.Views.Admin
{
    partial class EditProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productNameLabel = new Label();
            priceLabel = new Label();
            quantityLabel = new Label();
            imageLabel = new Label();
            productNameTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            uploadImageButton = new Button();
            clearImageButton = new Button();
            saveButton = new Button();
            deleteProduct = new Button();
            uploadedImagePictureBox = new PictureBox();
            backToMainMenuButton = new Button();
            pRule = new Label();
            qRule = new Label();
            pNameRule = new Label();
            ((System.ComponentModel.ISupportInitialize)uploadedImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.BackColor = Color.Transparent;
            productNameLabel.Location = new Point(181, 70);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(42, 15);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Location = new Point(181, 105);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(36, 15);
            priceLabel.TabIndex = 1;
            priceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Location = new Point(181, 144);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(56, 15);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.BackColor = Color.Transparent;
            imageLabel.Location = new Point(181, 184);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(43, 15);
            imageLabel.TabIndex = 3;
            imageLabel.Text = "Image:";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(249, 73);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(174, 23);
            productNameTextBox.TabIndex = 4;
            productNameTextBox.TextChanged += productNameTextBox_TextChanged;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(248, 108);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(175, 23);
            priceTextBox.TabIndex = 5;
            priceTextBox.TextChanged += priceTextBox_TextChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(247, 146);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(176, 23);
            quantityTextBox.TabIndex = 6;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // uploadImageButton
            // 
            uploadImageButton.Location = new Point(247, 184);
            uploadImageButton.Name = "uploadImageButton";
            uploadImageButton.Size = new Size(136, 37);
            uploadImageButton.TabIndex = 7;
            uploadImageButton.Text = "Upload Image";
            uploadImageButton.UseVisualStyleBackColor = true;
            uploadImageButton.Click += uploadImageButton_Click;
            // 
            // clearImageButton
            // 
            clearImageButton.Location = new Point(389, 184);
            clearImageButton.Name = "clearImageButton";
            clearImageButton.Size = new Size(111, 37);
            clearImageButton.TabIndex = 8;
            clearImageButton.Text = "Clear Image";
            clearImageButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(237, 247);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(124, 42);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.BackColor = Color.Red;
            deleteProduct.FlatAppearance.BorderColor = Color.Red;
            deleteProduct.FlatAppearance.BorderSize = 0;
            deleteProduct.Location = new Point(597, 265);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(128, 58);
            deleteProduct.TabIndex = 10;
            deleteProduct.Text = "DELETE PRODUCT";
            deleteProduct.UseVisualStyleBackColor = false;
            deleteProduct.Click += button4_Click;
            // 
            // uploadedImagePictureBox
            // 
            uploadedImagePictureBox.Image = Images.NOPRODUCTAVAILABLE;
            uploadedImagePictureBox.Location = new Point(544, 53);
            uploadedImagePictureBox.Name = "uploadedImagePictureBox";
            uploadedImagePictureBox.Size = new Size(195, 146);
            uploadedImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            uploadedImagePictureBox.TabIndex = 12;
            uploadedImagePictureBox.TabStop = false;
            uploadedImagePictureBox.WaitOnLoad = true;
            // 
            // backToMainMenuButton
            // 
            backToMainMenuButton.Location = new Point(237, 319);
            backToMainMenuButton.Name = "backToMainMenuButton";
            backToMainMenuButton.Size = new Size(131, 58);
            backToMainMenuButton.TabIndex = 11;
            backToMainMenuButton.Text = "Back To Main Menu";
            backToMainMenuButton.UseVisualStyleBackColor = true;
            backToMainMenuButton.Click += backToMainMenuButton_Click;
            // 
            // pRule
            // 
            pRule.AutoSize = true;
            pRule.ForeColor = Color.Red;
            pRule.Location = new Point(52, 90);
            pRule.Name = "pRule";
            pRule.Size = new Size(162, 15);
            pRule.TabIndex = 23;
            pRule.Text = "Price must not contain letters";
            // 
            // qRule
            // 
            qRule.AutoSize = true;
            qRule.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            qRule.ForeColor = Color.Red;
            qRule.Location = new Point(52, 130);
            qRule.Name = "qRule";
            qRule.Size = new Size(147, 13);
            qRule.TabIndex = 22;
            qRule.Text = "Quantity must be a number";
            // 
            // pNameRule
            // 
            pNameRule.AutoSize = true;
            pNameRule.ForeColor = Color.Red;
            pNameRule.Location = new Point(48, 43);
            pNameRule.Name = "pNameRule";
            pNameRule.Size = new Size(365, 15);
            pNameRule.TabIndex = 21;
            pNameRule.Text = "Name must be 3 to 15 characters and consist of numbers and letters";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pRule);
            Controls.Add(qRule);
            Controls.Add(pNameRule);
            Controls.Add(uploadedImagePictureBox);
            Controls.Add(backToMainMenuButton);
            Controls.Add(deleteProduct);
            Controls.Add(saveButton);
            Controls.Add(clearImageButton);
            Controls.Add(uploadImageButton);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(imageLabel);
            Controls.Add(quantityLabel);
            Controls.Add(priceLabel);
            Controls.Add(productNameLabel);
            DoubleBuffered = true;
            Name = "EditProductForm";
            Text = "EditProductForm";
            FormClosed += EditProductForm_FormClosed;
            Load += EditProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)uploadedImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productNameLabel;
        private Label priceLabel;
        private Label quantityLabel;
        private Label imageLabel;
        private TextBox productNameTextBox;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private Button uploadImageButton;
        private Button clearImageButton;
        private Button saveButton;
        private Button deleteProduct;
        private PictureBox uploadedImagePictureBox;
        private Button backToMainMenuButton;
        private Label pRule;
        private Label qRule;
        private Label pNameRule;
    }
}