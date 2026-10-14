using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Application.DTOs;

public record CreditCardResponse
(
    Guid Id,
    string Name,
    decimal CreditLimit,
    int  ClosingDay,
    int  DueDay,
    Guid UserId,
    CreditFlag CreditFlag,
    DateTimeOffset CreatedAt
    
);