

namespace BatatasFinance.Infrastructure;

using BatatasFinance.Domain.Repositories;
using BatatasFinance.Infrastructure.Data;
using BatatasFinance.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<BatatasDbContext>(options =>
            options.UseInMemoryDatabase("BatatasDb"));
        services.AddScoped<IExpenseRepository, ExpenseRepository>();
        services.AddScoped<IIncomeRepository, IncomeRepository>();
        services.AddScoped<ICreditCardRepository, CreditCardRepository>();
        return services;
    }
}