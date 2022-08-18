using Feasablty_study.Domin.Entites;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Feasablty_study.Infrastructure.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _context;
        public string Error { get; set; }
        public int returntype { get; set; }
        public UserRepo(AppDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public async Task AddAsync(CreateUserViewModel entity,string CurrentUserLoginId)
        {
            var currentuser = _userManager.Users.First(u => u.Id == CurrentUserLoginId);

            var newUser = new User()
            {
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
                Status = entity.Status,
                UserName = entity.UserName,
                Name = entity.Name,
                regionId = currentuser.regionId,
                EmailConfirmed = entity.Status,
                roleId = 2,

                };
            
            

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

                    await _userManager.AddToRoleAsync(newUser, UserRoles.User);
            
                
                await _userManager.AddPasswordAsync(newUser, entity.Password);



            }
            
            else
            {
                returntype = 2;

                Error = "كلمة السر يجب ان تكون ارقام و حروف و رموز";
                return;
            }


        }public async Task AddAsync(CreateUserViewModel entity)
        {

            var newUser = new User()
            {
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
                Status = entity.Status,
                UserName = entity.UserName,
                Name = entity.Name,
                regionId = entity.RegionId,
                EmailConfirmed = entity.Status,
                roleId = entity.userRoles,

                };
            
            

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
                else if (entity.userRoles == 3)
                {
                    
                    await _userManager.AddToRoleAsync(newUser, UserRoles.Employee);
                }
                await _userManager.AddPasswordAsync(newUser, entity.Password);



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
            var DeletedUser = await _userManager.FindByIdAsync(id);
            var roleId = await _userManager.GetRolesAsync(DeletedUser);
            if ( DeletedUser==null)
            {
                return;
            }
            await _userManager.RemoveFromRolesAsync(DeletedUser, roleId);
            await _userManager.DeleteAsync(DeletedUser);
           // await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {

            return await _context.Set<User>().ToListAsync();
        }
        

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
        public async Task<User> EnableAndDisbleUser(string id)
        {
            var UserEdited = await _userManager.FindByIdAsync(id);
            if (UserEdited != null)
            {
                if(await _userManager.IsEmailConfirmedAsync(UserEdited))
                {
                    UserEdited.EmailConfirmed = false;
                    UserEdited.Status = false;
                }
                else
                {
                    UserEdited.Status=true;
                    UserEdited.EmailConfirmed= true;

                }
               await _userManager.UpdateAsync(UserEdited);
               // _context.SaveChanges();
                //await _signInManager.RefreshSignInAsync(UserEdited).ConfigureAwait(false);
                return UserEdited;
            }
            else
                return null;
        }
        public async Task UpdateAsync(string id, EditUserViewModel entity)
        {
            var updatedUser = await _userManager.FindByIdAsync(id);
            var roleId = await _userManager.GetRolesAsync(updatedUser);
            if (updatedUser == null)
                return;
            else
            {
               
                    updatedUser.UserName = entity.Name;
                    updatedUser.regionId= entity.RegionId;
                    updatedUser.PhoneNumber = entity.PhoneNumber;
                    updatedUser.Status = entity.Status;
                    updatedUser.EmailConfirmed = entity.Status;
                    updatedUser.CreationDate = DateTime.Now;
                    updatedUser.roleId = entity.userRoles;
                    await _userManager.UpdateAsync(updatedUser);

                    if (entity.userRoles == 1)
                    {
                        await _userManager.RemoveFromRolesAsync(updatedUser, roleId);
                        await _userManager.AddToRoleAsync(updatedUser,UserRoles.Admin);
                    }
                   else if(entity.userRoles == 2)
                    {
                        await _userManager.RemoveFromRolesAsync(updatedUser, roleId);
                        await _userManager.AddToRoleAsync(updatedUser, UserRoles.User);
                     }
                    else if (entity.userRoles == 3)
                {
                    await _userManager.RemoveFromRolesAsync(updatedUser, roleId);
                    await _userManager.AddToRoleAsync(updatedUser, UserRoles.Employee);
                }

                //Change password 
                await _userManager.RemovePasswordAsync(updatedUser);
                await _userManager.AddPasswordAsync(updatedUser,entity.Password);

            }

            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(string id, EditUserViewModel entity, string CurrentUserLoginId)
        {
            var currentuser = _userManager.Users.First(u => u.Id == CurrentUserLoginId);
            var updatedUser = await _userManager.FindByIdAsync(id);
            var roleId = await _userManager.GetRolesAsync(updatedUser);
            if (updatedUser == null)
                return;
            else
            {
               
                    updatedUser.PhoneNumber = entity.PhoneNumber;
                    updatedUser.Status = entity.Status;
                    updatedUser.EmailConfirmed = entity.Status;
                    updatedUser.CreationDate = DateTime.Now;
                    await _userManager.UpdateAsync(updatedUser);               
                //Change password 
                await _userManager.RemovePasswordAsync(updatedUser);
                await _userManager.AddPasswordAsync(updatedUser,entity.Password);

            }

            await _context.SaveChangesAsync();
        }



        public async Task<User> GetByUserNameAsync(string UserName) => await _context.Users.FirstOrDefaultAsync(x => x.UserName == UserName);
    }


}
