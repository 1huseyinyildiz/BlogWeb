using Business.Abstract;
using Data.Absract;
using Data.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.CreateAsync(user);

        }

        public void GetAll()
        {
            _userDal.GetAllAsync();
        }
    }
}
