namespace BatatasFinance.Application.DTOs;

public record IncomeResponse(Guid Id, string Description, decimal Amount, bool IsRecurring, DateTime CreatedAt);