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
            this.GeneratePasswordLabel = new System.Windows.Forms.Label();
            this.Answer3Label = new System.Windows.Forms.Label();
            this.Answer3TextBox = new System.Windows.Forms.TextBox();
            this.Question3Label = new System.Windows.Forms.Label();
            this.Question3TextBox = new System.Windows.Forms.TextBox();
            this.Answer2Label = new System.Windows.Forms.Label();
            this.Answer2TextBox = new System.Windows.Forms.TextBox();
            this.Question2Label = new System.Windows.Forms.Label();
            this.Question2TextBox = new System.Windows.Forms.TextBox();
            this.Answer1Label = new System.Windows.Forms.Label();
            this.Answer1TextBox = new System.Windows.Forms.TextBox();
            this.SecurityQuestionsLabel = new System.Windows.Forms.Label();
            this.Question1Label = new System.Windows.Forms.Label();
            this.Question1TextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.ApplicationTextBox = new System.Windows.Forms.TextBox();
            this.GeneratePasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.LoginDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddLoginDetailTitleLabel
            // 
            this.AddLoginDetailTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLoginDetailTitleLabel.Location = new System.Drawing.Point(12, 16);
            this.AddLoginDetailTitleLabel.Name = "AddLoginDetailTitleLabel";
            this.AddLoginDetailTitleLabel.Size = new System.Drawing.Size(155, 21);
            this.AddLoginDetailTitleLabel.TabIndex = 2;
            this.AddLoginDetailTitleLabel.Text = "Add new login detail";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(1, 81);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(95, 18);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password *";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(1, 29);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(95, 18);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username *";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(101, 81);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(197, 20);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(100, 29);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(198, 20);
            this.UsernameTextBox.TabIndex = 8;
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
            // LoginDetailPanel
            // 
            this.LoginDetailPanel.AutoScroll = true;
            this.LoginDetailPanel.Controls.Add(this.GeneratePasswordCheckbox);
            this.LoginDetailPanel.Controls.Add(this.GeneratePasswordLabel);
            this.LoginDetailPanel.Controls.Add(this.Answer3Label);
            this.LoginDetailPanel.Controls.Add(this.Answer3TextBox);
            this.LoginDetailPanel.Controls.Add(this.Question3Label);
            this.LoginDetailPanel.Controls.Add(this.Question3TextBox);
            this.LoginDetailPanel.Controls.Add(this.Answer2Label);
            this.LoginDetailPanel.Controls.Add(this.Answer2TextBox);
            this.LoginDetailPanel.Controls.Add(this.Question2Label);
            this.LoginDetailPanel.Controls.Add(this.Question2TextBox);
            this.LoginDetailPanel.Controls.Add(this.Answer1Label);
            this.LoginDetailPanel.Controls.Add(this.Answer1TextBox);
            this.LoginDetailPanel.Controls.Add(this.SecurityQuestionsLabel);
            this.LoginDetailPanel.Controls.Add(this.Question1Label);
            this.LoginDetailPanel.Controls.Add(this.Question1TextBox);
            this.LoginDetailPanel.Controls.Add(this.EmailLabel);
            this.LoginDetailPanel.Controls.Add(this.EmailTextBox);
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
            // GeneratePasswordLabel
            // 
            this.GeneratePasswordLabel.Location = new System.Drawing.Point(0, 107);
            this.GeneratePasswordLabel.Name = "GeneratePasswordLabel";
            this.GeneratePasswordLabel.Size = new System.Drawing.Size(106, 18);
            this.GeneratePasswordLabel.TabIndex = 26;
            this.GeneratePasswordLabel.Text = "Generate Password";
            this.GeneratePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Answer3Label
            // 
            this.Answer3Label.Location = new System.Drawing.Point(4, 317);
            this.Answer3Label.Name = "Answer3Label";
            this.Answer3Label.Size = new System.Drawing.Size(95, 18);
            this.Answer3Label.TabIndex = 24;
            this.Answer3Label.Text = "Answer";
            this.Answer3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Answer3TextBox
            // 
            this.Answer3TextBox.Location = new System.Drawing.Point(104, 317);
            this.Answer3TextBox.Name = "Answer3TextBox";
            this.Answer3TextBox.Size = new System.Drawing.Size(197, 20);
            this.Answer3TextBox.TabIndex = 25;
            // 
            // Question3Label
            // 
            this.Question3Label.Location = new System.Drawing.Point(4, 291);
            this.Question3Label.Name = "Question3Label";
            this.Question3Label.Size = new System.Drawing.Size(95, 18);
            this.Question3Label.TabIndex = 22;
            this.Question3Label.Text = "Question";
            this.Question3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Question3TextBox
            // 
            this.Question3TextBox.Location = new System.Drawing.Point(104, 291);
            this.Question3TextBox.Name = "Question3TextBox";
            this.Question3TextBox.Size = new System.Drawing.Size(197, 20);
            this.Question3TextBox.TabIndex = 23;
            this.Question3TextBox.UseSystemPasswordChar = true;
            // 
            // Answer2Label
            // 
            this.Answer2Label.Location = new System.Drawing.Point(4, 253);
            this.Answer2Label.Name = "Answer2Label";
            this.Answer2Label.Size = new System.Drawing.Size(95, 18);
            this.Answer2Label.TabIndex = 20;
            this.Answer2Label.Text = "Answer";
            this.Answer2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Answer2TextBox
            // 
            this.Answer2TextBox.Location = new System.Drawing.Point(104, 253);
            this.Answer2TextBox.Name = "Answer2TextBox";
            this.Answer2TextBox.Size = new System.Drawing.Size(197, 20);
            this.Answer2TextBox.TabIndex = 21;
            this.Answer2TextBox.UseSystemPasswordChar = true;
            // 
            // Question2Label
            // 
            this.Question2Label.Location = new System.Drawing.Point(4, 227);
            this.Question2Label.Name = "Question2Label";
            this.Question2Label.Size = new System.Drawing.Size(95, 18);
            this.Question2Label.TabIndex = 18;
            this.Question2Label.Text = "Question";
            this.Question2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Question2TextBox
            // 
            this.Question2TextBox.Location = new System.Drawing.Point(104, 227);
            this.Question2TextBox.Name = "Question2TextBox";
            this.Question2TextBox.Size = new System.Drawing.Size(197, 20);
            this.Question2TextBox.TabIndex = 19;
            this.Question2TextBox.UseSystemPasswordChar = true;
            // 
            // Answer1Label
            // 
            this.Answer1Label.Location = new System.Drawing.Point(4, 191);
            this.Answer1Label.Name = "Answer1Label";
            this.Answer1Label.Size = new System.Drawing.Size(95, 18);
            this.Answer1Label.TabIndex = 16;
            this.Answer1Label.Text = "Answer";
            this.Answer1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Answer1TextBox
            // 
            this.Answer1TextBox.Location = new System.Drawing.Point(104, 191);
            this.Answer1TextBox.Name = "Answer1TextBox";
            this.Answer1TextBox.Size = new System.Drawing.Size(197, 20);
            this.Answer1TextBox.TabIndex = 17;
            this.Answer1TextBox.UseSystemPasswordChar = true;
            // 
            // SecurityQuestionsLabel
            // 
            this.SecurityQuestionsLabel.Location = new System.Drawing.Point(3, 137);
            this.SecurityQuestionsLabel.Name = "SecurityQuestionsLabel";
            this.SecurityQuestionsLabel.Size = new System.Drawing.Size(95, 18);
            this.SecurityQuestionsLabel.TabIndex = 15;
            this.SecurityQuestionsLabel.Text = "Security Questions";
            this.SecurityQuestionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Question1Label
            // 
            this.Question1Label.Location = new System.Drawing.Point(4, 165);
            this.Question1Label.Name = "Question1Label";
            this.Question1Label.Size = new System.Drawing.Size(95, 18);
            this.Question1Label.TabIndex = 13;
            this.Question1Label.Text = "Question";
            this.Question1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Question1TextBox
            // 
            this.Question1TextBox.Location = new System.Drawing.Point(104, 165);
            this.Question1TextBox.Name = "Question1TextBox";
            this.Question1TextBox.Size = new System.Drawing.Size(197, 20);
            this.Question1TextBox.TabIndex = 14;
            this.Question1TextBox.UseSystemPasswordChar = true;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Location = new System.Drawing.Point(0, 55);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(95, 18);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email *";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(100, 55);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(197, 20);
            this.EmailTextBox.TabIndex = 12;
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.Location = new System.Drawing.Point(0, 3);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(95, 18);
            this.ApplicationLabel.TabIndex = 9;
            this.ApplicationLabel.Text = "Application *";
            this.ApplicationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ApplicationTextBox
            // 
            this.ApplicationTextBox.Location = new System.Drawing.Point(100, 3);
            this.ApplicationTextBox.Name = "ApplicationTextBox";
            this.ApplicationTextBox.Size = new System.Drawing.Size(197, 20);
            this.ApplicationTextBox.TabIndex = 10;
            // 
            // GeneratePasswordCheckbox
            // 
            this.GeneratePasswordCheckbox.Location = new System.Drawing.Point(112, 107);
            this.GeneratePasswordCheckbox.Name = "GeneratePasswordCheckbox";
            this.GeneratePasswordCheckbox.Size = new System.Drawing.Size(29, 21);
            this.GeneratePasswordCheckbox.TabIndex = 27;
            this.GeneratePasswordCheckbox.UseVisualStyleBackColor = true;
            this.GeneratePasswordCheckbox.CheckedChanged += new System.EventHandler(this.GeneratePasswordCheckbox_CheckedChanged);
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
            this.Text = "Add Login Detail";
            this.LoginDetailPanel.ResumeLayout(false);
            this.LoginDetailPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox GeneratePasswordCheckbox;

        private System.Windows.Forms.Label GeneratePasswordLabel;

        private System.Windows.Forms.Label Question2Label;
        private System.Windows.Forms.Label Answer2Label;
        private System.Windows.Forms.TextBox Question2TextBox;
        private System.Windows.Forms.TextBox Answer2TextBox;

        private System.Windows.Forms.Label Question1Label;
        private System.Windows.Forms.TextBox Question1TextBox;
        private System.Windows.Forms.Label SecurityQuestionsLabel;
        private System.Windows.Forms.Label Answer1Label;
        private System.Windows.Forms.TextBox Answer1TextBox;
        private System.Windows.Forms.Label Answer3Label;
        private System.Windows.Forms.TextBox Answer3TextBox;
        private System.Windows.Forms.Label Question3Label;
        private System.Windows.Forms.TextBox Question3TextBox;

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;

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