﻿using dotnet_rpg.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController: ControllerBase
{
    private readonly IAuthRepository _authRepo;

    public AuthController(IAuthRepository authRepo)
    {
        _authRepo = authRepo;
    }

    [HttpPost("Register")]
    public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
    {
        var response = await _authRepo.Register(
            new User { Username = request.Username }, request.Password
        );
        if (!response.Success)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }
}
