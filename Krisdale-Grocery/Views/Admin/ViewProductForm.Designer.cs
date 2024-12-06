namespace Krisdale_Grocery.Views.Admin
{
    partial class ViewProductForm
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
            searchClicked = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Location = new Point(298, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(954, 657);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(18, 49);
            searchTextBox.MaxLength = 15;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(234, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchClicked
            // 
            searchClicked.Location = new Point(67, 126);
            searchClicked.Name = "searchClicked";
            searchClicked.Size = new Size(120, 52);
            searchClicked.TabIndex = 2;
            searchClicked.Text = "Search";
            searchClicked.UseVisualStyleBackColor = true;
            searchClicked.Click += searchClicked_Click;
            // 
            // ViewProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(searchClicked);
            Controls.Add(searchTextBox);
            Controls.Add(flowLayoutPanel1);
            Name = "ViewProductForm";
            Text = "ViewProductForm";
            Load += ViewProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox searchTextBox;
        private Button searchClicked;
    }
}