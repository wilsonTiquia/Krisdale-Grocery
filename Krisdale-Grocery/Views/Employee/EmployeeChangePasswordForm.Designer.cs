namespace Krisdale_Grocery.Views.Employee
{
    partial class EmployeeChangePasswordForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            changePasswordButton = new Button();
            backToMainMenuButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(63, 48);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(63, 88);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(63, 130);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "New Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(156, 48);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(196, 23);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(156, 85);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(196, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(156, 127);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(196, 23);
            newPasswordTextBox.TabIndex = 5;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(138, 172);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(123, 41);
            changePasswordButton.TabIndex = 6;
            changePasswordButton.Text = "Change Password";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // backToMainMenuButton
            // 
            backToMainMenuButton.Location = new Point(138, 228);
            backToMainMenuButton.Name = "backToMainMenuButton";
            backToMainMenuButton.Size = new Size(123, 51);
            backToMainMenuButton.TabIndex = 7;
            backToMainMenuButton.Text = "Back To Main Menu";
            backToMainMenuButton.UseVisualStyleBackColor = true;
            backToMainMenuButton.Click += backToMainMenuButton_Click;
            // 
            // EmployeeChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(495, 313);
            Controls.Add(backToMainMenuButton);
            Controls.Add(changePasswordButton);
            Controls.Add(newPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "EmployeeChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox newPasswordTextBox;
        private Button changePasswordButton;
        private Button backToMainMenuButton;
    }
}