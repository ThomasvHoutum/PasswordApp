using System;
using System.Linq;
using System.Windows.Forms;
using Domain.Managers;
using Shared.Dtos;

namespace PasswordApp.Forms
{
    public partial class AddCreditCard : Form
    {
        private readonly Manager _manager;
        private readonly PasswordManager _passwordManager;
        
        public AddCreditCard(Manager manager, PasswordManager passwordManager)
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
            
            var creditCard = new CreditCard(
                IssuerTextBox.Text,
                double.Parse(NumberTextBox.Text),
                ExpiryDateFieldPicker.Value,
                double.Parse(CvvTextBox.Text),
                BillingAddressTextBox.Text);
            
            _passwordManager.AddCreditCard(creditCard);
            _manager.AddToLoginTable(creditCard.Issuer, creditCard.Number.ToString());
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Validate input fields
        /// </summary>
        /// <returns></returns>
        private bool ValidTextFields()
        {
            if (IssuerTextBox.Text == null)
                return false;
            
            // TODO make char.IsDigit into string extension method
            if (NumberTextBox.Text == null || NumberTextBox.Text.Any(c => char.IsLetter(c)))
                return false;
            
            if (CvvTextBox.Text == null || CvvTextBox.Text.Any(c => char.IsLetter(c)))
                return false;
            
            if (BillingAddressTextBox.Text == null)
                return false;
            
            return true;
        }
    }
}