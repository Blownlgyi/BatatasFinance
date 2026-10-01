namespace BatatasFinance.Application.Interfaces;

public interface IRegisterIncomeUseCase
{
    Task ExecuteAsync(string description, decimal amount, bool isRecurring);
}