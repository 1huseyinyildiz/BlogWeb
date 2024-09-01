using Data.Absract;
using Data.Concrete.EntityFramework.Context;
using Data.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, BlogDbContext>, IUserDal
    {
        public EfUserDal(BlogDbContext context) : base(context)
        {
        }
    }
}
