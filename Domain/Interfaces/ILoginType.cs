namespace Domain.Interfaces;

public interface ILoginType
{
    /// <summary>
    /// Generate a random password
    /// </summary>
    /// <returns></returns>
    string GeneratePassword();
}