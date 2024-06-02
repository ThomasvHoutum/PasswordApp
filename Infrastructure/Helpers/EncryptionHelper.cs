using System;
using System.Security.Cryptography;
using System.Text;
using Domain.Interfaces;
using Newtonsoft.Json;

namespace Infrastructure.Helpers;

public class EncryptionHelper : IEncryptionHelper
{
    /// <summary>
    /// Convert undefined object to an encrypted string
    /// </summary>
    /// <param name="objectToEncrypt"></param>
    /// <returns></returns>
    public string Encrypt<T>(T objectToEncrypt)
    {
        var jsonObject = JsonConvert.SerializeObject(objectToEncrypt);
        var data = Encoding.UTF8.GetBytes(jsonObject);
        var encryptedData = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
        return Convert.ToBase64String(encryptedData);
    }

    /// <summary>
    /// Convert encrypted text to an undefined object
    /// </summary>
    /// <param name="encryptedText"></param>
    /// <returns></returns>
    public T Decrypt<T>(string encryptedText)
    {
        var encryptedData = Convert.FromBase64String(encryptedText);
        var decryptedData = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
        var decryptedString = Encoding.UTF8.GetString(decryptedData);

        return JsonConvert.DeserializeObject<T>(decryptedString);
    }
}