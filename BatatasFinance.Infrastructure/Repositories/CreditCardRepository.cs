using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BatatasFinance.Infrastructure.Repositories;

public class CreditCardRepository(BatatasDbContext context) : ICreditCardRepository
{
    public async Task AddAsync(CreditCard creditCard)
    {
        await context.CreditCards.AddAsync(creditCard);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<CreditCard?>> GetAllAsync()
    {
        return await context.CreditCards.AsNoTracking().ToListAsync();
    }

    public async Task<CreditCard?> GetByIdAsync(Guid creditCardId)
    {
        return await context.CreditCards.FirstOrDefaultAsync(c => c.Id == creditCardId);
    }
}