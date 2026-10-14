using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Application.UseCases;

public class RegisterExpensesUseCase(IExpenseRepository repository) : IRegisterExpenseUseCase
{
    public async Task ExecuteAsync(
        string description,
        decimal amount,
        ExpenseCategory category,
        PaymentMethod paymentMethod,
        bool isFixed,
        Guid? creditCardId
        )
    {
        var purchase = new Expense(description, amount , category, paymentMethod, isFixed , creditCardId);
        await repository.AddAsync(purchase);

    }


}