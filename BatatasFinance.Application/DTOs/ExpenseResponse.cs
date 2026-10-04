using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Application.DTOs;

public record ExpenseResponse
    (
    Guid Id ,
    string Description ,
    decimal Amount ,
    ExpenseCategory Category ,
    PaymentMethod PaymentMethod ,
    bool IsFixed ,
    Guid UserId ,
    Guid? CreditCardId, 
    DateTimeOffset CreatedAt
    );