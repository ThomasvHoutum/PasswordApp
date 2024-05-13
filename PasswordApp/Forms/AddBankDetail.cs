using System;
using System.Linq;
using System.Windows.Forms;
using Domain.Managers;
using Shared.Dtos;

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
            if (!ValidTextFields())
            {
                MessageBox.Show("Invalid input!", "Failed to create credit card", MessageBoxButtons.OK);
                return;
            }
            
            var bankDetail = new BankDetail(
                BankNameTextBox.Text,
                double.Parse(IbanTextBox.Text),
                UsernameTextBox.Text,
                PasswordTextBox.Text);
            
            _passwordManager.AddBankDetail(bankDetail);
            _manager.AddToLoginTable(bankDetail.BankName, bankDetail.Username);
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Validate input fields
        /// </summary>
        /// <returns></returns>
        private bool ValidTextFields()
        {
            if (BankNameTextBox.Text == null)
                return false;
            
            // TODO make char.IsDigit into string extension method
            if (IbanTextBox.Text == null || IbanTextBox.Text.Any(c => char.IsLetter(c)))
                return false;
            
            if (UsernameTextBox.Text == null)
                return false;
            
            if (PasswordTextBox.Text == null)
                return false;
            
            return true;
        }
    }
}