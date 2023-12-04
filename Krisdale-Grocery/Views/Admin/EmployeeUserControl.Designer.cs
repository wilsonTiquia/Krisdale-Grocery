namespace Krisdale_Grocery.Views.Admin
{
    partial class EmployeeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            employeePictureBox = new PictureBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            contactNumberLabel = new Label();
            startedWorkingLabel = new Label();
            employeeIDLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)employeePictureBox).BeginInit();
            SuspendLayout();
            // 
            // employeePictureBox
            // 
            employeePictureBox.BorderStyle = BorderStyle.Fixed3D;
            employeePictureBox.Image = Images.blank_picture;
            employeePictureBox.Location = new Point(15, 26);
            employeePictureBox.Name = "employeePictureBox";
            employeePictureBox.Size = new Size(124, 111);
            employeePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            employeePictureBox.TabIndex = 0;
            employeePictureBox.TabStop = false;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(161, 26);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(161, 56);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Location = new Point(161, 88);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new Size(96, 15);
            contactNumberLabel.TabIndex = 3;
            contactNumberLabel.Text = "Contact Number";
            // 
            // startedWorkingLabel
            // 
            startedWorkingLabel.AutoSize = true;
            startedWorkingLabel.Location = new Point(161, 122);
            startedWorkingLabel.Name = "startedWorkingLabel";
            startedWorkingLabel.Size = new Size(92, 15);
            startedWorkingLabel.TabIndex = 4;
            startedWorkingLabel.Text = "Started Working";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new Point(15, 8);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new Size(25, 15);
            employeeIDLabel.TabIndex = 5;
            employeeIDLabel.Text = "ID#";
            // 
            // EmployeeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(employeeIDLabel);
            Controls.Add(startedWorkingLabel);
            Controls.Add(contactNumberLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(employeePictureBox);
            Name = "EmployeeUserControl";
            Size = new Size(360, 184);
            Click += EmployeeUserControl_Click;
            ((System.ComponentModel.ISupportInitialize)employeePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox employeePictureBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label contactNumberLabel;
        private Label startedWorkingLabel;
        private Label employeeIDLabel;
    }
}
