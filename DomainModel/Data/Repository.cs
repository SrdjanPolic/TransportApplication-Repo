using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Service.Data
{
    public class Repository<T> : BaseRepository<T>, IRepository<T> where T : class
    {
        public Repository(DbContext context) : base(context)
        {
        }

        public async void Add(T entity)
        {
           _dbSet.Add(entity);
        }

        public async void Add(params T[] entities)
        {
            _dbSet.AddRange(entities);
        }


        public async void Add(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }


        public async void Delete(T entity)
        {
            var existing = _dbSet.Find(entity);
            if (existing != null) _dbSet.Remove(existing);
        }


        public async void Delete(object id)
        {
            var typeInfo = typeof(T).GetTypeInfo();
            var key = _dbContext.Model.FindEntityType(typeInfo).FindPrimaryKey().Properties.FirstOrDefault();
            var property = typeInfo.GetProperty(key?.Name);
            if (property != null)
            {
                var entity = Activator.CreateInstance<T>();
                property.SetValue(entity, id);
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
            else
            {
                var entity = _dbSet.Find(id);
                if (entity != null) Delete(entity);
            }
        }

        public async void Delete(params T[] entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public async void Delete(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }


        [Obsolete("Method is replaced by GetList")]
        public async Task<IEnumerable<T>> Get()
        {
            return await (from n in _dbSet select n).ToListAsync();
        }

        [Obsolete("Method is replaced by GetList")]
        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate)
        {
            return await (from n in _dbSet.Where(predicate) select n).ToListAsync();
        }

        public async void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public async void Update(params T[] entities)
        {
            _dbSet.UpdateRange(entities);
        }


        public async void Update(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public async void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}