namespace BatatasFinance.Infrastructure.Data;

using Microsoft.EntityFrameworkCore;
using BatatasFinance.Domain.Entities;

public class BatatasDbContext : DbContext
{
    public BatatasDbContext(DbContextOptions<BatatasDbContext> options) : base(options) { }

    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Income> Incomes { get; set; }
    public DbSet<CreditCard> CreditCards { get; set; }
    public DbSet<User> Users { get; set; }
}