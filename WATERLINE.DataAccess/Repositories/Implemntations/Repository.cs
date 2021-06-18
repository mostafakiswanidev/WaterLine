using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WATERLINE.Context;
using WATERLINE.DataAccess.Repositories.Interfaces;
using WATERLINE.Entities.Base;

namespace WATERLINE.DataAccess.Repositories.Implemntations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DataContext context;
        private DbSet<T> entities;
        public Repository(DataContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task DeleteAsync(string UserId, T oldEntity)
        {
            var entity = oldEntity;
            entity.Deleted = true;
            context.Entry(oldEntity).CurrentValues.SetValues(entity);
            await context.SaveChangesAsync(UserId);
        }

        public List<T> FindAllByCondition(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).ToList();
        }

        public IQueryable<T> FindAllByConditionWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = entities.Where(predicate);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public IQueryable<T> FindAllWithIncludes(params Expression<Func<T, object>>[] includes)
        {
            var query = entities.AsQueryable();
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public T FindByCondition(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().SingleOrDefault(predicate);
        }

        public T FindByConditionWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = entities.Where(predicate);
            var result = includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            if (!result.Any())
                return null;

            return result.First();
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public async Task<T> InsertAsync(string UserId, T entity)
        {
            entities.Add(entity);
            await context.SaveChangesAsync(UserId);

            return entity;
        }

        public async Task UpdateAsync(string UserId, T oldEntity, T entity)
        {
            context.Entry(oldEntity).CurrentValues.SetValues(entity);
            await context.SaveChangesAsync(UserId);
        }

    }
}
