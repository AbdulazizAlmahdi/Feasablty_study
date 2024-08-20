using Feasablty_study.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Feasablty_study.Domin.Interfaces
{
    public interface IBaseRepository<T> where T : class, IEntityBase, new()
    {
        
            Task<IEnumerable<T>> GetAllAsync(object id);
            Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
            Task<T> GetByIdAsync(int id);
            Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties);
            Task AddAsync(T entity);
            Task UpdateAsync(int id, T entity);
            Task DeleteAsync(int id);
            Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);



    }
}
