namespace Krisdale_Grocery.Views.Employee
{
    partial class PaymentForm
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
            totalAmountTextBox = new TextBox();
            label2 = new Label();
            amountPaidTextBox = new TextBox();
            label3 = new Label();
            changeTextBox = new TextBox();
            computeButton = new Button();
            closeButton = new Button();
            cartRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(772, 70);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.BackColor = Color.White;
            totalAmountTextBox.Enabled = false;
            totalAmountTextBox.Location = new Point(904, 67);
            totalAmountTextBox.Margin = new Padding(5);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.Size = new Size(205, 33);
            totalAmountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(772, 124);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 2;
            label2.Text = "Amount Paid:";
            // 
            // amountPaidTextBox
            // 
            amountPaidTextBox.Location = new Point(904, 124);
            amountPaidTextBox.Name = "amountPaidTextBox";
            amountPaidTextBox.Size = new Size(205, 33);
            amountPaidTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(772, 206);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 4;
            label3.Text = "Change:";
            // 
            // changeTextBox
            // 
            changeTextBox.Enabled = false;
            changeTextBox.Location = new Point(904, 206);
            changeTextBox.Name = "changeTextBox";
            changeTextBox.Size = new Size(205, 33);
            changeTextBox.TabIndex = 5;
            // 
            // computeButton
            // 
            computeButton.Location = new Point(948, 163);
            computeButton.Name = "computeButton";
            computeButton.Size = new Size(110, 36);
            computeButton.TabIndex = 6;
            computeButton.Text = "Compute";
            computeButton.UseVisualStyleBackColor = true;
            computeButton.Click += computeButton_Click;
            // 
            // closeButton
            // 
            closeButton.Enabled = false;
            closeButton.Location = new Point(957, 249);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(83, 35);
            closeButton.TabIndex = 7;
            closeButton.Text = "Done";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // cartRichTextBox
            // 
            cartRichTextBox.Location = new Point(12, 12);
            cartRichTextBox.Name = "cartRichTextBox";
            cartRichTextBox.Size = new Size(724, 595);
            cartRichTextBox.TabIndex = 8;
            cartRichTextBox.Text = "";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Images.allformsbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1145, 681);
            Controls.Add(cartRichTextBox);
            Controls.Add(closeButton);
            Controls.Add(computeButton);
            Controls.Add(changeTextBox);
            Controls.Add(label3);
            Controls.Add(amountPaidTextBox);
            Controls.Add(label2);
            Controls.Add(totalAmountTextBox);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox totalAmountTextBox;
        private Label label2;
        private TextBox amountPaidTextBox;
        private Label label3;
        private TextBox changeTextBox;
        private Button computeButton;
        private Button closeButton;
        private RichTextBox cartRichTextBox;
    }
}