namespace BatatasFinance.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    // public string Username { get; set; }
    // public string Password { get; set; }
    public string UserName { get; set; }
    public decimal Salary { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public User(string userName, decimal salary)
    {
        if (string.IsNullOrWhiteSpace(userName))
            throw new ArgumentException("Name is required");
        if (salary <= 0)
            throw new ArgumentException("Salary is more  than zero");
        Id = Guid.NewGuid();
        Salary = salary;
        CreatedAt = DateTimeOffset.Now;
        UserName = userName;
    }
    public void UpdateSalary(decimal newSalary)
    {
        if (newSalary <= 0)
            throw new ArgumentException("Salary is more  than zero");
        Salary = newSalary;
    }
}