using Core.DataAccess;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

public class MongodbRepositoryDal<TEntity> : IEntityRepositoryBase<TEntity> where TEntity : class
{
    private readonly IMongoCollection<TEntity> _collection;

    public MongodbRepositoryDal(IMongoDatabase database, string collectionName)
    {
        _collection = database.GetCollection<TEntity>(collectionName);
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _collection.Find(_ => true).ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(string id)
    {
        return await _collection.Find(Builders<TEntity>.Filter.Eq("Id", id)).FirstOrDefaultAsync();
    }

    public async Task CreateAsync(TEntity entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task UpdateAsync(string id, TEntity entity)
    {
        await _collection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("Id", id), entity);
    }

    public async Task DeleteAsync(string id)
    {
        await _collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("Id", id));
    }
}
