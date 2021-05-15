using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryLibrary
{
    public class GenericUnitOfWork : IDisposable
    {
        DbContext context;
        public GenericUnitOfWork(DbContext context)
        {
            this.context = context;
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        public IGenericRepository<T> Repository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)) == true)
            {
                return repositories[typeof(T)] as IGenericRepository<T>;
            }
            IGenericRepository<T> repo = new EFGenericRepository<T>(context);
            repositories.Add(typeof(T), repo);
            return repo;
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
