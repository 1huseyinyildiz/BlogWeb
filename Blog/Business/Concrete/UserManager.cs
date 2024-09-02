using Business.Abstract;
using Core.Utilities.Hashing;
using Data.Absract;
using Data.Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        private readonly IAuthService _authService;

        public UserManager(IUserDal userDal, IAuthService authService)
        {
            _userDal = userDal;
            _authService = authService;
        }

        public void Add(RegisterDto autDto)
        {
            byte[] passwordHash, passwordSalt;

            HashingHelper.CreatePassword(autDto.Password, out passwordHash, out passwordSalt);

            User user = new User()
            {
                CreateTime = DateTime.Now,
                Email = autDto.Email,
                FullName = autDto.FullName,
                PasswordldHash = passwordHash,
                PasswordldSalt = passwordSalt,
                UserName = autDto.Email,
                UpdateTime = DateTime.Now,
                ImageUrl = ""
            };


            _userDal.CreateAsync(user);

        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userDal.GetAllAsync();
        }
    }
}
