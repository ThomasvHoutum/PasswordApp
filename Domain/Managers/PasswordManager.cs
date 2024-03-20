#nullable enable
using System.Collections.Generic;
using Domain.Models;
using Infrastructure.Helpers;

namespace Domain.Managers
{
    public class PasswordManager
    {
        private User? ActiveUser { get; set; }
        
        private readonly List<CreditCard> _creditCards = new();
        public IReadOnlyList<CreditCard> CreditCards => _creditCards.AsReadOnly();

        private readonly List<BankDetail> _bankDetails = new();
        public IReadOnlyList<BankDetail> BankDetails => _bankDetails.AsReadOnly();

        private readonly List<LoginDetail> _loginDetails = new();
        public IReadOnlyList<LoginDetail> LoginDetails => _loginDetails.AsReadOnly();

        public PasswordManager()
        {
            
        }

        /// <summary>
        /// Creates a new user with given password as master password
        /// Only possible if there is no active user
        /// </summary>
        public void SetMasterPassword(string password)
        {
            // Early return if there is already a user logged in
            if (ActiveUser != null)
                return;

            ActiveUser = new User(password);
            var encryptedString = EncryptionHelper.Encrypt(ActiveUser);
            FileHelper.WriteMasterPasswordFile(encryptedString);
        }

        /// <summary>
        /// Tries to log in the user with the given master password
        /// </summary>
        /// <param name="masterPassword"></param>
        /// <returns>Login success</returns>
        public bool TryLoginUser(string masterPassword)
        {
            return false;
        }

        /// <summary>
        /// Tries to log out the active user
        /// </summary>
        /// <returns>Logout success</returns>
        public bool TryLogoutUser()
        {
            return false;
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
        /// Add a new login detail
        /// </summary>
        /// <param name="loginDetail"></param>
        public void AddLoginDetail(LoginDetail loginDetail) => _loginDetails.Add(loginDetail);
        
        /// <summary>
        /// Decrypt the master password
        /// </summary>
        /// <returns> Master password, null if none set</returns>
        private User? DecryptMasterPassword()
        {
            var encryptedPassword = FileHelper.ReadMasterPasswordFile();
            return encryptedPassword != null
                ? EncryptionHelper.Decrypt<User>(encryptedPassword)
                : null;
        }

        /// <summary>
        /// 
        /// </summary>
        private void DecryptAllAccountEntries()
        {
            
        } 
    }
}