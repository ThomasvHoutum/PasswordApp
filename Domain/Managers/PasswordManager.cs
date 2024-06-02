using Domain.Interfaces;
using Domain.Repositories;
using Shared.Dtos;

namespace Domain.Managers
{
    public class PasswordManager
    {
        public AccountEntryRepository<CreditCard> CreditCardRepository { get; private set; }
        
        public AccountEntryRepository<BankDetail> BankDetailRepository { get; private set; }
        
        public AccountEntryRepository<LoginDetail> LoginDetailRepository { get; private set; }

        public PasswordManager(IFileHelper fileHelper, IEncryptionHelper encryptionHelper)
        {
            CreditCardRepository = new AccountEntryRepository<CreditCard>(fileHelper, encryptionHelper);
            BankDetailRepository = new AccountEntryRepository<BankDetail>(fileHelper, encryptionHelper);
            LoginDetailRepository = new AccountEntryRepository<LoginDetail>(fileHelper, encryptionHelper);

            DecryptAllAccountEntries();
        }

        /// <summary>
        /// Decrypt all account entries
        /// </summary>
        private void DecryptAllAccountEntries()
        {
            CreditCardRepository.LoadFromFile();
            BankDetailRepository.LoadFromFile();
            LoginDetailRepository.LoadFromFile();
        }
    }
}