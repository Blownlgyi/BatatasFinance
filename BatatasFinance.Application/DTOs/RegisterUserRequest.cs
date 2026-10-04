namespace BatatasFinance.Application.DTOs;

public record RegisterUserRequest
{
    public required string UserName { get; init; }
    public decimal Salary { get; init; }
};