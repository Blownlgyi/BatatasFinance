using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Application.DTOs;

public record CreditCardResponse
(
    Guid Id,
    string Name,
    decimal CreditLimit,
    int  ClosingDay,
    int  DueDay,
    CreditFlag CreditFlag,
    DateTimeOffset CreatedAt
    
);