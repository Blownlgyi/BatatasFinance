using System.ComponentModel.DataAnnotations;

namespace BatatasFinance.Application.DTOs;

public record RegisterIncomeRequest
{
    [Required]
    public string Description { get; init; }
    [Required]
    public decimal Amount{ get; init; }
    [Required]
    public bool IsRecurring { get; init; }
};