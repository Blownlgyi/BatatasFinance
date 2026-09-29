namespace BatatasFinance.Application.UseCases;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Application.Repositories;
public class GetAllPurchasesUseCase : IGetAllPurchasesUseCase
{
    private readonly IPurchaseRepository _repository;

    public GetAllPurchasesUseCase(IPurchaseRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Purchase>> ExecuteAsync()
    {
        return await _repository.GetAllAsync();
    }
}