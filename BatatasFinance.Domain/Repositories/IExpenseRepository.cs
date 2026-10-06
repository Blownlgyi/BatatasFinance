using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Domain.Repositories;

public interface IExpenseRepository
{
    Task AddAsync(Expense expense);
    Task<IEnumerable<Expense?>> GetAllAsync();
    Task<decimal> GetInvoiceAsync(Guid creditCardId,  Guid userId);
    Task<IEnumerable<Expense?>> GetExpensesCardAsync(Guid creditCardId, Guid userId);
}