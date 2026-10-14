using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Application.DTOs;

public record RegisterExpenseRequest
{
    public string Description { get; init; }
    public decimal Amount { get; init; }
    public ExpenseCategory Category { get; init; }
    public bool IsFixed { get; init; }
    public Guid? CreditCardId { get; init; }
    public PaymentMethod PaymentMethod { get; init; }
}