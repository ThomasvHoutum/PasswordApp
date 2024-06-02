namespace Domain.Interfaces;

public interface IEncryptionHelper
{
    /// <summary>
    /// Convert undefined object to an encrypted string
    /// </summary>
    /// <param name="objectToEncrypt"></param>
    /// <returns></returns>
    string Encrypt<T>(T objectToEncrypt);
    
    /// <summary>
    /// Convert encrypted text to an undefined object
    /// </summary>
    /// <param name="encryptedText"></param>
    /// <returns></returns>
    T Decrypt<T>(string encryptedText);
}