using Microsoft.Extensions.DependencyInjection;
using BatatasFinance.Application.Interfaces;
using BatatasFinance.Application.UseCases;

namespace BatatasFinance.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IRegisterExpenseUseCase, RegisterExpensesUseCase>();
        services.AddScoped<IGetAllPurchasesUseCase, GetAllExpensesUseCase>();
        services.AddScoped<IRegisterIncomeUseCase, RegisterIncomeUseCase>();
        services.AddScoped<IGetAllIncomesUseCase, GetAllIncomesUseCase>();
        services.AddScoped<IRegisterCreditCardUseCase, RegisterCreditCardUseCase>();
        services.AddScoped<IGetAllCreditCards, GetAllCreditCards>();
        services.AddScoped<IRegisterUserCase, RegisterUserCase>();
        
        return services;
    }
}