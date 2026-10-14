using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Application.Interfaces;

public interface IRegisterExpenseUseCase
{
    Task ExecuteAsync(
        string description,
        decimal amount,
        ExpenseCategory category,
        PaymentMethod  paymentMethod,
        bool isFixed,
        Guid userId,
        Guid? creditCardId
         );
}