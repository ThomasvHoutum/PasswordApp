using System;
using System.Windows.Forms;
using Domain.Managers;
using Domain.Models;

namespace PasswordApp.Forms
{
    public partial class AddLoginDetail : Form
    {
        private readonly PasswordManager _passwordManager;
        
        public AddLoginDetail(PasswordManager passwordManager)
        {
            _passwordManager = passwordManager;
            
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // TODO: Do this in domain layer
            if (!ValidTextFields())
            {
                MessageBox.Show("Invalid input!", "Failed to create login", MessageBoxButtons.OK);
                return;
            }

            var loginDetail = new LoginDetail(ApplicationTextBox.Text, 
                UsernameTextBox.Text, 
                EmailTextBox.Text,
                PasswordTextBox.Text,
                null);
            
            _passwordManager.SaveLoginDetail(loginDetail);
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            Close();
        }

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
    }
}