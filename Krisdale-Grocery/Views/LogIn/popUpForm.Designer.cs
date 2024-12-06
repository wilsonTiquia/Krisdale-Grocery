namespace Krisdale_Grocery.Views.LogIn
{
    partial class popUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popUpForm));
            label1 = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            confirmPasswordTextBox = new TextBox();
            passwordRulesLabel = new Label();
            passwordMatchLabel = new Label();
            button1 = new Button();
            usernamelabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 23);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 59);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirm Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(174, 19);
            passwordTextBox.MaxLength = 15;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(179, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(174, 57);
            confirmPasswordTextBox.MaxLength = 15;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(179, 23);
            confirmPasswordTextBox.TabIndex = 3;
            confirmPasswordTextBox.TextChanged += confirmPasswordTextBox_TextChanged;
            // 
            // passwordRulesLabel
            // 
            passwordRulesLabel.AutoSize = true;
            passwordRulesLabel.ForeColor = Color.Red;
            passwordRulesLabel.Location = new Point(359, 19);
            passwordRulesLabel.Name = "passwordRulesLabel";
            passwordRulesLabel.Size = new Size(313, 75);
            passwordRulesLabel.TabIndex = 14;
            passwordRulesLabel.Text = resources.GetString("passwordRulesLabel.Text");
            // 
            // passwordMatchLabel
            // 
            passwordMatchLabel.AutoSize = true;
            passwordMatchLabel.ForeColor = Color.Red;
            passwordMatchLabel.Location = new Point(41, 102);
            passwordMatchLabel.Name = "passwordMatchLabel";
            passwordMatchLabel.Size = new Size(277, 15);
            passwordMatchLabel.TabIndex = 15;
            passwordMatchLabel.Text = "Password and Confirm Password must be the same";
            // 
            // button1
            // 
            button1.Location = new Point(174, 142);
            button1.Name = "button1";
            button1.Size = new Size(237, 34);
            button1.TabIndex = 16;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Location = new Point(41, 3);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(60, 15);
            usernamelabel.TabIndex = 17;
            usernamelabel.Text = "Username";
            // 
            // popUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 214);
            Controls.Add(usernamelabel);
            Controls.Add(button1);
            Controls.Add(passwordMatchLabel);
            Controls.Add(passwordRulesLabel);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "popUpForm";
            Text = "popUpForm";
            Load += popUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTextBox;
        private Label passwordRulesLabel;
        private Label passwordMatchLabel;
        private Button button1;
        private Label usernamelabel;
    }
}