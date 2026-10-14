using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Domain.Entities;

public class Expense
{
    public Guid Id { get; init; }
    public string Description { get; private set; }
    public decimal Amount { get; private set; }
    public ExpenseCategory Category { get; init; }
    public PaymentMethod PaymentMethod { get; init; }
    public bool IsFixed { get; init; }
    public Guid? CreditCardId { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public Expense(
        string description,
        decimal amount,
        ExpenseCategory category,
        PaymentMethod paymentMethod,
        bool isFixed,
        Guid? creditCardId
        )
    {
        if (string.IsNullOrWhiteSpace(description)) 
            throw new ArgumentException("Invalid description.");
        if (amount <= 0) 
            throw new ArgumentException("Invalid amount.");
        if (paymentMethod == PaymentMethod.CreditCard && creditCardId == null)
            throw new ArgumentException("Invalid credit card id.");
        Id = Guid.NewGuid();
        Description = description;
        Amount = amount;
        Category = category;
        PaymentMethod = paymentMethod;
        IsFixed = isFixed;
        CreditCardId = creditCardId;
        CreatedAt = DateTime.UtcNow;
    }
}