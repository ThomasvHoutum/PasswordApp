using System;
using System.Drawing;
using System.Windows.Forms;
using Domain.Managers;
using PasswordApp.Forms;

namespace PasswordApp
{
    static class Program
    {
        private static AuthenticationManager _authenticationManager;
        private static NotifyIcon _trayIcon;
        
        [STAThread]
        private static void Main()
        {
            _authenticationManager = new AuthenticationManager();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            _trayIcon = new NotifyIcon
            {
                Text = "PasswordApp Manager",
                Icon = SystemIcons.Application,
                Visible = true
            };

            // _trayIcon.Click += (sender, e) => new Manager(_authenticationManager).Show();
            // Application.Run();
            
            Application.Run(new Manager(_authenticationManager));
        }
    }
}