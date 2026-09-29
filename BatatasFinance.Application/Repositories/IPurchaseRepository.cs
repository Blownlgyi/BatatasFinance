using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Application.Repositories;

public interface IPurchaseRepository
{
    Task AddAsync (Purchase purchase);
    Task<IEnumerable<Purchase>> GetAllAsync();
}