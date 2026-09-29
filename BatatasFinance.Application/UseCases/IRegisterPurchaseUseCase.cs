namespace BatatasFinance.Application.UseCases;

public interface IRegisterPurchaseUseCase
{
    Task ExecuteAsync(string description, decimal amount);
}