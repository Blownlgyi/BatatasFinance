using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Domain.Repositories;

public interface IUserRepository
{
    Task AddAsync(User user);
}