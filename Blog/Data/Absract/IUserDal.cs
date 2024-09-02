using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Data.Entities.Concrete;
using Entities.Dtos;

namespace Data.Absract
{
    public interface IUserDal : IEntityRepositoryBase<User>
    {
        
    }
}
