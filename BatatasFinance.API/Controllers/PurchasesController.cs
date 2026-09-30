using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BatatasFinance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PurchasesController (IRegisterPurchaseUseCase registerPurchaseUseCase, IGetAllPurchasesUseCase getAllPurchasesUseCase) : ControllerBase
{
    
    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterPurchaseRequest request)
    {
        await registerPurchaseUseCase.ExecuteAsync(request.Description, request.Amount);
        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
       var response  = await getAllPurchasesUseCase.ExecuteAsync();
       if (response == null || !response.Any())
       {
           return NotFound();
       }
       return Ok(response);
    }
}