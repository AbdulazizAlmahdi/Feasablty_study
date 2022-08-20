using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Feasablty_study.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Feasablty_study.Controllers
{
    [Authorize]
    public class Support_MessagesController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ISupportMessageRepo _messageRepo;

        public Support_MessagesController(ISupportMessageRepo messageRepo,UserManager<User> userManager)
        {
            _userManager = userManager;
            _messageRepo = messageRepo;

        }
        [Authorize(Roles ="Admin")]
        // GET: Support_Messages
        public async Task<IActionResult> Index()
        {
            var AllMessages = await _messageRepo.GetAllAsync(s=>s.User);  //_messageRepo.GetAllAsync();

            return View(AllMessages.ToList());
        }
        [Authorize(Roles = "Admin")]
        // GET: Support_Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var support_Messages = await _messageRepo.GetByIdAsync((int)id,s=>s.User);
                
            if (support_Messages == null)
            {
                return NotFound();
            }

            return View(support_Messages);
        }

        // GET: Support_Messages/Create
        public IActionResult Create()
        {
            return View();
        }

  
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,Email,Date,UserId")] Support_Messages support_Messages)
        {
            if (ModelState.IsValid)
            {
                support_Messages.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                support_Messages.User = await _userManager.Users.FirstOrDefaultAsync(u=>u.Id==support_Messages.UserId);
                await _messageRepo.AddAsync(support_Messages);
                return RedirectToAction("Index", "Home");
            }
            return View(support_Messages);
        }

        [Authorize(Roles = "Admin")]
        // GET: Support_Messages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var support_Messages = await _messageRepo.GetByIdAsync((int)id, s => s.User);
             
            if (support_Messages == null)
            {
                return NotFound();
            }

            return View(support_Messages);
        }
        [Authorize(Roles = "Admin")]
        // POST: Support_Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
             await _messageRepo.DeleteAsync(id);
            return RedirectToAction("Index","Home");
        }

    }
}
