namespace BatatasFinance.Application.DTOs;

public record CreditCardSummaryResponse
{
    public Guid UserId { get; init; }
    public Guid CreditCardId { get; init; }
    public decimal TotalLimit { get; init; }
    public decimal AvailableLimit { get; init; }
    public decimal CurrentInvoiceAmount { get; init; }
};