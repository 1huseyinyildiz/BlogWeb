using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDto authDto)
        {
            _authService.Register(authDto);

            return Ok("Register Successfull");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginAutDto loginAutDto)
        {
            _authService.Login(loginAutDto);

            return Ok("Login Successfull");
        }
    }
}
