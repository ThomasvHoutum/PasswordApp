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
    }
}