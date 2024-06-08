using System.Collections.Generic;
using Domain.Interfaces;
using Domain.LoginTypes;
using Domain.Results;

namespace Domain.Entities;

public class LoginDetail : WebLogin, IAccountEntry
{
    public string ApplicationName { get; private set; }
        
    public string Username { get; private set; }
        
    public string Email { get; private set; }
        
    public string Password { get; private set; }
        
    public List<SecurityQuestion> SecurityQuestions { get; private set; }

    public LoginDetail(string applicationName, string username, string email, string password, List<SecurityQuestion> securityQuestions)
    {
        ApplicationName = applicationName;
        Username = username;
        Email = email;
        Password = password;
        SecurityQuestions = securityQuestions;
    }

    public ValidationResult Validate()
    {
        if (string.IsNullOrEmpty(ApplicationName))
            return new ValidationResult(false, "Application name is required");
            
        if (string.IsNullOrEmpty(Username))
            return new ValidationResult(false, "Username is required");
            
        if (string.IsNullOrEmpty(Email))
            return new ValidationResult(false, "Email is required");
            
        if (string.IsNullOrEmpty(Password))
            return new ValidationResult(false, "Password is required");
            
        return new ValidationResult(true);
    }
}