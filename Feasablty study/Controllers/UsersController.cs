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

        public string UserId { get; private set; }

        public UsersController(IUserRepo userRepo, IRegionsRepo regions)
        {
            this.userRepo = userRepo;
            this._regions = regions;
           
        }


        // GET: Users

        public async Task<IActionResult> Index()
        {
            var viewModel = new ViewModelAllOpreation();
             ViewBag.Regions = new SelectList(await _regions.GetAllAsync(), "Id", "Name");
            var currentuser = await userRepo.GetByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var Users = await userRepo.GetAllAsync(u=>u.Region);
            viewModel.Users = Users;
            if (User.IsInRole(UserRoles.Employee))
            {
               Users= Users.Where(u => u.RegionId == currentuser.RegionId && u.RoleId==2);
                viewModel.Users = Users;
                return View(viewModel);
            }
            else
            return View(viewModel);
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {

            var user = await userRepo.GetByIdAsync((string)id, u => u.Region);
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
        
       
        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserViewModel user)
        {
            ViewBag.Regions = new SelectList(await _regions.GetAllAsync(), "Id", "Name");

            if (ModelState.IsValid)
            {
                if (userRepo.Returntype == 1)
                {
                    TempData["Error"] = userRepo.Error;
                    return View(user);
                }
                else if (userRepo.Returntype == 2)
                {
                    TempData["Error"]=userRepo.Error;
                    return View(user);
                }

                if (User.IsInRole("Employee"))
                {
                    await userRepo.AddAsync(user, User.FindFirstValue(ClaimTypes.NameIdentifier));
                }
                else
                {
                    await userRepo.AddAsync(user);
                }
                return RedirectToAction(nameof(Index));
            }
            return Json(new { result = "Redirect", url = Url.Action("Index", "Users") });
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
       

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await userRepo.DeleteAsync(id);
            return RedirectToAction("Index");
        }
          public async Task<IActionResult> DisbleOrEnableUser(string id)
        {
            await userRepo.EnableAndDisbleUser(id);
            return RedirectToAction("Index");


        }

        private bool UserExists(string id)
        {
            return string.IsNullOrEmpty(userRepo.GetByIdAsync(id).ToString());
        }
    }
}
