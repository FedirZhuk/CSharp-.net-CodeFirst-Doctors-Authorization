using Cwiczenia9.Models;
using Cwiczenia9.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia9.Controllers;

[ApiController]
[Route("api/accounts")]
public class AccountsController : Controller
{
    private readonly IAccountDbService _accountDbService;

    public AccountsController(IAccountDbService accountDbService)
    {
        _accountDbService = accountDbService;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(_accountDbService.LoginUser(request));
    }

    [HttpPost("create-user")]
    public IActionResult CreateUser(LoginRequest request)
    {
        var hashedPassword = _accountDbService.CreateUser(request);
        return Ok(hashedPassword);
    }

    [HttpPost("api/refresh")]
    public IActionResult RefreshToken()
    {
        return Ok(_accountDbService.RefreshToken());
    }
}