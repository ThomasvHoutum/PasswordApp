using System;
using System.Windows.Forms;
using Domain.Managers;

namespace PasswordApp.Forms
{
    public partial class MasterLogin : Form
    {
        private AuthenticationManager _authenticationManager;
        
        public MasterLogin()
        {
            InitializeComponent();
            
            _authenticationManager = new AuthenticationManager();
            
            if (!_authenticationManager.HasMasterPassword())
            {
                var registerMasterLoginForm = new RegisterMasterLogin(_authenticationManager);
                registerMasterLoginForm.Show();
                registerMasterLoginForm.Focus();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var loginResult = _authenticationManager.TryLoginUser(PasswordTextBox.Text);
            
            if (loginResult.Success)
                Close();
            else
                MessageBox.Show(loginResult.Reason, "Failed to log in", MessageBoxButtons.OK);
        }
    }
}