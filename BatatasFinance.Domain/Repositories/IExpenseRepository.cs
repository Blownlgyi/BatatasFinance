using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Domain.Repositories;

public interface IExpenseRepository
{
    Task AddAsync(Expense expense);
    Task<IEnumerable<Expense?>> GetAllAsync();
}