using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace BatatasFinance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class 
    CreditCardController (IRegisterCreditCardUseCase registerCreditCardUseCase, IGetAllCreditCards getAllCreditCards,IGetCreditCardSummaryUseCase getCreditCardSummaryUseCase,IGetCreditCardExpenses getCreditCardExpenses): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> RegisterCreditCard([FromBody] RegisterCreditCardRequest request)
    {
        try
        {
            await registerCreditCardUseCase.ExecuteAsync(
                request.Name,
                request.CreditLimit,
                request.ClosingDay,
                request.DueDay,
                request.UserId,
                request.CreditFlag);
            return Created();
        }
        catch (ArgumentException e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetCreditCards()
    {
        var response = await getAllCreditCards.ExecuteAsync();
        if (!response.Any())
        {
            return NoContent();
        }
        return Ok(response);
    }

    [HttpGet("{creditCardId}/summary/{userId}")]
    public async Task<IActionResult> GetCreditCardSummary(Guid creditCardId, Guid userId)
    {
        try
        {
            var summary = await getCreditCardSummaryUseCase.ExecuteAsync(creditCardId, userId);
            return Ok(summary);
        }
        catch (ArgumentException ex)
        {
            return NotFound(new { error = ex.Message });
        }
    }
    [HttpGet("expenses/{creditCardId}/summary/{userId}")]
    public async Task<IActionResult> Get([FromRoute] Guid creditCardId, [FromRoute] Guid userId)
    {
        try
        {
            var expenses = await getCreditCardExpenses.GetExpensesCardAsync(creditCardId, userId);
            return  Ok(expenses);
        }
        catch(Exception e)
        {
            return BadRequest();
        }
    }
}