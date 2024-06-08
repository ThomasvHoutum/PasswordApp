using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Domain.Interfaces;

namespace Domain.LoginTypes;

public class BankLogin : ILoginType
{
    private readonly int _passwordLength = 32;
    
    private readonly char[] _characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()".ToCharArray();
    private readonly string _capitalCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private readonly string _numberCharacters = "1234567890";
    private readonly string _specialCharacters = "!@#$%^&*()";

    /// <inheritdoc />
    public string GeneratePassword()
    {
        var password = new StringBuilder(_passwordLength);
        password.Append(GetRandomCharacter(_capitalCharacters));
        password.Append(GetRandomCharacter(_numberCharacters));
        password.Append(GetRandomCharacter(_specialCharacters));

        var data = new byte[4 * (_passwordLength - 3)];
        using (var random = new RNGCryptoServiceProvider())
        {
            random.GetBytes(data);
        }

        for (int i = 0; i < _passwordLength - 3; i++)
        {
            var rnd = BitConverter.ToUInt32(data, i * 4);
            var idx = rnd % _characters.Length;
            password.Append(_characters[idx]);
        }

        return new string(password.ToString().OrderBy(c => GetRandomIndex()).ToArray());
    }

    /// <summary>
    /// Get a random character
    /// </summary>
    /// <param name="characters"></param>
    /// <returns></returns>
    private char GetRandomCharacter(string characters)
    {
        byte[] randomByte = new byte[1];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(randomByte);
        }
        return characters[randomByte[0] % characters.Length];
    }

    /// <summary>
    /// Get a random index
    /// </summary>
    /// <returns></returns>
    private int GetRandomIndex()
    {
        var randomBytes = new byte[4];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(randomBytes);
        }
        return BitConverter.ToInt32(randomBytes, 0);
    }
}