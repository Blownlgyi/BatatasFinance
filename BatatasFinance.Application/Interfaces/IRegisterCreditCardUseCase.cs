using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Application.Interfaces;

public interface IRegisterCreditCardUseCase
{
    Task ExecuteAsync(
        string name,
        decimal creditLimit,
        int closingDay,
        int dueDay,
        CreditFlag creditFlag
       );
}