using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Repositories;

namespace BatatasFinance.Application.UseCases;

public class GetCreditCardExpenses (IExpenseRepository repository) : IGetCreditCardExpenses
{
    public async Task<IEnumerable<CreditCardSummaryExpensesResponse?>> GetExpensesCardAsync(Guid creditCardId, Guid userId)
    {
        var expenses = await repository.GetExpensesCardAsync(creditCardId, userId);
        return expenses.Select(e => new CreditCardSummaryExpensesResponse( 
            e.Id,
            e.Description,
            e.Amount,
            e.Category,
            e.PaymentMethod,
            e.IsFixed,
            e.UserId,
            e.CreditCardId,
            e.Installments,
            e.CreatedAt));
    }
}