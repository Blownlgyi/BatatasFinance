using Microsoft.EntityFrameworkCore;
namespace BatatasFinance.Infrastructure.Repositories;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Infrastructure.Data;
public class ExpenseRepository(BatatasDbContext context) : IExpenseRepository
{
    public async Task AddAsync(Expense expense)
    {
        await context.Expenses.AddAsync(expense);
        await context.SaveChangesAsync();
    }
    public async Task<IEnumerable<Expense?>> GetAllAsync()
    {
        return await context.Expenses.AsNoTracking().ToListAsync();
    }
    public async Task<decimal> GetInvoiceAsync(Guid creditCardId, Guid userId)
    {
        return await context.Expenses.Where(e => e.CreditCardId == creditCardId && e.UserId == userId).SumAsync(e => e.Amount);
    }
    public async Task<IEnumerable<Expense?>> GetExpensesCardAsync(Guid creditCardId, Guid userId)
    {
        return await context.Expenses.Where(e => e.CreditCardId == creditCardId && e.UserId == userId).ToListAsync();
    }
}