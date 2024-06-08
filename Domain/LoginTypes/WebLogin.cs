using System;
using System.Linq;
using System.Text;
using Domain.Interfaces;

namespace Domain.LoginTypes;

public class WebLogin : ILoginType
{
    private readonly int _passwordLength = 16;
    private readonly char[] _characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()".ToCharArray();
    private readonly string _capitalCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private readonly string _numberCharacters = "1234567890";
    
    /// <inheritdoc />
    public string GeneratePassword()
    {
        var random = new Random();
        
        var password = new StringBuilder(_passwordLength);
        password.Append(_capitalCharacters[random.Next(_capitalCharacters.Length)]);
        password.Append(_numberCharacters[random.Next(_numberCharacters.Length)]);

        for (var i = 2; i < _passwordLength; i++)
            password.Append(_characters[random.Next(_characters.Length)]);

        return new string(password.ToString().OrderBy(c => random.Next()).ToArray());
    }
}