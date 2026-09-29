namespace BatatasFinance.Domain.Entities;

public class Purchase
{
    public Guid Id { get; private set; }
    public string Description { get; private set; }
    public decimal Amount { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Purchase(string description, decimal amount)
    {
        if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("Invalid description.");
        if (amount <= 0) throw new ArgumentException("Invalid amount.");
        
        Id = Guid.NewGuid();
        Description = description;
        Amount = amount;
        CreatedAt = DateTime.UtcNow;
    }
}