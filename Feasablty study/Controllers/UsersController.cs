using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Feasablty_study.Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Feasablty_study.Domin.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Feasablty_study.Domin.Entites;
using System.Security.Claims;

namespace Feasablty_study.Controllers
{
    [Authorize(Roles = "Admin,Employee")]
    public class UsersController : Controller
    {
        private readonly IUserRepo userRepo;
        private readonly IRegionsRepo _regions;
        public UsersController(IUserRepo userRepo, IRegionsRepo regions)
        {
            this.userRepo = userRepo;
            this._regions = regions;
            _regions = regions;
        }


        // GET: Users

        public async Task<IActionResult> Index()
        {
            var currentuser = await userRepo.GetByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var Users = await userRepo.GetAllAsync(u=>u.region);
            if(User.IsInRole(UserRoles.Employee))
            {
               Users= Users.Where(u => u.regionId == currentuser.regionId && u.roleId==2);
                return View(Users);
            }
            else
            return View(Users);
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {

            var user = await userRepo.GetByIdAsync((string)id, u => u.region);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public async Task<IActionResult> Create()
        {

            ViewBag.Regions = new SelectList(await _regions.GetAllAsync(), "Id", "Name");
            return View();
        }
/*        [AcceptVerbs("Get","Post")]
        public  bool IsUserNameExist(string userName)
        {
            var User=userRepo.GetByUserNameAsync(userName);
            if (User == null)
                return  false;
            return true;
        }*/

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserViewModel user)
        {
            
            if (ModelState.IsValid)
            {
                if(userRepo.returntype == 1)
                {
                    TempData["Error"] = userRepo.Error;
                    return View(user);
                }
                else if(userRepo.returntype == 2)
                {
                    TempData["Error"]=userRepo.Error;
                    return View(user);
                }

                if(User.IsInRole("Employee"))
                {
                  await userRepo.AddAsync(user,User.FindFirstValue(ClaimTypes.NameIdentifier));
                }
                else
                {
                  await userRepo.AddAsync(user);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            ViewBag.Regions = new SelectList(await _regions.GetAllAsync(), "Id", "Name");
            var user = await userRepo.GetByIdAsync(id);
            
            if (user == null)
            {
                return NotFound();
            }
            var newUser = new EditUserViewModel
            {
                Name = user.UserName,
                PhoneNumber = user.PhoneNumber,
                Status = user.Status,
                

            };
            return View(newUser);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, EditUserViewModel user)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    if (User.IsInRole("Admin"))
                    {
                        await userRepo.UpdateAsync(id, user);
                    }
                    else if(User.IsInRole("Employee"))
                    {
                        await userRepo.UpdateAsync(id, user, User.FindFirstValue(ClaimTypes.NameIdentifier));
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
           
            if (id == null)
            {
                return NotFound();
            }

            var user = await userRepo.GetByIdAsync((string)id, u => u.region);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await userRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
          public async Task<IActionResult> disbleOrEnableUser(string id)
        {
            await userRepo.EnableAndDisbleUser(id);
            return RedirectToAction(nameof(Index));


        }

        private bool UserExists(string id)
        {
            return string.IsNullOrEmpty(userRepo.GetByIdAsync(id).ToString());
        }
    }
}
