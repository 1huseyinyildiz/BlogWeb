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
    public class MongoDbPostDal : MongodbRepositoryDal<User>, IUserDal
    {
        public MongoDbPostDal(IMongoDatabase database, string collectionName) : 
            base(database, collectionName)
        {
        }
    }
}
