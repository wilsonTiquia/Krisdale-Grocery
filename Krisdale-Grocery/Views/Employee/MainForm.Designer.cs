namespace Krisdale_Grocery.Views.Employee
{
    partial class MainForm
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
            productFlowLayoutPanel = new FlowLayoutPanel();
            totalCostPanel = new Panel();
            totalAmountLabel = new Label();
            amountDueLabel = new Label();
            paymentButtonClick = new Button();
            clockInButton = new Button();
            clockOutButton = new Button();
            shoppingListFlowLayoutPanel = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            nextPageButton = new Button();
            quantityTextBox = new TextBox();
            previousPageButton = new Button();
            clearButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            pageNumberTextBox = new TextBox();
            settingsButton = new Button();
            totalCostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // productFlowLayoutPanel
            // 
            productFlowLayoutPanel.AutoScroll = true;
            productFlowLayoutPanel.BackColor = Color.FromArgb(244, 244, 244);
            productFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            productFlowLayoutPanel.Location = new Point(12, 205);
            productFlowLayoutPanel.Margin = new Padding(0);
            productFlowLayoutPanel.Name = "productFlowLayoutPanel";
            productFlowLayoutPanel.Padding = new Padding(20, 0, 0, 0);
            productFlowLayoutPanel.Size = new Size(576, 464);
            productFlowLayoutPanel.TabIndex = 2;
            // 
            // totalCostPanel
            // 
            totalCostPanel.BackColor = Color.FromArgb(244, 244, 244);
            totalCostPanel.BorderStyle = BorderStyle.FixedSingle;
            totalCostPanel.Controls.Add(totalAmountLabel);
            totalCostPanel.Controls.Add(amountDueLabel);
            totalCostPanel.Location = new Point(361, 69);
            totalCostPanel.Name = "totalCostPanel";
            totalCostPanel.Size = new Size(227, 130);
            totalCostPanel.TabIndex = 3;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalAmountLabel.Location = new Point(13, 57);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(71, 40);
            totalAmountLabel.TabIndex = 1;
            totalAmountLabel.Text = "0.00";
            // 
            // amountDueLabel
            // 
            amountDueLabel.AutoSize = true;
            amountDueLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            amountDueLabel.Location = new Point(13, 9);
            amountDueLabel.Name = "amountDueLabel";
            amountDueLabel.Size = new Size(209, 40);
            amountDueLabel.TabIndex = 0;
            amountDueLabel.Text = "Amount To Pay";
            // 
            // paymentButtonClick
            // 
            paymentButtonClick.BackColor = Color.Transparent;
            paymentButtonClick.BackgroundImage = Images.PAYMENT;
            paymentButtonClick.BackgroundImageLayout = ImageLayout.Stretch;
            paymentButtonClick.Cursor = Cursors.Hand;
            paymentButtonClick.FlatAppearance.BorderSize = 0;
            paymentButtonClick.FlatAppearance.MouseDownBackColor = Color.Transparent;
            paymentButtonClick.FlatAppearance.MouseOverBackColor = Color.Transparent;
            paymentButtonClick.FlatStyle = FlatStyle.Flat;
            paymentButtonClick.Location = new Point(766, 579);
            paymentButtonClick.Name = "paymentButtonClick";
            paymentButtonClick.Size = new Size(140, 90);
            paymentButtonClick.TabIndex = 4;
            paymentButtonClick.UseVisualStyleBackColor = false;
            paymentButtonClick.Click += paymentButtonClick_Click;
            // 
            // clockInButton
            // 
            clockInButton.BackColor = Color.Transparent;
            clockInButton.BackgroundImage = Images.CLOCK_IN;
            clockInButton.BackgroundImageLayout = ImageLayout.Stretch;
            clockInButton.Cursor = Cursors.Hand;
            clockInButton.FlatAppearance.BorderSize = 0;
            clockInButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            clockInButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            clockInButton.FlatStyle = FlatStyle.Flat;
            clockInButton.Location = new Point(938, 579);
            clockInButton.Name = "clockInButton";
            clockInButton.Size = new Size(140, 90);
            clockInButton.TabIndex = 6;
            clockInButton.UseVisualStyleBackColor = false;
            clockInButton.Click += clockInButton_Click;
            // 
            // clockOutButton
            // 
            clockOutButton.BackColor = Color.Transparent;
            clockOutButton.BackgroundImage = Images.CLOCK_OUT;
            clockOutButton.BackgroundImageLayout = ImageLayout.Stretch;
            clockOutButton.Cursor = Cursors.Hand;
            clockOutButton.FlatAppearance.BorderSize = 0;
            clockOutButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            clockOutButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            clockOutButton.FlatStyle = FlatStyle.Flat;
            clockOutButton.Location = new Point(1110, 579);
            clockOutButton.Name = "clockOutButton";
            clockOutButton.Size = new Size(140, 90);
            clockOutButton.TabIndex = 7;
            clockOutButton.UseVisualStyleBackColor = false;
            clockOutButton.Click += clockOutButton_Click;
            // 
            // shoppingListFlowLayoutPanel
            // 
            shoppingListFlowLayoutPanel.AutoScroll = true;
            shoppingListFlowLayoutPanel.BackColor = Color.FromArgb(244, 244, 244);
            shoppingListFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            shoppingListFlowLayoutPanel.Location = new Point(594, 69);
            shoppingListFlowLayoutPanel.Name = "shoppingListFlowLayoutPanel";
            shoppingListFlowLayoutPanel.Padding = new Padding(10, 0, 0, 0);
            shoppingListFlowLayoutPanel.Size = new Size(658, 477);
            shoppingListFlowLayoutPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Images.LOGO;
            pictureBox1.Location = new Point(12, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 10;
            label1.Text = "Cashier";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 244, 244);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(nextPageButton);
            panel2.Controls.Add(quantityTextBox);
            panel2.Controls.Add(previousPageButton);
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 133);
            panel2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
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
            nextPageButton.Location = new Point(233, 102);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(36, 23);
            nextPageButton.TabIndex = 15;
            nextPageButton.UseVisualStyleBackColor = false;
            nextPageButton.Click += nextPageButton_Click;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(65, 54);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(44, 23);
            quantityTextBox.TabIndex = 4;
            quantityTextBox.Text = "1";
            quantityTextBox.TextAlign = HorizontalAlignment.Center;
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
            previousPageButton.Location = new Point(122, 102);
            previousPageButton.Name = "previousPageButton";
            previousPageButton.Size = new Size(36, 23);
            previousPageButton.TabIndex = 12;
            previousPageButton.UseVisualStyleBackColor = false;
            previousPageButton.Click += previousPageButton_Click;
            // 
            // clearButton
            // 
            clearButton.Cursor = Cursors.Hand;
            clearButton.Location = new Point(242, 53);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(96, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // searchButton
            // 
            searchButton.Cursor = Cursors.Hand;
            searchButton.Location = new Point(135, 53);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(101, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(87, 9);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(230, 29);
            searchTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 0;
            label2.Text = "Search:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(21, 176);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 13;
            label4.Text = "Current Page:";
            // 
            // pageNumberTextBox
            // 
            pageNumberTextBox.BackColor = Color.FromArgb(244, 244, 244);
            pageNumberTextBox.Enabled = false;
            pageNumberTextBox.Location = new Point(177, 173);
            pageNumberTextBox.Name = "pageNumberTextBox";
            pageNumberTextBox.Size = new Size(63, 23);
            pageNumberTextBox.TabIndex = 14;
            pageNumberTextBox.Text = "1";
            pageNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(594, 579);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(140, 90);
            settingsButton.TabIndex = 16;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(settingsButton);
            Controls.Add(pageNumberTextBox);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(shoppingListFlowLayoutPanel);
            Controls.Add(clockOutButton);
            Controls.Add(clockInButton);
            Controls.Add(paymentButtonClick);
            Controls.Add(totalCostPanel);
            Controls.Add(productFlowLayoutPanel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            totalCostPanel.ResumeLayout(false);
            totalCostPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel productFlowLayoutPanel;
        private Panel totalCostPanel;
        private Button paymentButtonClick;
        private Button clockInButton;
        private Button clockOutButton;
        private FlowLayoutPanel shoppingListFlowLayoutPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button clearButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label label2;
        private Label label3;
        private TextBox quantityTextBox;
        private Button previousPageButton;
        private Label label4;
        private TextBox pageNumberTextBox;
        private Button nextPageButton;
        private Label totalAmountLabel;
        private Label amountDueLabel;
        private Button settingsButton;
    }
}