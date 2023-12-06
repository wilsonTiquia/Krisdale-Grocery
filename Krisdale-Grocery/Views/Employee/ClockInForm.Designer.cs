namespace Krisdale_Grocery.Views.Employee
{
    partial class ClockInForm
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
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            clockInButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(52, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(52, 99);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(133, 61);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(156, 23);
            userNameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(133, 99);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(156, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // clockInButton
            // 
            clockInButton.Cursor = Cursors.Hand;
            clockInButton.Location = new Point(123, 154);
            clockInButton.Name = "clockInButton";
            clockInButton.Size = new Size(110, 43);
            clockInButton.TabIndex = 4;
            clockInButton.Text = "Clock In";
            clockInButton.UseVisualStyleBackColor = true;
            clockInButton.Click += clockInButton_Click;
            // 
            // closeButton
            // 
            closeButton.Cursor = Cursors.Hand;
            closeButton.Location = new Point(123, 202);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(110, 47);
            closeButton.TabIndex = 5;
            closeButton.Text = "Back To Cashier";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ClockInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(348, 284);
            Controls.Add(closeButton);
            Controls.Add(clockInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ClockInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClockInForm";
            FormClosed += ClockInForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button clockInButton;
        private Button closeButton;
    }
}