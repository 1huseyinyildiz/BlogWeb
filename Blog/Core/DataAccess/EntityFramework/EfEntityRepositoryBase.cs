using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.DataAccess;
using Microsoft.EntityFrameworkCore;

public class EfEntityRepositoryBase<TEntity, Tcontext> : IEntityRepositoryBase<TEntity>
    where TEntity : class,new()
    where Tcontext:DbContext, new()
{
    private readonly Tcontext _context;
    private readonly DbSet<TEntity> _dbSet;

    public EfEntityRepositoryBase(Tcontext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(string id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task CreateAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(string id, TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(string id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        return _dbSet.SingleOrDefault(filter);
    }
}
