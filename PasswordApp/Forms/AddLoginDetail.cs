using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Managers;
using PasswordApp.Results;

namespace PasswordApp.Forms
{
    public partial class AddLoginDetail : Form
    {
        private readonly Manager _manager;
        private readonly PasswordManager _passwordManager;
        
        public AddLoginDetail(Manager manager, PasswordManager passwordManager)
        {
            _manager = manager;
            _passwordManager = passwordManager;
            
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var validationResult = ValidTextFields();
            if (!validationResult.Success)
            {
                MessageBox.Show(validationResult.Reason, "Failed to create login", MessageBoxButtons.OK);
                return;
            }

            var securityQuestions = GetSecurityQuestions();
            
            var loginDetail = new LoginDetail(
                ApplicationTextBox.Text, 
                UsernameTextBox.Text, 
                EmailTextBox.Text,
                PasswordTextBox.Text,
                securityQuestions);
            
            _passwordManager.LoginDetailRepository.Add(loginDetail);
            _manager.AddToLoginTable(loginDetail.Username, loginDetail.ApplicationName);
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Validate input fields
        /// </summary>
        /// <returns></returns>
        private ValidationResult ValidTextFields()
        {
            if (string.IsNullOrEmpty(ApplicationTextBox.Text))
                return new ValidationResult(false, "Application is required");

            if (string.IsNullOrEmpty(UsernameTextBox.Text))
                return new ValidationResult(false, "Username is required");
            
            if (string.IsNullOrEmpty(EmailTextBox.Text))
                return new ValidationResult(false, "Email is required");
            
            if (!EmailTextBox.Text.Contains("@") || !EmailTextBox.Text.Contains("."))
                return new ValidationResult(false, "Email must contain @ and .");
            
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
                return new ValidationResult(false, "Password is required");

            return new ValidationResult(true);
        }

        /// <summary>
        /// Get all security questions to a list
        /// </summary>
        /// <returns></returns>
        private List<SecurityQuestion> GetSecurityQuestions()
        {
            var securityQuestions = new List<SecurityQuestion>();

            if (Question1TextBox.Text != "" && Answer1TextBox.Text != "")
                securityQuestions.Add(new SecurityQuestion(Question1TextBox.Text, Answer1TextBox.Text));

            if (Question2TextBox.Text != "" && Answer2TextBox.Text != "")
                securityQuestions.Add(new SecurityQuestion(Question2TextBox.Text, Answer2TextBox.Text));
            
            if (Question3TextBox.Text != "" && Answer3TextBox.Text != "")
                securityQuestions.Add(new SecurityQuestion(Question3TextBox.Text, Answer3TextBox.Text));
            
            return securityQuestions;
        }
    }
}