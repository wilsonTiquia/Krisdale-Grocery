namespace Krisdale_Grocery.Views.Admin
{
    partial class EditEmployeeForm
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
            startedWorkingLabel = new Label();
            contactNumberLabel = new Label();
            label5 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            contactNumberTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            uploadImageButton = new Button();
            clearImageButton = new Button();
            saveButton = new Button();
            deleteEmployeeButton = new Button();
            backToMainMenuButton = new Button();
            employeeImagePictureBox = new PictureBox();
            lNameRule = new Label();
            numberRules = new Label();
            fNameRule = new Label();
            ((System.ComponentModel.ISupportInitialize)employeeImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Location = new Point(150, 49);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.Transparent;
            lastNameLabel.Location = new Point(150, 89);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // startedWorkingLabel
            // 
            startedWorkingLabel.AutoSize = true;
            startedWorkingLabel.BackColor = Color.Transparent;
            startedWorkingLabel.Location = new Point(150, 181);
            startedWorkingLabel.Name = "startedWorkingLabel";
            startedWorkingLabel.Size = new Size(95, 15);
            startedWorkingLabel.TabIndex = 2;
            startedWorkingLabel.Text = "Started Working:";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.BackColor = Color.Transparent;
            contactNumberLabel.Location = new Point(150, 133);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new Size(99, 15);
            contactNumberLabel.TabIndex = 3;
            contactNumberLabel.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(150, 226);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Image:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(275, 46);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(215, 23);
            firstNameTextBox.TabIndex = 5;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(275, 89);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(215, 23);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.Location = new Point(275, 133);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(215, 23);
            contactNumberTextBox.TabIndex = 7;
            contactNumberTextBox.TextChanged += contactNumberTextBox_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(290, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // uploadImageButton
            // 
            uploadImageButton.Location = new Point(275, 226);
            uploadImageButton.Name = "uploadImageButton";
            uploadImageButton.Size = new Size(99, 30);
            uploadImageButton.TabIndex = 9;
            uploadImageButton.Text = "Upload Image";
            uploadImageButton.UseVisualStyleBackColor = true;
            uploadImageButton.Click += uploadImageButton_Click;
            // 
            // clearImageButton
            // 
            clearImageButton.Location = new Point(395, 226);
            clearImageButton.Name = "clearImageButton";
            clearImageButton.Size = new Size(95, 30);
            clearImageButton.TabIndex = 10;
            clearImageButton.Text = "Clear Image";
            clearImageButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(307, 285);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(113, 57);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteEmployeeButton
            // 
            deleteEmployeeButton.BackColor = Color.Red;
            deleteEmployeeButton.Location = new Point(672, 245);
            deleteEmployeeButton.Name = "deleteEmployeeButton";
            deleteEmployeeButton.Size = new Size(116, 67);
            deleteEmployeeButton.TabIndex = 12;
            deleteEmployeeButton.Text = "DELETE";
            deleteEmployeeButton.UseVisualStyleBackColor = false;
            deleteEmployeeButton.Click += deleteEmployeeButton_Click;
            // 
            // backToMainMenuButton
            // 
            backToMainMenuButton.Location = new Point(321, 363);
            backToMainMenuButton.Name = "backToMainMenuButton";
            backToMainMenuButton.Size = new Size(120, 57);
            backToMainMenuButton.TabIndex = 13;
            backToMainMenuButton.Text = "Back To Main Menu";
            backToMainMenuButton.UseVisualStyleBackColor = true;
            backToMainMenuButton.Click += backToMainMenuButton_Click;
            // 
            // employeeImagePictureBox
            // 
            employeeImagePictureBox.BorderStyle = BorderStyle.Fixed3D;
            employeeImagePictureBox.Image = Images.blank_picture;
            employeeImagePictureBox.Location = new Point(586, 46);
            employeeImagePictureBox.Name = "employeeImagePictureBox";
            employeeImagePictureBox.Size = new Size(191, 144);
            employeeImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            employeeImagePictureBox.TabIndex = 14;
            employeeImagePictureBox.TabStop = false;
            // 
            // lNameRule
            // 
            lNameRule.AutoSize = true;
            lNameRule.ForeColor = Color.Red;
            lNameRule.Location = new Point(57, 69);
            lNameRule.Name = "lNameRule";
            lNameRule.Size = new Size(213, 15);
            lNameRule.TabIndex = 20;
            lNameRule.Text = "Last Name must be 3-15 Characters a-z";
            // 
            // numberRules
            // 
            numberRules.AutoSize = true;
            numberRules.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            numberRules.ForeColor = Color.Red;
            numberRules.Location = new Point(57, 109);
            numberRules.Name = "numberRules";
            numberRules.Size = new Size(181, 13);
            numberRules.TabIndex = 19;
            numberRules.Text = "Contact number must be 11 digits";
            // 
            // fNameRule
            // 
            fNameRule.AutoSize = true;
            fNameRule.ForeColor = Color.Red;
            fNameRule.Location = new Point(53, 22);
            fNameRule.Name = "fNameRule";
            fNameRule.Size = new Size(214, 15);
            fNameRule.TabIndex = 18;
            fNameRule.Text = "First Name must be 3-15 Characters a-z";
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lNameRule);
            Controls.Add(numberRules);
            Controls.Add(fNameRule);
            Controls.Add(employeeImagePictureBox);
            Controls.Add(backToMainMenuButton);
            Controls.Add(deleteEmployeeButton);
            Controls.Add(saveButton);
            Controls.Add(clearImageButton);
            Controls.Add(uploadImageButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(contactNumberTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label5);
            Controls.Add(contactNumberLabel);
            Controls.Add(startedWorkingLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            DoubleBuffered = true;
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            Load += EditEmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)employeeImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label startedWorkingLabel;
        private Label contactNumberLabel;
        private Label label5;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox contactNumberTextBox;
        private DateTimePicker dateTimePicker1;
        private Button uploadImageButton;
        private Button clearImageButton;
        private Button saveButton;
        private Button deleteEmployeeButton;
        private Button backToMainMenuButton;
        private PictureBox employeeImagePictureBox;
        private Label lNameRule;
        private Label numberRules;
        private Label fNameRule;
    }
}