using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Infrastructure.Data;

namespace BatatasFinance.Infrastructure.Repositories;

public class UserRepository (BatatasDbContext context) : IUserRepository
{
    public async Task AddAsync(User user)
    {
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
    }

    public async Task<User?> UpdateAsync(User user)
    {
        context.Users.Update(user);
        await context.SaveChangesAsync();
        return user;
    }

    public async Task SaveAsync(User user)
    {
        await context.SaveChangesAsync();
    }
    public async Task<User?> GetByIdAsync(Guid userId)
    {
        return await context.Users.FindAsync(userId); 
    }
}