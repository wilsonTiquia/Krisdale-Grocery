namespace Krisdale_Grocery.Views.Admin
{
    partial class AddProductForm
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
            nameLabel = new Label();
            priceLabel = new Label();
            quantityLabel = new Label();
            label4 = new Label();
            uploadedImagePictureBox = new PictureBox();
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            uploadImageButton = new Button();
            clearImageButton = new Button();
            saveImageButton = new Button();
            clearAllFieldsButton = new Button();
            backToMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)uploadedImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Location = new Point(121, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Location = new Point(121, 97);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(36, 15);
            priceLabel.TabIndex = 1;
            priceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Location = new Point(121, 130);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(56, 15);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(121, 176);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Upload Image:";
            // 
            // uploadedImagePictureBox
            // 
            uploadedImagePictureBox.BorderStyle = BorderStyle.Fixed3D;
            uploadedImagePictureBox.Image = Images.NOPRODUCTAVAILABLE;
            uploadedImagePictureBox.Location = new Point(483, 27);
            uploadedImagePictureBox.Name = "uploadedImagePictureBox";
            uploadedImagePictureBox.Size = new Size(210, 176);
            uploadedImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            uploadedImagePictureBox.TabIndex = 4;
            uploadedImagePictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(205, 51);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(120, 23);
            nameTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(207, 89);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(118, 23);
            priceTextBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(207, 122);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(118, 23);
            quantityTextBox.TabIndex = 7;
            // 
            // uploadImageButton
            // 
            uploadImageButton.Location = new Point(207, 172);
            uploadImageButton.Name = "uploadImageButton";
            uploadImageButton.Size = new Size(145, 23);
            uploadImageButton.TabIndex = 8;
            uploadImageButton.Text = "Upload Image";
            uploadImageButton.UseVisualStyleBackColor = true;
            uploadImageButton.Click += uploadImageButton_Click;
            // 
            // clearImageButton
            // 
            clearImageButton.Location = new Point(358, 172);
            clearImageButton.Name = "clearImageButton";
            clearImageButton.Size = new Size(119, 23);
            clearImageButton.TabIndex = 9;
            clearImageButton.Text = "Clear Image";
            clearImageButton.UseVisualStyleBackColor = true;
            clearImageButton.Click += clearImageButton_Click;
            // 
            // saveImageButton
            // 
            saveImageButton.Location = new Point(152, 240);
            saveImageButton.Name = "saveImageButton";
            saveImageButton.Size = new Size(75, 23);
            saveImageButton.TabIndex = 10;
            saveImageButton.Text = "Save";
            saveImageButton.UseVisualStyleBackColor = true;
            saveImageButton.Click += saveImageButton_Click;
            // 
            // clearAllFieldsButton
            // 
            clearAllFieldsButton.Location = new Point(281, 241);
            clearAllFieldsButton.Name = "clearAllFieldsButton";
            clearAllFieldsButton.Size = new Size(75, 23);
            clearAllFieldsButton.TabIndex = 12;
            clearAllFieldsButton.Text = "Clear";
            clearAllFieldsButton.UseVisualStyleBackColor = true;
            clearAllFieldsButton.Click += clearAllFieldsButton_Click;
            // 
            // backToMenuButton
            // 
            backToMenuButton.Location = new Point(203, 306);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(122, 50);
            backToMenuButton.TabIndex = 13;
            backToMenuButton.Text = "Back To Main Menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(backToMenuButton);
            Controls.Add(clearAllFieldsButton);
            Controls.Add(saveImageButton);
            Controls.Add(clearImageButton);
            Controls.Add(uploadImageButton);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(uploadedImagePictureBox);
            Controls.Add(label4);
            Controls.Add(quantityLabel);
            Controls.Add(priceLabel);
            Controls.Add(nameLabel);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)uploadedImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label priceLabel;
        private Label quantityLabel;
        private Label label4;
        private PictureBox uploadedImagePictureBox;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private Button uploadImageButton;
        private Button clearImageButton;
        private Button saveImageButton;
        private Button clearAllFieldsButton;
        private Button backToMenuButton;
    }
}