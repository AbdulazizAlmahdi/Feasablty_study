using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Feasablty_study.Infrastructure.Repository
{
    public class UserRepo :  IUserRepo
    {
        private readonly AppDbContext _context;
        public UserRepo(AppDbContext context)
        {
            _context = context;
        }
        

        public async Task AddAsync(User entity)
        {
            await _context.Set<User>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var entity = await _context.Set<User>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<User>(entity);
            entityEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync() => await _context.Set<User>().ToListAsync();

        public async Task<IEnumerable<User>> GetAllAsync(params Expression<Func<User, object>>[] includeProperties)
        {
            IQueryable<User> query = _context.Set<User>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();

        }

        public async Task<User> GetByIdAsync(string id) => await _context.Set<User>().FirstOrDefaultAsync(n => n.Id == id);

        public async Task<User> GetByIdAsync(string id, params Expression<Func<User, object>>[] includeProperties)
        {
            IQueryable<User> query = _context.Set<User>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task UpdateAsync(string id, User entity)
        {
            EntityEntry entityEntry = _context.Entry<User>(entity);
            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
        public async Task<User> GetByUserNameAsync(string UserName) => await _context.Users.FirstOrDefaultAsync(x => x.UserName == UserName);
        }


}
