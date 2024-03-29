using System;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace Infrastructure.Helpers;

public static class EncryptionHelper
{
    /// <summary>
    /// Convert undefined object to an encrypted string
    /// </summary>
    /// <param name="objectToEncrypt"></param>
    /// <returns></returns>
    public static string Encrypt<T>(T objectToEncrypt)
    {
        var jsonString = JsonConvert.SerializeObject(objectToEncrypt);
        byte[] data = Encoding.UTF8.GetBytes(jsonString);
        byte[] encryptedData = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
        return Convert.ToBase64String(encryptedData);
    }

    /// <summary>
    /// Convert encrypted text to an undefined object
    /// </summary>
    /// <param name="encryptedText"></param>
    /// <returns></returns>
    public static T Decrypt<T>(string encryptedText)
    {
        byte[] encryptedData = Convert.FromBase64String(encryptedText);
        byte[] decryptedData = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
        var decryptedString = Encoding.UTF8.GetString(decryptedData);

        return JsonConvert.DeserializeObject<T>(decryptedString);
    }
}