using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BatatasFinance.Infrastructure.Repositories;

public class IncomeRepository(BatatasDbContext context) : IIncomeRepository
{
    public async Task AddAsync(Income income)
    {
        await context.Incomes.AddAsync(income);
        await context.SaveChangesAsync();
    }
    public async Task<IEnumerable<Income>> GetAllAsync()
    {
        return await context.Incomes.AsNoTracking().ToListAsync();
    }
}