using Microsoft.EntityFrameworkCore;
using Service.Data;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service
{
    public class UnitOfWork<TContext> : IUnitOfWork, IUnitOfWork<TContext>
        where TContext : DbContext, IDisposable
    {
        private Dictionary<Type, object> _repositories;

        public TContext Context { get; }

        public UnitOfWork(TContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public int Commit()
        {
            return Context.SaveChanges();
        }

      

        public void Dispose()
        {
            Context?.Dispose();
        }

        public IRepository<TEntity> IUnitOfWork.GetRepository<TEntity>()
        {
            if (_repositories == null) _repositories = new Dictionary<Type, object>();

            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type)) _repositories[type] = new Repository<TEntity>(Context);
            return (IRepository<TEntity>)_repositories[type];
        }
    }
}
