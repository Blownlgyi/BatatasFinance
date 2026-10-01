namespace BatatasFinance.Application.DTOs;

public record RegisterIncomeRequest(string Description, decimal Amount, bool IsRecurring);