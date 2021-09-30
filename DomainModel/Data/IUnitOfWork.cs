using System;
using Microsoft.EntityFrameworkCore;
using Repository.ModelBase;

namespace Service.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity;
        //IRepositoryAsync<TEntity> GetRepositoryAsync<TEntity>() where TEntity : class;
        IRepositoryReadOnly<TEntity> GetReadOnlyRepository<TEntity>() where TEntity : Entity;

        int SaveChanges();
    }

    public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        TContext Context { get; }
    }
}