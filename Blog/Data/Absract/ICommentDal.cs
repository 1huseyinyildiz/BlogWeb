﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Absract
{
    public interface ICommentDal:IEntityRepositoryBase<Comment>
    {
    }
}
