using System.Collections.Generic;
using Shared.Interfaces;

namespace Shared.Dtos;

public class LoginDetail : IAccountEntry
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
}