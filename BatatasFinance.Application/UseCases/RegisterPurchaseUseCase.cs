using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Domain.Entities;
namespace BatatasFinance.Application.UseCases;

public class RegisterPurchaseUseCase(IPurchaseRepository repository) : IRegisterPurchaseUseCase
{
    public async Task ExecuteAsync(string description, decimal amount)
    {
        var purchase = new Purchase(description, amount);
        await repository.AddAsync(purchase);
        
    }


}