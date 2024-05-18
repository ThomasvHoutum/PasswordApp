using Domain.Repositories;
using Shared.Dtos;

namespace Domain.Managers
{
    public class PasswordManager
    {
        public AccountEntryRepository<CreditCard> CreditCardRepository { get; private set; }
        
        public AccountEntryRepository<BankDetail> BankDetailRepository { get; private set; }
        
        public AccountEntryRepository<LoginDetail> LoginDetailRepository { get; private set; }

        public PasswordManager()
        {
            CreditCardRepository = new AccountEntryRepository<CreditCard>();
            BankDetailRepository = new AccountEntryRepository<BankDetail>();
            LoginDetailRepository = new AccountEntryRepository<LoginDetail>();

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