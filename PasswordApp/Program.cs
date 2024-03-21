using System;
using System.Windows.Forms;
using Domain.Managers;
using PasswordApp.Forms;

namespace PasswordApp
{
    static class Program
    {
        private static AuthenticationManager _authenticationManager;
        
        [STAThread]
        private static void Main()
        {
            _authenticationManager = new AuthenticationManager();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MasterLogin(_authenticationManager));
        }
    }
}