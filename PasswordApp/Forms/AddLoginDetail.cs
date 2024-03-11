using System;
using System.Windows.Forms;
using Domain.Dtos.AddLoginDetail.Save;
using Domain.Interfaces.LoginDetails;

namespace PasswordApp.Forms
{
    public partial class AddLoginDetail : Form
    {
        private readonly ILoginDetailService _loginDetailService;
        
        public AddLoginDetail(ILoginDetailService loginDetailService)
        {
            _loginDetailService = loginDetailService;
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var saveLoginDetailDto = new SaveLoginDetailDto
            {
                Username = UsernameTextBox.Text,
                Password = PasswordTextBox.Text,
                Application = ApplicationTextBox.Text
            };
    
            _loginDetailService.SaveLoginDetail(saveLoginDetailDto);
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}