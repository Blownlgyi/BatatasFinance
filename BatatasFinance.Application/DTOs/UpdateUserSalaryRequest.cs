namespace BatatasFinance.Application.DTOs;

public record UpdateUserSalaryRequest
{
    public Guid UserId { get; set; }
    public  decimal Salary { get; set; }
}