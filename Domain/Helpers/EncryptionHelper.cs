using System;
using System.Security.Cryptography;
using System.Text;

namespace Domain.Helpers
{
    public static class EncryptionHelper
    {
        public static string Encrypt(string plainText)
        {
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedData = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static string Decrypt(string cipherText)
        {
            byte[] encryptedData = Convert.FromBase64String(cipherText);
            byte[] decryptedData = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}