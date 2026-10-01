

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
        services.AddScoped<IPurchaseRepository, PurchaseRepository>();
        services.AddScoped<IIncomeRepository, IncomeRepository>();
        return services;
    }
}