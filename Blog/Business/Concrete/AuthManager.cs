using Business.Abstract;
using Data.Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;

        private readonly IAuthService _authService;


        public AuthManager(IUserService userService, IAuthService authService)  
        {
            _authService = authService;
        }

        public User GetByEmail(string email)
        {
            return _authService.GetByEmail(email);
        }

        public void Login(LoginAutDto loginDto)
        {
            //login işlemleri
        }

        public void Register(RegisterDto autDto)
        {
            _userService.Add(autDto);
        }
    }
}
