using Data.Absract;
using Data.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework
{
    public class EfPostDal : EfEntityRepositoryBase<Post, BlogDbContext>, IPostDal
    {
        public EfPostDal(BlogDbContext context) : base(context)
        {
        }
    }
}
