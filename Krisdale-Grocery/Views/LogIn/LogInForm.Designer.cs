namespace Krisdale_Grocery.Views.LogIn
{
    partial class LogInForm
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
            pictureBox1 = new PictureBox();
            logInButton = new Button();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(151, 242);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(151, 271);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Images.LOGO;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(176, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 210);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(234, 311);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(96, 42);
            logInButton.TabIndex = 3;
            logInButton.Text = "LogIn";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(234, 239);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(152, 23);
            userNameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(234, 271);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(152, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.loginformbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(579, 375);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(logInButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "LogInForm";
            Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button logInButton;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
    }
}