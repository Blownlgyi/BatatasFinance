using BatatasFinance.Application.Repositories;
using BatatasFinance.Domain.Entities;
namespace BatatasFinance.Application.UseCases;

public class RegisterPurchaseUseCase : IRegisterPurchaseUseCase
{
    private readonly IPurchaseRepository _repository;

    public RegisterPurchaseUseCase(IPurchaseRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(string description, decimal amount)
    {
        var purchase = new Purchase(description, amount);
        await _repository.AddAsync(purchase);
        
    }


}