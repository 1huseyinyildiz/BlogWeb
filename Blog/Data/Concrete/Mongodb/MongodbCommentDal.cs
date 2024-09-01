using Data.Absract;
using Entities.Concrete;
using MongoDB.Driver;

namespace Data.Concrete.Mongodb
{
    public class MongodbCommentDal : MongodbRepositoryDal<Comment>, ICommentDal
    {
        public MongodbCommentDal(IMongoDatabase database) : base(database, "Comments")
        {
        }
    }
}
