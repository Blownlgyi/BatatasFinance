using BatatasFinance.Domain.Entities;

namespace BatatasFinance.Domain.Repositories;

public interface IIncomeRepository
{
    Task AddAsync(Income income);
    Task <IEnumerable<Income>> GetAllAsync();
}