using MedicalWarehouse_Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MedicalWarehouse_API.Controllers;

[Controller]
[Route("api/auth")]
public class AuthController : Controller 
{ 
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    [Route("seed-roles")]
    public async Task<IActionResult> SeedRoles()
    {
        var seedRole = await _authService.SeedRoles();
        return Ok(seedRole);
    }
};

