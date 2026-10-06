using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;

namespace BatatasFinance.Application.UseCases;

public class UpdateUserSalaryUseCase(IUserRepository repository) : IUpdateUserSalary
{
    public async Task<User?> ExecuteAsync(Guid userId, decimal salary)
    {
        var user = await repository.GetByIdAsync(userId);
        if (user == null)
            throw new ArgumentException("Invalid user");
        user.UpdateSalary(salary);
        var updateUser = await repository.UpdateAsync(user);
        return updateUser;
    }
}