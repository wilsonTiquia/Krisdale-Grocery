namespace Krisdale_Grocery.Views.Admin
{
    partial class AttendanceUserControl
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
            employeeIdLabel = new Label();
            employeeFirstNameLabel = new Label();
            employeeLastNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            timeInLabel = new Label();
            timeOutLabel = new Label();
            label5 = new Label();
            hoursWorkedLabel = new Label();
            SuspendLayout();
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new Point(25, 13);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(73, 15);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "Employee ID";
            // 
            // employeeFirstNameLabel
            // 
            employeeFirstNameLabel.AutoSize = true;
            employeeFirstNameLabel.Location = new Point(26, 39);
            employeeFirstNameLabel.Name = "employeeFirstNameLabel";
            employeeFirstNameLabel.Size = new Size(64, 15);
            employeeFirstNameLabel.TabIndex = 1;
            employeeFirstNameLabel.Text = "First Name";
            // 
            // employeeLastNameLabel
            // 
            employeeLastNameLabel.AutoSize = true;
            employeeLastNameLabel.Location = new Point(27, 66);
            employeeLastNameLabel.Name = "employeeLastNameLabel";
            employeeLastNameLabel.Size = new Size(63, 15);
            employeeLastNameLabel.TabIndex = 2;
            employeeLastNameLabel.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 13);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Time In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 13);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Time Out";
            // 
            // timeInLabel
            // 
            timeInLabel.AutoSize = true;
            timeInLabel.Location = new Point(225, 39);
            timeInLabel.Name = "timeInLabel";
            timeInLabel.Size = new Size(65, 15);
            timeInLabel.TabIndex = 5;
            timeInLabel.Text = "06/12/2023";
            // 
            // timeOutLabel
            // 
            timeOutLabel.AutoSize = true;
            timeOutLabel.Location = new Point(400, 39);
            timeOutLabel.Name = "timeOutLabel";
            timeOutLabel.Size = new Size(65, 15);
            timeOutLabel.TabIndex = 6;
            timeOutLabel.Text = "06/12/2023";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(590, 13);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 7;
            label5.Text = "Hours Worked";
            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.AutoSize = true;
            hoursWorkedLabel.Location = new Point(590, 39);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new Size(65, 15);
            hoursWorkedLabel.TabIndex = 8;
            hoursWorkedLabel.Text = "06/12/2023";
            // 
            // AttendanceUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(hoursWorkedLabel);
            Controls.Add(label5);
            Controls.Add(timeOutLabel);
            Controls.Add(timeInLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(employeeLastNameLabel);
            Controls.Add(employeeFirstNameLabel);
            Controls.Add(employeeIdLabel);
            Margin = new Padding(10);
            Name = "AttendanceUserControl";
            Padding = new Padding(10, 0, 0, 0);
            Size = new Size(877, 99);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employeeIdLabel;
        private Label employeeFirstNameLabel;
        private Label employeeLastNameLabel;
        private Label label1;
        private Label label2;
        private Label timeInLabel;
        private Label timeOutLabel;
        private Label label5;
        private Label hoursWorkedLabel;
    }
}
