#nullable enable
using System.IO;

namespace Infrastructure.Helpers;

public static class FileHelper
{
    /// <summary>
    /// Read encrypted file
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static string? ReadFile(string fileName) => !DoesFileExist(fileName)
        ? null
        : File.ReadAllText(fileName);

    
    /// <summary>
    /// Write a new encrypted file
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="encryptedText"></param>
    /// <returns></returns>
    public static void WriteFile(string fileName, string encryptedText) => File.WriteAllText(fileName, encryptedText);

    /// <summary>
    /// Check if a file exists
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    private static bool DoesFileExist(string filePath) => File.Exists(filePath);
}