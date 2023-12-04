namespace Krisdale_Grocery.Views.Admin
{
    partial class ViewEmployeeForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchTextBox = new TextBox();
            searchButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gray;
            flowLayoutPanel1.Location = new Point(276, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(947, 598);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 99);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(182, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(48, 149);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 69);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 3;
            label1.Text = "Search Employee By Name\r\n";
            // 
            // ViewEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(flowLayoutPanel1);
            Name = "ViewEmployeeForm";
            Text = "ViewEmployeeForm";
            Load += ViewEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label label1;
    }
}