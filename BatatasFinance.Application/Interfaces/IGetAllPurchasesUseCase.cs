using BatatasFinance.Application.DTOs;
using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Application.Interfaces;

public interface IGetAllPurchasesUseCase
{
    Task<IEnumerable<ExpenseResponse?>> ExecuteAsync();
}