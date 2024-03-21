namespace Domain.Results;

public class LoginResult
{
    public bool Success { get; private set; }
    public string Reason { get; private set; }

    public LoginResult(bool success, string reason = "")
    {
        Success = success;
        Reason = reason;
    }
}