using Feasablty_study.Domin.Entites;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feasablty_study.Infrastructure.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();


            //Regions
            if (!context.Regions.Any())
            {
                context.Regions.AddRange(new List<Regions>()
                     {
                         new Regions()
                         {

                             Name = " صنعاء",

                         },
                          new Regions()
                         {
                             Name = " حجة",

                         },
                          new Regions()
                         {
                             Name = " مارب",

                         },
                          new Regions()
                         {
                             Name = " ذمار",

                         },
                          new Regions()
                         {
                             Name = " الجوف",

                         },
                          new Regions()
                         {
                             Name = " المحويت",

                         },

                         new Regions()
                         {
                             Name = " حضرموت",

                         },
                         new Regions()
                         {
                             Name = " تعز",

                         },
                         new Regions()
                         {
                             Name = " المهرة",

                         },
                         new Regions()
                         {
                             Name = " البيضاء",

                         },
                          new Regions()
                         {
                             Name = " الحديدة",

                         },
                          new Regions()
                         {
                             Name = " ابين",

                         },
                          new Regions()
                         {
                             Name = " اب",

                         },
                           new Regions()
                         {
                             Name = " امانة العاصمة",

                         },
                           new Regions()
                         {
                             Name = " ريمة",

                         },
                           new Regions()
                         {
                             Name = " صعدة",

                         },
                            new Regions()
                         {
                             Name = " الضالع",

                         },
                            new Regions()
                         {
                             Name = " لحج",

                         },
                            new Regions()
                         {
                             Name = " عدن",

                         },
                            new Regions()
                         {
                             Name = " شبوة",

                         },
                            new Regions()
                         {
                             Name = " عمران",

                         },

                     });
                context.SaveChanges();
            }

        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();

            //Roles
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            if (!await roleManager.RoleExistsAsync(UserRoles.Employee))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Employee));

            //Users
            var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();
            string adminUserEmail = "admin@etickets.com";

            var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
            if (adminUser == null)
            {
                var newAdminUser = new User()
                {
                    Id = "c6c75e08-3701-4355-b8f3-8db5be5310dc",
                    Name = "Admin User",
                    UserName = "admin-user",
                    Email = adminUserEmail,
                    EmailConfirmed = true,
                    Status = true,
                    RegionId = 1,
                    RoleId = 1,
                    PhoneNumber = "773019241",

                };
                await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
            }


            string appUserEmail = "user@etickets.com";

            var appUser = await userManager.FindByEmailAsync(appUserEmail);
            if (appUser == null)
            {
                var newAppUser = new User()
                {
                    Name = "Application User",
                    UserName = "app-user",
                    Email = appUserEmail,
                    EmailConfirmed = true,
                    Status = true,
                    RegionId = 1,
                    RoleId = 2,
                    PhoneNumber = "773019241",
                };
                await userManager.CreateAsync(newAppUser, "Coding@1234?");
                await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
            }
        }


    }
}
