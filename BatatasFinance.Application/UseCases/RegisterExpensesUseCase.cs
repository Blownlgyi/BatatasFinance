using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Enums;
using Microsoft.Extensions.Logging;

namespace BatatasFinance.Application.UseCases;

public class RegisterExpensesUseCase(IExpenseRepository repository, ILogger<RegisterExpensesUseCase> logger) : IRegisterExpenseUseCase
{
    public async Task ExecuteAsync(
        string description,
        decimal amount,
        ExpenseCategory category,
        PaymentMethod paymentMethod,
        bool isFixed,
        Guid  userId,
        Guid? creditCardId,
        int installments
        )
    {
        logger.LogInformation($"Register expense {description}");
        var purchase = new Expense(description, amount , category, paymentMethod, isFixed, userId , creditCardId, installments);
        await repository.AddAsync(purchase);
        logger.LogInformation($"Expenses register sucess {description}");

    }


}