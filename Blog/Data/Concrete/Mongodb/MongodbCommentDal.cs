using Data.Absract;
using Data.Concrete.EntityFramework;
using Data.Concrete.Mongodb.Entity;
using Entities.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.Mongodb
{
    public class MongodbCommentDal : MongodbRepositoryDal<Comment>, ICommentDal
    {
        public MongodbCommentDal(IMongoDatabase database, string collectionName) :
            base(database, collectionName)
        {
        }
    }
}
