#nullable enable
using Domain.Interfaces;
using Domain.Results;
using Shared.Dtos;

namespace Domain.Managers;

public class AuthenticationManager
{
    private readonly IFileHelper _fileHelper;
    private readonly IEncryptionHelper _encryptionHelper;
    
    private User? ActiveUser { get; set; }

    public AuthenticationManager(IFileHelper fileHelper, IEncryptionHelper encryptionHelper)
    {
        _fileHelper = fileHelper;
        _encryptionHelper = encryptionHelper;
    }
    
    /// <summary>
    /// Creates a new user with given password as master password
    /// Only possible if there is no active user
    /// </summary>
    public void SetMasterPassword(string password)
    {
        // Early return if there is already a user logged in
        if (ActiveUser != null)
            return;

        ActiveUser = new User(password);
        var encryptedString = _encryptionHelper.Encrypt(ActiveUser);
        _fileHelper.WriteFile("MasterPassword.json", encryptedString);
    }

    /// <summary>
    /// Tries to log in the user with the given master password
    /// </summary>
    /// <param name="masterPassword"></param>
    /// <returns>Login success</returns>
    public LoginResult TryLoginUser(string masterPassword)
    {
        var decryptedUser = DecryptMasterPassword();
        if (decryptedUser == null)
            return new LoginResult(false, "No user found! Create a new master password.");

        if (decryptedUser.MasterPassword != masterPassword)
            return new LoginResult(false, "Incorrect password!");

        ActiveUser = decryptedUser;
        return new LoginResult(true);
    }

    /// <summary>
    /// Tries to log out the active user
    /// </summary>
    /// <returns>Logout success</returns>
    public bool TryLogoutUser()
    {
        // TODO
        return false;
    }

    /// <summary>
    /// Checks if there is an active user logged in
    /// </summary>
    /// <returns></returns>
    public bool IsLoggedIn() => ActiveUser != null;
    
    /// <summary>
    /// Check if a master password has been set before
    /// </summary>
    /// <returns></returns>
    public bool HasMasterPassword()
    {
        var user = DecryptMasterPassword();
        return user != null;
    }
    
    /// <summary>
    /// Decrypt the master password
    /// </summary>
    /// <returns> Master password, null if none set</returns>
    private User? DecryptMasterPassword()
    {
        var encryptedPassword = _fileHelper.ReadFile("MasterPassword.json");
        return encryptedPassword != null
            ? _encryptionHelper.Decrypt<User>(encryptedPassword)
            : null;
    }
}