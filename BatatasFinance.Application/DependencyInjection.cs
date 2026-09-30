using Microsoft.Extensions.DependencyInjection;
using BatatasFinance.Application.Interfaces;
using BatatasFinance.Application.UseCases;

namespace BatatasFinance.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IRegisterPurchaseUseCase, RegisterPurchaseUseCase>();
        services.AddScoped<IGetAllPurchasesUseCase, GetAllPurchasesUseCase>();
        return services;
    }
}