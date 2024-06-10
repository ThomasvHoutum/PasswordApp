using Domain.Results;

namespace Domain.Interfaces;

public interface IAccountEntry : ILoginType
{
    ValidationResult Validate();
}