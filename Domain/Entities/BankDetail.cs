using Domain.Interfaces;
using Domain.Results;

namespace Domain.Entities;

public class BankDetail : IAccountEntry
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
    
    public ValidationResult Validate()
    {
        if (string.IsNullOrEmpty(BankName))
            return new ValidationResult(false, "Application name is required");
            
        if (Iban <= 0)
            return new ValidationResult(false, "Invalid IBAN");
        
        if (string.IsNullOrEmpty(Username))
            return new ValidationResult(false, "Username is required");
            
        if (string.IsNullOrEmpty(Password))
            return new ValidationResult(false, "Password is required");
            
        return new ValidationResult(true);
    }
}