using BatatasFinance.Application.DTOs;

namespace BatatasFinance.Application.Interfaces;

public interface IGetAllIncomesUseCase
{
    Task<IEnumerable<IncomeResponse>> ExecuteAsync();
}