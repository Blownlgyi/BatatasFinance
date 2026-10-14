using BatatasFinance.Application.DTOs;

namespace BatatasFinance.Application.Interfaces;

public interface IGetAllCreditCards
{
    Task <IEnumerable<CreditCardResponse>> ExecuteAsync();
}