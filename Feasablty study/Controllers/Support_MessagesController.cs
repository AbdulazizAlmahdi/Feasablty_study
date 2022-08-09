using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using System.Text.Unicode;
using Feasablty_study.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Feasablty_study.Domin.Entites;
using Feasablty_study.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Feasablty_study.Controllers
{
    [Authorize]
    public class Support_MessagesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly ISupportMessageRepo _messageRepo;

        public Support_MessagesController(AppDbContext context,ISupportMessageRepo messageRepo,UserManager<User> userManager)
        {

            _context = context;
            _messageRepo = messageRepo;
            this.userManager = userManager;

        }

        // GET: Support_Messages
        public async Task<IActionResult> Index()
        {
            var AllMessages = _context.SupportMessages.Include(s=>s.user);  //_messageRepo.GetAllAsync();

            return View(AllMessages);
        }

        // GET: Support_Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var support_Messages = await _messageRepo.GetByIdAsync((int)id);
                
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

        // POST: Support_Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,Email,Date,UserId")] Support_Messages support_Messages)
        {
            if (ModelState.IsValid)
            {
                support_Messages.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                support_Messages.user = await userManager.Users.FirstOrDefaultAsync(u=>u.Id==support_Messages.UserId);
                await _messageRepo.AddAsync(support_Messages);
                return RedirectToAction(nameof(Index));
            }
            return View(support_Messages);
        }






        // GET: Support_Messages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var support_Messages = await _context.SupportMessages
                .Include(s => s.user)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (support_Messages == null)
            {
                return NotFound();
            }

            return View(support_Messages);
        }

        // POST: Support_Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var support_Messages = await _context.SupportMessages.FindAsync(id);
            _context.SupportMessages.Remove(support_Messages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool Support_MessagesExists(int id)
        {
            return _context.SupportMessages.Any(e => e.Id == id);
        }
    }
}
