namespace Shared.Dtos;

public class BankDetail
{
    public string BankName { get; private set; }
        
    public double Iban { get; private set; }
        
    public string Username { get; private set; }
        
    public string Password { get; private set; }

    public BankDetail(string bankName, double iban, string username, string password)
    {
        BankName = bankName;
        Iban = iban;
        Username = username;
        Password = password;
    }
}