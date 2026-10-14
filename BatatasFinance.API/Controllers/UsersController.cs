using BatatasFinance.Application.DTOs;
using BatatasFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BatatasFinance.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UsersController (IRegisterUserCase registerUserCase, IUpdateUserSalary updateUserSalary) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterUserRequest request)
    {
        try
        {
            var user = await registerUserCase.ExecuteAsync(request.UserName, request.Salary);
            return Created("Perfil Criado", new {id =user , name = request.UserName } );
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("updateSalary/{userId}")]
    public async Task<IActionResult> UpdateSalary([FromRoute] Guid userId, [FromBody] UpdateUserSalaryRequest request)
    {
        try
        {
            var update = await updateUserSalary.ExecuteAsync(userId, request.Salary);
            return Ok(update);
        }
        catch (Exception e)
        {
            BadRequest();
        }

        return NoContent();
    }
}