namespace BatatasFinance.Application.DTOs;

public record RegisterPurchaseRequest
{
    public string Description { get; init; }
    public decimal Amount { get; init; }
}