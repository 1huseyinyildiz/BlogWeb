using Core.DataAccess;
using Data.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Absract
{
    public interface IPostDal : IEntityRepositoryBase<Post>
    {
    }
}
