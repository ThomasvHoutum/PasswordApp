namespace Domain.Models
{
    public class BankDetail
    {
        public string BankName { get; private set; }
        
        public int Iban { get; private set; }
        
        public string Username { get; private set; }
        
        public string Password { get; private set; }

        public BankDetail(string bankName, int iban, string username, string password)
        {
            BankName = bankName;
            Iban = iban;
            Username = username;
            Password = password;
        }
    }
}