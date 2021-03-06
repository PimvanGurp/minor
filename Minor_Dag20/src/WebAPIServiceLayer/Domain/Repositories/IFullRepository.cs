﻿namespace WebAPIServiceLayer.Domain.Repositories
{
    public interface IFullRepository<TEntity, TKey> : IRepository<TEntity>
    {
        TEntity Find(TKey key);
    }
}