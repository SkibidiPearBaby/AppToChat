using AppToChat.Api.Controllers.Base;
using AppToChat.Infrastructure.Repository.Account;
using AppToChat.Shared.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppToChat.Api.Controllers;

public class AccountController : BaseController
{
    private readonly IUserService _userService;
    
    public AccountController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Register(RegisterDto loginDto)
    {
        var registerResult = await _userService.Register(loginDto);
        return registerResult.IsSuccess ? Ok() : BadRequest(registerResult.Errors.First().Message);
    }
    
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var loginResult = await _userService.Login(loginDto);
        return loginResult.IsSuccess ? Ok() : BadRequest(loginResult.Errors.First().Message);
    }
}