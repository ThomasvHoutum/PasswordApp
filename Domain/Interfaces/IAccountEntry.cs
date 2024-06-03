using Domain.Results;

namespace Domain.Interfaces;

public interface IAccountEntry
{
    ValidationResult Validate();
}