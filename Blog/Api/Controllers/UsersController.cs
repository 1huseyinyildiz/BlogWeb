using Business.Abstract;
using Data.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return Ok("Kayıt işlemi başarıyla tamamlandı");
        }

        [HttpGet("get")]
        public IActionResult GetAll()
        {
            _userService.GetAll();
            return Ok("Kayıt işlemi başarıyla tamamlandı");
        }
    }
}
