using Core.DataAccess;
using Data.Absract;
using Data.Concrete.Mongodb.Entity;
using Data.Entities.Concrete;
using Entities.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.Mongodb
{
    public class MongoDbUserDal : MongodbRepositoryDal<User>, IUserDal
    {
        public MongoDbUserDal(IMongoDatabase database, string collectionName) : base(database, collectionName)
        {
        }
    }
}
