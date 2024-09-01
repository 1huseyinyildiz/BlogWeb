using Data.Absract;
using Data.Concrete.Mongodb.Entity;
using Data.Entities.Concrete;
using Entities.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Concrete;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.Mongodb
{
    public class MongodbPostDal : MongodbRepositoryDal<Post>, IPostDal
    {
        public MongodbPostDal(IMongoDatabase database) : base(database, "Posts")
        {
        }
    }
}
