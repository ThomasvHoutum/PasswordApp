using System.IO;

namespace Infrastructure.Helpers;

public static class WriteFileHelper
{
    private const string CreditCardsPath = "creditCards.json";
    private const string BankDetailsPath = "bankDetails.json";
    private const string LoginDetailsPath = "loginDetails.json";
        
    private const string MasterPasswordPath = "masterPassword.json";

    /// <summary>
    /// Write a new encrypted file for credit cards
    /// </summary>
    /// <param name="encryptedText"></param>
    public static void WriteCreditCardsFile(string encryptedText) => File.WriteAllText(CreditCardsPath, encryptedText);
    
    /// <summary>
    /// Write a new encrypted file for bank details
    /// </summary>
    /// <param name="encryptedText"></param>
    public static void WriteBankDetailsFile(string encryptedText) => File.WriteAllText(BankDetailsPath, encryptedText);
    
    /// <summary>
    /// Write a new encrypted file for login details
    /// </summary>
    /// <param name="encryptedText"></param>
    public static void WriteLoginDetailsFile(string encryptedText) => File.WriteAllText(LoginDetailsPath, encryptedText);
    
    /// <summary>
    /// Write a new encrypted file for the master password
    /// </summary>
    /// <param name="encryptedText"></param>
    public static void WriteMasterPasswordFile(string encryptedText) => File.WriteAllText(MasterPasswordPath, encryptedText);
}