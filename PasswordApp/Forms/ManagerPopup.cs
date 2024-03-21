using System.Windows.Forms;
using Domain.Managers;

namespace PasswordApp.Forms
{
    public partial class ManagerPopup : Form
    {
        private readonly AuthenticationManager _authenticationManager;
        
        public ManagerPopup(AuthenticationManager authenticationManager)
        {
            _authenticationManager = authenticationManager;
            
            if (!_authenticationManager.IsLoggedIn())
            {
                var masterLoginForm = new MasterLogin(_authenticationManager);
                masterLoginForm.LoginSuccessful += Initialize;
                masterLoginForm.Show();
                masterLoginForm.Focus();
            }
            else
            {
                Initialize();
            }
            
        }

        /// <summary>
        /// Initialize form
        /// </summary>
        private void Initialize()
        {
            InitializeComponent();
        }
    }
}