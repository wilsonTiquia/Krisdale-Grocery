namespace Krisdale_Grocery.Views.Admin
{
    partial class DashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            pictureBox1 = new PictureBox();
            selectedOptionLabel = new Label();
            panel1 = new Panel();
            logOutButton = new Button();
            settingsButton = new Button();
            label1 = new Label();
            crudProductsLabel = new Label();
            label5 = new Label();
            viewAttendanceLabel = new Label();
            crudEmployeeLabel = new Label();
            label2 = new Label();
            mainPanel = new Panel();
            settingsPanel = new Panel();
            label13 = new Label();
            label12 = new Label();
            panel7 = new Panel();
            changePassRules = new Label();
            newPasswordForExistingTextBox = new TextBox();
            label11 = new Label();
            changePasswordButton = new Button();
            label9 = new Label();
            userNameExistingTextBox = new TextBox();
            passwordExistingTextBox = new TextBox();
            label10 = new Label();
            panel6 = new Panel();
            securityKeyRule = new Label();
            passwordMatchLabel = new Label();
            passwordRulesLabel = new Label();
            usernameRuleLabel = new Label();
            label16 = new Label();
            securityKeyTextBox = new TextBox();
            confirmPassword = new TextBox();
            label14 = new Label();
            newAccountHidePassword = new Button();
            newAccountShowPassword = new Button();
            addNewAdminAccount = new Button();
            label7 = new Label();
            newAccountUsernameTextBox = new TextBox();
            newAccountPasswordTextBox = new TextBox();
            label6 = new Label();
            crudEmployeePanel = new Panel();
            clearButton = new Button();
            button1 = new Button();
            searchEmployeeButton = new Button();
            panel3 = new Panel();
            employeeCountLabel = new Label();
            label8 = new Label();
            panel2 = new Panel();
            employeeFlowLayoutPanel = new FlowLayoutPanel();
            label3 = new Label();
            searchTextBox = new TextBox();
            viewAttendancePanel = new Panel();
            panel5 = new Panel();
            allTimeButton = new Button();
            searchDateButton = new Button();
            attendanceDateTimePicker = new DateTimePicker();
            attendanceFlowLayOutPanel = new FlowLayoutPanel();
            crudProductPanel = new Panel();
            productsFlowLayoutPanel = new FlowLayoutPanel();
            panel4 = new Panel();
            label4 = new Label();
            pageNumberTextBox = new TextBox();
            nextPageButton = new Button();
            previousPageButton = new Button();
            button3 = new Button();
            addProductButton = new Button();
            searchProductButton = new Button();
            searchProductTextBox = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            mainPanel.SuspendLayout();
            settingsPanel.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            crudEmployeePanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            viewAttendancePanel.SuspendLayout();
            panel5.SuspendLayout();
            crudProductPanel.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Images.LOGO;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1, -45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 225);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // selectedOptionLabel
            // 
            selectedOptionLabel.AutoSize = true;
            selectedOptionLabel.BackColor = Color.Transparent;
            selectedOptionLabel.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectedOptionLabel.Location = new Point(303, 9);
            selectedOptionLabel.Name = "selectedOptionLabel";
            selectedOptionLabel.Size = new Size(182, 42);
            selectedOptionLabel.TabIndex = 1;
            selectedOptionLabel.Text = "Employees";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(logOutButton);
            panel1.Controls.Add(settingsButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(crudProductsLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(viewAttendanceLabel);
            panel1.Controls.Add(crudEmployeeLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 544);
            panel1.TabIndex = 2;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.Location = new Point(23, 472);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(182, 59);
            logOutButton.TabIndex = 10;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackgroundImage = Images.settings;
            settingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Location = new Point(23, 413);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(69, 53);
            settingsButton.TabIndex = 9;
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 355);
            label1.Name = "label1";
            label1.Size = new Size(150, 45);
            label1.TabIndex = 8;
            label1.Text = "Settings";
            // 
            // crudProductsLabel
            // 
            crudProductsLabel.AutoSize = true;
            crudProductsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            crudProductsLabel.Location = new Point(23, 236);
            crudProductsLabel.Name = "crudProductsLabel";
            crudProductsLabel.Size = new Size(146, 50);
            crudProductsLabel.TabIndex = 7;
            crudProductsLabel.Text = "Add/Edit/Delete\r\nProducts";
            crudProductsLabel.Click += crudProductsLabel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 191);
            label5.Name = "label5";
            label5.Size = new Size(160, 45);
            label5.TabIndex = 6;
            label5.Text = "Products";
            // 
            // viewAttendanceLabel
            // 
            viewAttendanceLabel.AutoSize = true;
            viewAttendanceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            viewAttendanceLabel.Location = new Point(23, 143);
            viewAttendanceLabel.Name = "viewAttendanceLabel";
            viewAttendanceLabel.Size = new Size(154, 25);
            viewAttendanceLabel.TabIndex = 5;
            viewAttendanceLabel.Text = "View Attendance";
            viewAttendanceLabel.Click += viewAttendanceLabel_Click;
            // 
            // crudEmployeeLabel
            // 
            crudEmployeeLabel.AutoSize = true;
            crudEmployeeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            crudEmployeeLabel.Location = new Point(23, 72);
            crudEmployeeLabel.Name = "crudEmployeeLabel";
            crudEmployeeLabel.Size = new Size(146, 50);
            crudEmployeeLabel.TabIndex = 4;
            crudEmployeeLabel.Text = "Add/Edit/Delete\r\nEmployee\r\n";
            crudEmployeeLabel.Click += crudEmployeeLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 6);
            label2.Name = "label2";
            label2.Size = new Size(193, 45);
            label2.TabIndex = 3;
            label2.Text = "Employees";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Controls.Add(settingsPanel);
            mainPanel.Controls.Add(crudEmployeePanel);
            mainPanel.Controls.Add(viewAttendancePanel);
            mainPanel.Controls.Add(crudProductPanel);
            mainPanel.Location = new Point(295, 54);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(967, 615);
            mainPanel.TabIndex = 3;
            // 
            // settingsPanel
            // 
            settingsPanel.Controls.Add(label13);
            settingsPanel.Controls.Add(label12);
            settingsPanel.Controls.Add(panel7);
            settingsPanel.Controls.Add(panel6);
            settingsPanel.Location = new Point(0, 0);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(957, 608);
            settingsPanel.TabIndex = 4;
            settingsPanel.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(17, 340);
            label13.Name = "label13";
            label13.Size = new Size(243, 30);
            label13.TabIndex = 7;
            label13.Text = "Change Password Admin";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(18, 23);
            label12.Name = "label12";
            label12.Size = new Size(166, 30);
            label12.TabIndex = 6;
            label12.Text = "Add New Admin";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(244, 244, 244);
            panel7.Controls.Add(changePassRules);
            panel7.Controls.Add(newPasswordForExistingTextBox);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(changePasswordButton);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(userNameExistingTextBox);
            panel7.Controls.Add(passwordExistingTextBox);
            panel7.Controls.Add(label10);
            panel7.Location = new Point(18, 375);
            panel7.Name = "panel7";
            panel7.Size = new Size(824, 201);
            panel7.TabIndex = 5;
            panel7.Paint += panel7_Paint;
            // 
            // changePassRules
            // 
            changePassRules.AutoSize = true;
            changePassRules.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            changePassRules.ForeColor = Color.Red;
            changePassRules.Location = new Point(519, 28);
            changePassRules.Name = "changePassRules";
            changePassRules.Size = new Size(305, 65);
            changePassRules.TabIndex = 14;
            changePassRules.Text = resources.GetString("changePassRules.Text");
            // 
            // newPasswordForExistingTextBox
            // 
            newPasswordForExistingTextBox.Location = new Point(128, 99);
            newPasswordForExistingTextBox.MaxLength = 15;
            newPasswordForExistingTextBox.Name = "newPasswordForExistingTextBox";
            newPasswordForExistingTextBox.PasswordChar = '*';
            newPasswordForExistingTextBox.Size = new Size(357, 23);
            newPasswordForExistingTextBox.TabIndex = 6;
            newPasswordForExistingTextBox.TextChanged += newPasswordForExistingTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 107);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 5;
            label11.Text = "New Password:";
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(146, 156);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(184, 34);
            changePasswordButton.TabIndex = 4;
            changePasswordButton.Text = "Change Password";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 70);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 3;
            label9.Text = "Password:";
            // 
            // userNameExistingTextBox
            // 
            userNameExistingTextBox.Location = new Point(128, 31);
            userNameExistingTextBox.MaxLength = 15;
            userNameExistingTextBox.Name = "userNameExistingTextBox";
            userNameExistingTextBox.Size = new Size(357, 23);
            userNameExistingTextBox.TabIndex = 0;
            // 
            // passwordExistingTextBox
            // 
            passwordExistingTextBox.Location = new Point(128, 70);
            passwordExistingTextBox.MaxLength = 15;
            passwordExistingTextBox.Name = "passwordExistingTextBox";
            passwordExistingTextBox.PasswordChar = '*';
            passwordExistingTextBox.Size = new Size(357, 23);
            passwordExistingTextBox.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 38);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 2;
            label10.Text = "Username:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(244, 244, 244);
            panel6.Controls.Add(securityKeyRule);
            panel6.Controls.Add(passwordMatchLabel);
            panel6.Controls.Add(passwordRulesLabel);
            panel6.Controls.Add(usernameRuleLabel);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(securityKeyTextBox);
            panel6.Controls.Add(confirmPassword);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(newAccountHidePassword);
            panel6.Controls.Add(newAccountShowPassword);
            panel6.Controls.Add(addNewAdminAccount);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(newAccountUsernameTextBox);
            panel6.Controls.Add(newAccountPasswordTextBox);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(17, 68);
            panel6.Name = "panel6";
            panel6.Size = new Size(888, 259);
            panel6.TabIndex = 3;
            // 
            // securityKeyRule
            // 
            securityKeyRule.AutoSize = true;
            securityKeyRule.ForeColor = Color.Red;
            securityKeyRule.Location = new Point(541, 228);
            securityKeyRule.Name = "securityKeyRule";
            securityKeyRule.Size = new Size(284, 15);
            securityKeyRule.TabIndex = 15;
            securityKeyRule.Text = "Security key Length must be 3-15 characters only a-z";
            // 
            // passwordMatchLabel
            // 
            passwordMatchLabel.AutoSize = true;
            passwordMatchLabel.ForeColor = Color.Red;
            passwordMatchLabel.Location = new Point(128, 133);
            passwordMatchLabel.Name = "passwordMatchLabel";
            passwordMatchLabel.Size = new Size(277, 15);
            passwordMatchLabel.TabIndex = 14;
            passwordMatchLabel.Text = "Password and Confirm Password must be the same";
            // 
            // passwordRulesLabel
            // 
            passwordRulesLabel.AutoSize = true;
            passwordRulesLabel.ForeColor = Color.Red;
            passwordRulesLabel.Location = new Point(551, 49);
            passwordRulesLabel.Name = "passwordRulesLabel";
            passwordRulesLabel.Size = new Size(313, 75);
            passwordRulesLabel.TabIndex = 13;
            passwordRulesLabel.Text = resources.GetString("passwordRulesLabel.Text");
            // 
            // usernameRuleLabel
            // 
            usernameRuleLabel.AutoSize = true;
            usernameRuleLabel.ForeColor = Color.Red;
            usernameRuleLabel.Location = new Point(551, 31);
            usernameRuleLabel.Name = "usernameRuleLabel";
            usernameRuleLabel.Size = new Size(274, 15);
            usernameRuleLabel.TabIndex = 12;
            usernameRuleLabel.Text = "Username Length must be 3-15 characters only a-z";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(535, 169);
            label16.Name = "label16";
            label16.Size = new Size(317, 15);
            label16.TabIndex = 11;
            label16.Text = "Security Question: What was the name of your first school?";
            // 
            // securityKeyTextBox
            // 
            securityKeyTextBox.Location = new Point(535, 196);
            securityKeyTextBox.MaxLength = 15;
            securityKeyTextBox.Name = "securityKeyTextBox";
            securityKeyTextBox.PasswordChar = '*';
            securityKeyTextBox.Size = new Size(329, 23);
            securityKeyTextBox.TabIndex = 10;
            securityKeyTextBox.TextChanged += securityKeyTextBox_TextChanged;
            // 
            // confirmPassword
            // 
            confirmPassword.Location = new Point(160, 101);
            confirmPassword.MaxLength = 15;
            confirmPassword.Name = "confirmPassword";
            confirmPassword.PasswordChar = '*';
            confirmPassword.Size = new Size(297, 23);
            confirmPassword.TabIndex = 8;
            confirmPassword.TextChanged += confirmPassword_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 104);
            label14.Name = "label14";
            label14.Size = new Size(110, 15);
            label14.TabIndex = 7;
            label14.Text = "Confirm Password: ";
            // 
            // newAccountHidePassword
            // 
            newAccountHidePassword.Location = new Point(204, 161);
            newAccountHidePassword.Name = "newAccountHidePassword";
            newAccountHidePassword.Size = new Size(126, 23);
            newAccountHidePassword.TabIndex = 6;
            newAccountHidePassword.Text = "Hide Password";
            newAccountHidePassword.UseVisualStyleBackColor = true;
            newAccountHidePassword.Click += newAccountHidePassword_Click;
            // 
            // newAccountShowPassword
            // 
            newAccountShowPassword.Location = new Point(47, 161);
            newAccountShowPassword.Name = "newAccountShowPassword";
            newAccountShowPassword.Size = new Size(126, 23);
            newAccountShowPassword.TabIndex = 5;
            newAccountShowPassword.Text = "Show Password";
            newAccountShowPassword.UseVisualStyleBackColor = true;
            newAccountShowPassword.Click += newAccountShowPassword_Click;
            // 
            // addNewAdminAccount
            // 
            addNewAdminAccount.Location = new Point(48, 205);
            addNewAdminAccount.Name = "addNewAdminAccount";
            addNewAdminAccount.Size = new Size(184, 34);
            addNewAdminAccount.TabIndex = 4;
            addNewAdminAccount.Text = "Add New Admin Account";
            addNewAdminAccount.UseVisualStyleBackColor = true;
            addNewAdminAccount.Click += addNewAdminAccount_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 73);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 3;
            label7.Text = "Password:";
            // 
            // newAccountUsernameTextBox
            // 
            newAccountUsernameTextBox.Location = new Point(128, 31);
            newAccountUsernameTextBox.MaxLength = 15;
            newAccountUsernameTextBox.Name = "newAccountUsernameTextBox";
            newAccountUsernameTextBox.Size = new Size(202, 23);
            newAccountUsernameTextBox.TabIndex = 0;
            newAccountUsernameTextBox.TextChanged += newAccountUsernameTextBox_TextChanged;
            // 
            // newAccountPasswordTextBox
            // 
            newAccountPasswordTextBox.Location = new Point(128, 70);
            newAccountPasswordTextBox.MaxLength = 15;
            newAccountPasswordTextBox.Name = "newAccountPasswordTextBox";
            newAccountPasswordTextBox.PasswordChar = '*';
            newAccountPasswordTextBox.Size = new Size(202, 23);
            newAccountPasswordTextBox.TabIndex = 1;
            newAccountPasswordTextBox.TextChanged += newAccountPasswordTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 39);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 2;
            label6.Text = "Username:";
            // 
            // crudEmployeePanel
            // 
            crudEmployeePanel.BackColor = Color.Transparent;
            crudEmployeePanel.BorderStyle = BorderStyle.FixedSingle;
            crudEmployeePanel.Controls.Add(clearButton);
            crudEmployeePanel.Controls.Add(button1);
            crudEmployeePanel.Controls.Add(searchEmployeeButton);
            crudEmployeePanel.Controls.Add(panel3);
            crudEmployeePanel.Controls.Add(panel2);
            crudEmployeePanel.Controls.Add(searchTextBox);
            crudEmployeePanel.Location = new Point(14, 12);
            crudEmployeePanel.Name = "crudEmployeePanel";
            crudEmployeePanel.Size = new Size(943, 564);
            crudEmployeePanel.TabIndex = 0;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(10, 260);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(200, 68);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 124);
            button1.Name = "button1";
            button1.Size = new Size(200, 68);
            button1.TabIndex = 1;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // searchEmployeeButton
            // 
            searchEmployeeButton.BackgroundImage = Images.searchimage;
            searchEmployeeButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchEmployeeButton.Location = new Point(174, 213);
            searchEmployeeButton.Name = "searchEmployeeButton";
            searchEmployeeButton.Size = new Size(36, 23);
            searchEmployeeButton.TabIndex = 3;
            searchEmployeeButton.UseVisualStyleBackColor = true;
            searchEmployeeButton.Click += searchEmployeeButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(244, 244, 244);
            panel3.Controls.Add(employeeCountLabel);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(10, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 1;
            // 
            // employeeCountLabel
            // 
            employeeCountLabel.AutoSize = true;
            employeeCountLabel.BackColor = Color.Transparent;
            employeeCountLabel.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            employeeCountLabel.Location = new Point(11, 48);
            employeeCountLabel.Name = "employeeCountLabel";
            employeeCountLabel.Size = new Size(37, 42);
            employeeCountLabel.TabIndex = 4;
            employeeCountLabel.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(11, 13);
            label8.Name = "label8";
            label8.Size = new Size(146, 23);
            label8.TabIndex = 2;
            label8.Text = "Employee Count";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 244, 244);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(employeeFlowLayoutPanel);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(224, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 539);
            panel2.TabIndex = 0;
            // 
            // employeeFlowLayoutPanel
            // 
            employeeFlowLayoutPanel.AutoScroll = true;
            employeeFlowLayoutPanel.BackColor = Color.FromArgb(244, 244, 244);
            employeeFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            employeeFlowLayoutPanel.Location = new Point(12, 46);
            employeeFlowLayoutPanel.Margin = new Padding(0);
            employeeFlowLayoutPanel.Name = "employeeFlowLayoutPanel";
            employeeFlowLayoutPanel.Padding = new Padding(10, 10, 0, 0);
            employeeFlowLayoutPanel.Size = new Size(680, 474);
            employeeFlowLayoutPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 11);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 0;
            label3.Text = "Employees";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(2, 206);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search First Name";
            searchTextBox.Size = new Size(215, 33);
            searchTextBox.TabIndex = 2;
            // 
            // viewAttendancePanel
            // 
            viewAttendancePanel.Controls.Add(panel5);
            viewAttendancePanel.Controls.Add(attendanceFlowLayOutPanel);
            viewAttendancePanel.Location = new Point(14, 3);
            viewAttendancePanel.Name = "viewAttendancePanel";
            viewAttendancePanel.Size = new Size(943, 612);
            viewAttendancePanel.TabIndex = 20;
            viewAttendancePanel.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(244, 244, 244);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(allTimeButton);
            panel5.Controls.Add(searchDateButton);
            panel5.Controls.Add(attendanceDateTimePicker);
            panel5.Location = new Point(14, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(913, 65);
            panel5.TabIndex = 4;
            // 
            // allTimeButton
            // 
            allTimeButton.Location = new Point(583, 6);
            allTimeButton.Name = "allTimeButton";
            allTimeButton.Size = new Size(157, 44);
            allTimeButton.TabIndex = 2;
            allTimeButton.Text = "All Time";
            allTimeButton.UseVisualStyleBackColor = true;
            allTimeButton.Click += allTimeButton_Click;
            // 
            // searchDateButton
            // 
            searchDateButton.BackgroundImage = Images.searchimage;
            searchDateButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchDateButton.Cursor = Cursors.Hand;
            searchDateButton.FlatAppearance.BorderSize = 0;
            searchDateButton.FlatStyle = FlatStyle.Flat;
            searchDateButton.Location = new Point(511, 7);
            searchDateButton.Name = "searchDateButton";
            searchDateButton.Size = new Size(54, 43);
            searchDateButton.TabIndex = 3;
            searchDateButton.UseVisualStyleBackColor = true;
            searchDateButton.Click += searchDateButton_Click;
            // 
            // attendanceDateTimePicker
            // 
            attendanceDateTimePicker.CalendarFont = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            attendanceDateTimePicker.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            attendanceDateTimePicker.Location = new Point(3, 7);
            attendanceDateTimePicker.Name = "attendanceDateTimePicker";
            attendanceDateTimePicker.Size = new Size(502, 46);
            attendanceDateTimePicker.TabIndex = 1;
            // 
            // attendanceFlowLayOutPanel
            // 
            attendanceFlowLayOutPanel.AutoScroll = true;
            attendanceFlowLayOutPanel.BackColor = Color.FromArgb(244, 244, 244);
            attendanceFlowLayOutPanel.BorderStyle = BorderStyle.FixedSingle;
            attendanceFlowLayOutPanel.Location = new Point(11, 87);
            attendanceFlowLayOutPanel.Margin = new Padding(5);
            attendanceFlowLayOutPanel.Name = "attendanceFlowLayOutPanel";
            attendanceFlowLayOutPanel.Size = new Size(920, 504);
            attendanceFlowLayOutPanel.TabIndex = 0;
            // 
            // crudProductPanel
            // 
            crudProductPanel.BorderStyle = BorderStyle.FixedSingle;
            crudProductPanel.Controls.Add(productsFlowLayoutPanel);
            crudProductPanel.Controls.Add(panel4);
            crudProductPanel.Location = new Point(14, 3);
            crudProductPanel.Name = "crudProductPanel";
            crudProductPanel.Size = new Size(943, 609);
            crudProductPanel.TabIndex = 4;
            crudProductPanel.Visible = false;
            // 
            // productsFlowLayoutPanel
            // 
            productsFlowLayoutPanel.AutoScroll = true;
            productsFlowLayoutPanel.BackColor = Color.FromArgb(244, 244, 244);
            productsFlowLayoutPanel.Location = new Point(21, 113);
            productsFlowLayoutPanel.Name = "productsFlowLayoutPanel";
            productsFlowLayoutPanel.Padding = new Padding(10, 0, 0, 0);
            productsFlowLayoutPanel.Size = new Size(909, 477);
            productsFlowLayoutPanel.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(244, 244, 244);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pageNumberTextBox);
            panel4.Controls.Add(nextPageButton);
            panel4.Controls.Add(previousPageButton);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(addProductButton);
            panel4.Controls.Add(searchProductButton);
            panel4.Controls.Add(searchProductTextBox);
            panel4.Location = new Point(21, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(905, 95);
            panel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(138, 30);
            label4.TabIndex = 19;
            label4.Text = "Current Page:";
            // 
            // pageNumberTextBox
            // 
            pageNumberTextBox.BackColor = Color.FromArgb(244, 244, 244);
            pageNumberTextBox.Enabled = false;
            pageNumberTextBox.Location = new Point(167, 60);
            pageNumberTextBox.Name = "pageNumberTextBox";
            pageNumberTextBox.Size = new Size(63, 23);
            pageNumberTextBox.TabIndex = 18;
            pageNumberTextBox.Text = "1";
            pageNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // nextPageButton
            // 
            nextPageButton.BackColor = Color.Transparent;
            nextPageButton.BackgroundImage = Images.drop_down_arrow_pointing_right;
            nextPageButton.BackgroundImageLayout = ImageLayout.Stretch;
            nextPageButton.Cursor = Cursors.Hand;
            nextPageButton.FlatAppearance.BorderSize = 0;
            nextPageButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            nextPageButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            nextPageButton.FlatStyle = FlatStyle.Flat;
            nextPageButton.Location = new Point(223, 60);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(36, 23);
            nextPageButton.TabIndex = 17;
            nextPageButton.UseVisualStyleBackColor = false;
            nextPageButton.Click += nextPageButton_Click;
            // 
            // previousPageButton
            // 
            previousPageButton.BackColor = Color.Transparent;
            previousPageButton.BackgroundImage = Images.drop_down_arrow_pointing_left;
            previousPageButton.BackgroundImageLayout = ImageLayout.Stretch;
            previousPageButton.Cursor = Cursors.Hand;
            previousPageButton.Enabled = false;
            previousPageButton.FlatAppearance.BorderSize = 0;
            previousPageButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            previousPageButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            previousPageButton.FlatStyle = FlatStyle.Flat;
            previousPageButton.Location = new Point(139, 60);
            previousPageButton.Name = "previousPageButton";
            previousPageButton.Size = new Size(36, 23);
            previousPageButton.TabIndex = 16;
            previousPageButton.UseVisualStyleBackColor = false;
            previousPageButton.Click += previousPageButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(468, 8);
            button3.Name = "button3";
            button3.Size = new Size(168, 33);
            button3.TabIndex = 3;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(690, 7);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(168, 33);
            addProductButton.TabIndex = 2;
            addProductButton.Text = "Add Product";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // searchProductButton
            // 
            searchProductButton.BackgroundImage = Images.searchimage;
            searchProductButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchProductButton.Cursor = Cursors.Hand;
            searchProductButton.Location = new Point(410, 9);
            searchProductButton.Name = "searchProductButton";
            searchProductButton.Size = new Size(26, 31);
            searchProductButton.TabIndex = 1;
            searchProductButton.UseVisualStyleBackColor = true;
            searchProductButton.Click += searchProductButton_Click;
            // 
            // searchProductTextBox
            // 
            searchProductTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            searchProductTextBox.Location = new Point(4, 5);
            searchProductTextBox.Name = "searchProductTextBox";
            searchProductTextBox.PlaceholderText = "Search Product";
            searchProductTextBox.Size = new Size(436, 39);
            searchProductTextBox.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(23, 306);
            button2.Name = "button2";
            button2.Size = new Size(125, 38);
            button2.TabIndex = 11;
            button2.Text = "View Logs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Controls.Add(selectedOptionLabel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "DashBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoardForm";
            Load += DashBoardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            crudEmployeePanel.ResumeLayout(false);
            crudEmployeePanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            viewAttendancePanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            crudProductPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label selectedOptionLabel;
        private Panel panel1;
        private Label crudEmployeeLabel;
        private Label label2;
        private Label crudProductsLabel;
        private Label label5;
        private Label viewAttendanceLabel;
        private Panel mainPanel;
        private Panel crudEmployeePanel;
        private Panel panel2;
        private Button searchEmployeeButton;
        private TextBox searchTextBox;
        private FlowLayoutPanel employeeFlowLayoutPanel;
        private Label label3;
        private Panel panel3;
        private Button button1;
        private Label employeeCountLabel;
        private Label label8;
        private Panel crudProductPanel;
        private Panel panel4;
        private Button searchProductButton;
        private TextBox searchProductTextBox;
        private FlowLayoutPanel productsFlowLayoutPanel;
        private Button button3;
        private Button addProductButton;
        private Button nextPageButton;
        private Button previousPageButton;
        private TextBox pageNumberTextBox;
        private Label label4;
        private Panel viewAttendancePanel;
        private FlowLayoutPanel attendanceFlowLayOutPanel;
        private Panel panel5;
        private Button allTimeButton;
        private Button searchDateButton;
        private DateTimePicker attendanceDateTimePicker;
        private Button clearButton;
        private Label label1;
        private Button settingsButton;
        private Button logOutButton;
        private Panel settingsPanel;
        private Panel panel7;
        private TextBox newPasswordForExistingTextBox;
        private Label label11;
        private Button changePasswordButton;
        private Label label9;
        private TextBox userNameExistingTextBox;
        private TextBox passwordExistingTextBox;
        private Label label10;
        private Panel panel6;
        private Button addNewAdminAccount;
        private Label label7;
        private TextBox newAccountPasswordTextBox;
        private Label label6;
        private TextBox newAccountUsernameTextBox;
        private Button newAccountHidePassword;
        private Button newAccountShowPassword;
        private Label label13;
        private Label label12;
        private Label label14;
        private TextBox securityKeyTextBox;
        private TextBox confirmPassword;
        private Label label16;
        private Label passwordRulesLabel;
        private Label usernameRuleLabel;
        private Label passwordMatchLabel;
        private Label securityKeyRule;
        private Label changePassRules;
        private Button button2;
    }
}