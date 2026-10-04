namespace BatatasFinance.Domain.Entities;

public class Income
{
    public Guid Id { get; private set; }
    public string Description  { get; private set; }
    public decimal Amount { get; private set; }
    public bool IsRecurring { get; private set; }
    public DateTime CreatedAt { get; private set; }


    public Income(string description, decimal amount, bool isRecurring)
    {
        if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException("Invalid description.");
        if (amount <= 0) throw new ArgumentException("Invalid amount.");
        
        Id = Guid.NewGuid();
        Description = description;
        Amount = amount;
        IsRecurring = isRecurring;
        CreatedAt = DateTime.UtcNow;
    }
}