using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;

namespace BatatasFinance.Application.UseCases;

public class RegisterIncomeUseCase(IIncomeRepository repository) : IRegisterIncomeUseCase
{
    public async Task ExecuteAsync(string description, decimal amount, bool isRecurring)
    {
        try
        {
            var income = new Income(description, amount, isRecurring);
            await repository.AddAsync(income);
        }
        catch (Exception ex)
        {
            
        }
    }
}