using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BatatasFinance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpensesController(IRegisterExpenseUseCase registerExpenseUseCase, IGetAllPurchasesUseCase getAllPurchasesUseCase) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterExpenseRequest request)
    {
        try
        {
            await registerExpenseUseCase.ExecuteAsync(request.Description, request.Amount, request.Category,request.PaymentMethod, request.IsFixed, request.UserId, request.CreditCardId, request.Installments);
            return Created();
        }
        catch(Exception e)
        {
            return BadRequest(new { message = e.Message });
        } 
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await getAllPurchasesUseCase.ExecuteAsync();
        if (!response.Any())
        {
            return NoContent();
        }
        return Ok(response);
    }

    
}