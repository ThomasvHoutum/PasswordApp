using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.Managers;
using Shared.Dtos;

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
            if (!ValidTextFields())
            {
                MessageBox.Show("Invalid input!", "Failed to create login", MessageBoxButtons.OK);
                return;
            }

            var securityQuestions = GetSecurityQuestions();
            
            var loginDetail = new LoginDetail(ApplicationTextBox.Text, 
                UsernameTextBox.Text, 
                EmailTextBox.Text,
                PasswordTextBox.Text,
                securityQuestions);
            
            _passwordManager.SaveLoginDetail(loginDetail);
            _manager.AddToLoginTable(loginDetail.Username, loginDetail.ApplicationName);
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Validate input fields
        /// </summary>
        /// <returns></returns>
        private bool ValidTextFields()
        {
            if (ApplicationTextBox.Text == null)
                return false;

            if (UsernameTextBox.Text == null)
                return false;

            if (EmailTextBox.Text == null || !EmailTextBox.Text.Contains("@") || !EmailTextBox.Text.Contains("."))
                return false;

            if (PasswordTextBox.Text == null)
                return false;

            return true;
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