using System;
using System.Windows.Forms;
using Domain.Managers;

namespace PasswordApp.Forms
{
    public partial class RegisterMasterLogin : Form
    {
        private AuthenticationManager _authenticationManager;
        
        public RegisterMasterLogin(AuthenticationManager authenticationManager)
        {
            _authenticationManager = authenticationManager;
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidPassword())
                return;
            
            var loginResult = _authenticationManager.SetMasterPassword(PasswordTextBox.Text);
            
            if (!loginResult.Success)
                MessageBox.Show(loginResult.Reason, "Error", MessageBoxButtons.OK);
            
            Close();
        }

        /// <summary>
        /// Check if the entered password is valid
        /// </summary>
        /// <returns></returns>
        private bool ValidPassword()
        {
            if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Password is not set!", "Incorrect password", MessageBoxButtons.OK);
                return false;
            }

            if (ConfirmPasswordTextBox.Text == "" || ConfirmPasswordTextBox.Text != PasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match!", "Incorrect password", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}