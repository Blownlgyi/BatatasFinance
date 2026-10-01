namespace BatatasFinance.Application.Interfaces;

public interface IRegisterPurchaseUseCase
{
    Task ExecuteAsync(string description, decimal amount);
}