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
            fNameRule = new Label();
            numberRules = new Label();
            lNameRule = new Label();
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
            contactNumberTextBox.MaxLength = 11;
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(201, 23);
            contactNumberTextBox.TabIndex = 5;
            contactNumberTextBox.TextChanged += contactNumberTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(251, 74);
            lastNameTextBox.MaxLength = 15;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(201, 23);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(251, 38);
            firstNameTextBox.MaxLength = 15;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(201, 23);
            firstNameTextBox.TabIndex = 7;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
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
            // fNameRule
            // 
            fNameRule.AutoSize = true;
            fNameRule.ForeColor = Color.Red;
            fNameRule.Location = new Point(1, 9);
            fNameRule.Name = "fNameRule";
            fNameRule.Size = new Size(214, 15);
            fNameRule.TabIndex = 15;
            fNameRule.Text = "First Name must be 3-15 Characters a-z";
            // 
            // numberRules
            // 
            numberRules.AutoSize = true;
            numberRules.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            numberRules.ForeColor = Color.Red;
            numberRules.Location = new Point(5, 96);
            numberRules.Name = "numberRules";
            numberRules.Size = new Size(181, 13);
            numberRules.TabIndex = 16;
            numberRules.Text = "Contact number must be 11 digits";
            // 
            // lNameRule
            // 
            lNameRule.AutoSize = true;
            lNameRule.ForeColor = Color.Red;
            lNameRule.Location = new Point(5, 56);
            lNameRule.Name = "lNameRule";
            lNameRule.Size = new Size(213, 15);
            lNameRule.TabIndex = 17;
            lNameRule.Text = "Last Name must be 3-15 Characters a-z";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            ClientSize = new Size(867, 412);
            Controls.Add(lNameRule);
            Controls.Add(numberRules);
            Controls.Add(fNameRule);
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
        private Label fNameRule;
        private Label numberRules;
        private Label lNameRule;
    }
}