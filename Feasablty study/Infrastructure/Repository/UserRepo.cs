using Feasablty_study.Domin.Entites;
using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _context;
        public string Error { get; set; }
        public int returntype { get; set; }
        public UserRepo(AppDbContext context, UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        

        public async Task AddAsync(CreateUserViewModel entity)
        {
            var newUser=new User();
            if (entity.Status)
            {
                 newUser = new User()
                {
                    Name = entity.Name,
                    Email = entity.Email,
                    PhoneNumber = entity.PhoneNumber,
                    Status = entity.Status,
                    UserName = entity.UserName,
                    EmailConfirmed = true,
                
                };
            }
            else
            {
                 newUser = new User()
                {
                    Name = entity.Name,
                    Email = entity.Email,
                    PhoneNumber = entity.PhoneNumber,
                    Status = entity.Status,
                    UserName = entity.UserName,
                    EmailConfirmed = false,

                };
            }
            
            var user = await _userManager.FindByEmailAsync(entity.Email);
            if (user != null)
            {
                returntype = 1;
                Error = "المستخدم موجود مسبقا بهذا الايميل";
                return;
            }

            var newUserResponse = await _userManager.CreateAsync(newUser, entity.Password);

            if (newUserResponse.Succeeded)
            {
                if (entity.userRoles == 1)
                {
                await _userManager.AddToRoleAsync(newUser, UserRoles.Admin);

                }
                else if (entity.userRoles == 2)
                {
                    await _userManager.AddToRoleAsync(newUser, UserRoles.User);
                }
            }
            else
            {
                returntype = 2;
                Error = "كلمة السر يجب ان تكون ارقام و حروف و رموز";
                return;
            }


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
