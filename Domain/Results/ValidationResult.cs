namespace Domain.Results
{
    public class ValidationResult
    {
        public bool Success { get; private set; }
        public string Reason { get; private set; }

        public ValidationResult(bool success, string reason = "")
        {
            Success = success;
            Reason = reason;
        }
    }
}