using System.ComponentModel;

namespace PasswordApp.Forms
{
    partial class AddCreditCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.AddCreditCardTitleLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IssuerTextBox = new System.Windows.Forms.TextBox();
            this.IssuerLabel = new System.Windows.Forms.Label();
            this.CreditCardPanel = new System.Windows.Forms.Panel();
            this.BillingAddressLabel = new System.Windows.Forms.Label();
            this.BillingAddressTextBox = new System.Windows.Forms.TextBox();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.CvvLabel = new System.Windows.Forms.Label();
            this.CvvTextBox = new System.Windows.Forms.TextBox();
            this.ExpiryDateFieldPicker = new System.Windows.Forms.DateTimePicker();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.CreditCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCreditCardTitleLabel
            // 
            this.AddCreditCardTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCreditCardTitleLabel.Location = new System.Drawing.Point(12, 16);
            this.AddCreditCardTitleLabel.Name = "AddCreditCardTitleLabel";
            this.AddCreditCardTitleLabel.Size = new System.Drawing.Size(155, 21);
            this.AddCreditCardTitleLabel.TabIndex = 2;
            this.AddCreditCardTitleLabel.Text = "Add new credit card";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(201, 8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 32);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DiscardButton
            // 
            this.DiscardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DiscardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscardButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DiscardButton.Location = new System.Drawing.Point(282, 8);
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(63, 32);
            this.DiscardButton.TabIndex = 10;
            this.DiscardButton.Text = "Discard";
            this.DiscardButton.UseVisualStyleBackColor = false;
            this.DiscardButton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 2);
            this.panel1.TabIndex = 11;
            // 
            // IssuerTextBox
            // 
            this.IssuerTextBox.Location = new System.Drawing.Point(100, 3);
            this.IssuerTextBox.Name = "IssuerTextBox";
            this.IssuerTextBox.Size = new System.Drawing.Size(197, 20);
            this.IssuerTextBox.TabIndex = 10;
            // 
            // IssuerLabel
            // 
            this.IssuerLabel.Location = new System.Drawing.Point(0, 3);
            this.IssuerLabel.Name = "IssuerLabel";
            this.IssuerLabel.Size = new System.Drawing.Size(95, 18);
            this.IssuerLabel.TabIndex = 9;
            this.IssuerLabel.Text = "Issuer *";
            this.IssuerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreditCardPanel
            // 
            this.CreditCardPanel.AutoScroll = true;
            this.CreditCardPanel.Controls.Add(this.BillingAddressLabel);
            this.CreditCardPanel.Controls.Add(this.BillingAddressTextBox);
            this.CreditCardPanel.Controls.Add(this.ExpiryDateLabel);
            this.CreditCardPanel.Controls.Add(this.CvvLabel);
            this.CreditCardPanel.Controls.Add(this.CvvTextBox);
            this.CreditCardPanel.Controls.Add(this.ExpiryDateFieldPicker);
            this.CreditCardPanel.Controls.Add(this.NumberLabel);
            this.CreditCardPanel.Controls.Add(this.NumberTextBox);
            this.CreditCardPanel.Controls.Add(this.IssuerLabel);
            this.CreditCardPanel.Controls.Add(this.IssuerTextBox);
            this.CreditCardPanel.Location = new System.Drawing.Point(12, 57);
            this.CreditCardPanel.Name = "CreditCardPanel";
            this.CreditCardPanel.Size = new System.Drawing.Size(333, 343);
            this.CreditCardPanel.TabIndex = 12;
            // 
            // BillingAddressLabel
            // 
            this.BillingAddressLabel.Location = new System.Drawing.Point(0, 108);
            this.BillingAddressLabel.Name = "BillingAddressLabel";
            this.BillingAddressLabel.Size = new System.Drawing.Size(95, 18);
            this.BillingAddressLabel.TabIndex = 19;
            this.BillingAddressLabel.Text = "Billing address *";
            this.BillingAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BillingAddressTextBox
            // 
            this.BillingAddressTextBox.Location = new System.Drawing.Point(100, 108);
            this.BillingAddressTextBox.Name = "BillingAddressTextBox";
            this.BillingAddressTextBox.Size = new System.Drawing.Size(197, 20);
            this.BillingAddressTextBox.TabIndex = 20;
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.Location = new System.Drawing.Point(0, 57);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.Size = new System.Drawing.Size(95, 18);
            this.ExpiryDateLabel.TabIndex = 18;
            this.ExpiryDateLabel.Text = "Expiry date *";
            this.ExpiryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CvvLabel
            // 
            this.CvvLabel.Location = new System.Drawing.Point(0, 82);
            this.CvvLabel.Name = "CvvLabel";
            this.CvvLabel.Size = new System.Drawing.Size(95, 18);
            this.CvvLabel.TabIndex = 16;
            this.CvvLabel.Text = "Cvv *";
            this.CvvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CvvTextBox
            // 
            this.CvvTextBox.Location = new System.Drawing.Point(100, 82);
            this.CvvTextBox.Name = "CvvTextBox";
            this.CvvTextBox.Size = new System.Drawing.Size(197, 20);
            this.CvvTextBox.TabIndex = 17;
            // 
            // ExpiryDateFieldPicker
            // 
            this.ExpiryDateFieldPicker.Location = new System.Drawing.Point(101, 55);
            this.ExpiryDateFieldPicker.Name = "ExpiryDateFieldPicker";
            this.ExpiryDateFieldPicker.Size = new System.Drawing.Size(196, 20);
            this.ExpiryDateFieldPicker.TabIndex = 15;
            // 
            // NumberLabel
            // 
            this.NumberLabel.Location = new System.Drawing.Point(0, 29);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(95, 18);
            this.NumberLabel.TabIndex = 11;
            this.NumberLabel.Text = "Number *";
            this.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(100, 29);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(197, 20);
            this.NumberTextBox.TabIndex = 12;
            // 
            // AddCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 412);
            this.Controls.Add(this.CreditCardPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiscardButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddCreditCardTitleLabel);
            this.Name = "AddCreditCard";
            this.Text = "Add Credit Card";
            this.CreditCardPanel.ResumeLayout(false);
            this.CreditCardPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label BillingAddressLabel;
        private System.Windows.Forms.TextBox BillingAddressTextBox;

        private System.Windows.Forms.Label ExpiryDateLabel;

        private System.Windows.Forms.TextBox CvvTextBox;

        private System.Windows.Forms.DateTimePicker ExpiryDateFieldPicker;

        private System.Windows.Forms.Label CvvLabel;

        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NumberTextBox;

        private System.Windows.Forms.Label IssuerLabel;
        private System.Windows.Forms.TextBox IssuerTextBox;

        private System.Windows.Forms.Panel CreditCardPanel;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DiscardButton;

        private System.Windows.Forms.Label AddCreditCardTitleLabel;

        #endregion
    }
}