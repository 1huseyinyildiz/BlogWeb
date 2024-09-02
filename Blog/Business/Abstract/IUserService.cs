using Data.Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(RegisterDto autDto);

        Task<List<User>> GetAllUsersAsync();
    }
}
