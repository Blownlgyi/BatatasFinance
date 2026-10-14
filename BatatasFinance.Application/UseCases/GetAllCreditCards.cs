using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Entities;
using BatatasFinance.Domain.Repositories;

namespace BatatasFinance.Application.UseCases;

public class GetAllCreditCards(ICreditCardRepository repository) : IGetAllCreditCards
{
    public async Task<IEnumerable<CreditCardResponse?>> ExecuteAsync()
    {
        var creditCards = await repository.GetAllAsync();
        return creditCards.Select(c => new CreditCardResponse(
            c.Id,
            c.Name,
            c.CreditLimit,
            c.ClosingDay,
            c.DueDay,
            c.CreditFlag,
            c.CreateAt
        ));
    }
}