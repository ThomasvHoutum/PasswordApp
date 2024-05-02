using System.ComponentModel;

namespace PasswordApp.Forms
{
    partial class AddBankDetail
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
            this.AddBankDetailTitleLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BankNameTextBox = new System.Windows.Forms.TextBox();
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.BankDetailPanel = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.IbanLabel = new System.Windows.Forms.Label();
            this.IbanTextBox = new System.Windows.Forms.TextBox();
            this.BankDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBankDetailTitleLabel
            // 
            this.AddBankDetailTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBankDetailTitleLabel.Location = new System.Drawing.Point(12, 16);
            this.AddBankDetailTitleLabel.Name = "AddBankDetailTitleLabel";
            this.AddBankDetailTitleLabel.Size = new System.Drawing.Size(155, 21);
            this.AddBankDetailTitleLabel.TabIndex = 2;
            this.AddBankDetailTitleLabel.Text = "Add new bank detail";
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
            // BankNameTextBox
            // 
            this.BankNameTextBox.Location = new System.Drawing.Point(100, 3);
            this.BankNameTextBox.Name = "BankNameTextBox";
            this.BankNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.BankNameTextBox.TabIndex = 10;
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.Location = new System.Drawing.Point(0, 3);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(95, 18);
            this.BankNameLabel.TabIndex = 9;
            this.BankNameLabel.Text = "Bank name *";
            this.BankNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BankDetailPanel
            // 
            this.BankDetailPanel.AutoScroll = true;
            this.BankDetailPanel.Controls.Add(this.PasswordLabel);
            this.BankDetailPanel.Controls.Add(this.PasswordTextBox);
            this.BankDetailPanel.Controls.Add(this.UsernameLabel);
            this.BankDetailPanel.Controls.Add(this.UsernameTextBox);
            this.BankDetailPanel.Controls.Add(this.IbanLabel);
            this.BankDetailPanel.Controls.Add(this.IbanTextBox);
            this.BankDetailPanel.Controls.Add(this.BankNameLabel);
            this.BankDetailPanel.Controls.Add(this.BankNameTextBox);
            this.BankDetailPanel.Location = new System.Drawing.Point(12, 57);
            this.BankDetailPanel.Name = "BankDetailPanel";
            this.BankDetailPanel.Size = new System.Drawing.Size(333, 343);
            this.BankDetailPanel.TabIndex = 12;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(0, 81);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(95, 18);
            this.PasswordLabel.TabIndex = 19;
            this.PasswordLabel.Text = "Password *";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(100, 81);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(197, 20);
            this.PasswordTextBox.TabIndex = 20;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(0, 55);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(95, 18);
            this.UsernameLabel.TabIndex = 16;
            this.UsernameLabel.Text = "Username *";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(100, 55);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(197, 20);
            this.UsernameTextBox.TabIndex = 17;
            // 
            // IbanLabel
            // 
            this.IbanLabel.Location = new System.Drawing.Point(0, 29);
            this.IbanLabel.Name = "IbanLabel";
            this.IbanLabel.Size = new System.Drawing.Size(95, 18);
            this.IbanLabel.TabIndex = 11;
            this.IbanLabel.Text = "Iban *";
            this.IbanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IbanTextBox
            // 
            this.IbanTextBox.Location = new System.Drawing.Point(100, 29);
            this.IbanTextBox.Name = "IbanTextBox";
            this.IbanTextBox.Size = new System.Drawing.Size(197, 20);
            this.IbanTextBox.TabIndex = 12;
            // 
            // AddBankDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 412);
            this.Controls.Add(this.BankDetailPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiscardButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddBankDetailTitleLabel);
            this.Name = "AddBankDetail";
            this.Text = "Add Bank Detail";
            this.BankDetailPanel.ResumeLayout(false);
            this.BankDetailPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;

        private System.Windows.Forms.TextBox UsernameTextBox;

        private System.Windows.Forms.Label UsernameLabel;

        private System.Windows.Forms.Label IbanLabel;
        private System.Windows.Forms.TextBox IbanTextBox;

        private System.Windows.Forms.Label BankNameLabel;
        private System.Windows.Forms.TextBox BankNameTextBox;

        private System.Windows.Forms.Panel BankDetailPanel;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DiscardButton;

        private System.Windows.Forms.Label AddBankDetailTitleLabel;

        #endregion
    }
}