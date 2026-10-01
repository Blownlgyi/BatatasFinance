namespace BatatasFinance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using BatatasFinance.Domain.Entities;

public class BatatasDbContext : DbContext
{
    public BatatasDbContext(DbContextOptions<BatatasDbContext> options) : base(options) { }

    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Income> Incomes { get; set; }
}