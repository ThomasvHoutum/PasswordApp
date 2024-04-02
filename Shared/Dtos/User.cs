namespace Shared.Dtos;

public class User
{
    public string MasterPassword { get; private set; }

    public User(string masterPassword)
    {
        MasterPassword = masterPassword;
    }
}