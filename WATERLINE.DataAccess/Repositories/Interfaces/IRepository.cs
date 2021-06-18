﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WATERLINE.Entities.Base;

namespace WATERLINE.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T FindByCondition(Expression<Func<T, bool>> predicate);
        T FindByConditionWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        public List<T> FindAllByCondition(Expression<Func<T, bool>> predicate);
        public IQueryable<T> FindAllWithIncludes(params Expression<Func<T, object>>[] includes);
        public IQueryable<T> FindAllByConditionWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        List<T> GetAll();
        Task<T> InsertAsync(string UserId, T entity);
        Task UpdateAsync(string UserId, T oldEntity, T entity);
        Task DeleteAsync(string UserId, T entity);
    }
}
