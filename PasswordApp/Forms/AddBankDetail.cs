using System;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Managers;
using PasswordApp.Results;

namespace PasswordApp.Forms
{
    public partial class AddBankDetail : Form
    {
        private readonly Manager _manager;
        private readonly PasswordManager _passwordManager;
        
        public AddBankDetail(Manager manager, PasswordManager passwordManager)
        {
            _manager = manager;
            _passwordManager = passwordManager;
            
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var validationResult = ValidTextFields();
            if (!validationResult.Success)
            {
                MessageBox.Show(validationResult.Reason, "Failed to create credit card", MessageBoxButtons.OK);
                return;
            }
            
            var bankDetail = new BankDetail(
                BankNameTextBox.Text,
                double.Parse(IbanTextBox.Text),
                UsernameTextBox.Text,
                PasswordTextBox.Text);
            
            _passwordManager.BankDetailRepository.Add(bankDetail);
            _manager.AddToLoginTable(bankDetail.BankName, bankDetail.Username);
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Validate input fields
        /// </summary>
        /// <returns></returns>
        private ValidationResult ValidTextFields()
        {
            if (string.IsNullOrEmpty(BankNameTextBox.Text))
                return new ValidationResult(false, "Bank name is required");
            
            if (string.IsNullOrEmpty(IbanTextBox.Text))
                return new ValidationResult(false, "IBAN is required");
            
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
                return new ValidationResult(false, "Username is required");
            
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
                return new ValidationResult(false, "Password is required");
            
            return new ValidationResult(true);
        }
    }
}