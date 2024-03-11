using System.ComponentModel;

namespace PasswordApp.Forms
{
    partial class AddLoginDetail
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
            this.AddLoginDetailTitleLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginDetailPanel = new System.Windows.Forms.Panel();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.ApplicationTextBox = new System.Windows.Forms.TextBox();
            this.LoginDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddLoginDetailTitleLabel
            // 
            this.AddLoginDetailTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AddLoginDetailTitleLabel.Location = new System.Drawing.Point(12, 16);
            this.AddLoginDetailTitleLabel.Name = "AddLoginDetailTitleLabel";
            this.AddLoginDetailTitleLabel.Size = new System.Drawing.Size(155, 21);
            this.AddLoginDetailTitleLabel.TabIndex = 2;
            this.AddLoginDetailTitleLabel.Text = "Add new login detail";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(2, 29);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(95, 18);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password *";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(3, 3);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(95, 18);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username *";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(102, 29);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(197, 20);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(102, 3);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(198, 20);
            this.UsernameTextBox.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
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
            this.DiscardButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
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
            // LoginDetailPanel
            // 
            this.LoginDetailPanel.AutoScroll = true;
            this.LoginDetailPanel.Controls.Add(this.ApplicationLabel);
            this.LoginDetailPanel.Controls.Add(this.ApplicationTextBox);
            this.LoginDetailPanel.Controls.Add(this.UsernameTextBox);
            this.LoginDetailPanel.Controls.Add(this.UsernameLabel);
            this.LoginDetailPanel.Controls.Add(this.PasswordLabel);
            this.LoginDetailPanel.Controls.Add(this.PasswordTextBox);
            this.LoginDetailPanel.Location = new System.Drawing.Point(12, 57);
            this.LoginDetailPanel.Name = "LoginDetailPanel";
            this.LoginDetailPanel.Size = new System.Drawing.Size(333, 343);
            this.LoginDetailPanel.TabIndex = 12;
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.Location = new System.Drawing.Point(2, 55);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(95, 18);
            this.ApplicationLabel.TabIndex = 9;
            this.ApplicationLabel.Text = "Application *";
            this.ApplicationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ApplicationTextBox
            // 
            this.ApplicationTextBox.Location = new System.Drawing.Point(102, 55);
            this.ApplicationTextBox.Name = "ApplicationTextBox";
            this.ApplicationTextBox.Size = new System.Drawing.Size(197, 20);
            this.ApplicationTextBox.TabIndex = 10;
            // 
            // AddLoginDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 412);
            this.Controls.Add(this.LoginDetailPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiscardButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddLoginDetailTitleLabel);
            this.Name = "AddLoginDetail";
            this.Text = "AddLoginDetail";
            this.LoginDetailPanel.ResumeLayout(false);
            this.LoginDetailPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.TextBox ApplicationTextBox;

        private System.Windows.Forms.Panel LoginDetailPanel;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DiscardButton;
        private System.Windows.Forms.Label UsernameLabel;

        private System.Windows.Forms.TextBox UsernameTextBox;

        private System.Windows.Forms.Label AddLoginDetailTitleLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;

        #endregion
    }
}