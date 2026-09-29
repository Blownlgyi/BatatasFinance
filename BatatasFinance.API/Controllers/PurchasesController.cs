using BatatasFinance.API.DTOs;
using BatatasFinance.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace BatatasFinance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PurchasesController : ControllerBase
{
    private readonly IRegisterPurchaseUseCase _registerPurchaseUseCase;
    private readonly IGetAllPurchasesUseCase _getAllUseCase;
    
    public PurchasesController(IRegisterPurchaseUseCase registerPurchaseUseCase, IGetAllPurchasesUseCase getAllUseCase)
    {
        _registerPurchaseUseCase = registerPurchaseUseCase;
        _getAllUseCase =getAllUseCase;
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterPurchaseRequest request)
    {
        await _registerPurchaseUseCase.ExecuteAsync(request.Description, request.Amount);
        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var purchases = await _getAllUseCase.ExecuteAsync();
        
        var response = purchases.Select(p => new PurchaseResponse(
            p.Id, 
            p.Description, 
            p.Amount, 
            p.CreatedAt
        ));

        return Ok(response);
    }
}