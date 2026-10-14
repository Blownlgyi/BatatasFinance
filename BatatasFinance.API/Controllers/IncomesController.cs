using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using BatatasFinance.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BatatasFinance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IncomesController(IRegisterIncomeUseCase registeUseCase, IGetAllIncomesUseCase getAllIncomesUseCase) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterIncomeRequest request)
    {
        await registeUseCase.ExecuteAsync(request.Description, request.Amount, request.IsRecurring);
        return Created();
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await getAllIncomesUseCase.ExecuteAsync();
        if (response is null || !response.Any())
        {
            return NotFound(new { message = "No Incomes found" });
        }
        return Ok(response);
    }
}