namespace Domain.Models
{
    public class User
    {
        public string MasterPassword { get; private set; }

        public User(string masterPassword)
        {
            MasterPassword = masterPassword;
        }
    }
}