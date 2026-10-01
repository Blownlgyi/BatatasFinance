using BatatasFinance.Application.DTOs;

namespace BatatasFinance.Application.UseCases;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Application.Interfaces;
public class GetAllPurchasesUseCase(IPurchaseRepository repository) : IGetAllPurchasesUseCase
{
    
    public async Task<IEnumerable<PurchaseResponse?>> ExecuteAsync()
    {
        var purchases = await repository.GetAllAsync();


        return purchases.Select(p => new PurchaseResponse(
            p.Id, 
            p.Description, 
            p.Amount, 
            p.CreatedAt
        ));
    }
}