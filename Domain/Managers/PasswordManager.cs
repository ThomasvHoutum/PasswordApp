using System.Collections.Generic;
using Domain.Models;
using Infrastructure.Helpers;

namespace Domain.Managers
{
    public class PasswordManager
    {
        private readonly List<CreditCard> _creditCards = new();
        public IReadOnlyList<CreditCard> CreditCards => _creditCards.AsReadOnly();

        private readonly List<BankDetail> _bankDetails = new();
        public IReadOnlyList<BankDetail> BankDetails => _bankDetails.AsReadOnly();

        private readonly List<LoginDetail> _loginDetails = new();
        public IReadOnlyList<LoginDetail> LoginDetails => _loginDetails.AsReadOnly();

        public PasswordManager()
        {
            // TODO: Decrypt and populate lists on initialize
        }

        /// <summary>
        /// Add a new credit card
        /// </summary>
        /// <param name="creditCard"></param>
        public void AddCreditCard(CreditCard creditCard) => _creditCards.Add(creditCard);

        /// <summary>
        /// Add a new bank detail
        /// </summary>
        /// <param name="bankDetail"></param>
        public void AddBankDetail(BankDetail bankDetail) => _bankDetails.Add(bankDetail);
        
        /// <summary>
        /// Saves a new login detail
        /// </summary>
        /// <param name="loginDetail"></param>
        public void SaveLoginDetail(LoginDetail loginDetail)
        {
            _loginDetails.Add(loginDetail);
            var encryptedLoginDetails = EncryptionHelper.Encrypt(_loginDetails);
            FileHelper.WriteLoginDetailsFile(encryptedLoginDetails);
        }

        /// <summary>
        /// 
        /// </summary>
        private void DecryptAllAccountEntries()
        {
            
        } 
    }
}