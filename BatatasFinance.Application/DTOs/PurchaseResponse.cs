namespace BatatasFinance.Application.DTOs;

public record PurchaseResponse(Guid Id, string Description, decimal Amount, DateTime CreatedAt);