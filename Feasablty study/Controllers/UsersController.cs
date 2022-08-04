using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Http;
using Feasablty_study.Services;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;

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

        [AllowAnonymous]

        // GET: Users
        public async Task<IActionResult> Index()
        {

           await userRepo.GetByUserNameAsync("a");
            var jsonstring = await userRepo.GetAllAsync();
            if (!string.IsNullOrWhiteSpace(HttpContext.Session.GetString("UserName")) && HttpContext.Session.GetString("UserName")!="0")
            {

                //JsonFileConvertAndSave.SimpleWrite(jsonstring, @"D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\wwwroot\assets\json\table-datatable.json");
                return View(await userRepo.GetAllAsync());

            }
            else
            {
                ViewBag.Message = "خطا في اسم المستخدم او كلمة المرور";
                return View(await userRepo.GetAllAsync());

            }
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
        [AcceptVerbs("Get","Post")]
        public  bool IsUserNameExist(string userName)
        {
            var User=userRepo.GetByUserNameAsync(userName);
            if (User == null)
                return  false;
            return true;
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Status,PhoneNumber,Email,UserName,Password,PasswordConfirm,CreationDate")] User user)
        {
            if (ModelState.IsValid)
            {
                await userRepo.AddAsync(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {


            var user = await userRepo.GetByIdAsync((string)id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Status,PhoneNumber,Email,UserName,Password,PasswordConfirm,CreationDate")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await userRepo.UpdateAsync(id,user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
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
