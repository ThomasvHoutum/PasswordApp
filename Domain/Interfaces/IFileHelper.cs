namespace Domain.Interfaces;

public interface IFileHelper
{
    // TODO: Add comments
    string? ReadFile(string fileName);
    
    void WriteFile(string fileName, string encryptedText);
}