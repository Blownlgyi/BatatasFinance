using Microsoft.EntityFrameworkCore;

namespace BatatasFinance.Infrastructure.Repositories;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Infrastructure.Data;

public class PurchaseRepository (BatatasDbContext context) : IPurchaseRepository
{
    public async Task AddAsync(Purchase purchase)
    {
        await context.Purchases.AddAsync(purchase);
        await context.SaveChangesAsync(); 
    }

    public async Task<IEnumerable<Purchase?>> GetAllAsync()
    {
        return await context.Purchases.AsNoTracking().ToListAsync();
    }

   
}