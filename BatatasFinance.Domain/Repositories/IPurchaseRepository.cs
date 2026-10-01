using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Domain.Repositories;

public interface IPurchaseRepository
{
    Task AddAsync (Purchase purchase);
    Task<IEnumerable<Purchase?>> GetAllAsync();
}