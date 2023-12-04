namespace Krisdale_Grocery.Views.Employee
{
    partial class ClockOutForm
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
            closeButton = new Button();
            clockOutButton = new Button();
            passwordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Cursor = Cursors.Hand;
            closeButton.Location = new Point(127, 189);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(110, 47);
            closeButton.TabIndex = 11;
            closeButton.Text = "Back To Cashier";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // clockOutButton
            // 
            clockOutButton.Cursor = Cursors.Hand;
            clockOutButton.Location = new Point(127, 141);
            clockOutButton.Name = "clockOutButton";
            clockOutButton.Size = new Size(110, 43);
            clockOutButton.TabIndex = 10;
            clockOutButton.Text = "Clock Out";
            clockOutButton.UseVisualStyleBackColor = true;
            clockOutButton.Click += clockOutButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(137, 86);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(156, 23);
            passwordTextBox.TabIndex = 9;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(137, 48);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(156, 23);
            userNameTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(56, 86);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(56, 48);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // ClockOutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(348, 284);
            Controls.Add(closeButton);
            Controls.Add(clockOutButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ClockOutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClockOutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Button clockOutButton;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private Label label2;
        private Label label1;
    }
}