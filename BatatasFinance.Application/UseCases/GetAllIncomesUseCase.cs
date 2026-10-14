using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Repositories;

namespace BatatasFinance.Application.UseCases;

public class GetAllIncomesUseCase(IIncomeRepository repository) : IGetAllIncomesUseCase
{
    public async Task<IEnumerable<IncomeResponse>> ExecuteAsync()
    {
        var incomes = await repository.GetAllAsync();


        return incomes.Select(i => new IncomeResponse(
            i.Id,
            i.Description,
            i.Amount,
            i.IsRecurring,
            i.CreatedAt
        ));
    }
}