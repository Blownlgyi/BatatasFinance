using BatatasFinance.Application.DTOs;

namespace BatatasFinance.Application.Interfaces;

public interface IGetCreditCardSummaryUseCase
{
    Task<CreditCardSummaryResponse> ExecuteAsync(
        Guid creditCardId,
        Guid userId );
}