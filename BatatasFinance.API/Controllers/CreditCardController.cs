using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace BatatasFinance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CreditCardController (IRegisterCreditCardUseCase registerCreditCardUseCase, IGetAllCreditCards getAllCreditCards): ControllerBase
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
}