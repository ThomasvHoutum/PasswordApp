using System;
using System.Linq;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Managers;
using PasswordApp.Results;

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
            var validationResult = ValidTextFields();
            if (!validationResult.Success)
            {
                MessageBox.Show(validationResult.Reason, "Failed to create credit card", MessageBoxButtons.OK);
                return;
            }
            
            var creditCard = new CreditCard(
                IssuerTextBox.Text,
                double.Parse(NumberTextBox.Text),
                ExpiryDateFieldPicker.Value,
                double.Parse(CvvTextBox.Text),
                BillingAddressTextBox.Text);

            _passwordManager.CreditCardRepository.Add(creditCard);
            _manager.AddToLoginTable(creditCard.Issuer, creditCard.Number.ToString());
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Validate input fields
        /// </summary>
        /// <returns></returns>
        private ValidationResult ValidTextFields()
        {
            if (string.IsNullOrEmpty(IssuerTextBox.Text))
                return new ValidationResult(false, "Issuer is required");
            
            if (string.IsNullOrEmpty(NumberTextBox.Text))
                return new ValidationResult(false, "Number is required");
            
            if (NumberTextBox.Text.Any(char.IsLetter))
                return new ValidationResult(false, "Number field can only contain numbers");
            
            if (string.IsNullOrEmpty(CvvTextBox.Text))
                return new ValidationResult(false, "CVV is required");
            
            if (CvvTextBox.Text.Any(char.IsLetter))
                return new ValidationResult(false, "CVV field can only contain numbers");
            
            if (string.IsNullOrEmpty(BillingAddressTextBox.Text))
                return new ValidationResult(false, "Billing address is required");
            
            return new ValidationResult(true);
        }
    }
}