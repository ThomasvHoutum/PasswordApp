namespace Domain.Interfaces;

public interface IFileHelper
{
    /// <summary>
    /// Reads a file from the file system
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    string? ReadFile(string fileName);
    
    /// <summary>
    /// Writes a file to the file system
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="encryptedText"></param>
    void WriteFile(string fileName, string encryptedText);
}