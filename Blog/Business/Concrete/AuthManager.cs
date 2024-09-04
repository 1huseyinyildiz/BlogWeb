using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Hashing;
using Core.Utilities.Result;
using Core.Utilities.Result.Absract;
using Core.Utilities.Result.Concrete;
using Data.CrossCuttingConcerns.Validation;
using Data.Entities.Concrete;
using Entities.Dtos;
using FluentValidation;
using FluentValidation.Results;
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

        public string Login(LoginAutDto loginAutDto)
        {
            var user = _authService.GetByEmail(loginAutDto.Email);
            var result = HashingHelper.VerifyPasswordHas(loginAutDto.Password, user.PasswordldHash, user.PasswordldSalt);

            return result == false ? "Kullanıcı girişi başarısız" : "Kullanıcı girişi başarılı";
        }

        public IResult Register(RegisterDto registerDto)
        {
            AutValidator authValidator = new AutValidator();
            ValidationTool.Validate(authValidator, registerDto);

            if (CheckIfEmailExists(registerDto.Email))
            {
                _userService.Add(registerDto);
                return new SuccessResult("işlem başarılıdır.");

            }
            else
            {
                return new ErrorResult("işlem başarısızdır.");

            }
        }

        bool CheckIfEmailExists(string email)
        {
            var list = _userService.GetByEmail(email);
            return list != null ? false : true;
        }
    }
}
