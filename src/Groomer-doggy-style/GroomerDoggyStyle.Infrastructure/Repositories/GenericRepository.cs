﻿using System.Collections;
using System.Linq.Expressions;
using GroomerDoggyStyle.Domain.Interfaces;
using GroomerDoggyStyle.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GroomerDoggyStyle.Infrastructure.Repositories;

internal class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
{
    private readonly GroomerDoggyStyleDbContext _dbContext;
    private readonly DbSet<TEntity> _entities;

    public GenericRepository(GroomerDoggyStyleDbContext dbContext)
    {
        _dbContext = dbContext;
        _entities = _dbContext.Set<TEntity>();
    }

    public async Task<TEntity?> GetById(TKey id) => await _dbContext.Set<TEntity>().FindAsync(id);

    public async Task<IEnumerable<TEntity>> GetAll() => await _dbContext.Set<TEntity>().ToListAsync();

    public async Task<int> Add(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        var property = _dbContext.Entry(entity).Property("Id");
        return (int)(property.CurrentValue ?? throw new InvalidOperationException());
    }

    public async Task Update(TEntity entity)
    {
         _dbContext.Set<TEntity>().Update(entity);
         await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
    public async Task<TEntity?> GetNextRecordAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await _entities.Where(filter).FirstOrDefaultAsync();
    }
   
}