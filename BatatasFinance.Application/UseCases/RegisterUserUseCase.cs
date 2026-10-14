using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace BatatasFinance.Application.UseCases;

public class RegisterUserCase (IUserRepository repository , ILogger<RegisterUserCase> logger) : IRegisterUserCase
{
    public async Task<Guid> ExecuteAsync(
        string username,
        decimal salary
    )
    {
        logger.LogInformation($"Registering user {username}");
        var user = new User(username, salary);
        await repository.AddAsync(user);
        logger.LogInformation($"User {username} registered successfully");
        return user.Id;
    }
}