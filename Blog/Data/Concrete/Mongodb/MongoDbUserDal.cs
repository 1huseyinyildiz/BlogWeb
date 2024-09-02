using Core.DataAccess;
using Data.Absract;
using Data.Concrete.Mongodb.Entity;
using Data.Entities.Concrete;
using Entities.Concrete;
using Entities.Dtos;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.Mongodb
{
    public class MongodbUserDal : MongodbRepositoryDal<User>, IUserDal
    {
        public MongodbUserDal(IMongoDatabase database) : base(database, "Users")
        {
        }
    }
}
