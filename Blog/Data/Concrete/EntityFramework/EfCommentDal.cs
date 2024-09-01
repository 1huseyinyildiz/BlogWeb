using Core.DataAccess;
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
    public class EfCommentDal : EfEntityRepositoryBase<Comment, BlogDbContext>, ICommentDal
    {
        public EfCommentDal(BlogDbContext context) : base(context)
        {
        }
    }
}
