using Microsoft.EntityFrameworkCore;

namespace BatatasFinance.Infrastructure.Repositories;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Application.Repositories;
using BatatasFinance.Infrastructure.Data;

public class PurchaseRepository : IPurchaseRepository
{
    private readonly BatatasDbContext _context;

    public PurchaseRepository(BatatasDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Purchase purchase)
    {
        await _context.Purchases.AddAsync(purchase);
        await _context.SaveChangesAsync(); 
    }

    public async Task<IEnumerable<Purchase>> GetAllAsync()
    {
        return await _context.Purchases.AsNoTracking().ToListAsync();
    }

   
}