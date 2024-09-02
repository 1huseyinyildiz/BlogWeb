using Data.Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        void Register(RegisterDto registerDto);

        void Login(LoginAutDto loginAutDto);

        User GetByEmail(string email);
    }
}
