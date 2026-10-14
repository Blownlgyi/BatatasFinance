using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Application.Interfaces;

public interface IUpdateUserSalary
{
    Task<User?> ExecuteAsync( Guid userId, decimal salary);
}