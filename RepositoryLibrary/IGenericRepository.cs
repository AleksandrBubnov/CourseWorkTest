using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RepositoryLibrary
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> GetDbSet(); // tmp
        void Add(TEntity item);
        TEntity FindById(object id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}
