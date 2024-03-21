using System;
using System.Windows.Forms;
using Domain.Managers;

namespace PasswordApp.Forms
{
    public partial class MasterLogin : Form
    {
        // Create login successful event
        public delegate void LoginSuccessEventHandler();
        public event LoginSuccessEventHandler LoginSuccessful;
        
        private readonly AuthenticationManager _authenticationManager;
        
        public MasterLogin(AuthenticationManager authenticationManager)
        {
            InitializeComponent();
            
            _authenticationManager = authenticationManager;
            
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
            {
                LoginSuccessful?.Invoke();
                Close();
            }
            else
            {
                MessageBox.Show(loginResult.Reason, "Failed to log in", MessageBoxButtons.OK);
            }
        }
    }
}