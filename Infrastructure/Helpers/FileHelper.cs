#nullable enable
using System.IO;

namespace Infrastructure.Helpers;

public static class FileHelper
{
    private const string CreditCardsPath = "creditCards.json";
    private const string BankDetailsPath = "bankDetails.json";
    private const string LoginDetailsPath = "loginDetails.json";
        
    private const string MasterPasswordPath = "masterPassword.json";

    #region Write
    
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
    
    #endregion

    #region Read

    /// <summary>
    /// Read file for credit cards
    /// </summary>
    public static string? ReadCreditCardsFile() => !DoesFileExist(CreditCardsPath)
        ? null
        : File.ReadAllText(CreditCardsPath);
    
    /// <summary>
    /// Read file for bank details
    /// </summary>
    public static string? ReadBankDetailsFile() => !DoesFileExist(BankDetailsPath)
        ? null
        : File.ReadAllText(BankDetailsPath);
    
    /// <summary>
    /// Read file for login details
    /// </summary>
    public static string? ReadLoginDetailsFile() => !DoesFileExist(LoginDetailsPath)
        ? null
        : File.ReadAllText(LoginDetailsPath);

    /// <summary>
    /// Read file for the master password
    /// </summary>
    public static string? ReadMasterPasswordFile() => !DoesFileExist(MasterPasswordPath)
        ? null
        : File.ReadAllText(MasterPasswordPath);

    #endregion

    private static bool DoesFileExist(string filePath) => File.Exists(filePath);
}