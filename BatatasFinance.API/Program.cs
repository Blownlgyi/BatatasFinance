using BatatasFinance.Application.Repositories;
using BatatasFinance.Application.UseCases;
using BatatasFinance.Infrastructure.Data;
using BatatasFinance.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BatatasDbContext>(options =>
    options.UseInMemoryDatabase("BatatasDb"));


builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();
builder.Services.AddScoped<IRegisterPurchaseUseCase, RegisterPurchaseUseCase>();
builder.Services.AddScoped<IGetAllPurchasesUseCase, GetAllPurchasesUseCase>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();