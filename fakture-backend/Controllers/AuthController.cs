﻿using fakture_backend.Dtos;
using fakture_backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace fakture_backend.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase

    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegistrationDto request)
        {
            ServiceResponse<int> response = await _authRepo.Register(
                new User
                {
                    Name = request.Name,
                    Surname = request.Surname,
                    Telephone = request.Telephone,
                    Email = request.Email
                },
                request.Password
                );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            ServiceResponse<string> response = await _authRepo.Login(request.Email, request.Password);
            if(!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
