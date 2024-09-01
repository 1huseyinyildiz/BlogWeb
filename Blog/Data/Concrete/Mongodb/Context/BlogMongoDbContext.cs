using Data.Concrete.Mongodb.Entity;
using Entities.Concrete;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.Mongodb.Context
{
    public class BlogMongoDbContext
    {
        public IMongoDatabase Database { get; }

        public BlogMongoDbContext(IOptions<MongoDBSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            Database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<Comment> Comments => Database.GetCollection<Comment>("Comments");

        public IMongoCollection<Post> Posts => Database.GetCollection<Post>("Posts");

        public IMongoCollection<Post> Users => Database.GetCollection<Post>("Users");

    }
}
