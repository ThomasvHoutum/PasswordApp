using Domain.Interfaces;
using Domain.Results;

namespace Domain.Entities;

public class User
{
    public string MasterPassword { get; private set; }

    public User(string masterPassword)
    {
        MasterPassword = masterPassword;
    }

    public ValidationResult Validate()
    {
        if (string.IsNullOrEmpty(MasterPassword))
            return new ValidationResult(false, "Master password is required");

        return new ValidationResult(true);
    }
}