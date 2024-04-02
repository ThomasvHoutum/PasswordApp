using System.Collections.Generic;
using Infrastructure.Helpers;
using Shared.Dtos;

namespace Domain.Managers
{
    public class PasswordManager
    {
        private List<CreditCard> _creditCards = new();
        public IReadOnlyList<CreditCard> CreditCards => _creditCards.AsReadOnly();

        private List<BankDetail> _bankDetails = new();
        public IReadOnlyList<BankDetail> BankDetails => _bankDetails.AsReadOnly();

        private List<LoginDetail> _loginDetails = new();
        public IReadOnlyList<LoginDetail> LoginDetails => _loginDetails.AsReadOnly();

        public PasswordManager()
        {
            DecryptAllAccountEntries();
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
            var creditCardsFileContent = FileHelper.ReadCreditCardsFile();
            if (creditCardsFileContent != null)
                _creditCards = EncryptionHelper.Decrypt<List<CreditCard>>(creditCardsFileContent);

            var bankDetailsFileContent = FileHelper.ReadBankDetailsFile();
            if (bankDetailsFileContent != null)
                _bankDetails = EncryptionHelper.Decrypt<List<BankDetail>>(bankDetailsFileContent);

            var loginDetailsFileContent = FileHelper.ReadLoginDetailsFile();
            if (loginDetailsFileContent != null)
                _loginDetails = EncryptionHelper.Decrypt<List<LoginDetail>>(loginDetailsFileContent);
        } 
    }
}