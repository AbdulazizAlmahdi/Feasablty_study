using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Http;
using Feasablty_study.Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Domin.Entites;
namespace Feasablty_study.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly IUserRepo userRepo;

        public UsersController(IUserRepo userRepo)
        {
            this.userRepo = userRepo;

        }


        // GET: Users
        public async Task<IActionResult> Index()
        {

         return View(await userRepo.GetAllAsync());
            /*var jsonstring = await userRepo.GetAllAsync();
            if (!string.IsNullOrWhiteSpace(HttpContext.Session.GetString("UserName")) && HttpContext.Session.GetString("UserName")!="0")
            {

                //JsonFileConvertAndSave.SimpleWrite(jsonstring, @"D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\wwwroot\assets\json\table-datatable.json");
                return View(await userRepo.GetAllAsync());

            }
            else
            {
                ViewBag.Message = "خطا في اسم المستخدم او كلمة المرور";
                return View(await userRepo.GetAllAsync());

            }*/
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
       

            var user = await userRepo.GetByIdAsync((string)id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
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
                    
                await userRepo.AddAsync(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {


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
                    await userRepo.UpdateAsync(id,user);
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

            var user = await userRepo.GetByIdAsync((string)id);
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

        private bool UserExists(string id)
        {
            return string.IsNullOrEmpty(userRepo.GetByIdAsync(id).ToString());
        }
    }
}
