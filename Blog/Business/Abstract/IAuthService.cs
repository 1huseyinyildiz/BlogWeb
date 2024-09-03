using Core.Utilities.Result;
using Core.Utilities.Result.Absract;
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
        IResult Register(RegisterDto registerDto);

        string Login(LoginAutDto loginAutDto);

        User GetByEmail(string email);
    }
}
