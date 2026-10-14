using BatatasFinance.Application.DTOs;
using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Application.Interfaces;

public interface IGetCreditCardExpenses
{
    Task<IEnumerable<CreditCardSummaryExpensesResponse?>> GetExpensesCardAsync(Guid creditCardId, Guid userId);
}