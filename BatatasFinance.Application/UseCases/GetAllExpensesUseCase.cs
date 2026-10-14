using BatatasFinance.Application.DTOs;

namespace BatatasFinance.Application.UseCases;

using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;
using BatatasFinance.Application.Interfaces;
public class GetAllExpensesUseCase(IExpenseRepository repository) : IGetAllPurchasesUseCase
{
    public async Task<IEnumerable<ExpenseResponse?>> ExecuteAsync()
    {
        var expenses = await repository.GetAllAsync();
        return expenses.Select(p => new ExpenseResponse(
            p.Id,
            p.Description,
            p.Amount,
            p.Category,
            p.PaymentMethod,
            p.IsFixed,
            p.UserId,
            p.CreditCardId,
            p.Installments,
            p.CreatedAt
        ));
    }
}