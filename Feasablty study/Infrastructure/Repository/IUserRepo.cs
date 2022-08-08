using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Feasablty_study.Infrastructure.Repository
{
    public interface IUserRepo 
    {
        public string Error { get; set; }
        public int returntype { get; set; }
        Task<User> GetByUserNameAsync(string UserName);
        Task<IEnumerable<User>> GetAllAsync();
        Task<IEnumerable<User>> GetAllAsync(params Expression<Func<User, object>>[] includeProperties);
        Task<User> GetByIdAsync(string id);
        Task<User> GetByIdAsync(string id, params Expression<Func<User, object>>[] includeProperties);
        Task AddAsync(CreateUserViewModel entity);
        Task UpdateAsync(string id, EditUserViewModel entity);
        Task DeleteAsync(string id);



    }
}
