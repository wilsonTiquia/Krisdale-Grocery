namespace Krisdale_Grocery.Views.Admin
{
    partial class AddEmployeeForm
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            contactNumberLabel = new Label();
            startedWorkingLabel = new Label();
            dateStartedWorkingPicker = new DateTimePicker();
            contactNumberTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            uploadedImagePictureBox = new PictureBox();
            label1 = new Label();
            openFileButton = new Button();
            clearImageButton = new Button();
            saveButton = new Button();
            clearAllButton = new Button();
            backToMainMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)uploadedImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Location = new Point(129, 41);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(70, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name: ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.Transparent;
            lastNameLabel.Location = new Point(129, 74);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.BackColor = Color.Transparent;
            contactNumberLabel.Location = new Point(126, 109);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new Size(99, 15);
            contactNumberLabel.TabIndex = 2;
            contactNumberLabel.Text = "Contact Number:";
            // 
            // startedWorkingLabel
            // 
            startedWorkingLabel.AutoSize = true;
            startedWorkingLabel.BackColor = Color.Transparent;
            startedWorkingLabel.Location = new Point(128, 150);
            startedWorkingLabel.Name = "startedWorkingLabel";
            startedWorkingLabel.Size = new Size(95, 15);
            startedWorkingLabel.TabIndex = 3;
            startedWorkingLabel.Text = "Started Working:";
            // 
            // dateStartedWorkingPicker
            // 
            dateStartedWorkingPicker.Location = new Point(252, 150);
            dateStartedWorkingPicker.Name = "dateStartedWorkingPicker";
            dateStartedWorkingPicker.Size = new Size(200, 23);
            dateStartedWorkingPicker.TabIndex = 4;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.Location = new Point(251, 112);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(201, 23);
            contactNumberTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(251, 74);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(201, 23);
            lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(251, 38);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(201, 23);
            firstNameTextBox.TabIndex = 7;
            // 
            // uploadedImagePictureBox
            // 
            uploadedImagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            uploadedImagePictureBox.BorderStyle = BorderStyle.Fixed3D;
            uploadedImagePictureBox.Image = Images.blank_picture;
            uploadedImagePictureBox.InitialImage = Images.blank_picture;
            uploadedImagePictureBox.Location = new Point(533, 41);
            uploadedImagePictureBox.Name = "uploadedImagePictureBox";
            uploadedImagePictureBox.Size = new Size(198, 132);
            uploadedImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            uploadedImagePictureBox.TabIndex = 8;
            uploadedImagePictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 204);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 9;
            label1.Text = "Upload Image:";
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(251, 200);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(99, 23);
            openFileButton.TabIndex = 10;
            openFileButton.Text = "Open File";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // clearImageButton
            // 
            clearImageButton.Location = new Point(356, 200);
            clearImageButton.Name = "clearImageButton";
            clearImageButton.Size = new Size(128, 23);
            clearImageButton.TabIndex = 11;
            clearImageButton.Text = "Clear Image";
            clearImageButton.UseVisualStyleBackColor = true;
            clearImageButton.Click += clearImageButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(229, 263);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 46);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearAllButton
            // 
            clearAllButton.Location = new Point(360, 263);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(92, 46);
            clearAllButton.TabIndex = 13;
            clearAllButton.Text = "Clear";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // backToMainMenuButton
            // 
            backToMainMenuButton.Location = new Point(284, 329);
            backToMainMenuButton.Name = "backToMainMenuButton";
            backToMainMenuButton.Size = new Size(124, 52);
            backToMainMenuButton.TabIndex = 14;
            backToMainMenuButton.Text = "Back To Main Menu";
            backToMainMenuButton.UseVisualStyleBackColor = true;
            backToMainMenuButton.Click += backToMainMenuButton_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            ClientSize = new Size(755, 412);
            Controls.Add(backToMainMenuButton);
            Controls.Add(clearAllButton);
            Controls.Add(saveButton);
            Controls.Add(clearImageButton);
            Controls.Add(openFileButton);
            Controls.Add(label1);
            Controls.Add(uploadedImagePictureBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(contactNumberTextBox);
            Controls.Add(dateStartedWorkingPicker);
            Controls.Add(startedWorkingLabel);
            Controls.Add(contactNumberLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)uploadedImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label contactNumberLabel;
        private Label startedWorkingLabel;
        private DateTimePicker dateStartedWorkingPicker;
        private TextBox contactNumberTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private PictureBox uploadedImagePictureBox;
        private Label label1;
        private Button openFileButton;
        private Button clearImageButton;
        private Button saveButton;
        private Button clearAllButton;
        private Button backToMainMenuButton;
    }
}