using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Application.UseCases;

public interface IGetAllPurchasesUseCase
{
    Task<IEnumerable<Purchase>> ExecuteAsync();
}