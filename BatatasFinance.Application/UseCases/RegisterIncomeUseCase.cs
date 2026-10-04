using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace BatatasFinance.Application.UseCases;

public class RegisterIncomeUseCase(IIncomeRepository repository,  ILogger<RegisterIncomeUseCase> logger) : IRegisterIncomeUseCase
{
    public async Task ExecuteAsync(string description, decimal amount, bool isRecurring)
    {
            logger.LogInformation("Searching Income");
            var income = new Income(description, amount, isRecurring);
            await repository.AddAsync(income);
            logger.LogInformation("Returning Income");
    }
}