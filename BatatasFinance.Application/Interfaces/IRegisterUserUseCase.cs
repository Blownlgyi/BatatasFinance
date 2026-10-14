namespace BatatasFinance.Application.Interfaces;

public interface IRegisterUserCase
{
    Task<Guid> ExecuteAsync(
        string userName,
        decimal salary
        );
}